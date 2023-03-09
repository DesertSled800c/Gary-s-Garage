using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The Burgandy Tesla blazes by you. Mmmmmmmmmm!");
        }

        public override void Turn()
        {
            Console.WriteLine("The Burgandy Tesla squeal around a right turn");
        }

        public override void Stop()
        {
            Console.WriteLine("The Burgandy Tesla silently stops as if it never moved\n");
        }
    }
}