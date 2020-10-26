using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            Pokemon p = pokedex.Pokemons[1];
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
