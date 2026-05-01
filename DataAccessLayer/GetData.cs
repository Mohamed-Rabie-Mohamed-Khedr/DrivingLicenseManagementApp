using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class GetData
{
    public static Person GetPerson(ref int PersonID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
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
            sqlConnection.Close();
        }
        return null;
    }
    public static int GetPersonIDByDriver(ref int DriverID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select PersonID from Drivers where DriverID = @DriverID", sqlConnection);
            command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;
            int PersonID = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return PersonID;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return -1;
    }
    public static int GetPersonIDByNationalNo(ref string NationalNo)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select PersonID from People where NationalNo = @NationalNo", sqlConnection);
            command.Parameters.Add("@NationalNo", SqlDbType.NVarChar).Value = NationalNo;
            int PersonID = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return PersonID;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return -1;
    }
    public static int GetPersonIDByDriverID(int DriverID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select PersonID from Drivers where DriverID = @DriverID", sqlConnection);
            command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;
            int PersonID = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return PersonID;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return -1;
    }
    public static DataTable GetCountries()
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
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
            sqlConnection.Close();
        }
        return null;
    }
    public static bool PersonIsExists(ref int PersonID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from People where PersonID = @PersonID", sqlConnection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static bool PersonIsExists()
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from People", sqlConnection);
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static bool NationalNoIsExists(ref string NationalNo)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from People where NationalNo = @NationalNo", sqlConnection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static bool PersonAgeIsAllowedToGetThisLicense(int PersonAge, int LicenseClassID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT found = '1' FROM LicenseClasses L WHERE L.LicenseClassID = @LicenseClassID AND @PersonAge >= L.MinimumAllowedAge", sqlConnection);
            command.Parameters.Add("@PersonAge", SqlDbType.Int).Value = PersonAge;
            command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = LicenseClassID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static DataTable GetPeople(ref string FilterMode, ref object FilterValue)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
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
            sqlConnection.Close();
        }
        return null;
    }
    public static User GetUser(ref int PersonID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
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
            sqlConnection.Close();
        }
        return null;
    }
    public static DataTable GetUsers(ref string FilterMode, ref object FilterValue)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
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
            sqlConnection.Close();
        }
        return null;
    }
    public static User GetUserToLogIn(ref string UserName, ref string Password)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
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
            sqlConnection.Close();
        }
        return null;
    }
    public static bool UserIsExists(ref int PersonID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from Users where PersonID = @PersonID", sqlConnection);
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static bool UserIsExists()
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from Users", sqlConnection);
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static DataTable GetApplicationTypes()
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from ApplicationTypes", sqlConnection);
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static ApplicationType GetApplicationType(ref int ApplicationTypeID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID", sqlConnection);
            command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ApplicationTypeID;
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable.Rows.Count > 0 ? new ApplicationType(dataTable.Rows[0]) : null;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static DataTable GetTestTypes()
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from TestTypes", sqlConnection);
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static TestType GetTestType(ref int TestTypeID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from TestTypes where TestTypeID = @TestTypeID", sqlConnection);
            command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable.Rows.Count > 0 ? new TestType(dataTable.Rows[0]) : null;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static DataTable GetLicenseClasses()
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select * from LicenseClasses", sqlConnection);
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static decimal GetLicenseClasseFees(int ApplicationTypeID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select ClassFees from LicenseClasses where LicenseClassID = @ApplicationTypeID", sqlConnection);
            command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ApplicationTypeID;
            object Fees = command.ExecuteScalar();
            sqlConnection.Close();
            return Fees == null ? 0 : (decimal)Fees;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return 0;
    }

    static string LDLAppBaseSQLQuery =
@"WITH PassedTests AS (SELECT        TA.LocalDrivingLicenseApplicationID, COUNT(DISTINCT TA.TestAppointmentID) AS PassedCount
                                                   FROM            TestAppointments AS TA INNER JOIN
                                                                             Tests AS T ON TA.TestAppointmentID = T.TestAppointmentID
                                                   WHERE        (T.TestResult = 1)
                                                   GROUP BY TA.LocalDrivingLicenseApplicationID)
    SELECT        L.LocalDrivingLicenseApplicationID, LC.LicenseClassID, LC.ClassName, LC.DefaultValidityLength, P.NationalNo, P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName, 
                              A.ApplicationID, A.ApplicantPersonID, A.ApplicationDate, A.ApplicationTypeID, A.ApplicationStatus, A.LastStatusDate, A.PaidFees, A.CreatedByUserID,
CASE WHEN A.ApplicationStatus = 3 THEN 3
ELSE ISNULL(PT.PassedCount, 0) END AS PassedTests, TT.TestTypeID,
                              TT.TestTypeFees, CASE WHEN A.ApplicationStatus = 1 THEN 'New' WHEN A.ApplicationStatus = 2 THEN 'Canceled' WHEN A.ApplicationStatus = 3 THEN 'Completed' END AS Status, Users.UserName, AT.ApplicationTypeTitle, 
                              Licenses.LicenseID
     FROM            Users INNER JOIN
                              Applications AS A ON Users.UserID = A.CreatedByUserID INNER JOIN
                              ApplicationTypes AS AT ON A.ApplicationTypeID = AT.ApplicationTypeID INNER JOIN
                              People AS P ON A.ApplicantPersonID = P.PersonID INNER JOIN
                              LocalDrivingLicenseApplications AS L ON A.ApplicationID = L.ApplicationID INNER JOIN
                              LicenseClasses AS LC ON L.LicenseClassID = LC.LicenseClassID LEFT JOIN
                              Licenses ON A.ApplicationID = Licenses.ApplicationID LEFT OUTER JOIN
                              PassedTests AS PT ON PT.LocalDrivingLicenseApplicationID = L.LocalDrivingLicenseApplicationID LEFT OUTER JOIN
                              TestTypes AS TT ON TT.TestTypeID = ISNULL(PT.PassedCount, 0) + 1
";

    public static DataTable GetLDLApps(string FilterMode, object FilterValue)
    {
        try
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string whereClause = "";

            switch (FilterMode)
            {
                case "L.D.L AppID":
                    whereClause = "WHERE L.LocalDrivingLicenseApplicationID = @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.Int) { Value = Convert.ToInt32(FilterValue) });
                    break;
                case "National No":
                    whereClause = "WHERE P.NationalNo = @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar, 20) { Value = Convert.ToString(FilterValue) });
                    break;
                case "Full Name":
                    whereClause = "WHERE (P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName) LIKE @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar) { Value = Convert.ToString(FilterValue) + "%" });
                    break;
                case "Status":
                    whereClause = "WHERE A.ApplicationStatus = @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.TinyInt) { Value = Convert.ToByte(FilterValue) });
                    break;
                case "Application ID":
                    whereClause = "WHERE L.ApplicationID = @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.Int) { Value = Convert.ToInt32(FilterValue) });
                    break;
            }

            string finalSql = LDLAppBaseSQLQuery + (string.IsNullOrWhiteSpace(whereClause) ? "" : ("\n" + whereClause));

            using (SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString))
            using (SqlCommand command = new SqlCommand(finalSql, sqlConnection))
            {
                command.CommandType = CommandType.Text;
                if (parameters.Count > 0)
                    command.Parameters.AddRange(parameters.ToArray());

                sqlConnection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
    public static LDLApp GetLDLApp(ref int LdLAppID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            string FQ = LDLAppBaseSQLQuery + "\nWHERE L.LocalDrivingLicenseApplicationID = @LdLAppID\n";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(FQ, sqlConnection);
            command.Parameters.Add("@LdLAppID", SqlDbType.Int).Value = LdLAppID;
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable.Rows.Count > 0 ? new LDLApp(dataTable.Rows[0]) : null;
        }
        catch (Exception)
        {
            sqlConnection.Close();
            return null;
        }
    }
    public static bool LDLAppIsExists(ref int applicantPersonID, ref int licenseClassID)
    {
        const string sql =
        @"SELECT TOP 1 1
      FROM LocalDrivingLicenseApplications L
      INNER JOIN Applications A ON L.ApplicationID = A.ApplicationID
      WHERE A.ApplicantPersonID = @ApplicantPersonID
        AND L.LicenseClassID = @LicenseClassID
        AND A.ApplicationStatus != 2"; // 2 = Canceled

        try
        {
            using (var conn = new SqlConnection(DAHelper.connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@ApplicantPersonID", SqlDbType.Int).Value = applicantPersonID;
                cmd.Parameters.Add("@LicenseClassID", SqlDbType.TinyInt).Value = licenseClassID;

                conn.Open();
                var result = cmd.ExecuteScalar();
                return result != null;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }
    public static DataTable GetTestAppointments(ref int ldLAppID, ref byte TestTypeID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"select * from TestAppointments where LocalDrivingLicenseApplicationID = @ldLAppID
            and TestTypeID = @TestTypeID", sqlConnection);
            command.Parameters.Add("@ldLAppID", SqlDbType.Int).Value = ldLAppID;
            command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static TestAppointment GetTestAppointment(ref int TestAppointmentID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"select * from TestAppointments where TestAppointmentID = @TestAppointmentID", sqlConnection);
            command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;
            SqlDataReader sqlDataAdapter = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataAdapter);
            sqlConnection.Close();
            return dataTable.Rows.Count > 0 ? new TestAppointment(dataTable.Rows[0]) : null;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static bool TestAppointmentIsExists(ref int ldLAppID, ref int TestTypeID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"select found = '1' from TestAppointments where LocalDrivingLicenseApplicationID = @ldLAppID
            and TestTypeID = @TestTypeID and IsLocked = 0", sqlConnection);
            command.Parameters.Add("@ldLAppID", SqlDbType.Int).Value = ldLAppID;
            command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static bool TestIsPassed(ref int ldLAppID, ref int TestTypeID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"select found = '1' from TestAppointments TA INNER JOIN Tests T
            ON TA.TestAppointmentID = T.TestAppointmentID
            where LocalDrivingLicenseApplicationID = @ldLAppID
            and TestTypeID = @TestTypeID and TestResult = 1", sqlConnection);
            command.Parameters.Add("@ldLAppID", SqlDbType.Int).Value = ldLAppID;
            command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static int GetTestAppointmentIsLockedCount(int ldLAppID, int TestTypeID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"SELECT Count(*) FROM TestAppointments INNER JOIN Tests ON
            TestAppointments.TestAppointmentID = Tests.TestAppointmentID
            where (LocalDrivingLicenseApplicationID = @ldLAppID AND TestTypeID = @TestTypeID)
            AND IsLocked = 1", sqlConnection);
            command.Parameters.Add("@ldLAppID", SqlDbType.Int).Value = ldLAppID;
            command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
            int count = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return count;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return -1;
    }
    public static DataTable GetDrivers(string FilterMode, object FilterValue)
    {
        try
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string baseQuery =
@"SELECT DISTINCT
D.DriverID,
D.CreatedDate,
CASE WHEN DATEADD(year, LC.DefaultValidityLength, L.IssueDate) < GETDATE() THEN 0 ELSE 1 END AS ActiveLicenses,
P.PersonID,
P.NationalNo,
P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName
FROM Drivers D
INNER JOIN People P ON P.PersonID = D.PersonID
INNER JOIN Licenses L ON D.DriverID = L.DriverID
INNER JOIN LicenseClasses LC ON L.LicenseClass = LC.LicenseClassID";

            string whereQuery = "";

            switch (FilterMode)
            {
                case "Driver ID":
                    whereQuery = " WHERE D.DriverID = @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.Int) { Value = Convert.ToInt32(FilterValue) });
                    break;

                case "Person ID":
                    whereQuery = " WHERE P.PersonID = @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.Int) { Value = Convert.ToInt32(FilterValue) });
                    break;

                case "National No":
                    whereQuery = " WHERE P.NationalNo LIKE @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar) { Value = FilterValue + "%" });
                    break;

                case "Full Name":
                    whereQuery = " WHERE (P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName) LIKE @FilterValue";
                    parameters.Add(new SqlParameter("@FilterValue", SqlDbType.NVarChar) { Value = FilterValue + "%" });
                    break;
            }

            using (SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(baseQuery + whereQuery, sqlConnection))
                {
                    command.Parameters.AddRange(parameters.ToArray());
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
    public static Driver GetDriver(ref int PersonID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"select * from Drivers where PersonID = @PersonID", sqlConnection);
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable.Rows.Count == 0 ? null : new Driver(dataTable.Rows[0]);
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static bool IsThisPersonHasThisLicense(ref int LicenseClassID, ref int PersonID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"select found = '1' from Licenses L join Applications A ON L.ApplicationID = A.ApplicationID
            where LicenseClass = @LicenseClassID AND ApplicantPersonID = @PersonID"
            , sqlConnection);
            command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = LicenseClassID;
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static DataTable GetPersonLicenseHistory(ref int PersonID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
@"
SELECT
L.LicenseID,
L.ApplicationID,
LC.ClassName,
L.IssueDate,
L.ExpirationDate,
L.IsActive
FROM Licenses L INNER JOIN LicenseClasses LC ON L.LicenseClass = LC.LicenseClassID
INNER JOIN Applications A ON L.ApplicationID = A.ApplicationID
WHERE A.ApplicantPersonID = @PersonID
", sqlConnection);
            command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static License GetLicense(ref int licenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"SELECT        Licenses.*, LicenseClasses.ClassName
FROM            Licenses INNER JOIN
                         LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
WHERE        (Licenses.LicenseID = @licenseID)", sqlConnection);
            command.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable.Rows.Count == 0 ? null : new License(dataTable.Rows[0]);
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static bool LicenseIsExists(ref int LicenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"select found = '1' from Licenses where LicenseID = @LicenseID", sqlConnection);
            command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static bool LicenseIsActive(ref int LicenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
            @"select found = '1' from Licenses where LicenseID = @LicenseID AND IsActive = 1", sqlConnection);
            command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static InternationalLicense GetInternationalLicense(ref int licenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(@"SELECT
InternationalLicenses.InternationalLicenseID,
InternationalLicenses.ApplicationID,
InternationalLicenses.IssueDate,
InternationalLicenses.ExpirationDate,
InternationalLicenses.IsActive,
LicenseClasses.ClassName,
InternationalLicenses.DriverID, InternationalLicenses.IssuedUsingLocalLicenseID, InternationalLicenses.CreatedByUserID
FROM            InternationalLicenses INNER JOIN
                         Licenses ON InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID INNER JOIN
                         LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
where IssuedUsingLocalLicenseID = @licenseID", sqlConnection);
            command.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable.Rows.Count == 0 ? null : new InternationalLicense(dataTable.Rows[0]);
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static DataTable GetDriverInfo(ref int LicenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(@"
SELECT
Licenses.LicenseID,
Licenses.DriverID,
Licenses.IssueDate,
Licenses.ExpirationDate,
Licenses.Notes,
LicenseClasses.ClassName,
ApplicationTypes.ApplicationTypeTitle,
CASE WHEN Licenses.IsActive = 1 THEN 'Yes' ELSE 'No' END AS IsActive,
People.NationalNo,
People.DateOfBirth,
People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS FullName,
CASE WHEN People.Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gendor,
CASE WHEN ISNULL(DetainedLicenses.IsReleased, 1) = 1 THEN 'No' ELSE 'Yes' END AS IsDetained

FROM Licenses INNER JOIN LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
INNER JOIN Applications ON Licenses.ApplicationID = Applications.ApplicationID
INNER JOIN ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID
LEFT JOIN DetainedLicenses ON Licenses.LicenseID = DetainedLicenses.LicenseID
where Licenses.LicenseID = @LicenseID", sqlConnection);
            command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static DataTable GetApplicationInfoToShowOnForm(ref int LicenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(@"
SELECT        Applications.ApplicantPersonID, Applications.ApplicationID, Applications.ApplicationDate, Licenses.PaidFees, Licenses.LicenseID, Licenses.ExpirationDate, Users.UserName, ApplicationTypes.ApplicationTypeTitle
FROM            Licenses INNER JOIN
                         Applications ON Licenses.ApplicationID = Applications.ApplicationID INNER JOIN
                         Users ON Licenses.CreatedByUserID = Users.UserID INNER JOIN
                         ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID", sqlConnection);
            command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static bool InternationalLicenseIsExists(ref int licenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from InternationalLicenses where IssuedUsingLocalLicenseID = @licenseID", sqlConnection);
            command.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static DataTable GetInternationalLicenses()
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive FROM InternationalLicenses", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static DataTable GetNewLicenseApplicationInfo(ref int licenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(@"SELECT        Applications.ApplicationID, Applications.ApplicationDate, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.LicenseID, Users.UserName
FROM            Applications INNER JOIN
                         Licenses ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN
                         Users ON Applications.CreatedByUserID = Users.UserID AND Licenses.CreatedByUserID = Users.UserID
where Licenses.LicenseID = @licenseID", sqlConnection);
            command.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static DataTable GetApplicationTypesFeesAndLicenseFees(ref int applicationTypeID, ref int classID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
@"
SELECT 
    (SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @applicationTypeID) AS ApplicationFees,
    (SELECT ClassFees FROM LicenseClasses WHERE LicenseClassID = @classID) AS ClassFees;
", sqlConnection);
            command.Parameters.Add("@applicationTypeID", SqlDbType.Int).Value = applicationTypeID;
            command.Parameters.Add("@classID", SqlDbType.Int).Value = classID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static int GetApplicationTypesFees(ref int applicationTypeID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @applicationTypeID", sqlConnection);
            command.Parameters.Add("@applicationTypeID", SqlDbType.Int).Value = applicationTypeID;
            object fees = command.ExecuteScalar();
            sqlConnection.Close();
            return fees == null ? 0 : Convert.ToInt32(fees);
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return 0;
    }
    public static (DetainedLicense dl, string UserName) GetDetainedLicense(ref int licenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
@"SELECT DetainedLicenses.*, Users.UserName
FROM DetainedLicenses INNER JOIN
Users ON DetainedLicenses.CreatedByUserID = Users.UserID
where LicenseID = @licenseID", sqlConnection);
            command.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable.Rows.Count > 0 ? (new DetainedLicense(dataTable.Rows[0]), dataTable.Rows[0]["UserName"].ToString()) : (null, "");
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return (null, "");
    }
    public static bool LicenseIsDetained(ref int licenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from DetainedLicenses where LicenseID = @licenseID and IsReleased = 0", sqlConnection);
            command.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return false;
    }
    public static DataTable GetDetainedLicenses(string FilterMode, object FilterValue)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            string baseQuery =
@"SELECT        DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.FineFees, DetainedLicenses.IsReleased, DetainedLicenses.ReleaseApplicationID, DetainedLicenses.ReleaseDate, 
                         People.NationalNo, People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS FullName
FROM            DetainedLicenses INNER JOIN
                         Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN
                         Applications ON Licenses.ApplicationID = Applications.ApplicationID INNER JOIN
                         People ON Applications.ApplicantPersonID = People.PersonID";
            string where = "";
            switch (FilterMode)
            {
                case "Detain ID":
                    where = " where DetainedLicenses.DetainID = @DetainID";
                    parameters.Add(new SqlParameter("@DetainID", FilterValue));
                    break;
                case "Release Application ID":
                    where = " where DetainedLicenses.ReleaseApplicationID = @ReleaseApplicationID";
                    parameters.Add(new SqlParameter("@ReleaseApplicationID", FilterValue));
                    break;
                case "National No":
                    where = " where People.NationalNo = @NationalNo";
                    parameters.Add(new SqlParameter("@NationalNo", FilterValue));
                    break;
                case "Full Name":
                    where = " where (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName) LIKE @FullName + '%'";
                    parameters.Add(new SqlParameter("@FullName", FilterValue));
                    break;
                case "Is Released":
                    where = " where DetainedLicenses.IsReleased = @IsReleased";
                    parameters.Add(new SqlParameter("@IsReleased", FilterValue));
                    break;
            }
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(baseQuery + where, sqlConnection);
            command.Parameters.AddRange(parameters.ToArray());
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
    public static DataTable GetReleaseDetainedLicenseInfo(ref int licenseID)
    {
        SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
        try
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
@"SELECT        DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.FineFees, Users.UserName, ApplicationTypes.ApplicationFees
FROM            DetainedLicenses INNER JOIN
                         Users ON DetainedLicenses.CreatedByUserID = Users.UserID INNER JOIN
                         Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN
                         Applications ON Applications.ApplicationID = Licenses.ApplicationID INNER JOIN
                         ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
WHERE DetainedLicenses.LicenseID = @licenseID", sqlConnection);
            command.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
            sqlConnection.Close();
        }
        return null;
    }
}