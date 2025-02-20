using System.Data;
using WypozyczalniaSprzetuNarciarskiego.Modele;
using WypozyczalniaSprzetuNarciarskiego.Repozytoria;

namespace WypozyczalniaSprzetuNarciarskiego
{
    public partial class MenedzerSprzetu : Form
    {
        private List<int> akcesoriaIds = new List<int>();
        private List<int> sprzetNarciarskiIds = new List<int>();
        private List<int> sprzetSnowboardIds = new List<int>();
        public MenedzerSprzetu()
        {
            InitializeComponent();
            CzytajSprzet();
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void CzytajSprzet()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID sprzętu");
            dataTable.Columns.Add("Rodzaj sprzętu");
            dataTable.Columns.Add("Producent");
            dataTable.Columns.Add("Typ sprzętu");
            dataTable.Columns.Add("Numer inwentaryzacyjny");
            dataTable.Columns.Add("Rozmiar");
            dataTable.Columns.Add("Długość");
            dataTable.Columns.Add("Twardość");
            dataTable.Columns.Add("Kształt");
            dataTable.Columns.Add("Rozmiar buta");
            dataTable.Columns.Add("Twardość buta");
            dataTable.Columns.Add("Koszt wypożyczenia / dzień");

            var repo = new RepozytoriumSprzetu.RepozytoriumSprzetuNarciarskiego();
            var repo2 = new RepozytoriumSprzetu.RepozytoriumSprzetuSnowboard();
            var repo3 = new RepozytoriumAkcesoriow();
            var akcesoria = repo3.PobierzAkcesoria();
            var sprzetn = repo.PobierzSprzetyN();
            var sprzets = repo2.PobierzSprzetyS();
            foreach (var akcesorium in akcesoria)
            {
                akcesoriaIds.Add(akcesorium.nr_akcesoria);
                var row = dataTable.NewRow();
                row["ID Sprzętu"] = akcesorium.nr_akcesoria;
                row["Rodzaj sprzętu"] = "Akcesoria";
                row["Producent"] = akcesorium.producent;
                row["Typ sprzętu"] = akcesorium.typ;
                row["Numer inwentaryzacyjny"] = akcesorium.numer_inw;
                row["Rozmiar"] = akcesorium.rozmiar;
                row["Długość"] = "NULL";
                row["Twardość"] = "NULL";
                row["Kształt"] = "NULL";
                row["Rozmiar buta"] = "NULL";
                row["Twardość buta"] = "NULL";
                row["Koszt wypożyczenia / dzień"] = akcesorium.koszt_wypozyczenia;
                dataTable.Rows.Add(row);
            }
            foreach (var sprzetNarciarski in sprzetn)
            {
                sprzetNarciarskiIds.Add(sprzetNarciarski.nr_sprzetN);
                var row = dataTable.NewRow();
                row["ID Sprzętu"] = sprzetNarciarski.nr_sprzetN;
                row["Rodzaj sprzętu"] = "Sprzęt Narciarski";
                row["Producent"] = sprzetNarciarski.producent;
                row["Typ sprzętu"] = sprzetNarciarski.typ;
                row["Numer inwentaryzacyjny"] = sprzetNarciarski.numer_inw;
                row["Rozmiar"] = "NULL";
                row["Długość"] = sprzetNarciarski.dlugosc_nart;
                row["Twardość"] = sprzetNarciarski.twardosc_nart;
                row["Kształt"] = "NULL";
                row["Rozmiar buta"] = sprzetNarciarski.rozmiar_buta;
                row["Twardość buta"] = sprzetNarciarski.twardosc_buta;
                row["Koszt wypożyczenia / dzień"] = sprzetNarciarski.koszt_wypozyczenia;
                dataTable.Rows.Add(row);
            }
            foreach (var sprzetSnowboard in sprzets)
            {
                sprzetSnowboardIds.Add(sprzetSnowboard.nr_sprzetS);
                var row = dataTable.NewRow();
                row["ID Sprzętu"] = sprzetSnowboard.nr_sprzetS;
                row["Rodzaj sprzętu"] = "Sprzęt Snowboard";
                row["Producent"] = sprzetSnowboard.producent;
                row["Typ sprzętu"] = sprzetSnowboard.typ;
                row["Numer inwentaryzacyjny"] = sprzetSnowboard.numer_inw;
                row["Rozmiar"] = "NULL";
                row["Długość"] = sprzetSnowboard.dlugosc_deski;
                row["Twardość"] = sprzetSnowboard.twardosc_deski;
                row["Kształt"] = sprzetSnowboard.ksztalt_deski;
                row["Rozmiar buta"] = sprzetSnowboard.rozmiar_buta;
                row["Twardość buta"] = sprzetSnowboard.twardosc_buta;
                row["Koszt wypożyczenia / dzień"] = sprzetSnowboard.koszt_wypozyczenia;
                dataTable.Rows.Add(row);
            }

            this.tabelaSprzet.DataSource = dataTable;
        }

        private void btnPowrotdomenu_Click(object sender, EventArgs e)
        {
            MenuGlowne menuGlowne = new MenuGlowne();
            menuGlowne.Show();
            this.Hide();
        }

        private void btnDodajSprzet_Click(object sender, EventArgs e)
        {
            DodajSprzet form = new DodajSprzet();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // zaktualizuj bazę klientów
                CzytajSprzet();
            }
        }

        private void btnUsunSprzet_Click(object sender, EventArgs e)
        {
            var selectedRow = this.tabelaSprzet.SelectedRows[0];
            var val = this.tabelaSprzet.SelectedRows[0].Cells[0].Value.ToString();
            var rep1 = new RepozytoriumSprzetu.RepozytoriumSprzetuNarciarskiego();
            var rep2 = new RepozytoriumSprzetu.RepozytoriumSprzetuSnowboard();
            var rep3 = new RepozytoriumAkcesoriow();
            string rodzajSprzetu = selectedRow.Cells["Rodzaj sprzętu"].Value.ToString();
            if (val == null || val.Length == 0) return;
            int clientID = int.Parse(val);
            DialogResult dialogResult =
                MessageBox.Show("Czy jesteś pewien swojej decyzji? Usuwasz rekord z bazy danych!", "Usuń Klienta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (rodzajSprzetu == "Sprzęt Narciarski")
            {
                rep1.UsunSprzetNarciarski(clientID);
                CzytajSprzet();
            }
            else if (rodzajSprzetu == "Sprzęt Snowboard")
            {
                rep2.UsunSprzetSnowboard(clientID);
                CzytajSprzet();
            }
            else if (rodzajSprzetu == "Akcesoria")
            {
                rep3.UsunAkcesoria(clientID);
                CzytajSprzet();
            }
        }
        private void btnEdycjaSprzetu_Click(object sender, EventArgs e)
        {
            var selectedRow = this.tabelaSprzet.SelectedRows[0];
            var val = this.tabelaSprzet.SelectedRows[0].Cells[0].Value.ToString();
            var rep1 = new RepozytoriumSprzetu.RepozytoriumSprzetuNarciarskiego();
            var rep2 = new RepozytoriumSprzetu.RepozytoriumSprzetuSnowboard();
            var rep3 = new RepozytoriumAkcesoriow();
            string rodzajSprzetu = selectedRow.Cells["Rodzaj sprzętu"].Value.ToString();
            if (val == null || val.Length == 0) return;
            if (rodzajSprzetu == "Sprzęt Narciarski")
            {
                int clientID = int.Parse(val);
                var sprzet = rep1.PobierzSprzetN(clientID);
                if (sprzet == null) return;
                DodajSprzet form = new DodajSprzet();
                form.EdycjaSprzetu(sprzet);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CzytajSprzet();
                }
            }
            else if (rodzajSprzetu == "Sprzęt Snowboard")
            {
                int clientID = int.Parse(val);

                var sprzet = rep2.PobierzSprzetS(clientID);
                if (sprzet == null) return;
                DodajSprzet form = new DodajSprzet();
                form.EdycjaSprzetu(sprzet);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CzytajSprzet();
                }
            }
            else if (rodzajSprzetu == "Akcesoria")
            {
                int clientID = int.Parse(val);
                var sprzet = rep3.PobierzAkcesoria(clientID);
                if (sprzet == null) return;
                DodajSprzet form = new DodajSprzet();
                form.EdycjaSprzetu(sprzet);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CzytajSprzet();
                }
            }

        }
    }
}
