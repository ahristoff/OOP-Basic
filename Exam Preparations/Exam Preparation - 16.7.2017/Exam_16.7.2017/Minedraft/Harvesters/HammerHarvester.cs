﻿
public class HammerHarvester: Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
         : base(id, oreOutput, energyRequirement)
    {
        OreOutput = 3 * OreOutput;
        EnergyRequirement = 2 * EnergyRequirement;
    }
}

