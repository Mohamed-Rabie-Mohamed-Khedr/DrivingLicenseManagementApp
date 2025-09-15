using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingLicenseManagement
{
    public partial class AddAndUpdatePerson : UserControl
    {
        Status myStatus = Status.Add;
        string nationalNoOld;
        public AddAndUpdatePerson(ref string nationalNoOld)
        {
            InitializeComponent();

            if (nationalNoOld == "") return;
            this.nationalNoOld = nationalNoOld;
            myStatus = Status.Update;
            label1.Text = "Update Person";
        }

        private void AddAndUpdatePerson_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            DateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            Country.Items.AddRange(MyDB.GetCountries());
            if (myStatus == Status.Add)
            {
                Gendor.SelectedIndex = 0;
                Country.SelectedIndex = 0;
            }
            else
            {
                LoadPerson(MyDB.GetPerson(ref nationalNoOld));
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Regex emailCheck = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (string.IsNullOrEmpty(Name1.Text) || string.IsNullOrEmpty(Name2.Text) || string.IsNullOrEmpty(Name3.Text) || string.IsNullOrEmpty(Name4.Text))
                MessageBox.Show("Please Enter Your Full Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(NationalNo.Text))
                MessageBox.Show("Please Enter Your National No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!string.IsNullOrEmpty(Email.Text) && !emailCheck.IsMatch(Email.Text))
                MessageBox.Show("Your Email Is Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(Phone.Text) || (!string.IsNullOrEmpty(Phone.Text) && (!int.TryParse(Phone.Text, out int result))))
                MessageBox.Show("Your Phone Is Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrEmpty(Address.Text))
                MessageBox.Show("Please Enter Your Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Country.SelectedIndex == 0)
                MessageBox.Show("Please Select Your Country", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if (myStatus == Status.Add)
                {
                    Person person = RaedPersonFromForm();
                    if (MyDB.AddPerson(ref person))
                    {
                        IDT.Text = "Person ID: " + person.PersonID.ToString();
                        Name1.Text = Name2.Text = Name3.Text = Name4.Text =
                        NationalNo.Text = Phone.Text = Address.Text = Email.Text = "";
                        SetImagePerson();
                        RemoveImage.Visible = false;
                        MessageBox.Show("Person Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error While Adding Person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Person person = RaedPersonFromForm();
                    if (person.NationalNo != nationalNoOld)
                        DLMHelper.RemoveFile("Images\\" + nationalNoOld + ".jpg");
                    if (MyDB.UpdatePerson(ref person, ref nationalNoOld))
                    {
                        MessageBox.Show("Person Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error While Updating Person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePerson.Image = DLMHelper.GetImage(openFileDialog.FileName);
                RemoveImage.Visible = true;
            }
        }

        Person RaedPersonFromForm()
        {
            Person person = new Person();
            person.FirstName = Name1.Text;
            person.SecondName = Name2.Text;
            person.ThirdName = Name3.Text;
            person.LastName = Name4.Text;
            person.Phone = Phone.Text;
            person.Gendor = (byte)Gendor.SelectedIndex;
            person.Address = Address.Text;
            person.DateOfBirth = DateOfBirth.Value;
            person.NationalityCountryID = Country.SelectedIndex;
            person.NationalNo = NationalNo.Text;

            if (RemoveImage.Visible)
            {
                person.ImagePath = NationalNo.Text;
                ImagePerson.Image.Save("Images\\" + person.ImagePath + ".jpg", ImageFormat.Jpeg);
            }
            if (!string.IsNullOrEmpty(Email.Text))
                person.Email = Email.Text;

            return person;
        }

        private void Gendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetImagePerson();
        }

        void LoadPerson(Person person)
        {
            IDT.Text = "Person ID: " + person.PersonID.ToString();
            Name1.Text = person.FirstName;
            Name2.Text = person.SecondName;
            Name3.Text = person.ThirdName;
            Name4.Text = person.LastName;
            NationalNo.Text = person.NationalNo;
            Phone.Text = person.Phone;
            Address.Text = person.Address;
            DateOfBirth.Value = person.DateOfBirth;
            Country.SelectedIndex = person.NationalityCountryID;
            Gendor.SelectedIndex = person.Gendor;
            if (!string.IsNullOrEmpty(person.ImagePath))
            {
                ImagePerson.Image = DLMHelper.GetImage("Images\\" + person.ImagePath + ".jpg");
                RemoveImage.Visible = true;
            }
            if (!string.IsNullOrEmpty(person.Email))
                Email.Text = person.Email;
        }

        private void RemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemoveImage.Visible = false;
            SetImagePerson();
            if (myStatus == Status.Update)
                DLMHelper.RemoveFile("Images\\" + nationalNoOld + ".jpg");
        }

        void SetImagePerson()
        {
            if (Gendor.SelectedIndex == 0)
                ImagePerson.Image = Properties.Resources.male;
            else
                ImagePerson.Image = Properties.Resources.female;
        }
    }
}