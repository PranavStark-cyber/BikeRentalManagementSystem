using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    public class Bike
    {
      public  int BikeId { get; set; }
      public  string Brand {  get; set; }
        public string Model {  get; set; }
        public decimal RentalPrice {  get; set; }


        public static int Totalbikes { get; private set; } = 0;

      public Bike(int bikeId, string brand, string model, decimal rentalprice)
            {
            BikeId = bikeId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalprice;
            Totalbikes++;
       }


        public virtual string ToString()
        {
            return $"ID: {BikeId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice}";
        }




    }


    public class ElectricBike : Bike
    {
        public decimal BatteryCapacity { get; set; }
        public int MotorPower { get; set; }

        public ElectricBike(int bikeId, string brand, string model, decimal rentalprice, decimal batteryCapacity, int motorPower) : base(bikeId, brand, model, rentalprice)
        {
            BatteryCapacity = batteryCapacity;
            MotorPower = motorPower;
        }

        public override string ToString()
        {
            return base.ToString() + $", Battery Capacity: {BatteryCapacity} kWh, Motor Power: {MotorPower} W";
        }
    }

    public class PetrolBike : Bike
    {
        public decimal FuelTankCapacity { get; set; }
        public int EngineCapacity { get; set; }


        public PetrolBike(int bikeId, string brand, string model, decimal rentalPrice, decimal fuelTankCapacity, int engineCapacity)
            : base(bikeId, brand, model, rentalPrice)
        {
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
        }


        public override string ToString()
        {
            return base.ToString() + $", Fuel Tank Capacity: {FuelTankCapacity} L, Engine Capacity: {EngineCapacity} cc";
        }

    }



}
