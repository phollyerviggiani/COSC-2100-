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

        // Creating a list of values to rearrange and reasign values to
        List<double> dayNumberSales = new List<double> { 0, 0, 0, 0, 0, 0, 0 };

        public Assignment1Patrick()
        {
            InitializeComponent();
        }

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

        private void OnEnter(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBoxGameSales.Text, out value) && value >= 0)
            {
                // Selecting the value and number we want to change 
                dayNumberSales[(int)comboBoxDayNumber.SelectedIndex] = value;
                ((BindingSource)listBoxData.DataSource).ResetBindings(false);

                // Adding up the values in the listbox
                double total = dayNumberSales.Sum();
                textBoxOutputSum.Text = $"Sum up to {total.ToString("#.##")}";

            }
            // If invalid input, throw and error message then refocus
            else
            {
                MessageBox.Show("Invalid value! Must be numeric.", "Error Message");
                textBoxGameSales.SelectAll();
                textBoxGameSales.Focus();
            }
        }

        // Function to reset the current window to a clear state
        private void OnReset(object sender, EventArgs e)
        {
            // Loops through and sets each number value in the list to 0
            for (int i = 0; i < dayNumberSales.Count; i++)
            {
                dayNumberSales[i] = 0;
            }

            // Clears the outputsum and gamesales box
            ((BindingSource)listBoxData.DataSource).ResetBindings(false);
            textBoxOutputSum.Clear();
            textBoxGameSales.Clear();
        }

        // Function to exit the program when the user activates the exit button
        private void OnExit(object sender, EventArgs e)
        {
            // Closes this instance of the program
            this.Close();
        }
    }
}
