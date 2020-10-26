using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();
            p.Nome = "Bulbasauro";
            p.Descricao = ("Bulbasauro é um pokemon tipo planda...");
            p.ExibirDadosPokemon();
            Console.ReadKey();
        }
    }
}
