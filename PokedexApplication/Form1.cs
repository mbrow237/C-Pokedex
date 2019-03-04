using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexApplication
{
    public partial class pokedexMainWindow : Form
    {
        List<pokemonObject> listOfPokemon = null;
        SqlConnection connection = null;
        statBar sb = new statBar(0,0,0);//object to reperesent stat bar
        Graphics g;
        pokemonInfo pi = null;
        
        
        public pokedexMainWindow(List<pokemonObject> pl)
            {
            listOfPokemon = pl;
            InitializeComponent();
            foreach (var pokeName in listOfPokemon)
            {
                pokemonListComboBox.Items.Add(pokeName);
            }
        }

        public void pokemonSelection(pokemonObject si)
        {
            pokemonObject currentPokemon = si;
            pi = new pokemonInfo(currentPokemon);
            drawReset();//Reset Statbar drawings
            pokemonNameLabel.Text = currentPokemon.pokeIdentifier;
            

                    #region
                    //currentPokemon.hpStat = statsArray[0];
                    hpLabel.Text = "HP: " + currentPokemon.hpStat.ToString();//Set Up Label for HP stat
                    sb.setRect(80, (hpLabel.Location.Y), (Convert.ToInt16(currentPokemon.hpStat)));//this set up rectangle to represent the stat bar
                    drawRect(); //draw method for stat bar

                    //currentPokemon.attStat = statsArray[1];
                    attackLabel.Text = "Attack: " + currentPokemon.attStat.ToString();
                    sb.setRect(80, (attackLabel.Location.Y), Convert.ToInt16(currentPokemon.attStat));
                    drawRect();

                    //currentPokemon.defStat = statsArray[2];
                    defLabel.Text = "Def: " + currentPokemon.defStat.ToString();
                    sb.setRect(80, (defLabel.Location.Y), Convert.ToInt16(currentPokemon.defStat));
                    drawRect();

                    //currentPokemon.spatkStat = statsArray[3];
                    spattLabel.Text = "SpAtt: " + currentPokemon.spatkStat.ToString();
                    sb.setRect(80, (spattLabel.Location.Y), Convert.ToInt16(currentPokemon.spatkStat));
                    drawRect();

                    //currentPokemon.spdefStat = statsArray[4];
                    spdefLabel.Text = "SpDef: " + currentPokemon.spdefStat.ToString();
                    sb.setRect(80, (spdefLabel.Location.Y), Convert.ToInt16(currentPokemon.spdefStat));
                    drawRect();

                    //currentPokemon.spdStat = statsArray[5];
                    spdLabel.Text = "Speed: " + currentPokemon.spdStat.ToString();
                    sb.setRect(80, (spdLabel.Location.Y), Convert.ToInt16(currentPokemon.spdStat));
                    drawRect();
                    #endregion Setting up stats and draw rectangles


            pokemonTypeOneLabel.Text = currentPokemon.typeOne;
            pokemonTypeTwoLabel.Text = currentPokemon.typeTwo;
            pokemonAbilityOneLabel.Text = currentPokemon.abilityOne;
            pokemonAbilityTwoLabel.Text = currentPokemon.abilityTwo;
            pokemonAbilityThreeLabel.Text = currentPokemon.abilityThree;

            toolTip1.SetToolTip(pokemonAbilityOneLabel, pi.getPokemonAbilitiesFlavorText(pokemonAbilityOneLabel.Text));
            toolTip1.SetToolTip(pokemonAbilityTwoLabel, pi.getPokemonAbilitiesFlavorText(pokemonAbilityTwoLabel.Text));
            toolTip1.SetToolTip(pokemonAbilityThreeLabel, pi.getPokemonAbilitiesFlavorText(pokemonAbilityThreeLabel.Text));

        }


        private void drawRect()
        {

            g.FillRectangle(sb.getBrush(), sb.GetRectangle());//create stat bar when called
        }

        private void drawReset()
        {
            panel1.Refresh();
        }

        private void pokemonListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokemonObject selectedItem = (pokemonObject)pokemonListComboBox.SelectedItem;
            pokemonSelection(selectedItem);
        }

        private void pokemonNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            string test = "Test";
        }
    }
}
