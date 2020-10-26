using System;
using System.Collections.Generic;
using System.Text;

namespace pooPokemonApp
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        public Pokemon(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        private string nome;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                string texto = value;
                nome = texto;
            }
        }

        private string descricao; //Armazena o valor da propriedade Descrição

        public string Descricao // Representa a característica Descrição do Pokemon
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokémon: " + this.Nome);
            Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
        }
        public void ExibirDadosPokemon(bool formatado)
        {
            if(formatado == true)
            {
                Console.WriteLine($"Pokémon: {this.Nome}: {this.Descricao}");
            }
            else
            {
                Console.WriteLine("Nome do Pokémon: " + this.Nome);
                Console.WriteLine("Descrição do Pokémon: " + this.Descricao);
            }
        }
    }
}
