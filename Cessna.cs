using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The White Cessna flashes by you like a hurricane. Zzzzoooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine("The White Cessna rolls down the runway for a mile and stops.\n");
        }
    }
}