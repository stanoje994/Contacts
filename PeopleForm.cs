using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public PeopleForm()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = people;
            listPeopleListBox.DisplayMember = "Contact";
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;
            p.PhoneNumber = PhoneNumberText.Text;
            p.Address = AddressText.Text;
            p.Email = EmailText.Text;

            SqliteDataAccess.SavePerson(p);

            firstNameText.Text = "";
            lastNameText.Text = "";
            PhoneNumberText.Text = "";
            AddressText.Text = "";
            EmailText.Text = "";
        }

        private void listPeopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
