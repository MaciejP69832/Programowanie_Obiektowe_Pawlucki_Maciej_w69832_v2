using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaSprzetuNarciarskiego.Modele;

namespace WypozyczalniaSprzetuNarciarskiego.Repozytoria
{
    public class RepozytoriumAkcesoriow
    {
        private readonly string connectionString = "Data Source=HP-Langzzey\\SQLEXPRESS;Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True;Trust Server Certificate=True";

        public List<Akcesoria> PobierzAkcesoria()
        {
            var akcesoriaa = new List<Akcesoria>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Akcesoria";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Akcesoria akcesoria = new Akcesoria();
                                akcesoria.nr_akcesoria = reader.GetInt32(0);
                                akcesoria.producent = reader.GetString(1);
                                akcesoria.typ = reader.GetString(2);
                                akcesoria.numer_inw = reader.GetString(3);
                                akcesoria.rozmiar = reader.IsDBNull(4) ? null : reader.GetString(4);
                                akcesoria.opis = reader.IsDBNull(5) ? null : reader.GetString(5);
                                akcesoria.koszt_wypozyczenia = reader.IsDBNull(reader.GetOrdinal("koszt_wypozyczenia"))
                                    ? 0.00m : reader.GetDecimal(reader.GetOrdinal("koszt_wypozyczenia"));

                                akcesoriaa.Add(akcesoria);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
            return akcesoriaa;
        }
        public Akcesoria? PobierzAkcesoria(int nr_akcesoria)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Akcesoria WHERE nr_akcesoria = @nr_akcesoria";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_akcesoria", nr_akcesoria);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Akcesoria akcesoria = new Akcesoria();
                                akcesoria.nr_akcesoria = reader.GetInt32(0);
                                akcesoria.producent = reader.GetString(1);
                                akcesoria.typ = reader.GetString(2);
                                akcesoria.numer_inw = reader.GetString(3);
                                akcesoria.rozmiar = reader.IsDBNull(4) ? null : reader.GetString(4);
                                akcesoria.opis = reader.IsDBNull(5) ? null : reader.GetString(5);
                                akcesoria.koszt_wypozyczenia = reader.IsDBNull(reader.GetOrdinal("koszt_wypozyczenia"))
                                    ? 0.00m : reader.GetDecimal(reader.GetOrdinal("koszt_wypozyczenia"));

                                return akcesoria;
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
        public void DodajAkcesoria(Akcesoria akcesoria)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Akcesoria (producent, typ, numer_inw, rozmiar, opis, koszt_wypozyczenia) VALUES " +
                                   "(@producent, @typ, @numer_inw, @rozmiar, @opis, @koszt_wypozyczenia);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@producent", akcesoria.producent);
                        command.Parameters.AddWithValue("@typ", akcesoria.typ);
                        command.Parameters.AddWithValue("@numer_inw", akcesoria.numer_inw);
                        command.Parameters.AddWithValue("@rozmiar", akcesoria.rozmiar);
                        command.Parameters.AddWithValue("@opis", akcesoria.opis);
                        command.Parameters.AddWithValue("@koszt_wypozyczenia", akcesoria.koszt_wypozyczenia);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
        }
        public void EdytujAkcesoria(Akcesoria akcesoria)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Akcesoria SET producent=@producent, typ = @typ, numer_inw = @numer_inw, rozmiar = @rozmiar, " +
                                   "opis = @opis, koszt_wypozyczenia = @koszt_wypozyczenia WHERE nr_akcesoria = @nr_akcesoria;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_akcesoria", akcesoria.nr_akcesoria);
                        command.Parameters.AddWithValue("@producent", akcesoria.producent);
                        command.Parameters.AddWithValue("@typ", akcesoria.typ);
                        command.Parameters.AddWithValue("@numer_inw", akcesoria.numer_inw);
                        command.Parameters.AddWithValue("@rozmiar", akcesoria.rozmiar);
                        command.Parameters.AddWithValue("@opis", akcesoria.opis);
                        command.Parameters.AddWithValue("@koszt_wypozyczenia", akcesoria.koszt_wypozyczenia);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
        }
        public void UsunAkcesoria(int nr_akcesoria)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Akcesoria WHERE nr_akcesoria = @nr_akcesoria";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_akcesoria", nr_akcesoria);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
        }
        public int PobierzNastepneID()
        {
            int nextId3 = 1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IDENT_CURRENT('Akcesoria') + IDENT_INCR('Akcesoria')";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        nextId3 = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd pobierania ID: " + ex.Message);
            }
            return nextId3;
        }
    }
}
