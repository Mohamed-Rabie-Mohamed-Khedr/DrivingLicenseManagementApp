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
            (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
            Gendor, Address, Phone, Email, NationalityCountryID)
            VALUES
            (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName,
            @DateOfBirth, @Gendor, @Address, @Phone, @Email,
            @NationalityCountryID); select SCOPE_IDENTITY();", connection);

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
            person.PersonID = Convert.ToInt32(command.ExecuteScalar());

            command.CommandText = "UPDATE People SET ImagePath = @ImagePath WHERE PersonID = @PersonID;";
            command.Parameters.AddWithValue("@PersonID", person.PersonID);
            if (person.ImageIsExists)
            {
                person.ImageName = person.PersonID.ToString();
                command.Parameters.AddWithValue("@ImagePath", person.ImageName);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
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
            , ImagePath = @ImagePath where PersonID = @PersonID;", connection);

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
            command.Parameters.AddWithValue("@PersonID", person.PersonID);
            command.Parameters.AddWithValue("@Email", (object)person.Email ?? DBNull.Value);
            command.Parameters.AddWithValue("@ImagePath", person.ImageIsExists? (object)person.ImageName : DBNull.Value);
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

    public static bool AddUser(ref User user)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"insert into Users (UserName, Password, IsActive, PersonID) values
            (@UserName, @Password, @IsActive, @PersonID); select SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@PersonID", user.PersonID);
            user.UserID = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return user.UserID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool UpdateUser(ref User user)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"update Users set UserName = @UserName, Password = @Password,
            IsActive = @IsActive where PersonID = @PersonID", connection);
            command.Parameters.AddWithValue("@UserName", user.UserName);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@PersonID", user.PersonID);
            bool result = command.ExecuteNonQuery() > 0;
            connection.Close();
            return result;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool DeleteUser(ref int UserID)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(@"delete from Users where UserID = @UserID", connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            bool result = command.ExecuteNonQuery() > 0;
            connection.Close();
            return result;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool UpdateApplicationType(ref ApplicationType applicationType)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"update ApplicationTypes set ApplicationTypeTitle = @ApplicationTypeTitle,
            ApplicationFees = @ApplicationFees
            where ApplicationTypeID = @ApplicationTypeID", connection);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", applicationType.ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", applicationType.ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationType.ApplicationTypeID);
            bool result = command.ExecuteNonQuery() > 0;
            connection.Close();
            return result;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool UpdateTestType(ref TestType testType)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"update TestTypes set TestTypeTitle = @TestTypeTitle,
            TestTypeDescription = @TestTypeDescription,
            TestTypeFees = @TestTypeFees
            where TestTypeID = @TestTypeID", connection);
            command.Parameters.AddWithValue("@TestTypeTitle", testType.TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", testType.TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", testType.TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeID", testType.TestTypeID);
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