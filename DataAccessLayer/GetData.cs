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
    public static int GetPersonIDByDriver(ref int DriverID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select PersonID from Drivers where DriverID = @DriverID", sqlConnection);
            command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;
            int PersonID = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            return PersonID;
        }
        catch (Exception)
        {
        }
        return -1;
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
    public static DataTable GetApplicationTypes()
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static ApplicationType GetApplicationType(ref int ApplicationTypeID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static DataTable GetTestTypes()
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static TestType GetTestType(ref int TestTypeID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static DataTable GetLicenseClasses()
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }

    static string LDLAppBaseSQLQuery =
@"WITH PassedTests AS (SELECT        TA.LocalDrivingLicenseApplicationID, COUNT(DISTINCT TA.TestAppointmentID) AS PassedCount
                                                   FROM            TestAppointments AS TA INNER JOIN
                                                                             Tests AS T ON TA.TestAppointmentID = T.TestAppointmentID
                                                   WHERE        (T.TestResult = 1)
                                                   GROUP BY TA.LocalDrivingLicenseApplicationID)
    SELECT        L.LocalDrivingLicenseApplicationID AS LdLAppID, LC.LicenseClassID, LC.ClassName, LC.DefaultValidityLength, P.NationalNo, P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName, 
                              A.ApplicationID, A.ApplicantPersonID, A.ApplicationDate, A.ApplicationTypeID, A.ApplicationStatus, A.LastStatusDate, A.PaidFees, A.CreatedByUserID, ISNULL(PT.PassedCount, 0) AS PassedTests, TT.TestTypeID, 
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
        try
        {
            string FQ = LDLAppBaseSQLQuery + "\nWHERE L.LocalDrivingLicenseApplicationID = @LdLAppID\n";
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static TestAppointment GetTestAppointment(ref int TestAppointmentID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static bool TestAppointmentIsExists(ref int ldLAppID, ref int TestTypeID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return false;
    }
    public static bool TestIsPassed(ref int ldLAppID, ref int TestTypeID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return false;
    }
    public static int GetTestAppointmentIsLockedCount(ref int ldLAppID, ref int TestTypeID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static bool LicenseIsExists(ref int LicenseClassID, ref int PersonID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return false;
    }
    public static DataTable GetPersonLicenseHistory(ref int PersonID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static License GetLicense(ref int licenseID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static InternationalLicense GetInternationalLicense(ref int licenseID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static DataTable GetDriverInfo(ref int LicenseID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(@"
SELECT
LC.ClassName,
L.LicenseID,
L.DriverID,
L.IssueDate,
L.ExpirationDate,
L.Notes,
CASE WHEN L.IsActive = 1 THEN 'Yes' ELSE 'No' END AS IsActive,
ApplicationTypes.ApplicationTypeTitle,
P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
P.NationalNo,
P.DateOfBirth,
CASE WHEN P.Gendor = 0 THEN 'Male' ELSE 'Female' END AS Gendor
FROM
LocalDrivingLicenseApplications LDLA INNER JOIN
LicenseClasses LC ON LDLA.LicenseClassID = LC.LicenseClassID INNER JOIN
Licenses L ON LDLA.ApplicationID = L.ApplicationID INNER JOIN
Drivers ON L.DriverID = Drivers.DriverID INNER JOIN
People P ON Drivers.PersonID = P.PersonID INNER JOIN
Applications ON LDLA.ApplicationID = Applications.ApplicationID INNER JOIN
ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
where L.LicenseID = @LicenseID", sqlConnection);
            command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            sqlConnection.Close();
            return dataTable;
        }
        catch (Exception)
        {
        }
        return null;
    }
    public static DataTable GetApplicationInfo(ref int LicenseID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
    public static bool InternationalLicenseIsExists(ref int licenseID)
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("select found = '1' from InternationalLicenses where IssuedUsingLocalLicenseID = @licenseID", sqlConnection);
            command.Parameters.Add("@licenseID", SqlDbType.Int).Value = licenseID;
            object found = command.ExecuteScalar();
            sqlConnection.Close();
            return found == null ? false : true;
        }
        catch (Exception)
        {
        }
        return false;
    }
    public static DataTable GetInternationalLicenses()
    {
        try
        {
            SqlConnection sqlConnection = new SqlConnection(DAHelper.connectionString);
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
        }
        return null;
    }
}