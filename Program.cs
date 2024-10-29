using CarRentingSystem.Management;
using CarRentingSystem.Services;
using System;

namespace CarRentingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRentalSystem carRentalSystem = new CarRentalSystem();
            AdminPanel adminPanel = new AdminPanel(carRentalSystem);

            carRentalSystem.AddCar(new Car("Toyota", "Corolla", 2020, 300));
            carRentalSystem.AddCar(new Car("Honda", "Civic", 2019, 280));
            carRentalSystem.AddCar(new Car("Ford", "Focus", 2018, 250));

            bool isRunning = true;



            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Car Rental System ===");
                Console.WriteLine("1. List Available Cars");
                Console.WriteLine("2. Rent a Car");
                Console.WriteLine("3. End Rental");
                Console.WriteLine("4. List Rented Cars");
                Console.WriteLine("5. Admin Menu");
                Console.WriteLine("6. Exit");
                Console.Write("Please select an option (1-6): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        carRentalSystem.ListAvailableCars();
                        break;
                    case "2":
                        RentCarMenu(carRentalSystem);
                        break;
                    case "3":
                        EndRentalMenu(carRentalSystem);
                        break;
                    case "4":
                        carRentalSystem.ListRentedCars();
                        break;
                    case "5":
                        adminPanel.ShowAdminMenu();
                        break;
                    case "6":
                        isRunning = false;
                        Console.WriteLine("Exiting the system. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void RentCarMenu(CarRentalSystem carRentalSystem)
        {
            Console.Clear();
            Console.WriteLine("Enter the brand and model of the car you want to rent:");
            carRentalSystem.ListAvailableCars();

            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Rental Days: ");
            int days = int.Parse(Console.ReadLine());

            Car car = carRentalSystem.FindCar(brand, model);
            if (car != null && !car.IsRented)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your ID: ");
                string id = Console.ReadLine();

                Customer customer = new Customer(name, id);
                carRentalSystem.RentCar(car, customer, days);
            }
            else
            {
                Console.WriteLine("The car is either rented or not found.");
            }
        }

        static void EndRentalMenu(CarRentalSystem carRentalSystem)
        {
            Console.Clear();
            Console.WriteLine("Enter the brand and model of the car you want to return:");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();

            Car car = carRentalSystem.FindCar(brand, model);
            if (car != null && car.IsRented)
            {
                carRentalSystem.EndRental(car);
                Console.WriteLine("The rental has been successfully ended.");
            }
            else
            {
                Console.WriteLine("The car is either not rented or not found.");
            }
        }
    }
}
