using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public int CurrentFuelPercentage { get; set; }
        public double RefuelTank { get; set; }

        public override void Drive()
        {
            Console.WriteLine("The Silver Ram growls by you. Rrrruuummmbbbble!");
        }

    }
}