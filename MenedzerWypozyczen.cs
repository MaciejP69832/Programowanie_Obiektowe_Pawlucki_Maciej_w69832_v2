using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WypozyczalniaSprzetuNarciarskiego.Repozytoria;
using WypozyczalniaSprzetuNarciarskiego.Modele;

namespace WypozyczalniaSprzetuNarciarskiego
{
    public partial class MenedzerWypozyczen : Form
    {
        public static class Session
        {
            public static string currentUser { get; set; }
        }

        public MenedzerWypozyczen()
        {
            InitializeComponent();
            CzytajWypozyczenia();
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);
        }
        private void CzytajWypozyczenia()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Wypożyczenia");
            dataTable.Columns.Add("ID Klienta");
            dataTable.Columns.Add("ID Sprzętu Narciarskiego");
            dataTable.Columns.Add("ID Sprzętu Snowboard");
            dataTable.Columns.Add("ID Akcesoria");
            dataTable.Columns.Add("Data wypożyczenia");
            dataTable.Columns.Add("Data oddania");
            dataTable.Columns.Add("Kwota");
            var repo = new RepozytoriumWypozyczen();
            var wypozyczenia = repo.PobierzWypozyczenia();

            foreach (var wypozyczenie in wypozyczenia)
            {
                var row = dataTable.NewRow();
                row["ID Wypożyczenia"] = wypozyczenie.nr_wypozyczenia;
                row["ID Klienta"] = wypozyczenie.pk_klienta;
                row["ID Sprzętu Narciarskiego"] = wypozyczenie.pk_sprzetN;
                row["ID Sprzętu Snowboard"] = wypozyczenie.pk_sprzetS;
                row["ID Akcesoria"] = wypozyczenie.pk_akcesoria;
                row["Data wypożyczenia"] = wypozyczenie.data_wypozyczenia;
                row["Data oddania"] = wypozyczenie.data_oddanie;
                row["Kwota"] = wypozyczenie.koszt_wypozyczenia;
                dataTable.Rows.Add(row);
            }
            this.tabelaKlientow.DataSource = dataTable;
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void bntPowrotdoMenu_Click(object sender, EventArgs e)
        {
            MenuGlowne menuGlowne = new MenuGlowne();
            menuGlowne.Show();
            this.Hide();
        }

        private void btnEdytujKlienta_Click(object sender, EventArgs e)
        {
            if (tabelaKlientow.SelectedRows.Count == 0) return;
            var val = this.tabelaKlientow.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(val))
            {
                MessageBox.Show("Nie wybrano poprawnego wypozyczenia!");
                return;
            }

            if (!int.TryParse(val, out int clientID))
            {
                MessageBox.Show("Błąd parsowania ID wypozyczenia!");
                return;
            }
            var repo = new RepozytoriumWypozyczen();
            var wypozyczenie = repo.PobierzWypozyczenie(clientID);
            if (wypozyczenie == null) return;

            DodajWypozyczenie form = new DodajWypozyczenie();
            form.EdycjaWypozyczenia(wypozyczenie);
            if (form.ShowDialog() == DialogResult.OK)
            {
                CzytajWypozyczenia();
            }
        }

        private void btnDodajKlienta_Click(object sender, EventArgs e)
        {
            DodajWypozyczenie form = new DodajWypozyczenie();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CzytajWypozyczenia();
            }
        }
    }
}
