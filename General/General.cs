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
    public string ImageName { get; set; }
    public byte Gendor { get; set; }
    public bool ImageIsExist { get; set; }
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
    }
}