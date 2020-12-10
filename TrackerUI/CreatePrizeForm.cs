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
using TrackerLibrary.DataConnections;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        // This form will have an object implementing the IPrizeRequester called 'callingForm'
        IPrizeRequester callingForm;

        // Some other object implmenting the IPrizeRequester 
        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();

            // The caller is the callingForm variable 
            callingForm = caller;
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void saveTeamButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text, 
                    placeNumberValue.Text, 
                    prizeAmountValue.Text, 
                    prizePercentValue.Text
                );

                // Pass prize data to Database AND update model with Id
                GlobalConfig.Connection.CreatePrize(model);

                // Pass the model back to the calling object's PrizeComplete method  
                callingForm.PrizeComplete(model);

                // Close the prize form
                this.Close();
            }

            else
            {
                MessageBox.Show("This form has invalid information.  Please check and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            
            bool placeNumberValid = int.TryParse(placeNumberValue.Text, out int placeNumber);

            if (!placeNumberValid)
            {
                output = false;
            }

            
            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            bool prizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out decimal prizeAmount);

            bool prizePercentageValid = double.TryParse(prizePercentValue.Text, out double prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if( prizeAmount < 0 || (prizePercentage < 0 || prizePercentage > 100))
            {
                output = false;
            }
            
            return output;
        }
    }
}
