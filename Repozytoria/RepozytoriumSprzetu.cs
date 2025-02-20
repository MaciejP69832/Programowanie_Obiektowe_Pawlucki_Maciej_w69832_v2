using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaSprzetuNarciarskiego.Modele;

namespace WypozyczalniaSprzetuNarciarskiego.Repozytoria
{
    public class RepozytoriumSprzetu
    {

        public class RepozytoriumSprzetuNarciarskiego
        {
            private readonly string connectionString = "Data Source=HP-Langzzey\\SQLEXPRESS;Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True;Trust Server Certificate=True";

            public List<SprzetNarciarski> PobierzSprzetyN()
            {
                var sprzetn = new List<SprzetNarciarski>();
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM SprzetNarciarski";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    SprzetNarciarski sprzetNarciarski = new SprzetNarciarski();
                                    sprzetNarciarski.nr_sprzetN = reader.GetInt32(0);
                                    sprzetNarciarski.producent = reader.GetString(1);
                                    sprzetNarciarski.typ = reader.GetString(2);
                                    sprzetNarciarski.numer_inw = reader.GetString(3);
                                    sprzetNarciarski.dlugosc_nart = reader["dlugosc_nart"] == DBNull.Value ? 0 : Convert.ToInt32(reader["dlugosc_nart"]);
                                    sprzetNarciarski.twardosc_nart = reader["twardosc_nart"] == DBNull.Value ? 0 : Convert.ToInt32(reader["twardosc_nart"]);
                                    sprzetNarciarski.rozmiar_buta = reader["rozmiar_buta"] == DBNull.Value ? 0 : Convert.ToInt32(reader["rozmiar_buta"]);
                                    sprzetNarciarski.twardosc_buta = reader["twardosc_buta"] == DBNull.Value ? 0 : Convert.ToInt32(reader["twardosc_buta"]);
                                    sprzetNarciarski.dlugosc_kijkow = reader["dlugosc_kijkow"] == DBNull.Value ? 0 : Convert.ToInt32(reader["dlugosc_kijkow"]);
                                    sprzetNarciarski.koszt_wypozyczenia = reader.IsDBNull(reader.GetOrdinal("koszt_wypozyczenia"))
                                        ? 0.00m : reader.GetDecimal(reader.GetOrdinal("koszt_wypozyczenia"));
                                    sprzetn.Add(sprzetNarciarski);

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
                return sprzetn;
            }
            public SprzetNarciarski? PobierzSprzetN(int nr_sprzetN)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM SprzetNarciarski WHERE nr_sprzetN = @nr_sprzetN";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nr_sprzetN", nr_sprzetN);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    SprzetNarciarski sprzetNarciarski = new SprzetNarciarski();
                                    sprzetNarciarski.nr_sprzetN = reader.GetInt32(0);
                                    sprzetNarciarski.producent = reader.GetString(1);
                                    sprzetNarciarski.typ = reader.GetString(2);
                                    sprzetNarciarski.numer_inw = reader.GetString(3);
                                    sprzetNarciarski.dlugosc_nart = reader["dlugosc_nart"] == DBNull.Value ? 0 : Convert.ToInt32(reader["dlugosc_nart"]);
                                    sprzetNarciarski.twardosc_nart = reader["twardosc_nart"] == DBNull.Value ? 0 : Convert.ToInt32(reader["twardosc_nart"]);
                                    sprzetNarciarski.rozmiar_buta = reader["rozmiar_buta"] == DBNull.Value ? 0 : Convert.ToInt32(reader["rozmiar_buta"]);
                                    sprzetNarciarski.twardosc_buta = reader["twardosc_buta"] == DBNull.Value ? 0 : Convert.ToInt32(reader["twardosc_buta"]);
                                    sprzetNarciarski.dlugosc_kijkow = reader["dlugosc_kijkow"] == DBNull.Value ? 0 : Convert.ToInt32(reader["dlugosc_kijkow"]); 
                                    sprzetNarciarski.koszt_wypozyczenia = reader.IsDBNull(reader.GetOrdinal("koszt_wypozyczenia"))
                                        ? 0.00m : reader.GetDecimal(reader.GetOrdinal("koszt_wypozyczenia"));
                                    return sprzetNarciarski;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
                return null;
            }
            public void DodajSprzetNarciarski(SprzetNarciarski sprzetNarciarski)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO SprzetNarciarski (producent, typ, numer_inw, dlugosc_nart, twardosc_nart, rozmiar_buta, twardosc_buta, dlugosc_kijkow, koszt_wypozyczenia) VALUES " +
                                       "(@producent, @typ, @numer_inw, @dlugosc_nart, @twardosc_nart, @rozmiar_buta, @twardosc_buta, @dlugosc_kijkow, @koszt_wypozyczenia);";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@producent", sprzetNarciarski.producent);
                            command.Parameters.AddWithValue("@typ", sprzetNarciarski.typ);
                            command.Parameters.AddWithValue("@numer_inw", sprzetNarciarski.numer_inw);
                            command.Parameters.AddWithValue("@dlugosc_nart", sprzetNarciarski.dlugosc_nart);
                            command.Parameters.AddWithValue("@twardosc_nart", sprzetNarciarski.twardosc_nart);
                            command.Parameters.AddWithValue("@rozmiar_buta", sprzetNarciarski.rozmiar_buta);
                            command.Parameters.AddWithValue("@twardosc_buta", sprzetNarciarski.twardosc_buta);
                            command.Parameters.AddWithValue("@dlugosc_kijkow", sprzetNarciarski.dlugosc_kijkow);
                            command.Parameters.AddWithValue("@koszt_wypozyczenia", sprzetNarciarski.koszt_wypozyczenia);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
            }
            public void EdytujSprzetNarciarski(SprzetNarciarski sprzetNarciarski)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE SprzetNarciarski SET producent=@producent, typ = @typ, numer_inw = @numer_inw, dlugosc_nart = @dlugosc_nart, " +
                                       "twardosc_nart = @twardosc_nart, rozmiar_buta = @rozmiar_buta, twardosc_buta = @twardosc_buta, " +
                                       "dlugosc_kijkow = @dlugosc_kijkow, koszt_wypozyczenia = @koszt_wypozyczenia WHERE nr_sprzetN = @nr_sprzetN;";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nr_sprzetN", sprzetNarciarski.nr_sprzetN);
                            command.Parameters.AddWithValue("@producent", sprzetNarciarski.producent);
                            command.Parameters.AddWithValue("@typ", sprzetNarciarski.typ);
                            command.Parameters.AddWithValue("@numer_inw", sprzetNarciarski.numer_inw);
                            command.Parameters.AddWithValue("@dlugosc_nart", sprzetNarciarski.dlugosc_nart);
                            command.Parameters.AddWithValue("@twardosc_nart", sprzetNarciarski.twardosc_nart);
                            command.Parameters.AddWithValue("@rozmiar_buta", sprzetNarciarski.rozmiar_buta);
                            command.Parameters.AddWithValue("@twardosc_buta", sprzetNarciarski.twardosc_buta);
                            command.Parameters.AddWithValue("@dlugosc_kijkow", sprzetNarciarski.dlugosc_kijkow);
                            command.Parameters.AddWithValue("@koszt_wypozyczenia", sprzetNarciarski.koszt_wypozyczenia);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
            }
            public void UsunSprzetNarciarski(int nr_sprzetN)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM SprzetNarciarski WHERE nr_sprzetN = @nr_sprzetN";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nr_sprzetN", nr_sprzetN);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
            }
            public int PobierzNastepneIDSprzetNarciarski()
            {
                int nextId = 1;
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT IDENT_CURRENT('SprzetNarciarski') + IDENT_INCR('SprzetNarciarski')";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            nextId = Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania ID: " + ex.Message);
                }
                return nextId;
            }
        }
        public class RepozytoriumSprzetuSnowboard
        {
            private readonly string connectionString = "Data Source=HP-Langzzey\\SQLEXPRESS;Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True;Trust Server Certificate=True";
            public List<SprzetSnowboard> PobierzSprzetyS()
            {
                var sprzets = new List<SprzetSnowboard>();
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM SprzetSnowboard";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    SprzetSnowboard sprzetSnowboard = new SprzetSnowboard();
                                    sprzetSnowboard.nr_sprzetS = reader.GetInt32(0);
                                    sprzetSnowboard.producent = reader.GetString(1);
                                    sprzetSnowboard.typ = reader.GetString(2);
                                    sprzetSnowboard.numer_inw = reader.GetString(3);
                                    sprzetSnowboard.dlugosc_deski = reader["dlugosc_deski"] == DBNull.Value ? 0 : Convert.ToInt32(reader["dlugosc_deski"]); 
                                    sprzetSnowboard.twardosc_deski = reader["twardosc_deski"] == DBNull.Value ? 0 : Convert.ToInt32(reader["twardosc_deski"]);
                                    sprzetSnowboard.ksztalt_deski = reader["ksztalt_deski"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ksztalt_deski"]); 
                                    sprzetSnowboard.rozmiar_buta = reader["rozmiar_buta"] == DBNull.Value ? 0 : Convert.ToInt32(reader["rozmiar_buta"]); 
                                    sprzetSnowboard.twardosc_buta = reader["twardosc_buta"] == DBNull.Value ? 0 : Convert.ToInt32(reader["twardosc_buta"]);
                                    sprzetSnowboard.koszt_wypozyczenia = reader.IsDBNull(reader.GetOrdinal("koszt_wypozyczenia"))
                                        ? 0.00m : reader.GetDecimal(reader.GetOrdinal("koszt_wypozyczenia"));
                                    sprzets.Add(sprzetSnowboard);

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
                return sprzets;
            }
            public SprzetSnowboard? PobierzSprzetS(int nr_sprzetS)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM SprzetSnowboard WHERE nr_sprzetS = @nr_sprzetS";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nr_sprzetS", nr_sprzetS);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    SprzetSnowboard sprzetSnowboard = new SprzetSnowboard();
                                    sprzetSnowboard.nr_sprzetS = reader.GetInt32(0);
                                    sprzetSnowboard.producent = reader.GetString(1);
                                    sprzetSnowboard.typ = reader.GetString(2);
                                    sprzetSnowboard.numer_inw = reader.GetString(3);
                                    sprzetSnowboard.dlugosc_deski = reader["dlugosc_deski"] == DBNull.Value ? 0 : Convert.ToInt32(reader["dlugosc_deski"]);
                                    sprzetSnowboard.twardosc_deski = reader["twardosc_deski"] == DBNull.Value ? 0 : Convert.ToInt32(reader["twardosc_deski"]);
                                    sprzetSnowboard.ksztalt_deski = reader["ksztalt_deski"] == DBNull.Value ? 0 : Convert.ToInt32(reader["ksztalt_deski"]);
                                    sprzetSnowboard.rozmiar_buta = reader["rozmiar_buta"] == DBNull.Value ? 0 : Convert.ToInt32(reader["rozmiar_buta"]);
                                    sprzetSnowboard.twardosc_buta = reader["twardosc_buta"] == DBNull.Value ? 0 : Convert.ToInt32(reader["twardosc_buta"]);
                                    sprzetSnowboard.koszt_wypozyczenia = reader.IsDBNull(reader.GetOrdinal("koszt_wypozyczenia"))
                                        ? 0.00m : reader.GetDecimal(reader.GetOrdinal("koszt_wypozyczenia"));
                                    return sprzetSnowboard;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
                return null;
            }
            public void DodajSprzetSnowboard(SprzetSnowboard sprzetSnowboard)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO SprzetSnowboard (producent, typ, numer_inw, dlugosc_deski, twardosc_deski, ksztalt_deski, rozmiar_buta, twardosc_buta, koszt_wypozyczenia) VALUES " +
                                       "(@producent, @typ, @numer_inw, @dlugosc_deski, @twardosc_deski, @ksztalt_deski, @rozmiar_buta, @twardosc_buta, @koszt_wypozyczenia);";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@producent", sprzetSnowboard.producent);
                            command.Parameters.AddWithValue("@typ", sprzetSnowboard.typ);
                            command.Parameters.AddWithValue("@numer_inw", sprzetSnowboard.numer_inw);
                            command.Parameters.AddWithValue("@dlugosc_deski", sprzetSnowboard.dlugosc_deski);
                            command.Parameters.AddWithValue("@twardosc_deski", sprzetSnowboard.twardosc_deski);
                            command.Parameters.AddWithValue("@ksztalt_deski", sprzetSnowboard.ksztalt_deski);
                            command.Parameters.AddWithValue("@rozmiar_buta", sprzetSnowboard.rozmiar_buta);
                            command.Parameters.AddWithValue("@twardosc_buta", sprzetSnowboard.twardosc_buta);
                            command.Parameters.AddWithValue("@koszt_wypozyczenia", sprzetSnowboard.koszt_wypozyczenia);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
            }
            public void EdytujSprzetSnowboard(SprzetSnowboard sprzetSnowboard)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE SprzetSnowboard SET producent=@producent, typ = @typ, numer_inw = @numer_inw, dlugosc_deski = @dlugosc_deski, " +
                                       "twardosc_deski = @twardosc_ndeski, ksztalt_deski = @ksztalt_deski, rozmiar_buta = @rozmiar_buta, twardosc_buta = @twardosc_buta, koszt_wypozyczenia = @koszt_wypozyczenia " +
                                       "WHERE nr_sprzetS = @nr_sprzetS;";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nr_sprzetS", sprzetSnowboard.nr_sprzetS);
                            command.Parameters.AddWithValue("@producent", sprzetSnowboard.producent);
                            command.Parameters.AddWithValue("@typ", sprzetSnowboard.typ);
                            command.Parameters.AddWithValue("@numer_inw", sprzetSnowboard.numer_inw);
                            command.Parameters.AddWithValue("@dlugosc_nart", sprzetSnowboard.dlugosc_deski);
                            command.Parameters.AddWithValue("@twardosc_nart", sprzetSnowboard.twardosc_deski);
                            command.Parameters.AddWithValue("@ksztalt_deski", sprzetSnowboard.ksztalt_deski);
                            command.Parameters.AddWithValue("@rozmiar_buta", sprzetSnowboard.rozmiar_buta);
                            command.Parameters.AddWithValue("@twardosc_buta", sprzetSnowboard.twardosc_buta);
                            command.Parameters.AddWithValue("@koszt_wypozyczenia", sprzetSnowboard.koszt_wypozyczenia);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
            }
            public void UsunSprzetSnowboard(int nr_sprzetS)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM SprzetSnowboard WHERE nr_sprzetS = @nr_sprzetS";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@nr_sprzetS", nr_sprzetS);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
                }
            }
            public int PobierzNastepneIDSprzetSnowboard()
            {
                int nextId2 = 1;
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT IDENT_CURRENT('SprzetSnowboard') + IDENT_INCR('SprzetSnowboard')";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            nextId2 = Convert.ToInt32(command.ExecuteScalar());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania ID: " + ex.Message);
                }
                return nextId2;
            }
        }
    }
}