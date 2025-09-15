using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GetData
{
    public static Person GetPerson(ref string NationalNo)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from People where NationalNo = @NationalNo", sqlConnection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable.Rows.Count == 0 ? null : new Person(dataTable.Rows[0]);
        }
        catch (Exception)
        {
        }
        return null;
    }
    public static int GetPeopleCount()
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select count(*) from People", sqlConnection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return count;
        }
        catch (Exception)
        {
        }
        return -1;
    }
    public static DataTable GetCountries()
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from countries", sqlConnection);
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
        }
        return null;
    }
    public static bool CheckNationalNo(ref string NationalNo)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from People where NationalNo = @NationalNo", sqlConnection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static DataTable GetPeople(ref string FilterMode, ref object FilterValue)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command;

            switch (FilterMode)
            {
                case "Person ID":
                    command = new SqlCommand("select * from People where PersonID = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.Int).Value = FilterValue;
                    break;
                case "First Name":
                    command = new SqlCommand("select * from People where FirstName like  @FilterValue + '%'", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.NVarChar, 20).Value = FilterValue;
                    break;
                case "Second Name":
                    command = new SqlCommand("select * from People where SecondName like @FilterValue + '%'", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.NVarChar, 20).Value = FilterValue;
                    break;
                case "Third Name":
                    command = new SqlCommand("select * from People where ThirdName like @FilterValue + '%'", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.NVarChar, 20).Value = FilterValue;
                    break;
                case "Last Name":
                    command = new SqlCommand("select * from People where LastName like @FilterValue + '%'", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.NVarChar, 20).Value = FilterValue;
                    break;
                case "National No":
                    command = new SqlCommand("select * from People where NationalNo = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.NVarChar, 20).Value = FilterValue;
                    break;
                case "Phone":
                    command = new SqlCommand("select * from People where Phone = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.NVarChar, 20).Value = FilterValue;
                    break;
                case "Email":
                    command = new SqlCommand("select * from People where Email = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.NVarChar, 20).Value = FilterValue;
                    break;
                case "Nationality":
                    command = new SqlCommand("select * from People where NationalityCountryID = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.Int).Value = FilterValue;
                    break;
                case "Gendor":
                    command = new SqlCommand("select * from People where Gendor = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.TinyInt).Value = FilterValue;
                    break;
                default:
                    command = new SqlCommand("select * from People", sqlConnection);
                    break;
            }

            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
        }
        return null;
    }
}