/* 
Assignmnet: Simple Calculation FOrms
Name: Patrick Hollyer-Viggiani
Student Number: 100910706
Date: September 22, 2024
Description: Create a program which takes in two inputs and gives the user an option to either add or multiply
             following a set critera for specifics with the interface.
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

namespace COSC2100.IP1
{
    public partial class IP1Patrick : Form
    {
        public IP1Patrick()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // Handling the keybinding for exit, add, and multiply
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(buttonExit_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonAdd_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonMultiply_KeyDown);
        }

        /* 
         Upon clicking the add button, sum the two numbers together and display the output in the output box
         If the numbers are invalid, throw an error message and clear the numbers
         Change the input boxes to read only until the reset button is pressed 
        */
        private void OnClickAdd(object sender, EventArgs e)
        {
            // Initializing the first and second box variables
            double firstBoxValue, secondBoxValue;

            // Boolean check on both input boxes to ensure they are valid doubles
            bool isFirstBoxValid = double.TryParse(textFirstBox.Text, out firstBoxValue);
            bool isSecondBoxValid = double.TryParse(textSecondBox.Text, out secondBoxValue);


            // If both boxes are valid continue with calculating the product multiply the two values together
            // and put the product of the two numbers in the output box, rounding to two decimals
            if (isFirstBoxValid && isSecondBoxValid)
            {
                double totalBoxSum = firstBoxValue + secondBoxValue;
                textOutputBox.Text = totalBoxSum.ToString("#.##");

                // Making the input boxes read-only until the user presses the reset button or esc key
                textFirstBox.ReadOnly = true;
                textSecondBox.ReadOnly = true;
            }

            // If the first box's input is invalid, throw an error message stating where the error is
            // Then clear the refocus the given box
            else if (!isFirstBoxValid && isSecondBoxValid)
            {
                MessageBox.Show("Error, the first box's input is invalid");
                textFirstBox.Clear();
                textFirstBox.Focus();
            }

            // If the second box's input is invalid, throw an error message stating where the error is
            // Then clear the refocus the given box
            else if (isFirstBoxValid && !isSecondBoxValid)
            {
                MessageBox.Show("Error, the second box's input is invalid");
                textSecondBox.Clear();
                textSecondBox.Focus();
            }
            else
            {
                // Handle the case where both inputs are invalid
                MessageBox.Show("Error, please ensure both numbers entered are valid.");
                textFirstBox.Clear();
                textSecondBox.Clear();
            }

        }

        /* 
        Upon clicking the multiply button, multiply the two numbers together and display the output in the output box
        If the numbers are invalid, throw an error message and clear the numbers
        Change the input boxes to read only until the reset button is pressed 
        */
        private void OnClickMultiply(object sender, EventArgs e)
        {
            // Initializing the first and second box variables
            double firstBoxValue, secondBoxValue;

            // Boolean check on both input boxes to ensure they are valid doubles
            bool isFirstBoxValid = double.TryParse(textFirstBox.Text, out firstBoxValue);
            bool isSecondBoxValid = double.TryParse(textSecondBox.Text, out secondBoxValue);


            // If both boxes are valid continue with calculating the product multiply the two values together
            // and put the product of the two numbers in the output box, rounding to two decimals
            if (isFirstBoxValid && isSecondBoxValid)
            {
                double totalBoxProduct = firstBoxValue * secondBoxValue;
                textOutputBox.Text = totalBoxProduct.ToString("#.##");

                // Making the input boxes read-only until the user presses the reset button or esc key
                textFirstBox.ReadOnly = true;
                textSecondBox.ReadOnly = true;
            }

            // If the first box's input is invalid, throw an error message stating where the error is
            // Then clear the refocus the given box
            else if (!isFirstBoxValid && isSecondBoxValid)
            {
                MessageBox.Show("Error, the first box's input is invalid");
                textFirstBox.Clear();
                textFirstBox.Focus();
            }

            // If the second box's input is invalid, throw an error message stating where the error is
            // Then clear the refocus the given box
            else if (isFirstBoxValid && !isSecondBoxValid)
            {
                MessageBox.Show("Error, the second box's input is invalid");
                textSecondBox.Clear();
                textSecondBox.Focus();
            }
            else
            {
                // Handle the case where both inputs are invalid
                MessageBox.Show("Error, please ensure both numbers entered are valid.");
                textFirstBox.Clear();
                textSecondBox.Clear();
            }
        }

        // Function involved with clearing and reseting the data, refocuses on the first texxbox
        private void OnClickReset(object sender, EventArgs e)
        {
            // Clearing all boxes
            textFirstBox.Clear();
            textSecondBox.Clear();
            textOutputBox.Clear();

            // Changing back the first two boxes from read only
            textFirstBox.ReadOnly = false;
            textSecondBox.ReadOnly = false;

            // Focueses on the first box
            textFirstBox.Focus();
        }

        // Function involved with exiting the program
        private void OnClickExit(object sender, EventArgs e)
        {
            // Exiting the program
            this.Close();
        }

        // Assigning the keybind F4 to exiting the program
        private void buttonExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }

        // Assigning the keybinds ctrl + a to executing the add function
        private void buttonAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                OnClickAdd(this, EventArgs.Empty);
            }
        }

        // Assigning the keybinds ctrl + m to executing the multuply function
        private void buttonMultiply_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.M)
            {
                OnClickMultiply(this, EventArgs.Empty);
            }
        }
    }
}
