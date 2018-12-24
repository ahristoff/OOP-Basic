using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _11._Pokemon_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {                                   
            var trainers = GetTrainers();
                    
            var trainersResult = ManipulateTrainers(trainers);

            PrintTrainers(trainersResult);
        }

        private static void PrintTrainers(List<Trainer> trainers)
        {
            foreach (var x in trainers.OrderByDescending(c => c.NumberOfBadges))
            {
                Console.WriteLine(x.ToString());
            }
        }

        private static List<Trainer> ManipulateTrainers(List<Trainer> trainers)
        {
            var command = Console.ReadLine();
            while (command != "End")
            {
                var match = trainers
                    .Where(t => t.Pokemons.Any(p => p.Element == command)).ToList();

                foreach (var x in match)
                {
                    x.NumberOfBadges++;
                }

                var nonmatch = trainers
                    .Where(t => t.Pokemons.Any(p => p.Element != command)).ToList();

                foreach (var x in nonmatch)
                {
                    foreach (var y in x.Pokemons)
                    {
                        y.Health -= 10;
                    }

                    x.Pokemons = x.Pokemons.Where(p => p.Health > 0).ToList();
                }
                
                command = Console.ReadLine();
            }
            
            return trainers;
        }

        private static List<Trainer> GetTrainers()
        {
            var dictTrainer = new Dictionary<string, List<Pokemon>>();
            var trainers = new List<Trainer>();

            var command = Console.ReadLine();

            while (command != "Tournament")
            {
                var com = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var trainerName = com[0];
                var pokemonName = com[1];
                var pokemonElement = com[2];
                var pokemonHealth = int.Parse(com[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!dictTrainer.ContainsKey(trainerName))
                {
                    dictTrainer[trainerName] = new List<Pokemon>();
                }

                dictTrainer[trainerName].Add(pokemon);

                command = Console.ReadLine();
            }

            foreach (var x in dictTrainer)
            {              
                var trainer = new Trainer(x.Key, x.Value);
                trainers.Add(trainer);
            }
            
            return trainers;
        }
    }
}
