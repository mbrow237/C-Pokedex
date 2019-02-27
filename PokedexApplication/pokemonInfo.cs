using System;
using System.Data;
using System.Data.SqlClient;

namespace PokedexApplication
{
    internal class pokemonInfo
    {
        SqlConnection connection = null;
        public pokemonInfo(pokemonObject poke)
        {
            int pokeIDInt = Convert.ToInt32(poke.pokeID);
            setPokemonType(pokeIDInt, poke);
        }



        public void setPokemonType(int pID, pokemonObject poke)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "MSI\\MSSQLSERVER01";   // update me
                builder.UserID = "pokeuser";              // update me
                builder.Password = "password";      // update me
                builder.InitialCatalog = "PokemonDatabase";


                using (connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    SqlDataReader sdr = null;
                    string sqlText = "pokemon.pr_vSelectPokemonByID_TypesOnly";
                    SqlCommand cmd = new SqlCommand(sqlText, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", pID);
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        poke.typeOne = sdr.GetString(0);
                    }

                    if (sdr.Read())
                    {
                        poke.typeTwo = sdr.GetString(0);
                    }
                    else
                    {
                        poke.typeTwo = "-";
                    }                 
                }
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}