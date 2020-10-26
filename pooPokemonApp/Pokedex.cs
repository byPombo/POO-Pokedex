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
		private List<Pokemon> pokemons;

		public List<Pokemon> Pokemons
		{
			get { return pokemons; }
		}

		private void InicializaLista()
		{
			// Instanciar a lista
			this.pokemons = new List<Pokemon>();
			Pokemon p = new Pokemon("Bulbasauro", "pokémon tipo planta");
			this.pokemons.Add(p);
			p = new Pokemon("Mew", "lendário psiquico");
			this.pokemons.Add(p);
			p = new Pokemon("Mewtwo", "lendário psiquico");
			this.pokemons.Add(p);
			p = new Pokemon("Giratina", "lendário fantasma");
			this.pokemons.Add(p);
			p = new Pokemon("Flygon", "pokémon dragão");
			this.pokemons.Add(p);
			p = new Pokemon("Metagross", "pokémon tipo metal");
			this.pokemons.Add(p);
			p = new Pokemon("Metagross", "pokémon tipo toxico");
			this.pokemons.Add(p);
			p = new Pokemon("Metagross", "pokémon tipo terra");
			this.pokemons.Add(p);
			p = new Pokemon("Muk", "pokémon tipo metal");
			this.pokemons.Add(p);
			p = new Pokemon("Kyogre", "lendário tipo água");
			this.pokemons.Add(p);
		}
	}
}
