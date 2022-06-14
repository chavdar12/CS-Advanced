namespace _005;

public static class PokemonTrainer
{
    private static void Main(string[] args)
    {
        string input;
        var pokemonTrainers = new List<Trainer>();
        while ((input = Console.ReadLine()) != "Tournament")
        {
            var caughtPokemon = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var trainerName = caughtPokemon[0];
            var pokemonName = caughtPokemon[1];
            var pokemonElement = caughtPokemon[2];
            var pokemonHealth = int.Parse(caughtPokemon[3]);
            var currentTrainer = new Trainer(trainerName);
            var currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            if (!pokemonTrainers.Exists(t => t.Name == trainerName)) pokemonTrainers.Add(currentTrainer);
            pokemonTrainers.First(t => t.Name == trainerName).Pokemons.Add(currentPokemon);
        }

        while ((input = Console.ReadLine()) != "End")
            foreach (var trainer in pokemonTrainers)
                if (trainer.Pokemons.Any(p => p.Element == input))
                {
                    trainer.Badges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(p => p.Health -= 10);
                    trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                }

        Console.WriteLine(string.Join(Environment.NewLine, pokemonTrainers.OrderByDescending(t => t.Badges)));
    }
}