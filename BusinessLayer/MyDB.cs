using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MyDB
{
    static DataTable LicenseClassesDT = null;
    static string[] countryNames = null;
    public static bool AddPerson(ref Person person)
    {
        if (NationalNoIsExists(person.NationalNo)) return false;
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
    public static int GetPeopleCount()
    {
        return GetData.GetPeopleCount();
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
    public static bool UpdateLicensesIsActive()
    {
        return SetData.UpdateLicensesIsActive();
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
    public static bool AddLDLApp(ref LDLApp app)
    {
        if (app.ApplicationTypeID != 2 && LDLAppIsExists(app.ApplicantPersonID, app.LicenseClassID))
            return false;
        return SetData.AddLDLApp(ref app);
    }
    public static bool DeleteLDLApp(int LdLAppID)
    {
        return SetData.DeleteLDLApp(ref LdLAppID);
    }
    public static bool UpdateLDLApp(ref LDLApp app)
    {
        return SetData.UpdateLDLApp(ref app);
    }
    public static bool AddTestAppointment(ref TestAppointment ta)
    {
        return SetData.AddTestAppointment(ref ta);
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
        return GetData.GetTestAppointmentIsLockedCount(ref ldLAppID, ref TestTypeID);
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
        if (UpdateLicensesIsActive())
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
    public static bool UpdateInternationalLicensesIsActive()
    {
        return SetData.UpdateInternationalLicensesIsActive();
    }
    public static InternationalLicense GetInternationalLicense(int licenseID)
    {
        if (UpdateInternationalLicensesIsActive())
        return GetData.GetInternationalLicense(ref licenseID);
        else return null;
    }
    public static DataTable GetInternationalLicenses()
    {
        if (UpdateInternationalLicensesIsActive())
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
    public static DataTable GetApplicationFeesAndLicenseFees(int applicationTypeID, int classID)
    {
        return GetData.GetApplicationFeesAndLicenseFees(ref applicationTypeID, ref classID);
    }
}