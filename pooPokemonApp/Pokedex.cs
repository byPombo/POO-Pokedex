using System;
using System.Collections.Generic;
using System.Text;

namespace pooPokemonApp
{
    public class Pokedex
    {
		public Pokedex()
		{
			this.InicializaLista();
		}
		private List<PokemonPlus> pokemons;

		public List<PokemonPlus> Pokemons
		{
			get { return pokemons; }
		}

		private void InicializaLista()
		{
			// Instanciar a lista
			this.pokemons = new List<PokemonPlus>();
			PokemonPlus p = new PokemonPlus("Bulbasauro", "pokémon tipo planta", 300);
			this.pokemons.Add(p);
			p = new PokemonPlus("Mew", "lendário psiquico", 130);
			this.pokemons.Add(p);
			p = new PokemonPlus("Mewtwo", "lendário psiquico", 400);
			this.pokemons.Add(p);
			p = new PokemonPlus("Giratina", "lendário fantasma", 420);
			this.pokemons.Add(p);
			p = new PokemonPlus("Flygon", "pokémon dragão", 340);
			this.pokemons.Add(p);
			p = new PokemonPlus("Metagross", "pokémon tipo metal", 120);
			this.pokemons.Add(p);
			p = new PokemonPlus("Metagross", "pokémon tipo toxico", 76);
			this.pokemons.Add(p);
			p = new PokemonPlus("Metagross", "pokémon tipo terra", 128);
			this.pokemons.Add(p);
			p = new PokemonPlus("Muk", "pokémon tipo metal", 85);
			this.pokemons.Add(p);
			p = new PokemonPlus("Kyogre", "lendário tipo água", 89);
			this.pokemons.Add(p);
		}

		public void ListarPokemons()
		{
			for (int i = 0; i < this.Pokemons.Count; i++)
			{
				Console.WriteLine("Código do pokémon" + i);
				this.Pokemons[i].ExibirDadosPokemon();
			}
		}
	}
}
