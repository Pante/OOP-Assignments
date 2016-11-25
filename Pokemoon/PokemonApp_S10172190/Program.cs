using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Matthias Ngeo (S10172190F) - IT04

namespace PokemonApp_S10172190 {
    class Program {

        static List<Pokemon> pokemonList;

        static void Main(string[] args) {
            Pokemon pokemon1 = new Pokemon("Snorlax", 1272, 166);
            Pokemon pokemon2 = new Pokemon("Exeggutor", 1908, 130);
            Pokemon pokemon3 = new Pokemon("Gyarados", 2097, 141);

            Console.WriteLine(pokemon1.name);
            pokemon1.combatPoints += 45;

            pokemonList = new List<Pokemon> { pokemon1, pokemon2, pokemon3 };

            ListPokemonStrengths(pokemonList);
        }

        static void ListPokemonStrengths(List<Pokemon> pokemons) {
            Console.WriteLine(String.Format("{0, -10} {1, 10} {2, 10} {3, 10}", "Name", "Combat Points", "Health Points", "Strength"));

            foreach (Pokemon pokemon in pokemons) {
                Console.WriteLine(pokemon.ToString());
            }

            Console.ReadLine();
        }
    }
}
