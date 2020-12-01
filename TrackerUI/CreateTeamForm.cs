using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();

            //CreateSamples();

            WireUpLists();
        }

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        private void CreateSamples()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Connor", LastName = "Clancy" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Saleh", LastName = "Alkhalifa" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Test", LastName = "Player" });
        }

        private void WireUpLists()
        {
            selectPlayerDropDown.DataSource = null; 

            selectPlayerDropDown.DataSource = availableTeamMembers;
            selectPlayerDropDown.DisplayMember = "FullName";

            teamPlayerListBox.DataSource = null;

            teamPlayerListBox.DataSource = selectedTeamMembers;
            teamPlayerListBox.DisplayMember = "FullName";
        }

        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellPhoneNumber = cellPhoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("One or more feilds contain an invalid input.  Please try again.");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                // TODO - Add validation to confirm @ and . are present in address
                return false;
            }

            // assuming North American styled phone number.  
            if (cellPhoneValue.Text.Length < 10 || cellPhoneValue.Text.Length > 11)
            {
                return false;
            }

            if (cellPhoneValue.Text.Length == 11 && !cellPhoneValue.Text.StartsWith("1"))
            {
                return false;
            }

            if (cellPhoneValue.Text.Length == 10 && (cellPhoneValue.Text.StartsWith("1") || cellPhoneValue.Text.StartsWith("0")) )
            {
                return false;
            }

            return true;
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectPlayerDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists(); 
            }
        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamPlayerListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }
    }
}
