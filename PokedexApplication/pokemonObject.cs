﻿/*This will be the pokemon object. 
 * This class represent each indiviual pokemon
 */ 
namespace PokedexApplication
{
    public class pokemonObject
    {
        public string pokeIdentifier { get; set; }
        public double pokeID { get; set; }
        public double pokeSpecies { get; set; }
        public double hpStat { get; set; }
        public double attStat { get; set; }
        public double defStat { get; set; }
        public double spatkStat { get; set; }
        public double spdefStat { get; set; }
        public double spdStat { get; set; }

        public pokemonObject()
        {
            pokeIdentifier = "MissingNo";
        }

        public override string ToString()//To string provide the number and the pokemon name(Combobox)
        {
            return "#" + pokeSpecies + " " + pokeIdentifier;
        }
    }
 }