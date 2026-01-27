using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class SetData
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
    public static bool AddLDLApp(ref LDLApp app)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"insert into Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID,
            ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) values
            (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID,
            @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
            select SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@ApplicationDate", app.ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", app.ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicantPersonID", app.ApplicantPersonID);
            byte status;
            if (app.ApplicationStatus == "New") status = 1;
            else if (app.ApplicationStatus == "Canceled") status = 2;
            else status = 3;
            command.Parameters.AddWithValue("@ApplicationStatus", status);
            command.Parameters.AddWithValue("@LastStatusDate", app.LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", app.PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", app.CreatedByUserID);
            app.ApplicationID = Convert.ToInt32(command.ExecuteScalar());

            command.CommandText = @"insert into LocalDrivingLicenseApplications
            (ApplicationID, LicenseClassID) values (@ApplicationID, @LicenseClassID);
            select SCOPE_IDENTITY();";
            command.Parameters.AddWithValue("@ApplicationID", app.ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", app.LicenseClassID);
            app.LDLAppID = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return app.LDLAppID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }

    public static bool DeleteLDLApp(ref int LdLAppID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(@"
            DECLARE @AppID INT;

            SELECT @AppID = ApplicationID 
            FROM LocalDrivingLicenseApplications
            WHERE LocalDrivingLicenseApplicationID = @LdLAppID;

            DELETE FROM LocalDrivingLicenseApplications 
            WHERE LocalDrivingLicenseApplicationID = @LdLAppID;

            DELETE FROM Applications 
            WHERE ApplicationID = @AppID;
            ", sqlConnection);
            command.Parameters.Add("@LdLAppID", SqlDbType.Int).Value = LdLAppID;
            bool result = command.ExecuteNonQuery() == 2;
            sqlConnection.Close();
            return result;
        }
        catch (Exception)
        {
        }
        return false;
    }

    public static bool UpdateLDLApp(ref LDLApp app)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"update Applications set ApplicationStatus = @ApplicationStatus,
            LastStatusDate = @LastStatusDate where ApplicationID = @ApplicationID", connection);
            command.Parameters.AddWithValue("@ApplicationStatus", app.ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", app.LastStatusDate);
            command.Parameters.AddWithValue("@ApplicationID", app.ApplicationID);
            bool result = command.ExecuteNonQuery() > 0;
            connection.Close();
            return result;
        }
        catch (Exception)
        {
        }
        return false;
    }

    public static bool AddTestAppointment(ref TestAppointment ta)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"insert into TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID,
            AppointmentDate, PaidFees, CreatedByUserID, IsLocked) values
            (@TestTypeID, @LdLAppID, @AppointmentDate, @PaidFees,
            @CreatedByUserID, @IsLocked); select SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@TestTypeID", ta.TestTypeID);
            command.Parameters.AddWithValue("@LdLAppID", ta.LDLAppID);
            command.Parameters.AddWithValue("@AppointmentDate", ta.AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", ta.PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", ta.CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", ta.IsLocked);
            ta.TestAppointmentID = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return ta.TestAppointmentID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }

    public static bool UpdateTestAppointment(ref TestAppointment ta)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"update TestAppointments set AppointmentDate = @AppointmentDate,
            IsLocked = @IsLocked where TestAppointmentID = @TestAppointmentID", connection);
            command.Parameters.AddWithValue("@AppointmentDate", ta.AppointmentDate);
            command.Parameters.AddWithValue("@IsLocked", ta.IsLocked);
            command.Parameters.AddWithValue("@TestAppointmentID", ta.TestAppointmentID);
            bool result = command.ExecuteNonQuery() > 0;
            connection.Close();
            return result;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool UpdateApplicationStatus(ref int AppointmentID, ref byte ApplicationStatus)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"UPDATE Applications SET ApplicationStatus = @ApplicationStatus WHERE ApplicationID = @ApplicationID", sqlConnection);
            command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = AppointmentID;
            command.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = ApplicationStatus;
            bool result = command.ExecuteNonQuery() > 0;
            sqlConnection.Close();
            return result;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool AddTest(ref Test tr)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"insert into Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) values
            (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID); select SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@TestAppointmentID", tr.TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", tr.TestResult);
            command.Parameters.AddWithValue("@Notes", tr.Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", tr.CreatedByUserID);
            tr.TestID = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return tr.TestID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool AddDriver(ref Driver dr)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"insert into Drivers (PersonID, CreatedByUserID, CreatedDate) values
            (@PersonID, @CreatedByUserID, @CreatedDate); select SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@PersonID", dr.PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", dr.CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", dr.CreatedDate);
            dr.DriverID = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return dr.DriverID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool AddLicense(ref License lc)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(
            @"insert into Licenses (ApplicationID,  DriverID, LicenseClass, IssueDate,
            ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
            values (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes,
            @PaidFees, @IsActive, @IssueReason, @CreatedByUserID); select SCOPE_IDENTITY();",
            connection);
            command.Parameters.AddWithValue("@ApplicationID", lc.ApplicationID);
            command.Parameters.AddWithValue("@DriverID", lc.DriverID);
            command.Parameters.AddWithValue("@LicenseClass", lc.LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", lc.IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", lc.ExpirationDate);
            if (string.IsNullOrEmpty(lc.Notes))
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else command.Parameters.AddWithValue("@Notes", lc.Notes);
            command.Parameters.AddWithValue("@PaidFees", lc.PaidFees);
            command.Parameters.AddWithValue("@IsActive", lc.IsActive);
            command.Parameters.AddWithValue("@IssueReason", lc.IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", lc.CreatedByUserID);
            lc.LicenseID = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return lc.LicenseID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool AddInternationalLicense(ref InternationalLicense il)
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(@"insert into InternationalLicenses
(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) values
(@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID); select SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@ApplicationID", il.ApplicationID);
            command.Parameters.AddWithValue("@DriverID", il.DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", il.IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", il.IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", il.ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", il.IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", il.CreatedByUserID);
            il.InternationalLicenseID = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return il.InternationalLicenseID > 0;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static bool UpdateInternationalLicensesIsActive()
    {
        try
        {
            SqlConnection connection = new SqlConnection(DAHelper.connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(@"update InternationalLicenses
set IsActive = case when ExpirationDate < GETDATE() then 0 else 1 end", connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        catch (Exception)
        {
        }
        return false;
    }
}