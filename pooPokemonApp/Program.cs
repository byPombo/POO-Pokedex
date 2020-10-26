using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon("Bulbasauro", "Bulbasauro é um pokemon tipo planda...");
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
