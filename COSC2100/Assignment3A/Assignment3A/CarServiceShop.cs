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
    internal class CarServiceShop
    {
        public static class Constants
        {
            // Constants for pricing calculations
            public const double TaxRate = 0.13;
            public const int MaxCarYear = 20;
            public const double EngOilChgPrice = 60.0;
            public const double TransOilChgPrice = 120.0;
            public const double AirFilChgPrice = 40.5;
        }

        // Static to keep track of sequence number for services
        static private int sequence = 1;

        // List to hold car services 
        private List<CarService> carServices = new List<CarService>();

        // Arrary of cars for user to select
        string[] carMaker = { "Toyota", "GMC", "Honda","Ford", "Dodge", "Tesla", "BMW", "Audi","Jeep" };

        // Constructor for CarServiceShop
        public CarServiceShop()
        {
        }

        // Properties to get available car makers and services
        public IEnumerable<string> CarMaker
        {
            get { return carMaker; }
        }
        public IEnumerable<CarService> CarServices
        {
            get { return carServices; }
        }

        // Method to add new car service
        public void AddService(CarService carService)
        {
            if (carService != null)
            {
                carService.ID = sequence++; 
                carServices.Add(carService); 
            }
        }

        // Method to update existing car service
        public void UpdateService(int id, CarService carService)
        {
            CarService existingService = GetService(id);

            // If exists, copy it
            if (existingService != null)
            {
                existingService.Copy(carService);
            }

            // Throw error if does not exist
            else
            {
                throw new ArgumentException("Service not found for the given ID.");
            }
        }

        // Method to retrieve car service by id
        public CarService? GetService(int id)
        {
            return carServices.Where(item => item.ID == id).FirstOrDefault();
        }

        // Method to remove service
        public int RemoveService(int id)
        {
            CarService serviceToRemove = GetService(id);

            // If empty, throw error message
            if (serviceToRemove == null)
            {
                throw new ArgumentException("Service not found.");
            }


            // Remove the service
            carServices.Remove(serviceToRemove);


            // Loop through and re-order id to reflect the removal of items
            for (int i = 0; i < carServices.Count; i++)
            {
                carServices[i].ID = i + 1;
            }

            // Return new id
            return id;
        }

        // Method that clears all fields
        public void ClearAll()
        {
            carServices.Clear();
        }

    }
}
