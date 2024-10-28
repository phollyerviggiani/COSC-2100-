/* 
IP2: Loan Report
Name: Patrick Hollyer-Viggiani
Student Number: 100910706
Date: October 20, 2024
Description: Create a program that showcases classes functionality and importing.
             This is done by generateing a loan form with caclulation, then displaying it
             to a textbox.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100.IP2
{
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();

            // Adding keybinding functionality (calculate and reset handled by accept/cancel buttons)
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(buttonExit_KeyDown);
        }

        // On pressing the calculate button parse the inputs and generate the loan report
        private void OnCalculate(object sender, EventArgs e)
        {
            // Trying to parse the inputs
            try
            {
                int loanNumber = int.Parse(textBoxLoanNumber.Text);
                string customerName = textBoxCustomerName.Text;
                string customerAddress = textBoxCustomerAddress.Text;
                double loanAmount = double.Parse(textBoxLoanAmount.Text);
                double interestRate = double.Parse(textBoxInterestRate.Text);
                int loanDuration = int.Parse(textBoxLoanDuration.Text);


                // If all inputs are valid, add instance of the loan class
                Loan loan = new Loan(loanNumber, customerName, customerAddress, loanAmount, interestRate, loanDuration);

                // Assign the generatestatement method from the loan class to a value called loan report
                string loanReport = loan.GenerateStatement();

                // Display the generated value in the loan report textbox
                textBoxLoanReport.Text = loanReport;

                // Set all values to read only mode to disable re-input until reset button is pressed
                textBoxLoanNumber.ReadOnly = true;
                textBoxCustomerName.ReadOnly = true;
                textBoxCustomerAddress.ReadOnly = true;
                textBoxLoanAmount.ReadOnly = true;
                textBoxInterestRate.ReadOnly = true;
                textBoxLoanDuration.ReadOnly = true;
            }

            // Catch blocks from the try statement to handle invalid inputs
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for loan number, amount, interest rate, and duration.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // On pressing the reset button, clear all values and re-enable the boxes for input
        private void OnReset(object sender, EventArgs e)
        {
            // Clearing all values from all fields
            textBoxLoanNumber.Clear();
            textBoxInterestRate.Clear();
            textBoxLoanDuration.Clear();
            textBoxCustomerAddress.Clear();
            textBoxCustomerName.Clear();
            textBoxLoanAmount.Clear();
            textBoxLoanReport.Clear();

            // Focusing the first box (loan number)
            textBoxLoanNumber.Focus();

            // Setting read only on all boxes to false
            textBoxLoanNumber.ReadOnly = false;
            textBoxCustomerName.ReadOnly = false;
            textBoxCustomerAddress.ReadOnly = false;
            textBoxLoanAmount.ReadOnly = false;
            textBoxInterestRate.ReadOnly = false;
            textBoxLoanDuration.ReadOnly = false;
        }

        // On clicking the exit button, close the program
        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        // Adding an exit button keybind set to F4
        private void buttonExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
    }
}
