
public class PressureProvider:Provider
{
    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        EnergyOutput = EnergyOutput * 1.5;
    }
}

