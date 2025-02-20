using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaSprzetuNarciarskiego.Modele;

namespace WypozyczalniaSprzetuNarciarskiego.Repozytoria
{
    public class RepozytoriumWypozyczen
    {
        private readonly string connectionString = "Data Source=HP-Langzzey\\SQLEXPRESS;Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True;Trust Server Certificate=True";

        public List<Wypozyczenia> PobierzWypozyczenia()
        {
            var wypozyczenia = new List<Wypozyczenia>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Wypozyczenia";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Wypozyczenia wypozyczenie = new Wypozyczenia();
                                wypozyczenie.nr_wypozyczenia = reader.GetInt32(0);
                                wypozyczenie.pk_klienta = reader.GetInt32(1);
                                wypozyczenie.pk_pracownika = reader.GetInt32(2);
                                wypozyczenie.pk_sprzetN = reader["pk_sprzetN"] == DBNull.Value ? 0 : Convert.ToInt32(reader["pk_sprzetN"]);
                                wypozyczenie.pk_sprzetS = reader["pk_sprzetS"] == DBNull.Value ? 0 : Convert.ToInt32(reader["pk_sprzetS"]);
                                wypozyczenie.pk_akcesoria = reader["pk_akcesoria"] == DBNull.Value ? 0 : Convert.ToInt32(reader["pk_akcesoria"]);
                                wypozyczenie.koszt_wypozyczenia = reader.IsDBNull(reader.GetOrdinal("koszt_wypozyczenia"))
                                        ? 0.00m : reader.GetDecimal(reader.GetOrdinal("koszt_wypozyczenia"));
                                wypozyczenie.data_wypozyczenia = reader.GetDateTime(7);
                                wypozyczenie.data_oddanie = reader.IsDBNull(8) ? null : reader.GetString(8);
                                wypozyczenia.Add(wypozyczenie);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
            return wypozyczenia;
        }
        public Wypozyczenia? PobierzWypozyczenie(int nr_wypozyczenia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Wypozyczenia WHERE nr_wypozyczenia = @nr_wypozyczenia";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_wypozyczenia", nr_wypozyczenia);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Wypozyczenia wypozyczenie = new Wypozyczenia();
                                wypozyczenie.nr_wypozyczenia = reader.GetInt32(0);
                                wypozyczenie.pk_klienta = reader.GetInt32(1);
                                wypozyczenie.pk_pracownika = reader.GetInt32(2);
                                wypozyczenie.pk_sprzetN = reader["pk_sprzetN"] == DBNull.Value ? 0 : Convert.ToInt32(reader["pk_sprzetN"]);
                                wypozyczenie.pk_sprzetS = reader["pk_sprzetS"] == DBNull.Value ? 0 : Convert.ToInt32(reader["pk_sprzetS"]);
                                wypozyczenie.pk_akcesoria = reader["pk_akcesoria"] == DBNull.Value ? 0 : Convert.ToInt32(reader["pk_akcesoria"]);
                                wypozyczenie.koszt_wypozyczenia = reader.IsDBNull(reader.GetOrdinal("koszt_wypozyczenia"))
                                        ? 0.00m : reader.GetDecimal(reader.GetOrdinal("koszt_wypozyczenia"));
                                wypozyczenie.data_wypozyczenia = reader.GetDateTime(7);
                                wypozyczenie.data_oddanie = reader.IsDBNull(8) ? null : reader.GetString(8);

                                return wypozyczenie;
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
        public void StworzWypozyczenie(Wypozyczenia wypozyczenie)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Wypozyczenia (pk_klienta, pk_pracownika, pk_sprzetN, pk_sprzetS, pk_akcesoria, koszt_wypozyczenia, data_wypozyczenia, data_oddanie) VALUES " +
                                   "(@pk_klienta, @pk_pracownika, @pk_sprzetN, @pk_sprzetS, @pk_akcesoria, @koszt_wypozyczenia, @data_wypozyczenia, @data_oddanie);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@pk_klienta", wypozyczenie.pk_klienta);
                        command.Parameters.AddWithValue("@pk_pracownika", wypozyczenie.pk_pracownika);
                        command.Parameters.AddWithValue("@pk_sprzetN", wypozyczenie.pk_sprzetN);
                        command.Parameters.AddWithValue("@pk_sprzetS", wypozyczenie.pk_sprzetS);
                        command.Parameters.AddWithValue("@pk_akcesoria", wypozyczenie.pk_akcesoria);
                        command.Parameters.AddWithValue("@koszt_wypozyczenia", wypozyczenie.koszt_wypozyczenia);
                        command.Parameters.AddWithValue("@data_wypozyczenia", wypozyczenie.data_wypozyczenia);
                        command.Parameters.AddWithValue("@data_oddanie", wypozyczenie.data_oddanie);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
        }
        public void EdytujWypozyczenie(Wypozyczenia wypozyczenie)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Wypozyczenia SET pk_klienta=@pk_klienta, pk_pracownika = @pk_pracownika, pk_sprzetN = @pk_sprzetN, pk_sprzetS = @pk_sprzetS, " +
                                   "pk_akcesoria = @pk_akcesoria, koszt_wypozyczenia = @koszt_wypozyczenia, data_wypozyczenia = @data_wypozyczenia, data_oddanie = @data_oddanie " +
                                   "WHERE nr_wypozyczenia = @nr_wypozyczenia";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_wypozyczenia", wypozyczenie.nr_wypozyczenia);
                        command.Parameters.AddWithValue("@pk_klienta", wypozyczenie.pk_klienta);
                        command.Parameters.AddWithValue("@pk_pracownika", wypozyczenie.pk_pracownika);
                        command.Parameters.AddWithValue("@pk_sprzetN", wypozyczenie.pk_sprzetN);
                        command.Parameters.AddWithValue("@pk_sprzetS", wypozyczenie.pk_sprzetS);
                        command.Parameters.AddWithValue("@pk_akcesoria", wypozyczenie.pk_akcesoria);
                        command.Parameters.AddWithValue("@koszt_wypozyczenia", wypozyczenie.koszt_wypozyczenia);
                        command.Parameters.AddWithValue("@data_wypozyczenia", wypozyczenie.data_wypozyczenia);
                        command.Parameters.AddWithValue("@data_oddanie", wypozyczenie.data_oddanie);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
        }
        public void UsunWypozyczenie(int nr_wypozyczenia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Wypozyczenia WHERE nr_wypozyczenia = @nr_wypozyczenia";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_wypozyczenia", nr_wypozyczenia);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
        }
        public int PobierzNastepneIDWypozyczenia()
        {
            int nextId = 1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IDENT_CURRENT('Wypozyczenia') + IDENT_INCR('Wypozyczenia')";
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
}
