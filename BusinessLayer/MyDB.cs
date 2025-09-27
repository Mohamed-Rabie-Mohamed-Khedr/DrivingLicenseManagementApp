using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyDB
{
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
}