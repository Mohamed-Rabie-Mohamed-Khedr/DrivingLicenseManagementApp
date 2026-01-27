using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Status
{
    Add,
    Update
};

public class Person
{
    public int PersonID { get; set; }
    public int NationalityCountryID { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string ThirdName { get; set; }
    public string LastName { get; set; }
    public string NationalNo { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public bool ImageIsExists { get; set; }
    public string ImageName { get; set; }
    public byte Gendor { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Person() { }

    public Person(DataRow dr)
    {
        PersonID = Convert.ToInt32(dr["PersonID"]);
        FirstName = dr["FirstName"].ToString();
        SecondName = dr["SecondName"].ToString();
        ThirdName = dr["ThirdName"].ToString();
        LastName = dr["LastName"].ToString();
        NationalityCountryID = Convert.ToInt32(dr["NationalityCountryID"]);
        NationalNo = dr["NationalNo"].ToString();
        Phone = dr["Phone"].ToString();
        Address = dr["Address"].ToString();
        DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
        Gendor = Convert.ToByte(dr["Gendor"]);
        Email = dr["Email"].ToString();
        ImageName = dr["ImagePath"].ToString();
        ImageIsExists = !string.IsNullOrEmpty(ImageName);
    }
}

public class User
{
    public int PersonID { get; set; }
    public int UserID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }

    public User() { }

    public User(DataRow dr)
    {
        PersonID = Convert.ToInt32(dr["PersonID"]);
        UserID = Convert.ToInt32(dr["UserID"]);
        UserName = dr["UserName"].ToString();
        Password = dr["Password"].ToString();
        IsActive = Convert.ToBoolean(dr["IsActive"]);
    }
}

public class ApplicationType
{
    public int ApplicationTypeID { get; set; }
    public string ApplicationTypeTitle { get; set; }
    public decimal ApplicationFees { get; set; }

    public ApplicationType() { }

    public ApplicationType(DataRow dr)
    {
        ApplicationTypeID = Convert.ToInt32(dr["ApplicationTypeID"]);
        ApplicationTypeTitle = dr["ApplicationTypeTitle"].ToString();
        ApplicationFees = Convert.ToDecimal(dr["ApplicationFees"]);
    }
}

public class TestType
{
    public int TestTypeID { get; set; }
    public string TestTypeTitle { get; set; }
    public string TestTypeDescription { get; set; }
    public decimal TestTypeFees { get; set; }

    public TestType() { }

    public TestType(DataRow dr)
    {
        TestTypeID = Convert.ToInt32(dr["TestTypeID"]);
        TestTypeTitle = dr["TestTypeTitle"].ToString();
        TestTypeDescription = dr["TestTypeDescription"].ToString();
        TestTypeFees = Convert.ToDecimal(dr["TestTypeFees"]);
    }
}

public class LDLApp
{
    public int LDLAppID { get; set; }
    public int ApplicationID { get; set; }
    public int LicenseID { get; set; }
    public int LicenseClassID { get; set; }
    public string LicenseClassName { get; set; }
    public byte DefaultValidityLength { get; set; }
    public DateTime ApplicationDate { get; set; }
    public int ApplicationTypeID { get; set; }
    public string ApplicationTypeTitle { get; set; }
    public string ApplicationStatus { get; set; }
    public DateTime LastStatusDate { get; set; }
    public byte PassedTests { get; set; }
    public decimal PaidFees { get; set; }
    public int TestTypeID { get; set; }
    public byte TestTypeFees { get; set; }
    public int CreatedByUserID { get; set; }
    public string CreatedName { get; set; }
    public int ApplicantPersonID { get; set; }
    public string ApplicantName { get; set; }

    public LDLApp() { }

    public LDLApp(DataRow dr)
    {
        LDLAppID = Convert.ToInt32(dr["LdLAppID"]);
        ApplicationID = Convert.ToInt32(dr["ApplicationID"]);
        LicenseID = Convert.ToInt32(dr["LicenseID"]);
        LicenseClassID = Convert.ToInt32(dr["LicenseClassID"]);
        LicenseClassName = dr["ClassName"].ToString();
        DefaultValidityLength = Convert.ToByte(dr["DefaultValidityLength"]);
        ApplicantPersonID = Convert.ToInt32(dr["ApplicantPersonID"]);
        ApplicationDate = Convert.ToDateTime(dr["ApplicationDate"]);
        ApplicationTypeID = Convert.ToInt32(dr["ApplicationTypeID"]);
        ApplicationTypeTitle = dr["ApplicationTypeTitle"].ToString();
        ApplicationStatus = dr["Status"].ToString();
        LastStatusDate = Convert.ToDateTime(dr["LastStatusDate"]);
        PassedTests = Convert.ToByte(dr["PassedTests"]);
        PaidFees = Convert.ToDecimal(dr["PaidFees"]);
        if (dr["TestTypeID"] != DBNull.Value)
            TestTypeID = Convert.ToInt32(dr["TestTypeID"]);
        if (dr["TestTypeFees"] != DBNull.Value)
            TestTypeFees = Convert.ToByte(dr["TestTypeFees"]);
        CreatedByUserID = Convert.ToInt32(dr["CreatedByUserID"]);
        ApplicantName = dr["FullName"].ToString();
        CreatedName = dr["UserName"].ToString();
    }
}

public class TestAppointment
{
    public int TestAppointmentID { get; set; }
    public int TestTypeID { get; set; }
    public int LDLAppID { get; set; }
    public DateTime AppointmentDate { get; set; }
    public decimal PaidFees { get; set; }
    public int CreatedByUserID { get; set; }
    public byte IsLocked { get; set; }

    public TestAppointment() { }

    public TestAppointment(DataRow dr)
    {
        TestAppointmentID = Convert.ToInt32(dr["TestAppointmentID"]);
        TestTypeID = Convert.ToInt32(dr["TestTypeID"]);
        LDLAppID = Convert.ToInt32(dr["LocalDrivingLicenseApplicationID"]);
        AppointmentDate = Convert.ToDateTime(dr["AppointmentDate"]);
        PaidFees = Convert.ToInt32(dr["PaidFees"]);
        CreatedByUserID = Convert.ToInt32(dr["CreatedByUserID"]);
        IsLocked = Convert.ToByte(dr["IsLocked"]);
    }
}
public class Test
{
    public int TestID { get; set; }
    public int TestAppointmentID { get; set; }
    public byte TestResult { get; set; }
    public string Notes { get; set; }
    public int CreatedByUserID { get; set; }

    public Test() { }

    public Test(DataRow dr)
    {
        TestID = Convert.ToInt32(dr["TestID"]);
        TestAppointmentID = Convert.ToInt32(dr["TestAppointmentID"]);
        TestResult = Convert.ToByte(dr["TestResult"]);
        Notes = dr["Notes"].ToString();
        CreatedByUserID = Convert.ToInt32(dr["CreatedByUserID"]);
    }
}
public class Driver
{
    public int DriverID { get; set; }
    public int PersonID { get; set; }
    public int CreatedByUserID { get; set; }
    public DateTime CreatedDate { get; set; }

    public Driver() { }

    public Driver(DataRow dr)
    {
        DriverID = Convert.ToInt32(dr["DriverID"]);
        PersonID = Convert.ToInt32(dr["PersonID"]);
        CreatedByUserID = Convert.ToInt32(dr["CreatedByUserID"]);
        CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
    }
}
public class License
{
    public int LicenseID { get; set; }
    public int ApplicationID { get; set; }
    public int DriverID { get; set; }
    public int LicenseClass { get; set; }
    public string ClassName { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string Notes { get; set; }
    public decimal PaidFees { get; set; }
    public bool IsActive { get; set; }
    public byte IssueReason { get; set; }
    public int CreatedByUserID { get; set; }
    
    public License() { }
    public License(DataRow dr)
    {
        LicenseID = Convert.ToInt32(dr["LicenseID"]);
        ApplicationID = Convert.ToInt32(dr["ApplicationID"]);
        DriverID = Convert.ToInt32(dr["DriverID"]);
        LicenseClass = Convert.ToInt32(dr["LicenseClass"]);
        ClassName = dr["ClassName"].ToString();
        IssueDate = Convert.ToDateTime(dr["IssueDate"]);
        ExpirationDate = Convert.ToDateTime(dr["ExpirationDate"]);
        if (dr["Notes"] != DBNull.Value)
            Notes = dr["Notes"].ToString();
        PaidFees = Convert.ToDecimal(dr["PaidFees"]);
        IsActive = ExpirationDate > DateTime.Now;
        IssueReason = Convert.ToByte(dr["IssueReason"]);
        CreatedByUserID = Convert.ToInt32(dr["CreatedByUserID"]);
    }
}
public class InternationalLicense
{
    public int InternationalLicenseID { get; set; }
    public int ApplicationID { get; set; }
    public int DriverID { get; set; }
    public int IssuedUsingLocalLicenseID { get; set; }
    public int CreatedByUserID { get; set; }
    public string ClassName { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsActive { get; set; }
    public InternationalLicense() { }
    public InternationalLicense(DataRow dr)
    {
        InternationalLicenseID = Convert.ToInt32(dr["InternationalLicenseID"]);
        ApplicationID = Convert.ToInt32(dr["ApplicationID"]);
        DriverID = Convert.ToInt32(dr["DriverID"]);
        IssuedUsingLocalLicenseID = Convert.ToInt32(dr["IssuedUsingLocalLicenseID"]);
        CreatedByUserID = Convert.ToInt32(dr["CreatedByUserID"]);
        ClassName = dr["ClassName"].ToString();
        IssueDate = Convert.ToDateTime(dr["IssueDate"]);
        ExpirationDate = Convert.ToDateTime(dr["ExpirationDate"]);
        IsActive = ExpirationDate < DateTime.Now;
    }
}