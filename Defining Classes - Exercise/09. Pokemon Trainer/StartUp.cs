using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputInfo = input.Split();
                string trainerName = inputInfo[0];
                string pokemonName = inputInfo[1];
                string pokemonElement = inputInfo[2];
                int pokemonHealth = int.Parse(inputInfo[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                trainers[trainerName].Pokemons.Add(pokemon);

            }

            string element = string.Empty;

            while ((element = Console.ReadLine()) != "End")
            {
                foreach (var (name, trainer) in trainers)
                {
                    if (trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                    trainer.Pokemons = trainer.Pokemons.Where(x => x.Health > 0).ToList();
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
