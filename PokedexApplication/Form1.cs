﻿using System;
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

        public pokedexMainWindow(List<pokemonObject> pl)
            {
            listOfPokemon = pl;
            InitializeComponent();
            foreach (var pokeName in listOfPokemon)
            {
                //pokemonListComboBox.Items.Add(pokeName.ToString());
                pokemonListComboBox.Items.Add(pokeName);
            }
        }

        public void pokemonSelection(pokemonObject si)
        {
            pokemonObject currentPokemon = si;
            Double[] statsArray = new Double[6];

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

                    currentPokemon.hpStat = statsArray[0];
                    hpLabel.Text = currentPokemon.hpStat.ToString();
                    currentPokemon.attStat = statsArray[1];
                    attackLabel.Text = currentPokemon.attStat.ToString();
                    currentPokemon.defStat = statsArray[2];
                    defLabel.Text = currentPokemon.defStat.ToString();
                    currentPokemon.spatkStat = statsArray[3];
                    spattLabel.Text = currentPokemon.spatkStat.ToString();
                    currentPokemon.spdefStat = statsArray[4];
                    spdefLabel.Text = currentPokemon.spdefStat.ToString();
                    currentPokemon.spdStat = statsArray[5];
                    spdLabel.Text = currentPokemon.spdStat.ToString();
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
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

        }
    }
}
