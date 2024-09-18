using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace COSC2100.W3Demo
{
    public partial class FormControl : Form
    {
        // Creates a list containing all the days of the week, along with value (prioity for it)
        List<Object> weekDays = new List<object>
        {
            new { Name = "Sunday", Value = 0 },
            new { Name = "Monday", Value = 1 },
            new { Name = "Tuesday", Value = 2 },
            new { Name = "Wednesday", Value = 3 },
            new { Name = "Thursday", Value = 4 },
            new { Name = "Friday", Value = 5 },
            new { Name = "Saturday", Value = 6 },
        };

        // Creating a list of values to rearrange and reasign values to
        List<double> weekDaySales = new List<double> { 0, 0, 0, 0, 0, 0, 0 };

        public FormControl()
        {
            InitializeComponent();
        }

        // When loading the form application, load the data from the weekdays list
        private void OnLoad(object sender, EventArgs e)
        {
            // Creating a new instance of bindingsource, passing weekdays 
            BindingSource bs = new BindingSource(weekDays, null);
            comboWeekDay.DataSource = bs;

            // Choosing to display the name string with its associated value in prio
            comboWeekDay.DisplayMember = "Name";
            comboWeekDay.ValueMember = "Value";

            // Binding the data from weekDaySales to the listbox
            BindingSource bsList = new BindingSource(weekDaySales, null);
            listBoxItem.DataSource = bsList;

        }

        // On clicking the input button, making a function that switches the value from 0 to whatever value we type
        // Value must be a double otherwise we get an error message
        private void OnInput(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textValue.Text, out value))
            {
                // Selecting the value and number we want to change 
                weekDaySales[(int)comboWeekDay.SelectedIndex] = value;
                ((BindingSource)listBoxItem.DataSource).ResetBindings(false);

                // Adding up the values in the listbox
                double total = weekDaySales.Sum();
                textResult.Text = $"Sum up to {total.ToString("#.##")}";

            }
            // If invalid input, throw and error message then refocus
            else
            {
                MessageBox.Show("Invalid value! Must be numeric.", "Error Message");
                textValue.SelectAll();
                textValue.Focus(); 
            }
        }
    }
}
