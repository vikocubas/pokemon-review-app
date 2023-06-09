﻿using PokemonReviewApp.Models;

//Adicionando as Interfaces
namespace PokemonReviewApp.Interfaces
{
    
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);
        //Criando interface para o método post
        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        //Criando interface para o método update
        bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);
        //Criando interface para o método delete
        bool DeletePokemon(Pokemon pokemon);
        bool Save();
    }
}
