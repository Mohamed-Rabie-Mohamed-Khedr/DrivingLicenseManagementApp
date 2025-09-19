using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

public class SetData
{
    public static bool AddPerson(ref Person person)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(@"
INSERT INTO People 
(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID)
VALUES
(@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID);", connection);

            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@SecondName", person.SecondName);
            command.Parameters.AddWithValue("@ThirdName", person.ThirdName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            command.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);
            command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
            command.Parameters.AddWithValue("@Phone", person.Phone);
            command.Parameters.AddWithValue("@Address", person.Address);
            command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", person.Gendor);
            command.Parameters.AddWithValue("@Email", (object)person.Email ?? DBNull.Value);
            command.ExecuteNonQuery();

            command.CommandText = "select PersonID from People where NationalNo = @NationalNo";
            person.PersonID = Convert.ToInt32(command.ExecuteScalar());

            command.CommandText = "update People set ImagePath = @ImagePath where PersonID = @PersonID";
            if (person.ImageIsExist)
            {
                person.ImageName = person.PersonID.ToString();
                command.Parameters.AddWithValue("@ImagePath", person.ImageName);
            }
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            command.Parameters.AddWithValue("@PersonID", person.PersonID);
            command.ExecuteNonQuery();
            connection.Close();

            return person.PersonID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }
    
    public static bool UpdatePerson(ref Person person)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(
            @"update People set NationalNo = @NationalNo, FirstName = @FirstName,
            SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName,
            DateOfBirth = @DateOfBirth, Gendor = @Gendor, Address = @Address,
            Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID
            where NationalNo = @NationalNo;", connection);

            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@SecondName", person.SecondName);
            command.Parameters.AddWithValue("@ThirdName", person.ThirdName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            command.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);
            command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
            command.Parameters.AddWithValue("@Phone", person.Phone);
            command.Parameters.AddWithValue("@Address", person.Address);
            command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", person.Gendor);
            command.Parameters.AddWithValue("@Email", (object)person.Email ?? DBNull.Value);
            command.ExecuteNonQuery();

            command.CommandText = "select PersonID from People where NationalNo = @NationalNo";
            person.PersonID = Convert.ToInt32(command.ExecuteScalar());

            command.CommandText = "update People set ImagePath = @ImagePath where PersonID = @PersonID";
            if (person.ImageIsExist)
            {
                person.ImageName = person.PersonID.ToString();
                command.Parameters.AddWithValue("@ImagePath", person.ImageName);
            }
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            command.Parameters.AddWithValue("@PersonID", person.PersonID);
            command.ExecuteNonQuery();
            connection.Close();
            return person.PersonID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }

    public static bool DeletePerson(ref int PersonID)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(@"delete from People where PersonID = @PersonID", connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            bool result = command.ExecuteNonQuery() > 0;
            connection.Close();
            return result;
        }
        catch (Exception)
        {
        }
        return false;
    }
}