using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GetData
{
    public static Person GetPerson(ref int PersonID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from People where PersonID = @PersonID", sqlConnection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
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
    public static bool PersonIsExists(ref int PersonID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from People where PersonID = @PersonID", sqlConnection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool NationalNoIsExists(ref string NationalNo)
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
    public static User GetUser(ref int PersonID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from Users where PersonID = @PersonID", sqlConnection);
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable.Rows.Count > 0 ? new User(dataTable.Rows[0]) : null;
        }
        catch (Exception)
        {
        }
        return null;
    }
    public static DataTable GetUsers(ref string FilterMode, ref object FilterValue)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command;

            switch (FilterMode)
            {
                case "User ID":
                    command = new SqlCommand("select * from Users where UserID = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.Int).Value = FilterValue;
                    break;
                case "Person ID":
                    command = new SqlCommand("select * from Users where PersonID = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.Int).Value = FilterValue;
                    break;
                case "User Name":
                    command = new SqlCommand("select * from Users where UserName like @FilterValue + '%'", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.NVarChar, 20).Value = FilterValue;
                    break;
                    case "Is Active":
                    command = new SqlCommand("select * from Users where IsActive = @FilterValue", sqlConnection);
                    command.Parameters.Add("@FilterValue", SqlDbType.Bit).Value = FilterValue;
                    break;
                default:
                    command = new SqlCommand("select * from Users", sqlConnection);
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
    public static User GetUserToLogIn(ref string UserName, ref string Password)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from Users where UserName = @UserName and Password = @Password", sqlConnection);
            command.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserName;
            command.Parameters.Add("@Password", SqlDbType.NVarChar, 20).Value = Password;
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable.Rows.Count > 0 ? new User(dataTable.Rows[0]) : null;
        }
        catch (Exception)
        {
        }
        return null;
    }
    public static bool UserIsExists(ref int PersonID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from Users where PersonID = @PersonID", sqlConnection);
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
        }
        return false;
    }
}