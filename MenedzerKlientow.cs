using System.Data;
using System.Diagnostics.Eventing.Reader;
using WypozyczalniaSprzetuNarciarskiego.Modele;
using WypozyczalniaSprzetuNarciarskiego.Repozytoria;

namespace WypozyczalniaSprzetuNarciarskiego
{
    public partial class MenedzerKlientow : Form
    {
        public MenedzerKlientow()
        {
            InitializeComponent();
            CzytajKlientow();
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);

        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void CzytajKlientow()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Klienta");
            dataTable.Columns.Add("Imiê i nazwisko");
            dataTable.Columns.Add("PESEL");
            dataTable.Columns.Add("Adres");
            dataTable.Columns.Add("Nr telefonu");
            dataTable.Columns.Add("NIP");
            var repo = new RepozytoriumKlienta();
            var klienci = repo.PobierzKlientow();
            foreach (var klient in klienci)
            {
                var row = dataTable.NewRow();
                row["ID Klienta"] = klient.nr_klienta;
                row["Imiê i nazwisko"] = klient.imie + " " + klient.nazwisko;
                row["PESEL"] = klient.pesel;
                row["Adres"] = klient.ulica + " " + klient.numerDomu + klient.postal + " " + klient.miasto;
                row["Nr telefonu"] = klient.nrTelefonu;
                row["NIP"] = klient.nip;
                dataTable.Rows.Add(row);
            }
            this.tabelaKlientow.DataSource = dataTable;
        }

        private void btnDodajKlienta_Click(object sender, EventArgs e)
        {
            DodajKlienta form = new DodajKlienta();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // zaktualizuj bazê klientów
                CzytajKlientow();
            }
        }

        private void btnEdytujKlienta_Click(object sender, EventArgs e)
        {
            if (tabelaKlientow.SelectedRows.Count == 0) return;
            var val = this.tabelaKlientow.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(val))
            {
                MessageBox.Show("Nie wybrano poprawnego klienta!");
                return;
            }

            if (!int.TryParse(val, out int clientID))
            {
                MessageBox.Show("B³¹d parsowania ID klienta!");
                return;
            }
            var repo = new RepozytoriumKlienta();
            var klient = repo.PobierzKlienta(clientID);
            if (klient == null) return;

            DodajKlienta form = new DodajKlienta();
            form.EdycjaKlienta(klient);
            if (form.ShowDialog() == DialogResult.OK)
            {
                CzytajKlientow();
            }
        }

        private void btnUsunKlienta_Click(object sender, EventArgs e)
        {
            var val = this.tabelaKlientow.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;
            int clientID = int.Parse(val);
            DialogResult dialogResult =
                MessageBox.Show("Czy jesteœ pewien swojej decyzji? Usuwasz rekord z bazy danych!", "Usuñ Klienta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var repo = new RepozytoriumKlienta();
            repo.UsunKlienta(clientID);
            CzytajKlientow();
        }

        private void bntPowrotdoMenu_Click(object sender, EventArgs e)
        {
            MenuGlowne menuGlowne = new MenuGlowne();
            menuGlowne.Show();
            this.Hide();
        }
    }
}
