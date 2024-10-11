using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    public class BikeManager
    {
        private List<Bike> bikeList = new List<Bike>();

        public void CreateBike(Bike bike)
        {
            bikeList.Add(bike);
            Console.WriteLine("Successfully Addded");
        }

        public void ReadBikes()
        {
            if (bikeList.Count == 0)
            {
                Console.WriteLine("No bikes available");
            }

            Console.WriteLine("List of bikes");
            foreach (Bike bike in bikeList)
            {
                Console.WriteLine(bike);
            }
        }

        public void UpdateBike(int bikeid)
        {
            var Bikeid = bikeList.FirstOrDefault(b => b.BikeId == bikeid);

            if (Bikeid != null)
            {
                Console.WriteLine("Write the New Brand");
                string newbrand = Console.ReadLine();
                Console.WriteLine("Write the New model");
                string newmodel = Console.ReadLine();
                Console.WriteLine("Write the New price");
                decimal newrentalprice = decimal.Parse(Console.ReadLine());

                Console.WriteLine("update Successfully");
                return;

            }
            Console.WriteLine("bike not found");
        }


        public void DeleteBike(int bikeid)
        {
            var Bikeid = bikeList.FirstOrDefault(b => b.BikeId == bikeid);
            if (Bikeid != null)
            {
                bikeList.Remove(Bikeid);
                Console.WriteLine("Successfully deleted");
                return;
            }
            Console.WriteLine("Bike not found");

        }

        public decimal ValidateBikeRentalPrice()
        {
            decimal rentalprice;
            while (true)
            {
                Console.WriteLine("Enter the rental price");
                if (decimal.TryParse(Console.ReadLine(), out rentalprice) && rentalprice > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invaild number enter the positive number");
                }

               
            }
            return rentalprice;
        }
    }
}
