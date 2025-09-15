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
(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)
VALUES
(@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
SELECT SCOPE_IDENTITY();", connection);

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

            command.Parameters.AddWithValue("@ImagePath", (object)person.ImagePath ?? DBNull.Value);
            command.Parameters.AddWithValue("@Email", (object)person.Email ?? DBNull.Value);

            person.PersonID = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return person.PersonID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }
    
    public static bool UpdatePerson(ref Person person, ref string nationalNoOld)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(
            @"update People set NationalNo = @NationalNo, FirstName = @FirstName,
            SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName,
            DateOfBirth = @DateOfBirth, Gendor = @Gendor, Address = @Address,
            Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID,
            ImagePath = @ImagePath where NationalNo = @NationalNoOld", connection);

            command.Parameters.AddWithValue("@FirstName", person.FirstName);
            command.Parameters.AddWithValue("@SecondName", person.SecondName);
            command.Parameters.AddWithValue("@ThirdName", person.ThirdName);
            command.Parameters.AddWithValue("@LastName", person.LastName);
            command.Parameters.AddWithValue("@NationalityCountryID", person.NationalityCountryID);
            command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
            command.Parameters.AddWithValue("@NationalNoOld", nationalNoOld);
            command.Parameters.AddWithValue("@Phone", person.Phone);
            command.Parameters.AddWithValue("@Address", person.Address);
            command.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", person.Gendor);

            command.Parameters.AddWithValue("@ImagePath", (object)person.ImagePath ?? DBNull.Value);
            command.Parameters.AddWithValue("@Email", (object)person.Email ?? DBNull.Value);

            bool result = command.ExecuteNonQuery() > 0;
            connection.Close();
            return result;
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