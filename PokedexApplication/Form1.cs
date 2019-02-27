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
            Double[] statsArray = new Double[6];
            drawReset();//Reset Statbar drawings

            pokemonNameLabel.Text = currentPokemon.pokeIdentifier;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "MSI\\MSSQLSERVER01";   // update me
                builder.UserID = "pokeuser";              // update me
                builder.Password = "password";      // update me
                builder.InitialCatalog = "PokemonDatabase";


                using (connection = new SqlConnection(builder.ConnectionString))
                {
                    int pokeIDInt = Convert.ToInt32(currentPokemon.pokeID);
                    connection.Open();
                    SqlDataReader sdr = null;
                    string sqlText = "pokemon.pr_vSelectPokemonByID_StatsOnly";
                    SqlCommand cmd = new SqlCommand(sqlText, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", pokeIDInt);
                    sdr = cmd.ExecuteReader();
                    int counter = 0;
                    while (sdr.Read())
                    {
                        statsArray[counter] = sdr.GetDouble(0);
                        counter++;
                    }

                    #region
                    currentPokemon.hpStat = statsArray[0];
                    hpLabel.Text = "HP: " + currentPokemon.hpStat.ToString();//Set Up Label for HP stat
                    sb.setRect(80, (hpLabel.Location.Y), (Convert.ToInt16(statsArray[0])));//this set up rectangle to represent the stat bar
                    drawRect(); //draw method for stat bar

                    currentPokemon.attStat = statsArray[1];
                    attackLabel.Text = "Attack: " + currentPokemon.attStat.ToString();
                    sb.setRect(80, (attackLabel.Location.Y), Convert.ToInt16(statsArray[1]));
                    drawRect();

                    currentPokemon.defStat = statsArray[2];
                    defLabel.Text = "Def: " + currentPokemon.defStat.ToString();
                    sb.setRect(80, (defLabel.Location.Y), Convert.ToInt16(statsArray[2]));
                    drawRect();

                    currentPokemon.spatkStat = statsArray[3];
                    spattLabel.Text = "SpAtt: " + currentPokemon.spatkStat.ToString();
                    sb.setRect(80, (spattLabel.Location.Y), Convert.ToInt16(statsArray[3]));
                    drawRect();

                    currentPokemon.spdefStat = statsArray[4];
                    spdefLabel.Text = "SpDef: " + currentPokemon.spdefStat.ToString();
                    sb.setRect(80, (spdefLabel.Location.Y), Convert.ToInt16(statsArray[4]));
                    drawRect();

                    currentPokemon.spdStat = statsArray[5];
                    spdLabel.Text = "Speed: " + currentPokemon.spdStat.ToString();
                    sb.setRect(80, (spdLabel.Location.Y), Convert.ToInt16(statsArray[5]));
                    drawRect();
                    #endregion Setting up stats and draw rectangles
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            pokemonTypeOneLabel.Text = currentPokemon.typeOne;
            pokemonTypeTwoLabel.Text = currentPokemon.typeTwo;

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
    }
}
