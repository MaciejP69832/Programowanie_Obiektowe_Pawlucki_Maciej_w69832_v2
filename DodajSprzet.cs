using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WypozyczalniaSprzetuNarciarskiego.Modele;
using WypozyczalniaSprzetuNarciarskiego.Repozytoria;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WypozyczalniaSprzetuNarciarskiego
{
    public partial class DodajSprzet : Form
    {
        private RepozytoriumSprzetu.RepozytoriumSprzetuNarciarskiego rep1 = new RepozytoriumSprzetu.RepozytoriumSprzetuNarciarskiego();
        private RepozytoriumSprzetu.RepozytoriumSprzetuSnowboard rep2 = new RepozytoriumSprzetu.RepozytoriumSprzetuSnowboard();
        private RepozytoriumAkcesoriow rep3 = new RepozytoriumAkcesoriow();
        private int sprzetID = 0;
        public DodajSprzet()
        {
            InitializeComponent();
            int nextId = rep1.PobierzNastepneIDSprzetNarciarski();
            int nextId2 = rep2.PobierzNastepneIDSprzetSnowboard();
            int nextId3 = rep3.PobierzNastepneID();
            lbID.Enabled = false; 
            cbRodzajSprzetu.Items.AddRange(new string[] { "Sprzęt Narciarski", "Sprzęt Snowboard", "Akcesoria" });
            cbRodzajSprzetu.SelectedIndexChanged += cbRodzajSprzetu_SelectedIndexChanged;
            if (cbRodzajSprzetu.SelectedIndex == 0) 
                lbID.Text = nextId.ToString();
            else if (cbRodzajSprzetu.SelectedIndex == 1) 
                lbID.Text = nextId2.ToString();
            else // Akcesoria
                lbID.Text = nextId3.ToString();

        }
        private void cbRodzajSprzetu_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktualizujPola();
        }

        public void EdycjaSprzetu(SprzetNarciarski sprzetNarciarski)
        {
            cbRodzajSprzetu.SelectedIndex = 0;
            this.Text = "Edytuj Sprzęt";
            this.lbTitle.Text = "Edytuj Sprzęt";
            this.lbID.Text = "" + sprzetNarciarski.nr_sprzetN.ToString();
            this.lbID.Enabled = false;
            this.tbNazwisko.Text = "" + sprzetNarciarski.producent;
            this.tbPesel.Text = "" + sprzetNarciarski.typ;
            this.tbUlica.Text = "" + sprzetNarciarski.numer_inw;
            this.tbNumerDomu.Text = "" + sprzetNarciarski.dlugosc_nart;
            this.tbMiasto.Text = "" + sprzetNarciarski.twardosc_nart;
            this.tbPostal.Text = "" + sprzetNarciarski.rozmiar_buta;
            this.tbNIP.Text = "" + sprzetNarciarski.twardosc_buta;
            this.tbTelefon.Text = "" + sprzetNarciarski.dlugosc_kijkow;
            this.tb11.Text = "" + sprzetNarciarski.koszt_wypozyczenia;
            this.sprzetID = sprzetNarciarski.nr_sprzetN;
            label2.Text = "Rodzaj Sprzętu";
            label3.Text = "Producent";
            label8.Text = "Typ";
            label4.Text = "Barcode";
            label5.Text = "Długość nart";
            label6.Text = "Twardość nart";
            label7.Text = "Rozmiar buta";
            label10.Text = "Twardość buta";
            label9.Text = "Długość kijków";
            label11.Text = "Koszt wyp.";
            label11.Visible = true;
            tb11.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            tbTelefon.Visible = true;
            tbNIP.Visible = true;
        }
        public void EdycjaSprzetu(SprzetSnowboard sprzetSnowboard)
        {
            cbRodzajSprzetu.SelectedIndex = 1;
            this.Text = "Edytuj Sprzęt";
            this.lbTitle.Text = "Edytuj Sprzęt";

            this.lbID.Enabled = false;
            this.tbNazwisko.Text = "" + sprzetSnowboard.producent;
            this.tbPesel.Text = "" + sprzetSnowboard.typ;
            this.tbUlica.Text = "" + sprzetSnowboard.numer_inw;
            this.tbNumerDomu.Text = "" + sprzetSnowboard.dlugosc_deski;
            this.tbMiasto.Text = "" + sprzetSnowboard.twardosc_deski;
            this.tbPostal.Text = "" + sprzetSnowboard.ksztalt_deski;
            this.tbNIP.Text = "" + sprzetSnowboard.rozmiar_buta;
            this.tbTelefon.Text = "" + sprzetSnowboard.twardosc_buta;
            this.tb11.Text = "" + sprzetSnowboard.koszt_wypozyczenia;
            this.sprzetID = sprzetSnowboard.nr_sprzetS;
            label2.Text = "Rodzaj Sprzętu";
            label3.Text = "Producent";
            label8.Text = "Typ";
            label4.Text = "Barcode";
            label5.Text = "Długość deski";
            label6.Text = "Twardość deski";
            label7.Text = "Kształt deski";
            label10.Text = "Rozmiar buta";
            label9.Text = "Twardość buta";
            label11.Text = "Koszt wyp.";
            label11.Visible = true;
            tb11.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            tbTelefon.Visible = true;
            tbNIP.Visible = true;
        }
        public void EdycjaSprzetu(Akcesoria akcesoria)
        {
            cbRodzajSprzetu.SelectedIndex = 2;
            this.Text = "Edytuj Akcesoria";
            this.lbTitle.Text = "Edytuj Akcesoria";

            this.lbID.Text = "" + akcesoria.nr_akcesoria.ToString();
            this.lbID.Enabled = false;
            tbNazwisko.Text = "" + akcesoria.producent;
            tbPesel.Text = "" + akcesoria.typ;
            tbUlica.Text = "" + akcesoria.numer_inw;
            tbNumerDomu.Text = "" + akcesoria.rozmiar;
            tbMiasto.Text = "" + akcesoria.opis;
            tbPostal.Text = "" + akcesoria.koszt_wypozyczenia;
            this.sprzetID = akcesoria.nr_akcesoria;
            label2.Text = "Rodzaj Sprzętu";
            label3.Text = "Producent";
            label8.Text = "Typ";
            label4.Text = "Barcode";
            label5.Text = "Rozmiar";
            label6.Text = "Opis";
            label7.Text = "Koszt wyp.";
            label10.Text = "Rozmiar buta";
            label9.Text = "Twardość buta";
            label11.Visible = false;
            tb11.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            tbTelefon.Visible = false;
            tbNIP.Visible = false;
        }
        private void AktualizujPola()
        {
            string wybranySprzet = cbRodzajSprzetu.SelectedItem.ToString();

            if (wybranySprzet == "Sprzęt Narciarski")
            {
                label2.Text = "Rodzaj Sprzętu";
                lbID.Text = rep1.PobierzNastepneIDSprzetNarciarski().ToString();
                label3.Text = "Producent";
                label8.Text = "Typ";
                label4.Text = "Barcode";
                label5.Text = "Długość nart";
                label6.Text = "Twardość nart";
                label7.Text = "Rozmiar buta";
                label10.Text = "Twardość buta";
                label9.Text = "Długość kijków";
                label11.Text = "Koszt wyp.";
                label11.Visible = true;
                tb11.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                tbTelefon.Visible = true;
                tbNIP.Visible = true;
            }
            else if (wybranySprzet == "Sprzęt Snowboard")
            {
                label2.Text = "Rodzaj Sprzętu";
                lbID.Text = rep2.PobierzNastepneIDSprzetSnowboard().ToString();
                label3.Text = "Producent";
                label8.Text = "Typ";
                label4.Text = "Barcode";
                label5.Text = "Długość deski";
                label6.Text = "Twardość deski";
                label7.Text = "Kształt deski";
                label10.Text = "Rozmiar buta";
                label9.Text = "Twardość buta";
                label11.Text = "Koszt wyp.";
                label11.Visible = true;
                tb11.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                tbTelefon.Visible = true;
                tbNIP.Visible = true;
            }
            else if (wybranySprzet == "Akcesoria")
            {
                label2.Text = "Rodzaj Sprzętu";
                lbID.Text = rep3.PobierzNastepneID().ToString();
                label3.Text = "Producent";
                label8.Text = "Typ";
                label4.Text = "Barcode";
                label5.Text = "Rozmiar";
                label6.Text = "Opis";
                label7.Text = "Koszt wyp.";
                label10.Text = "Rozmiar buta";
                label9.Text = "Twardość buta";
                label11.Visible = false;
                tb11.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                tbTelefon.Visible = false;
                tbNIP.Visible = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string wybranySprzet = cbRodzajSprzetu.Text.ToString();
            if (wybranySprzet == "Sprzęt Narciarski")
            {
                if (decimal.TryParse(tb11.Text, out decimal kosztWypozyczenia))
                {
                    SprzetNarciarski sprzetNarciarski = new SprzetNarciarski();
                    sprzetNarciarski.nr_sprzetN = this.sprzetID;
                    sprzetNarciarski.producent = this.tbNazwisko.Text;
                    sprzetNarciarski.typ = this.tbPesel.Text;
                    sprzetNarciarski.numer_inw = this.tbUlica.Text;
                    sprzetNarciarski.dlugosc_nart = int.Parse(this.tbNumerDomu.Text);
                    sprzetNarciarski.twardosc_nart = int.Parse(this.tbMiasto.Text);
                    sprzetNarciarski.rozmiar_buta = int.Parse(this.tbPostal.Text);
                    sprzetNarciarski.twardosc_buta = int.Parse(this.tbPostal.Text);
                    sprzetNarciarski.dlugosc_kijkow = int.Parse(this.tbNIP.Text);
                    sprzetNarciarski.koszt_wypozyczenia = kosztWypozyczenia;
                    var repo = new RepozytoriumSprzetu.RepozytoriumSprzetuNarciarskiego();
                    if (sprzetID == 0)
                    {
                        repo.DodajSprzetNarciarski(sprzetNarciarski);
                    }
                    else
                    {
                        repo.EdytujSprzetNarciarski(sprzetNarciarski);
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawny format kosztu wypożyczenia!");
                }
            }
            else if (wybranySprzet == "Sprzęt Snowboard")
            {
                if (decimal.TryParse(tb11.Text, out decimal kosztWypozyczenia))
                {
                    SprzetSnowboard sprzetSnowboard = new SprzetSnowboard();
                    sprzetSnowboard.nr_sprzetS = this.sprzetID;
                    sprzetSnowboard.producent = this.tbNazwisko.Text;
                    sprzetSnowboard.typ = this.tbPesel.Text;
                    sprzetSnowboard.numer_inw = this.tbUlica.Text;
                    sprzetSnowboard.dlugosc_deski = int.Parse(this.tbNumerDomu.Text);
                    sprzetSnowboard.twardosc_deski = int.Parse(this.tbMiasto.Text);
                    sprzetSnowboard.ksztalt_deski = int.Parse(this.tbPostal.Text);
                    sprzetSnowboard.rozmiar_buta = int.Parse(this.tbPostal.Text);
                    sprzetSnowboard.twardosc_buta = int.Parse(this.tbNIP.Text);
                    sprzetSnowboard.koszt_wypozyczenia = kosztWypozyczenia;
                    var repo2 = new RepozytoriumSprzetu.RepozytoriumSprzetuSnowboard();
                    if (sprzetID == 0)
                    {
                        repo2.DodajSprzetSnowboard(sprzetSnowboard);
                    }
                    else
                    {
                        repo2.EdytujSprzetSnowboard(sprzetSnowboard);
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawny format kosztu wypożyczenia!");
                }
            }
            else if (wybranySprzet == "Akcesoria")
            {
                if (decimal.TryParse(tbPostal.Text, out decimal kosztWypozyczenia))
                {
                    Akcesoria akcesoria = new Akcesoria();
                    akcesoria.nr_akcesoria = this.sprzetID;
                    akcesoria.producent = this.tbNazwisko.Text;
                    akcesoria.typ = this.tbPesel.Text;
                    akcesoria.numer_inw = this.tbUlica.Text;
                    akcesoria.rozmiar = this.tbNumerDomu.Text;
                    akcesoria.opis = this.tbMiasto.Text;
                    akcesoria.koszt_wypozyczenia = kosztWypozyczenia;
                    var repo3 = new RepozytoriumAkcesoriow();
                    if (sprzetID == 0)
                    {
                        repo3.DodajAkcesoria(akcesoria);
                    }
                    else
                    {
                        repo3.EdytujAkcesoria(akcesoria);
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawny format kosztu wypożyczenia!");
                }
            }
                            this.DialogResult = DialogResult.OK;
        }
        private void bntAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
