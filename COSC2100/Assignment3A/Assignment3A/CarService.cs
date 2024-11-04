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

namespace COSC2100.Assignment3A
{
    public class CarService : IComparable
    {

        // Unique identifier for each car service
        private int id = 0;

        // Property to get id and allow setting it (used when removing items)
        public int ID
        {
            get => id;
            set
            {
                id = value;
            }
        }

        // Fields for customer and car details
        string firstName = string.Empty;
        public string FirstName { get => firstName; }
        string lastName = string.Empty;
        public string LastName { get => lastName; }
        string phone = string.Empty;
        public string Phone { get => phone; }
        string make = string.Empty;
        public string Make { get => make; }
        string model = string.Empty;
        public string Model { get => model; }
        Int16 year = (Int16)DateTime.Now.Year;
        public Int16 Year { get => year; }
        string color = string.Empty;
        public string Color { get => color; }
        bool engOilChange = false;
        public bool EngOilChange { get => engOilChange; }
        bool transOilChange = false;
        public bool TransOilChange{ get => transOilChange; }
        bool airFilterChange = false;
        public bool AirFilterChange{ get => airFilterChange; }
        decimal price;
        public decimal Price { get => price; }
        string errMessage;
        public string ErrorMessage{ get => errMessage; }

        // Private constructor to prevent initalization without parameters 
        private CarService() {            
        }
        /// <summary>
        /// Constructor that initalizes a CarService with specific parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="color"></param>
        /// <param name="enginOil"></param>
        /// <param name="transOil"></param>
        /// <param name="airFilter"></param>
        /// <exception cref="ArgumentException"></exception>
        public CarService(string firstName, string lastName, string phone, 
                          string make, string model, Int16 year, string color, 
                          bool enginOil, bool transOil, bool airFilter) : this()
        {
            Set(firstName, lastName, phone,make,model,year,color,
                   enginOil,transOil,airFilter);
        }

        // Method to set properties of the CarService
        private void Set(string firstName, string lastName, string phone,
                          string make, string model, Int16 year, string color,
                          bool enginOil, bool transOil, bool airFilter)
        {

            // Validating input and throw an exception if invalid
            if(Validate(firstName, lastName, phone, make, model, year, color,
                          enginOil, transOil, airFilter) == false)
            {
                throw new ArgumentException(errMessage);
            }

            // Assign validated values to the fields
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone= phone;
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            this.engOilChange = enginOil;
            this.transOilChange = transOil;
            this.airFilterChange = airFilter;

            // Calculating and assigning services prices ased on selected services
            decimal _price = CalculatePrice(enginOil,transOil,airFilter);
            if (Math.Abs((double)(price - _price)) > 0.0001)
            {
                // Update price if difference
                price = _price;
            }
        }

        // Method to validate the input fields for a CarService
        private bool Validate(string firstName, string lastName, string phone,
                          string make, string model, int year, string color,
                          bool enginOil, bool transOil, bool airFilter)
        {
            // Clear error message
            errMessage = string.Empty;

            // List to collect errors, displaying specific errors for each invalid fields
            List<string> errors = new List<string>();
            if (firstName == string.Empty)
            {
                errors.Add("First Name");
            }

            if (lastName == string.Empty)
            {
                errors.Add("Last Name");
            }

            if (phone == string.Empty || !long.TryParse(phone, out _))
            {
                errors.Add("Phone Number");
            }

            if (model == string.Empty)
            {
                errors.Add("Model Number");
            }

            if (color == string.Empty)
            {
                errors.Add("Colour");
            }

            if ((enginOil || transOil || airFilter) == false)
            {
                errors.Add("Services");
            }

            if (errors.Count > 0)
            {
                // Joining all errors together
                errMessage = string.Join(", ", errors);

                // Returning false if there are validation errors
                return false;
            }

            // Returning true is no errors
            return true;
        }

        // Method to calculate price based on selected services
        public static decimal CalculatePrice(bool enginOil, bool transOil, bool airFilter)
        {
            double price = (enginOil ? CarServiceShop.Constants.EngOilChgPrice : 0) +
                        (transOil ? CarServiceShop.Constants.TransOilChgPrice : 0) +
                        (airFilter ? CarServiceShop.Constants.AirFilChgPrice : 0);
            price *= CarServiceShop.Constants.TaxRate;
            return (decimal)price;
        }

        // Method to compare two CarService objects based on id
        public int CompareTo(object? obj)
        {
            CarService carService = obj as CarService;
            if (carService == null)
                throw new ArgumentException("obj is not a CarService object.");
            return id.CompareTo(carService.id);
        }

        // Method to copy properties from another CarService object
        public void Copy(CarService source)
        {
            this.firstName = source.FirstName;
            this.lastName = source.LastName;
            this.phone = source.Phone;
            this.make = source.Make;
            this.model = source.Model;
            this.year = source.Year;
            this.color = source.Color;
            this.engOilChange = source.EngOilChange;
            this.transOilChange = source.TransOilChange;
            this.airFilterChange = source.AirFilterChange;
            price = source.Price;
        }
    }
}
