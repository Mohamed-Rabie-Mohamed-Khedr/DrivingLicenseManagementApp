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
    public int LicenseClassID { get; set; }
    public int ApplicantPersonID { get; set; }
    public DateTime ApplicationDate { get; set; }
    public int ApplicationTypeID { get; set; }
    public byte ApplicationStatus { get; set; }
    public DateTime LastStatusDate { get; set; }
    public decimal PaidFees { get; set; }
    public int CreatedByUserID { get; set; }

    public LDLApp() { }

    public LDLApp(DataRow dr)
    {
        LDLAppID = Convert.ToInt32(dr["LocalDrivingLicenseApplicationID"]);
        ApplicationID = Convert.ToInt32(dr["ApplicationID"]);
        LicenseClassID = Convert.ToInt32(dr["LicenseClassID"]);
        ApplicantPersonID = Convert.ToInt32(dr["ApplicantPersonID"]);
        ApplicationDate = Convert.ToDateTime(dr["ApplicationDate"]);
        ApplicationTypeID = Convert.ToInt32(dr["ApplicationTypeID"]);
        ApplicationStatus = Convert.ToByte(dr["ApplicationStatus"]);
        LastStatusDate = Convert.ToDateTime(dr["LastStatusDate"]);
        PaidFees = Convert.ToDecimal(dr["PaidFees"]);
        CreatedByUserID = Convert.ToInt32(dr["CreatedByUserID"]);
    }
}