using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexApplication
{
    internal class ListOfPokemon
    {
        
        List<pokemonObject> po = new List<pokemonObject>();
        SqlConnection connection = null;
        public ListOfPokemon()
        {
            try {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "MSI\\MSSQLSERVER01";  
                builder.UserID = "pokeuser";              
                builder.Password = "password";      
                builder.InitialCatalog = "PokemonDatabase";


                using (connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();


                    SqlDataReader sdr = null;                   
                    string sqlText = "SELECT species_id , identifier, id FROM [pokemon].[pokemon] Order By[species_id], id;";
                    SqlCommand cmd = new SqlCommand(sqlText, connection);
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                       
                        po.Add(new pokemonObject { pokeID = sdr.GetDouble(2), pokeSpecies = sdr.GetDouble(0), pokeIdentifier = sdr.GetString(1) });
                        
                    }
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
         }

        public List<pokemonObject> getListOfPokemon()
        {
            return po;
        }
    }
}