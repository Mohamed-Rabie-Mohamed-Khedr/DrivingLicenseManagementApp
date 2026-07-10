using System;
using System.Data;

public static class MyDB
{
    static DataTable LicenseClassesDT = null;
    static string[] countryNames = null;
    public static void SetConnectionString(string connStr)
    {
        DAHelper.SetConnectionString(connStr);
    }
    public static int AddPerson(ref Person person)
    {
        if (NationalNoIsExists(person.NationalNo)) return -1;
            return SetData.AddPerson(ref person);
    }
    public static bool UpdatePerson(ref Person person)
    {
        return SetData.UpdatePerson(ref person);
    }
    public static Person GetPerson(int PersonID)
    {
        return GetData.GetPerson(ref PersonID);
    }
    public static bool DeletePerson(int PersonID)
    {
        return SetData.DeletePerson(ref PersonID);
    }
    public static DataTable GetPeople(ref string FilterMode, ref object FilterValue)
    {
        return GetData.GetPeople(ref FilterMode, ref FilterValue);
    }
    public static int GetPersonIDByDriver(int DriverID)
    {
        return GetData.GetPersonIDByDriver(ref DriverID);
    }
    public static int GetPersonIDByNationalNo(string NationalNo)
    {
        return GetData.GetPersonIDByNationalNo(ref NationalNo);
    }
    public static ref string[] GetCountries()
    {
        if (countryNames != null) return ref countryNames;

        DataTable countries = GetData.GetCountries();
        countryNames = new string[countries.Rows.Count];
        for (int i = 0; i < countries.Rows.Count; i++)
        {
            countryNames[i] = countries.Rows[i][1].ToString();
        }
        return ref countryNames;
    }
    public static bool PersonIsExists(int PersonID)
    {
        return GetData.PersonIsExists(ref PersonID);
    }
    public static bool PersonIsExists()
    { return GetData.PersonIsExists(); }
    public static bool PersonAgeIsAllowedToGetThisLicense(int PersonAge, int LicenseClassID)
    {
        return GetData.PersonAgeIsAllowedToGetThisLicense(PersonAge, LicenseClassID);
    }
    public static bool AddUser(ref User user)
    {
        return SetData.AddUser(ref user);
    }
    public static User GetUser(int PersonID)
    {
        return GetData.GetUser(ref PersonID);
    }
    public static User GetUserToLogIn(string UserName, string Password)
    {
        return GetData.GetUserToLogIn(ref UserName, ref Password);
    }
    public static DataTable GetUsers(ref string FilterMode, ref object FilterValue)
    {
        return GetData.GetUsers(ref FilterMode, ref FilterValue);
    }
    public static bool UpdateUser(ref User user)
    {
        return SetData.UpdateUser(ref user);
    }
    public static bool DeleteUser(int UserID)
    {
        return SetData.DeleteUser(ref UserID);
    }
    public static bool UserIsExists(int UserID)
    {
        return GetData.UserIsExists(ref UserID);
    }
    public static bool UserIsExists()
    { return GetData.UserIsExists(); }
    public static bool NationalNoIsExists(string NationalNo)
    {
        return GetData.NationalNoIsExists(ref NationalNo);
    }
    public static DataTable GetApplicationTypes()
    {
        return GetData.GetApplicationTypes();
    }
    public static bool UpdateApplicationType(ref ApplicationType applicationType)
    {
        return SetData.UpdateApplicationType(ref applicationType);
    }
    public static ApplicationType GetApplicationType(int ApplicationTypeID)
    {
        return GetData.GetApplicationType(ref ApplicationTypeID);
    }
    public static DataTable GetTestTypes()
    {
        return GetData.GetTestTypes();
    }
    public static bool UpdateTestType(ref TestType testType)
    {
        return SetData.UpdateTestType(ref testType);
    }
    public static TestType GetTestType(ref int TestTypeID)
    {
        return GetData.GetTestType(ref TestTypeID);
    }
    public static ref DataTable GetLicenseClasses()
    {
        if (LicenseClassesDT != null) return ref LicenseClassesDT;
        LicenseClassesDT = GetData.GetLicenseClasses();
        return ref LicenseClassesDT;
    }
    public static decimal GetLicenseClasseFees(int ApplicationTypeID)
    {
        return GetData.GetLicenseClasseFees(ApplicationTypeID);
    }
    public static bool UpdateLicensesIsActiveByDate()
    {
        return SetData.UpdateLicensesIsActiveByDate();
    }
    public static bool UpdateLicenseIsActive(int LicenseID, bool IsActive)
    {
        return SetData.UpdateLicensesIActive(LicenseID, IsActive);
    }
    public static DataTable GetLDLApps(string FilterMode, object FilterValue)
    {
        return GetData.GetLDLApps(FilterMode, FilterValue);
    }
    public static LDLApp GetLDLApp(int LdLAppID)
    {
        return GetData.GetLDLApp(ref LdLAppID);
    }
    public static bool LDLAppIsExists(int ApplicantPersonID, int LicenseClassID)
    {
        return GetData.LDLAppIsExists(ref ApplicantPersonID, ref LicenseClassID);
    }
    public static int AddApplication(ref LDLApp app)
    {
        int age = (int)((DateTime.Now - GetPerson(app.ApplicantPersonID).DateOfBirth).TotalDays / 365);
        if (!PersonAgeIsAllowedToGetThisLicense(age, app.LicenseClassID) || (app.ApplicationTypeID == 1 && LDLAppIsExists(app.ApplicantPersonID, app.LicenseClassID)))
            return 0;
        return SetData.AddApplication(ref app);
    }
    public static bool DeleteLDLApp(int LdLAppID)
    {
        return SetData.DeleteLDLApp(ref LdLAppID);
    }
    public static bool UpdateLDLApp(ref LDLApp app)
    {
        return SetData.UpdateLDLApp(ref app);
    }
    public static bool AddTestAppointment(ref TestAppointment ta, int PersonID)
    {
        return SetData.AddTestAppointment(ref ta, PersonID);
    }
    public static DataTable GetTestAppointments(int ldLAppID, byte TestTypeID)
    {
        return GetData.GetTestAppointments(ref ldLAppID, ref TestTypeID);
    }
    public static TestAppointment GetTestAppointment(int TestAppointmentID)
    {
        return GetData.GetTestAppointment(ref TestAppointmentID);
    }
    public static bool TestAppointmentIsExists(int ldLAppID, int TestTypeID)
    {
        return GetData.TestAppointmentIsExists(ref ldLAppID, ref TestTypeID);
    }
    public static bool UpdateTestAppointment(ref TestAppointment ta)
    {
        return SetData.UpdateTestAppointment(ref ta);
    }
    public static int GetTestAppointmentIsLockedCount(int ldLAppID, int TestTypeID)
    {
        return GetData.GetTestAppointmentIsLockedCount(ldLAppID, TestTypeID);
    }
    public static bool UpdateApplicationStatus(int AppointmentID, byte ApplicationStatus)
    {
        return SetData.UpdateApplicationStatus(ref AppointmentID, ref ApplicationStatus);
    }
    public static bool AddTest(ref Test tr)
    {
        return SetData.AddTest(ref tr);
    }
    public static bool TestIsPassed(int ldLAppID, int TestTypeID)
    {
        return GetData.TestIsPassed(ref ldLAppID, ref TestTypeID);
    }
    public static DataTable GetDrivers(string FilterMode, object FilterValue)
    {
        return GetData.GetDrivers(FilterMode, FilterValue);
    }
    public static Driver GetDriver(int PersonID)
    {
        return GetData.GetDriver(ref PersonID);
    }
    public static bool AddDriver(ref Driver driver)
    {
        Driver d = GetDriver(driver.PersonID);
        if (d != null)
        {
            driver.DriverID = d.DriverID;
            return true;
        }
        return SetData.AddDriver(ref driver);
    }
    public static bool AddLicense(ref License lc)
    {
        return SetData.AddLicense(ref lc);
    }
    public static bool IsThisPersonHasThisLicense(int LicenseClassID, int PersonID)
    {
        return GetData.IsThisPersonHasThisLicense(ref LicenseClassID, ref PersonID);
    }
    public static bool LicenseIsExists(int LicenseID)
    {
        return GetData.LicenseIsExists(ref LicenseID);
    }
    public static bool LicenseIsActive(int LicenseID)
    {
        return GetData.LicenseIsActive(ref LicenseID);
    }
    public static DataTable GetDriverInfo(int LicenseID)
    {
        return GetData.GetDriverInfo(ref LicenseID);
    }
    public static DataTable GetPersonLicenseHistory(int PersonID)
    {
        if (UpdateLicensesIsActiveByDate())
            return GetData.GetPersonLicenseHistory(ref PersonID);
        else return null;
    }
    public static License GetLicense(int licenseID)
    {
        return GetData.GetLicense(ref licenseID);
    }
    public static bool AddInternationalLicense(ref InternationalLicense il)
    {
        return SetData.AddInternationalLicense(ref il);
    }
    public static bool UpdateInternationalLicensesIsActiveByDate()
    {
        return SetData.UpdateInternationalLicensesIsActiveByDate();
    }
    public static InternationalLicense GetInternationalLicense(int licenseID)
    {
        if (UpdateInternationalLicensesIsActiveByDate())
        return GetData.GetInternationalLicense(ref licenseID);
        else return null;
    }
    public static DataTable GetInternationalLicenses()
    {
        if (UpdateInternationalLicensesIsActiveByDate())
            return GetData.GetInternationalLicenses();
        else return null;
    }
    public static DataTable GetApplicationInfoToShowOnForm(int LicenseID)
    {
        return GetData.GetApplicationInfoToShowOnForm(ref LicenseID);
    }
    public static bool InternationalLicenseIsExists(int licenseID)
    {
        return GetData.InternationalLicenseIsExists(ref licenseID);
    }
    public static DataTable GetNewLicenseApplicationInfo(int licenseID)
    {
        return GetData.GetNewLicenseApplicationInfo(ref licenseID);
    }
    public static DataTable GetApplicationTypesFeesAndLicenseFees(int applicationTypeID, int classID)
    {
        return GetData.GetApplicationTypesFeesAndLicenseFees(ref applicationTypeID, ref classID);
    }
    public static int GetApplicationTypesFees(int applicationTypeID)
    {
        return GetData.GetApplicationTypesFees(ref applicationTypeID);
    }
    public static bool AddDetainedLicense(ref DetainedLicense dl)
    {
        return SetData.AddDetainedLicense(ref dl);
    }
    public static (DetainedLicense dl, string UserName) GetDetainedLicense(int licenseID)
    {
        return GetData.GetDetainedLicense(ref licenseID);
    }
    public static bool LicenseIsDetained(int licenseID)
    {
        return GetData.LicenseIsDetained(ref licenseID);
    }
    public static DataTable GetDetainedLicenses(string FilterMode, object FilterValue)
    {
        return GetData.GetDetainedLicenses(FilterMode, FilterValue);
    }
    public static DataTable GetReleaseDetainedLicenseInfo(int licenseID)
    {
        return GetData.GetReleaseDetainedLicenseInfo(ref licenseID);
    }
    public static bool IsReleasedTrue(DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID, int LicenseID)
    {
        return SetData.IsReleasedTrue(ReleaseDate, ReleasedByUserID, ReleaseApplicationID, LicenseID);
    }
}