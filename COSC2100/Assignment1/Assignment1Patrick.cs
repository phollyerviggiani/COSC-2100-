/* 
Assignmnet 1: Video Game Sales Calculator
Name: Patrick Hollyer-Viggiani
Student Number: 100910706
Date: October 1, 2024
Description: Create a program that allows for the calculation of video game sales during a 7 day period
             After each number is entered, allow for the total to be displayed at the bottom.
             Have reset/exit buttons and all functionalities enabled to project requirements.
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

namespace COSC2100.Assignment1
{
    // Creating a custom DaySales class that allows for numeric and string to be listed next to each other in the listbox
    public class DaySales
    {
        // Getters and setters
        public string Day { get; set; }
        public double Sales { get; set; }

        // Initalizing variables
        public DaySales(string day, double sales)
        {
            Day = day;
            Sales = sales;
        }

        // Override ToString() to display the day and its sales together
        public override string ToString()
        {
            // Return the values with proper formatting
            return $"{Day} - ${Sales}";
        }
    }
    public partial class Assignment1Patrick : Form
    {
        // Creates a list containing the days numbered 1-7, along with value (prioity for it)
        List<Object> dayNumber = new List<object>
        {
            new { Name = "Day 1", Value = 0 },
            new { Name = "Day 2", Value = 1 },
            new { Name = "Day 3", Value = 2 },
            new { Name = "Day 4", Value = 3 },
            new { Name = "Day 5", Value = 4 },
            new { Name = "Day 6", Value = 5 },
            new { Name = "Day 7", Value = 6 },
        };

        // Creating list, passing through the DaySales class made previously to allow for clean formatting of numbers
        List<DaySales> dayNumberSales = new List<DaySales>
        {
            new DaySales("Day 1", 0),
            new DaySales("Day 2", 0),
            new DaySales("Day 3", 0),
            new DaySales("Day 4", 0),
            new DaySales("Day 5", 0),
            new DaySales("Day 6", 0),
            new DaySales("Day 7", 0)
        };

        public Assignment1Patrick()
        {
            InitializeComponent();

            // Adding keybinding functionality
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(buttonEnter_KeyDown);
            this.KeyDown += new KeyEventHandler(buttonExit_KeyDown);
        }

        #region onLoad
        // Upon loading the windows form, assign the values and lists to the comboBox
        private void OnLoad(object sender, EventArgs e)
        {
            // Creating a new instance of bindingsource, passing dayNumber
            BindingSource bs = new BindingSource(dayNumber, null);
            comboBoxDayNumber.DataSource = bs;

            // Choosing to display the name string with its associated value in prio
            comboBoxDayNumber.DisplayMember = "Name";
            comboBoxDayNumber.ValueMember = "Value";

            // Binding the data from dayNumberSales to the listbox
            BindingSource bsList = new BindingSource(dayNumberSales, null);
            listBoxData.DataSource = bsList;
        }
        #endregion

        #region Enter
        // Upon pressing the enter button or ctrl + e key, enter the value from the input box
        // Assign it to the corresponding day value the user desires and add it to the sum total at the button
        private void OnEnter(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBoxGameSales.Text, out value) && value >= 0)
            {
                // Update the sales value for the selected day
                dayNumberSales[(int)comboBoxDayNumber.SelectedIndex].Sales = value;

                // Refresh the list box display
                ((BindingSource)listBoxData.DataSource).ResetBindings(false);

                // Initalizing the total variable which stones the total of each input
                double total = dayNumberSales.Sum(day => day.Sales);
                

                // Check if all days have been filled (i.e., no zero values in dayNumberSales)
                if (dayNumberSales.All(day => day.Sales > 0))
                {
                    // Disable input controls as all 7 inputs have been filled 
                    // Only display the sum once all 7 inputs are filled
                    textBoxGameSales.Enabled = false;
                    comboBoxDayNumber.Enabled = false;
                    textBoxOutputSum.Text = $"Average Video Game Sales: ${total.ToString("#.##")}";
                    
                    // Focus on the reset button
                    buttonReset.Focus();

                    // Message to show users everything has been inputted
                    MessageBox.Show("All  inputs have been filled. Please press Reset or 'ESC' to enter new values.", "Information");
                }
            }
            // If invalid input, throw and error message then refocus
            else
            {
                MessageBox.Show("Invalid value! Must be numeric.", "Error Message");
                textBoxGameSales.SelectAll();
                textBoxGameSales.Focus();
            }
        }
        #endregion

        #region Reset
        // Function to reset the current window to a clear state
        private void OnReset(object sender, EventArgs e)
        {
            // Loops through and resets each day's sales value to 0
            foreach (var daySales in dayNumberSales)
            {
                daySales.Sales = 0;
            }

            // Sets the ComboBox day to day 1
            comboBoxDayNumber.SelectedIndex = 0;

            // Clears the outputSum and gameSales box
            ((BindingSource)listBoxData.DataSource).ResetBindings(false);
            textBoxOutputSum.Clear();
            textBoxGameSales.Clear();

            // Re-enable the input controls
            textBoxGameSales.Enabled = true;
            comboBoxDayNumber.Enabled = true;

            // Refocus the input box
            textBoxGameSales.Focus();
        }
        #endregion

        #region Exit
        // Function to exit the program when the user activates the exit button
        private void OnExit(object sender, EventArgs e)
        {
            // Closes this instance of the program
            this.Close();
        }
        #endregion

        #region Keybinds
        // Enter button keybind, calling the value of the OnEnter function
        private void buttonEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
            {
                OnEnter(this, EventArgs.Empty);
            }
        }

        // Exit button keybind, closing the window when pressed
        private void buttonExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                this.Close();
            }
        }
        #endregion
    }
}