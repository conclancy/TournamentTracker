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

                GlobalConfig.Connection.CreatePerson(p);

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
    }
}
