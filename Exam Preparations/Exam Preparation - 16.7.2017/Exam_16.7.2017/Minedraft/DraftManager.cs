using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private List<Harvester> harvers;
    private List<Provider> providers;

    public DraftManager()
    {
        harvers = new List<Harvester>();
        providers = new List<Provider>();
        this.mode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        //RegisterHarvester {type} {id} {oreOutput} {energyRequirement}
        //RegisterHarvester Sonic {id} {oreOutput} {energyRequirement} {sonicFactor}

        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = Double.Parse(arguments[2]);
        var energyRequirement = Double.Parse(arguments[3]);

        try
        {

            if (type == "Sonic")
            {
                var sonicFactor = int.Parse(arguments[4]);
                Harvester sonic = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                harvers.Add(sonic);

                return $"Successfully registered {type} Harvester - {id}";
            }

            else if (type == "Hammer")
            {
                Harvester hammer = new HammerHarvester(id, oreOutput, energyRequirement);
                harvers.Add(hammer);

                return $"Successfully registered {type} Harvester - {id}";
            }

            else
            {
                return $"Harvester is not registered, because of it's Type";
            }
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        //RegisterProvider {type} {id} {energyOutput}

        var type = arguments[0];
        var id = arguments[1];

        try
        {
            var energyOutput = Double.Parse(arguments[2]);

            if (type == "Solar")
            {
                Provider provider = new SolarProvider(id, energyOutput);
                providers.Add(provider);

                return $"Successfully registered {type} Provider - {id}";
            }

            else if (type == "Pressure")
            {
                Provider provider = new PressureProvider(id, energyOutput);
                providers.Add(provider);

                return $"Successfully registered {type} Provider - {id}";
            }

            else
            {
                return "Provider is not registered, because of it's Type";
            }
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    public string Day()
    {
        double summedOre = 0;
        double requiredsummedEnergy = 0;
        double provideSummedEnergy = providers.Sum(p => p.EnergyOutput);

        totalStoredEnergy += provideSummedEnergy;

        if (this.mode == "Half")
        {
            requiredsummedEnergy = harvers.Sum(h => h.EnergyRequirement) * 0.6;

            if (requiredsummedEnergy <= totalStoredEnergy)
            {
                summedOre = harvers.Sum(h => h.OreOutput) * 0.5;
            }
        }

        else if (this.mode == "Energy")
        {
            requiredsummedEnergy = harvers.Sum(h => h.EnergyRequirement) * 0.0;

            if (requiredsummedEnergy <= totalStoredEnergy)
            {
                summedOre = harvers.Sum(h => h.OreOutput) * 0.0;
            }
        }

        else if (this.mode == "Full")
        {
            requiredsummedEnergy = harvers.Sum(h => h.EnergyRequirement) * 1.0;

            if (requiredsummedEnergy <= totalStoredEnergy)
            {
                summedOre = harvers.Sum(h => h.OreOutput) * 1.0;
            }
        }

        if (requiredsummedEnergy <= totalStoredEnergy)
        {
            totalMinedOre += summedOre;
            totalStoredEnergy -= requiredsummedEnergy;
        }

        var sb = new StringBuilder();

        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {provideSummedEnergy}");
        sb.AppendLine($"Plumbus Ore Mined: {summedOre}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        var type = arguments[0];

        if (type == "Full" || type == "Half" || type == "Energy")
        {
            this.mode = type;
        }

        return $"Successfully changed working mode to {this.mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        if (harvers.Any(h => h.Id == id))
        {
            var haver = harvers.FirstOrDefault(h => h.Id == id);

            var sb = new StringBuilder();

            sb.AppendLine($"{haver.GetType().Name} Harvester - {haver.Id}");
            sb.AppendLine($"Ore Output: {haver.OreOutput}");
            sb.AppendLine($"Energy Requirement: {haver.EnergyRequirement}");

            return sb.ToString().Trim();
        }

        else if (providers.Any(h => h.Id == id))
        {
            var provider = providers.FirstOrDefault(h => h.Id == id);

            var sb = new StringBuilder();
            sb.AppendLine($"{provider.GetType().Name} Provider - {provider.Id}");
            sb.AppendLine($"Energy Output: {provider.EnergyOutput}");

            return sb.ToString().Trim();
        }

        else
        {
            return $"No element found with id - {id}";
        }
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();

        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

        return sb.ToString().Trim();
    }
}

