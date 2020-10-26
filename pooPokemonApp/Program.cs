using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            pokedex.ListarPokemons();
            Console.ReadKey();
        }
    }
}
