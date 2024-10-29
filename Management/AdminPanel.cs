using CarRentingSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Management
{
    internal class AdminPanel
    {
        private CarRentalSystem carRentalSystem;

        public AdminPanel(CarRentalSystem system)
        {
            carRentalSystem = system;
        }

        public void ShowAdminMenu()
        {
            bool isAdminRunning = true;

            
            while (isAdminRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Admin Menu ===");
                Console.WriteLine("1. Add New Car");
                Console.WriteLine("2. Remove a Car");
                Console.WriteLine("3. List All Cars");
                Console.WriteLine("4. Return to Main Menu");
                Console.Write("Please select an option (1-4): ");

                string adminChoice = Console.ReadLine();

                switch (adminChoice)
                {
                    case "1":
                        AddNewCar();
                        break;
                    case "2":
                        RemoveCarMenu();
                        break;
                    case "3":
                        carRentalSystem.ListAvailableCars();
                        break;
                    case "4":
                        isAdminRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        private void AddNewCar()
        {
            Console.Clear();
            Console.WriteLine("Enter car details:");

            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Daily Rent Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            carRentalSystem.AddCar(new Car(brand, model, year, price));
            Console.WriteLine("Car added successfully.");

        }


        private void RemoveCarMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter the brand and model of the car you want to remove:");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();

            Car car = carRentalSystem.FindCar(brand, model);
            if (car != null)
            {
                carRentalSystem.RemoveCar(car);
            }
            else
            {
                Console.WriteLine("Car not found in the system.");
            }
        }
    }
}
