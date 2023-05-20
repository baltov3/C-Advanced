using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
     public class Car
    {
         private string make;
         private string model;
        private int year;
        private double fuelConsumption;
        private double fuelQuantity;
        public int Year  { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
      public void Drive(double distance)
        {
           fuelQuantity = fuelQuantity-distance;
            if (fuelQuantity < 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
       public string WhoAmI()
        {
            return $"Make: {this.Make} " +
                $"Model: {this.Model}" +
                $"Year: {this.Year}" +
                $"Fuel: {this.FuelQuantity:F2}";
        }
    }
}
