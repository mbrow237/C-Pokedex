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
            
            ListOfPokemon lop = new ListOfPokemon();
            List<String> pokeList = new List<string>();
            pokeList = lop.getListOfPokemon();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pokedexMainWindow(pokeList)); //Create Window, and add list of pokemon names, since it's the first thing loaded with the window.

            
        }
    }
}
