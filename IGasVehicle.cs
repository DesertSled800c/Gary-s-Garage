public interface IGasVehicle {

    int CurrentFuelPercentage { get; set; }

    void RefuelTank()
    {
        CurrentFuelPercentage = 100;
    }

}