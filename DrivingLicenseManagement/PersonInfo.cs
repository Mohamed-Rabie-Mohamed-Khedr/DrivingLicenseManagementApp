using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicenseManagement
{
    public partial class PersonInfo : UserControl
    {
        int CurrentPersonID = 0;
        public PersonInfo()
        {
            InitializeComponent();
        }
        public void SetPersonInfo(ref int PersonID)
        {
            CurrentPersonID = PersonID;
            Person person = MyDB.GetPerson(ref PersonID);
            PersonIDL.Text = "Person ID: " + person.PersonID.ToString();
            NameL.Text = "Name: " + person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            NationalNoL.Text = "National No: " + person.NationalNo;
            PhoneL.Text = "Phone: " + person.Phone;
            AddressL.Text = "Address: " + person.Address;
            DateOfBirthL.Text = "Date Of Birth: " + person.DateOfBirth.ToString();
            CountryL.Text = "Country: " + MyDB.GetCountries()[person.NationalityCountryID - 1];
            GendorL.Text = "Gendor: " + (person.Gendor == 0 ? "Male" : "Female");
            if (!string.IsNullOrEmpty(person.ImageName))
                ImagePerson.Image = DLMHelper.GetImage("Images\\" + person.ImageName + ".jpg");
            else
                ImagePerson.Image = DLMHelper.GetImagePersonDefault(person.Gendor == 0);
            if (!string.IsNullOrEmpty(person.Email))
                EmailL.Text = "Email: " + person.Email;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrentPersonID > 0)
            {
                AddAndUpdatePersonForm up = new AddAndUpdatePersonForm(CurrentPersonID);
                up.ShowDialog();
                SetPersonInfo(ref CurrentPersonID);
            }
        }
    }
}