using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public int CurrentFuelPercentage { get; set; }
        public double RefuelTank { get; set; }

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