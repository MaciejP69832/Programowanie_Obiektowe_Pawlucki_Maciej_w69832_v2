using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaSprzetuNarciarskiego.Modele;

namespace WypozyczalniaSprzetuNarciarskiego.Repozytoria
{
    public class RepozytoriumKlienta
    {
        private readonly string connectionString = "Data Source=HP-Langzzey\\SQLEXPRESS;Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True;Trust Server Certificate=True";

        public List<Klient> PobierzKlientow()
        {
            var klienci = new List<Klient>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Klienci";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Klient klient = new Klient();
                                klient.nr_klienta = reader.GetInt32(0);
                                klient.imie = reader.GetString(1);
                                klient.nazwisko = reader.GetString(2);
                                klient.ulica = reader.GetString(3);
                                klient.miasto = reader.GetString(4);
                                klient.numerDomu = reader.GetString(5);
                                klient.postal = reader.GetString(6);
                                klient.pesel = reader.GetString(7);
                                klient.nip = reader.IsDBNull(8) ? null : reader.GetString(8);
                                klient.nrTelefonu = reader.IsDBNull(9) ? null : reader.GetString(9);
                                klienci.Add(klient);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
            return klienci;
        }
        public Klient? PobierzKlienta(int nr_klienta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Klienci WHERE nr_klienta = @nr_klienta";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_klienta", nr_klienta);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Klient klient = new Klient();
                                klient.nr_klienta = reader.GetInt32(0);
                                klient.imie = reader.GetString(1);
                                klient.nazwisko = reader.GetString(2);
                                klient.ulica = reader.GetString(3);
                                klient.miasto = reader.GetString(4);
                                klient.numerDomu = reader.GetString(5);
                                klient.postal = reader.GetString(6);
                                klient.pesel = reader.GetString(7);
                                klient.nip = reader.IsDBNull(8) ? null : reader.GetString(8);
                                klient.nrTelefonu = reader.IsDBNull(9) ? null : reader.GetString(9);

                                return klient;
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
        public void StworzKlienta(Klient klient)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Klienci (imie, nazwisko, ulica, miasto, numerDomu, postal, pesel, nip, nrTelefonu) VALUES " +
                                   "(@imie, @nazwisko, @ulica, @miasto, @numerDomu, @postal, @pesel, @nip, @nrTelefonu);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@imie", klient.imie);
                        command.Parameters.AddWithValue("@nazwisko", klient.nazwisko);
                        command.Parameters.AddWithValue("@ulica", klient.ulica);
                        command.Parameters.AddWithValue("@miasto", klient.miasto);
                        command.Parameters.AddWithValue("@numerDomu", klient.numerDomu);
                        command.Parameters.AddWithValue("@postal", klient.postal);
                        command.Parameters.AddWithValue("@pesel", klient.pesel);
                        command.Parameters.AddWithValue("@nip", klient.nip);
                        command.Parameters.AddWithValue("@nrTelefonu", klient.nrTelefonu);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
        }
        public void EdytujKlienta(Klient klient)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Klienci SET imie=@imie, nazwisko = @nazwisko, ulica = @ulica, miasto = @miasto, " +
                                   "numerDomu = @numerDomu, postal = @postal, pesel = @pesel, nip = @nip, nrTelefonu = @nrTelefonu " +
                                   "WHERE nr_klienta = @nr_klienta";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_klienta", klient.nr_klienta);
                        command.Parameters.AddWithValue("@imie", klient.imie);
                        command.Parameters.AddWithValue("@nazwisko", klient.nazwisko);
                        command.Parameters.AddWithValue("@ulica", klient.ulica);
                        command.Parameters.AddWithValue("@miasto", klient.miasto);
                        command.Parameters.AddWithValue("@numerDomu", klient.numerDomu);
                        command.Parameters.AddWithValue("@postal", klient.postal);
                        command.Parameters.AddWithValue("@pesel", klient.pesel);
                        command.Parameters.AddWithValue("@nip", klient.nip);
                        command.Parameters.AddWithValue("@nrTelefonu", klient.nrTelefonu);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
        }
        public void UsunKlienta(int nr_klienta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Klienci WHERE nr_klienta = @nr_klienta";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_klienta", nr_klienta);
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
            int nextId = 1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IDENT_CURRENT('Klienci') + IDENT_INCR('Klienci')";
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
