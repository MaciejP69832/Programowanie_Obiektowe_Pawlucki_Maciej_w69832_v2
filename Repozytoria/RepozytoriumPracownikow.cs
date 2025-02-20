using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaSprzetuNarciarskiego.Modele;

namespace WypozyczalniaSprzetuNarciarskiego.Repozytoria
{
    public class RepozytoriumPracownikow
    {
        private readonly string connectionString = "Data Source=HP-Langzzey\\SQLEXPRESS;Initial Catalog=WypozyczalniaSprzetuNarciarskiego;Integrated Security=True;Trust Server Certificate=True";

        public List<Pracownik> PobierzPracownikow()
        {
            var pracownicy = new List<Pracownik>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Pracownicy";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Pracownik pracownik = new Pracownik();
                                pracownik.nr_pracownika = reader.GetInt32(0);
                                pracownik.imie = reader.GetString(1);
                                pracownik.nazwisko = reader.GetString(2);
                                pracownik.data_urodzenia = reader.GetString(3);
                                pracownik.telefon = reader.IsDBNull(4) ? null : reader.GetString(4);
                                pracownik.email = reader.IsDBNull(5) ? null : reader.GetString(5);
                                pracownik.stanowisko = reader.IsDBNull(6) ? null : reader.GetString(6);
                                pracownicy.Add(pracownik);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napotkano wyjątek o kodzie: " + ex.ToString());
            }
            return pracownicy;
        }
        public Pracownik? PobierzPracownika(int nr_pracownika)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Pracownicy WHERE nr_pracownika = @nr_pracownika";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nr_pracownika", nr_pracownika);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Pracownik pracownik = new Pracownik();
                                pracownik.nr_pracownika = reader.GetInt32(0);
                                pracownik.imie = reader.GetString(1);
                                pracownik.nazwisko = reader.GetString(2);
                                pracownik.data_urodzenia = reader.GetString(3);
                                pracownik.telefon = reader.IsDBNull(4) ? null : reader.GetString(4);
                                pracownik.email = reader.IsDBNull(5) ? null : reader.GetString(5);
                                pracownik.stanowisko = reader.IsDBNull(6) ? null : reader.GetString(6);
                                return pracownik;
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
        public int PobierzNastepneIDPracownika()
        {
            int nextId = 1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IDENT_CURRENT('Pracownicy') + IDENT_INCR('Pracownicy')";
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
