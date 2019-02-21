using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //List<String> pokeList = new List<string>();
            //pokeList = lop.getListOfPokemon();

            ListOfPokemon lop = new ListOfPokemon();
            List<pokemonObject> po = new List<pokemonObject>();
            po = lop.getListOfPokemon();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pokedexMainWindow(po)); //Create Window, and add list of pokemon names, since it's the first thing loaded with the window.

            
        }
    }
}
