/* 
Assignmnet 3: Car Service Form
Name: Patrick Hollyer-Viggiani
Student Number: 100910706
Date: November 5, 2024
Description: Create a program that allows for users to add information to a viewlist when visiting a car service
             shop. This program lets users input and add fields to a viewlist, update, and remove said fields
             The program utilizes two classes additional classes implimented into the CarServiceFrm.cs file
             tasked with handling functionality and shop services.
*/

using System.Data;
using System.Globalization;

namespace COSC2100.Assignment3A
{
    public partial class CarServiceFrm : Form
    {
        // Enumeration for the column indexes in the listview
        enum ColumnEnm
        {
            No = 0,
            FirstName,
            LastName,
            Phone,
            Make,
            Model,
            Year,
            Color,
            EngOilChange,
            TransOilChange,
            AirFilterChange,
            Price,
            MaxColumn
        }

        // Instance of the CarServiceShop to manage the services
        CarServiceShop carServiceShop;
        int state = 0; // State variable to track the current operation

        public CarServiceFrm()
        {
            // Initalizing the CarServiceShop + components
            carServiceShop = new CarServiceShop();
            InitializeComponent();

            // Create and set up columns for the lsitview contorl
            ColumnHeader[] columns = new ColumnHeader[(int)ColumnEnm.MaxColumn];
            for (ColumnEnm col = ColumnEnm.No; col< ColumnEnm.MaxColumn; col++)
            {
                columns[(int)col] = new ColumnHeader();
            }

            // Adding the columns to the listview
            lvCarServices.Columns.AddRange(columns);
            columns[(int)ColumnEnm.No].Text = "No.";
            columns[(int)ColumnEnm.FirstName].Text = "First Name";
            columns[(int)ColumnEnm.LastName].Text = "Last Name";
            columns[(int)ColumnEnm.Phone].Text = "Phone"; 
            columns[(int)ColumnEnm.Make].Text = "Make";
            columns[(int)ColumnEnm.Model].Text = "Model";
            columns[(int)ColumnEnm.Year].Text = "Year";
            columns[(int)ColumnEnm.Color].Text = "Color";
            columns[(int)ColumnEnm.EngOilChange].Text = "EngOilChange";
            columns[(int)ColumnEnm.TransOilChange].Text = "TransOilChange"; 
            columns[(int)ColumnEnm.AirFilterChange].Text = "AirFilterChange";
            columns[(int)ColumnEnm.Price].Text = "Price";

            // Set up the combo box for car makes
            comboMake.DataSource = carServiceShop.CarMaker;

            // Set the numeric year control's limits
            numericYear.Maximum = DateTime.Now.Year;
            numericYear.Minimum = numericYear.Maximum - CarServiceShop.Constants.MaxCarYear;

            // Default to current year
            numericYear.Value = numericYear.Maximum;

            // Update listview and form controls
            UpdateList();
            UpdateForm();
        }

        // Method to update the listview with car service entries
        private void UpdateList()
        {
            // Clear existing items in the listview
            lvCarServices.Items.Clear();
            int displayIndex = 1;

            // Loop through and create new listviewitem for each carservice
            foreach (CarService item in carServiceShop.CarServices)
            {
                ListViewItem listViewItem1 = new ListViewItem(displayIndex.ToString()); 
                displayIndex++; 

                listViewItem1.SubItems.Add(item.FirstName);
                listViewItem1.SubItems.Add(item.LastName);
                listViewItem1.SubItems.Add(item.Phone);
                listViewItem1.SubItems.Add(item.Make);
                listViewItem1.SubItems.Add(item.Model);
                listViewItem1.SubItems.Add(item.Year.ToString());
                listViewItem1.SubItems.Add(item.Color);
                listViewItem1.SubItems.Add(item.EngOilChange ? "X" : "");
                listViewItem1.SubItems.Add(item.TransOilChange ? "X" : "");
                listViewItem1.SubItems.Add(item.AirFilterChange ? "X" : "");
                listViewItem1.SubItems.Add(item.Price.ToString("#.##"));

                // Add the item to the listview
                lvCarServices.Items.Add(listViewItem1);
            }
        }

        // When clicking add or pressing 'enter' add the items to the listview
        private void OnAdd(object sender, EventArgs e)
        {
            // Check to see if form in correct state
            if (state == 0)
            {
                try
                {
                    // Create an instance of CarService with the user inputs
                    CarService carService = new CarService(
                        textFirstName.Text,
                        textLastName.Text,
                        textPhone.Text,
                        comboMake.Text,
                        textModel.Text,
                        (Int16)numericYear.Value,
                        textColor.Text,
                        chkEngineOil.Checked,
                        chkTransOil.Checked,
                        chkAirFilter.Checked);

                    // Adding to the shop
                    carServiceShop.AddService(carService);

                    // Clear all input fields + update listview
                    ClearInputFields();
                    UpdateList();

                    // Confirmation text + setting state to -1 to avoid double input of same item
                    lblResult.Text = "Service added successfully. Press 'New' to add new service.";
                    state = -1; 
                }
                // Error handling, catches the error and shows what fields are missing/invalid
                catch (Exception ex)
                {
                    lblResult.Text = $"Error! Please ensure the following are valid: \n{ex.Message}";
                }
            }
            
            // If the user has not pressed new, throws this message stating to press new since state still at -1
            else
            {
                lblResult.Text = "Please create a new record first. Select 'New'.";
            }
        }

        // When new is pressed, reset state to 0 and clear/update the form
        private void OnNew(object sender, EventArgs e)
        {
            state = 0;
            ClearInputFields();

            textCost.Clear();

            lvCarServices.SelectedIndices.Clear();

            lblResult.Text = string.Empty;
            UpdateForm();
        }

        // Method to update the form controls when updating a listview
        private void UpdateForm(CarService carService = null)
        {
            // If no data, clear inputs
            if(carService == null)
            {
                ClearInputFields();

                textCost.Clear();

                lblResult.Text = string.Empty;
            }

            // Else, populate the fields with existing carservice data
            else
            {
                textFirstName.Text = carService.FirstName;
                textLastName.Text = carService.LastName;
                textPhone.Text = carService.Phone;
                comboMake.SelectedItem = carService.Make; 
                textModel.Text = carService.Model;
                numericYear.Value = carService.Year; 
                textColor.Text = carService.Color;

                chkEngineOil.Checked = carService.EngOilChange;
                chkTransOil.Checked = carService.TransOilChange;
                chkAirFilter.Checked = carService.AirFilterChange;

                textCost.Text = carService.Price.ToString("C", CultureInfo.CurrentCulture);
            }

            // Clear any previous messages
            lblResult.Text = string.Empty;
        }

        // When update is pressed, the following will happen
        private void OnUpdate(object sender, EventArgs e)
        {

            // Ensure an item is selected
            if (lvCarServices.SelectedItems.Count > 0)
            {
                try
                {
                    // Get the id from selected items
                    int id = int.Parse(lvCarServices.SelectedItems[(int)ColumnEnm.No].Text);

                    // Create a new instance of CarServices with updated data
                    CarService carService = new CarService(textFirstName.Text, textLastName.Text, textPhone.Text,
                        comboMake.Text, textModel.Text, (Int16)numericYear.Value, textColor.Text, chkEngineOil.Checked,
                        chkTransOil.Checked, chkAirFilter.Checked);

                    // Update the service in the shop
                    carServiceShop.UpdateService(id, carService);

                    // Refresh the lsitview, show update, and set state to -1
                    UpdateList();
                    lblResult.Text = "Update successful. Press 'New' to add another service";
                    state = -1;
                }

                // Error handling, catches the error and shows what fields are invalid
                catch (Exception ex)
                {
                    lblResult.Text = $"{ex.Message} is not valid";
                }
            }

            // If user has not selected an item in the listview, throw this message
            else
            {
                lblResult.Text = "Select an item from the list to update.";
            }
        }

        // When remove is pressed, the following will happen
        private void OnRemove(object sender, EventArgs e)
        {

            // Checking to see if there are any items selected
            if (lvCarServices.SelectedItems.Count > 0)
            {
                try
                {
                    // Getting the id of selected service and removing it
                    int id = int.Parse(lvCarServices.SelectedItems[0].Text);
                    carServiceShop.RemoveService(id);

                    // Refreshing the listview
                    UpdateList();
                    lblResult.Text = "Service removed successfully. Press 'New' to add another service";
                }

                // Error catch to deal with issues removing
                catch (Exception ex)
                {
                    lblResult.Text = $"{ex.Message} is not valid";
                }
            }

            // If nothing is selected, throw this message to display that
            else
            {
                lblResult.Text = "Select an item from the list to remove";
            }
        }

        // When removeall button is clicked, the following will happen
        private void OnRemoveAll(object sender, EventArgs e)
        {
            try
            {
                // Clear everything within the listview and input fields + update refresh listview
                carServiceShop.ClearAll();
                UpdateList();
                lblResult.Text = "All services removed successfully. Press 'New' to add another service.";

            }

            // Catch to handle any issues with removing all
            catch (Exception ex)
            {
                lblResult.Text = $"{ex.Message} is not valid";
            }
        }

        // Pressing exit or 'esc' on keyboard will close the program 
        private void OnExit(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for when item in listview is selected
        private void OnSelectItem(object sender, EventArgs e)
        {

            // Check if sender is listview and if any items are selected
            if (sender is ListView lv && lv.SelectedItems.Count > 0)
            {

                // Get first selected item from listview, parse id, and retrieve the data
                ListViewItem selectedItem = lvCarServices.SelectedItems[0];
                int id = int.Parse(selectedItem.Text); 
                CarService carService = carServiceShop.GetService(id); 


                // If data found, populate fields with its data + fill out correct radial boxes
                if (carService != null)
                {
                    
                    textFirstName.Text = carService.FirstName;
                    textLastName.Text = carService.LastName;
                    textPhone.Text = carService.Phone;
                    comboMake.Text = carService.Make;
                    textModel.Text = carService.Model;
                    numericYear.Value = carService.Year;
                    textColor.Text = carService.Color;
                    chkEngineOil.Checked = carService.EngOilChange;
                    chkTransOil.Checked = carService.TransOilChange;
                    chkAirFilter.Checked = carService.AirFilterChange;
                    textCost.Text = carService.Price.ToString("C", CultureInfo.CurrentCulture);

                    // Update state to reflect it being in 'editing mode'
                    state = 1; 
                }
            }
        }

        // Method dealing with pricing when radial boxes checked
        private void OnServiceChange(object sender, EventArgs e)
        {
            decimal price = CarService.CalculatePrice(chkEngineOil.Checked, chkTransOil.Checked, chkAirFilter.Checked);
            textCost.Text = price.ToString("C", CultureInfo.CurrentCulture);
        }


        // Method used to make clearing all input fields reusable and easier
        private void ClearInputFields()
        {
            textFirstName.Clear();
            textLastName.Clear();
            textPhone.Clear();
            comboMake.SelectedIndex = 0;
            textModel.Clear();
            numericYear.Value = numericYear.Maximum;
            textColor.Clear();
            chkEngineOil.Checked = false;
            chkTransOil.Checked = false;
            chkAirFilter.Checked = false;
        }
    }
}
