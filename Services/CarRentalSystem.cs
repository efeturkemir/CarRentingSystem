using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem.Services
{
    internal class CarRentalSystem
    {
        private List<Car> cars = new List<Car>();
        private List<Rental> rentals = new List<Rental>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void ListAvailableCars()
        {
            Console.WriteLine("Available Cars:");
            foreach(var car in cars)
            {
                if (!car.IsRented)
                {
                    Console.WriteLine(car.Information());
                }
            }
        }

        public void ListRentedCars()
        {
            Console.WriteLine("Rented Cars:");
            foreach (var rental in rentals)
            {
                Console.WriteLine(rental.GetRentalInfo());
            }
        }

        public void RentCar(Car car, Customer customer, int rentalDays)
        {
            if (car.IsRented)
            {
                Console.WriteLine("This car is already rented");
            }
            Rental rental = new Rental(car, customer, rentalDays);
            rentals.Add(rental);
            car.IsRented = true;

            Console.WriteLine("Car rented succesfully:");
            Console.WriteLine(rental.GetRentalInfo());
      

        }
        public void RemoveCar(Car car)
        {
            if (cars.Contains(car))
            {
                cars.Remove(car);
                Console.WriteLine($"{car.Information()} has been removed from the system.");
            }
            else
            {
                Console.WriteLine("Car not found in the system.");
            }
        }



        public Car FindCar(string brand, string model)
        {
            foreach (var car in cars)
            {
                if (car.Brand == brand && car.Model == model)
                {
                    return car;
                }
            }
            return null;
        }

        public void EndRental(Car car)
        {
            car.IsRented = false;
        }
    }
}
