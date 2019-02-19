using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexApplication
{
    public partial class pokedexMainWindow : Form
    {
        List<String> listOfPokemon = null;
        public pokedexMainWindow(List<String> l)
        {
            listOfPokemon = l;
            InitializeComponent();
            foreach (var pokeName in listOfPokemon)
            {
                pokemonListComboBox.Items.Add(pokeName);
            }
        }
        private void pokemonListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
