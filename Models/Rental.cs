using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentingSystem
{
    internal class Rental
    {
        public Car RentedCar { get; set; }
        public Customer Renter { get; set; }   
        public int RentalDays { get; set; }

        public Rental(Car rentedCar, Customer renter, int rentalDays)
        {
            RentedCar = rentedCar;
            Renter = renter;
            RentalDays = rentalDays;
        }

        public decimal CalculateTotalCost()
        {
            return RentedCar.Price * RentalDays;
        }

        public string GetRentalInfo()
        {
            return $"{Renter.GetCustomerInfo()} rented {RentedCar.Information()} for {RentalDays} days. Total cost: ${CalculateTotalCost()}";
        }
    }
}
