using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Emily Anderson
        * November 17, 2022
        * This program validates input, calculates and displays price for flights */

        //Create ResetTrip function

        /* Name: ResetTrip
         * Sent: none
         * Returned: none
         * Resets form */
        private void ResetTrip()
        {
            grpTripInfo.Hide();
            radCuba.Checked = true;
            txtPeople.Text = "";
            lblPrice.Text = "";
            radCredit.Checked = true;
            txtPeople.Focus();
            chkFlightIncluded.Checked = false;
        }

        // Create SetFlight funciton

        /* Name: SetFlight
        * Sent: none
        * Returned: none
        * Changes the checkboxes */
        private void SetFlight()
        {
            chkFlightIncluded.Checked = true;
        }
        // Create DisplayMsg function

        /* Name: DsiplayMsg
         * Sent: 2 strings
         * Returned: none
         * Displays message */
        private void DisplayMsg (string message, string title)
        {
            MessageBox.Show(message, title);
        }
        // Call function ResetTrip on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTrip();
        }
        // Call the ResetTrip function when Reset is clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTrip();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // Declare variables
            bool validPeople;
            int number;
            double price;
            const double MEXICO = 2300.79;
            const double LOCATION  = 2150.50;
            const string PROGRAMMER = "Josh";
            const int MIN = 1;
            const int MAX = 10;
            const double RATE = 0.10;

            // TryParse to convert number in People Textbox and validating it is correct datatype
            validPeople = int.TryParse(txtPeople.Text, out number);


            // If user inputs wrong datatype, display error message
            if (validPeople == false)
            {
                DisplayMsg("People must be a whole number", "Input Error");
                txtPeople.Focus();
                txtPeople.SelectAll();
            }
            // If user inputs number outside the given range, display error message
            else if (number > MAX || number < MIN)
            {
                DisplayMsg("People must be between " + MIN + "-" + MAX, "Input Error");
                txtPeople.Focus();
                txtPeople.SelectAll();
            }
            // Calculate price if user chooses Mexico & display
            else if(radMexico.Checked)
            {
                SetFlight();
                price = MEXICO * number;
                lblDisplay.Text = "Booked by " + PROGRAMMER + "\n\nPeople: " + number.ToString("d2") + "\nLocation: " + radMexico.Text.ToUpper() + "\n" + chkFlightIncluded.Text;
                // If Cash is checked, calculate discount & display
                if (radCash.Checked)
                {
                    price = (MEXICO * number) - (MEXICO * number * RATE);
                    lblDisplay.Text += "\nCash Discount Applied";
                }
                lblPrice.Text = price.ToString("c");
                lblDisplay.Text += "\nPrice: " + lblPrice.Text;
                grpTripInfo.Show();
                grpBook.Enabled = false;
            }
            // Calculate price if user chooses Cuba & display
            else if (radCuba.Checked)
            {
                SetFlight();
                price = LOCATION * number;
                lblDisplay.Text = "Booked by " + PROGRAMMER + "\n\nPeople: " + number.ToString("d2") + "\nLocation: " + radCuba.Text.ToUpper() + "\n" + chkFlightIncluded.Text;
                // If Cash is checked, calculate discount and display
                if (radCash.Checked)
                {
                    price = (LOCATION * number) - (LOCATION * number * RATE);
                    lblDisplay.Text += "\nCash Discount Applied";
                }
                lblPrice.Text = price.ToString("c");
                lblDisplay.Text += "\nPrice: " + lblPrice.Text;
                grpTripInfo.Show();
                grpBook.Enabled = false;
            }
            // Calculate if user chooses Florida & display
            else if (radFlorida.Checked)
            {
                chkFlightIncluded.Checked = false;
                price = LOCATION * number;
                lblDisplay.Text = "Booked by " + PROGRAMMER + "\n\nPeople: " + number.ToString("d2") + "\nLocation: " + radFlorida.Text.ToUpper();
                // If Cash is checked, calculate discount and display
                if (radCash.Checked)
                {
                    price = (LOCATION * number) - (LOCATION * number * RATE);
                    lblDisplay.Text += "\nCash Discount Applied";
                }
                lblPrice.Text = price.ToString("c");
                lblDisplay.Text += "\nPrice: " + lblPrice.Text;
                grpTripInfo.Show();
                grpBook.Enabled = false;
            }
            // Switch for a BOGO special, case is true, display message
            switch (txtPeople.Text)
            {
                case "1": case "3":
                    DisplayMsg("Special when booking single or triple.\n" + "BOGO Special - Call 555-1212 to recieve another person free!", "Limited Time Offer");
                    break;
            } // Ending switch bracket

        } // Ending bracket of parent IF statement

        // Display message & reset form once confirm is clicked
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DisplayMsg("Trip booked and paid\n" + "Price: " + lblPrice.Text, "Confirmation Email Sent");
            grpBook.Enabled = true;
            ResetTrip();
        }
    }
}
