using System;

namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();
            int resp = 100;
            while (resp != 0)
            {
                resp = menu();
                if (resp == 1)
                {
                    pokedex.ListarPokemons();
                }
                if(resp ==2)
                {
                    pokedex.ListarPokemons();
                    Console.WriteLine("Digite o código do pokémon: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());
                    //Pegar o pokemon do player
                    PokemonPlus pPlayer = pokedex.Pokemons[codigo];
                    //Definir o Pokemon do PC
                    Random r = new Random();
                    codigo = r.Next(0, pokedex.Pokemons.Count);
                    PokemonPlus pPC = pokedex.Pokemons[codigo];
                    //batalhar
                    if(pPlayer.Poder >= pPC.Poder)
                    {
                        Console.WriteLine("Parabéns!!!! Você ganhou");
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static int menu()
        {
            Console.WriteLine("Pokémon - Batalha");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Listar todos os Pokémons da pokédex");
            Console.WriteLine("2 - Batalhar");
            Console.WriteLine("Opção: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
