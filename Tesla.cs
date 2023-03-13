using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public int CurrentChargePercentage { get; set; }
        public double BatteryKWh { get; set; }
        public override void Drive()
        {
            Console.WriteLine("The Burgundy Tesla blazes by you. Mmmmmmmmmm!");
        }

        public override void Turn()
        {
            Console.WriteLine("The Burgundy Tesla squeal around a right turn");
        }

        public override void Stop()
        {
            Console.WriteLine("The Burgundy Tesla silently stops as if it never moved\n");
        }
    }
}