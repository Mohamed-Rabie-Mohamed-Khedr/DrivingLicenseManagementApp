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
        if (CheckNationalNo(person.NationalNo)) return false;
            return SetData.AddPerson(ref person);
    }
    public static bool UpdatePerson(ref Person person, ref string nationalNoOld)
    {
        return SetData.UpdatePerson(ref person, ref nationalNoOld);
    }
    public static Person GetPerson(ref string NationalNo)
    {
        return GetData.GetPerson(ref NationalNo);
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
    public static bool CheckNationalNo(string NationalNo)
    {
        return GetData.CheckNationalNo(ref NationalNo);
    }
}