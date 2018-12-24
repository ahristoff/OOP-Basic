using System;
using System.Collections.Generic;

public class HarvesterFactory
{

    public Harvester CreateHarvester(List<string> args)
    {
        var type = args[0];
        var id = args[1];
        var oreOutput = Double.Parse(args[2]);
        var energyRequirement = Double.Parse(args[3]);

        switch (type)
        {
            case "Hammer":
                return new HammerHarvester(id, oreOutput, energyRequirement);

            case "Sonic":
                var sonic = int.Parse(args[4]);
                return new SonicHarvester(id, oreOutput, energyRequirement, sonic);

            default:
                throw new ArgumentException("Harvester is not registered, because of it's Type");
        }   
    }
}

