using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
