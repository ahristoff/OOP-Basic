using System;

public class SonicHarvester: Harvester
{
    private int sonicFactor ;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement)
    {
        SonicFactor = sonicFactor;
        EnergyRequirement = EnergyRequirement / SonicFactor;
    }

    public int SonicFactor
    {
        get { return this.sonicFactor; }
        set
        {
            if (value <= 0 || value > 10)
            {
                throw new ArgumentException("Harvester is not registered, because of it's SonicFactor");
            }

            this.sonicFactor = value;
        }
    }
}

