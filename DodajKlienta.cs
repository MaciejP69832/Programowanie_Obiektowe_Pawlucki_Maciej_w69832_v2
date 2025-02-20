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

namespace WypozyczalniaSprzetuNarciarskiego
{
    public partial class DodajKlienta : Form
    {
        private RepozytoriumKlienta repo = new RepozytoriumKlienta();
        public DodajKlienta()
        {
            InitializeComponent();
            int nextId = repo.PobierzNastepneID();
            lbID.Text = nextId.ToString();
            lbID.Enabled = false; 
        }
        private int clientID = 0;
        public void EdycjaKlienta(Klient klient)
        {
            this.Text = "Edytuj Klienta";
            this.lbTitle.Text = "Edytuj Klienta";

            this.lbID.Text = "" + klient.nr_klienta.ToString();
            this.lbID.Enabled = false;
            this.tbImie.Text = "" + klient.imie;
            this.tbNazwisko.Text = "" + klient.nazwisko;
            this.tbPesel.Text = "" + klient.pesel;
            this.tbUlica.Text = "" + klient.ulica;
            this.tbNumerDomu.Text = "" + klient.numerDomu;
            this.tbMiasto.Text = "" + klient.miasto;
            this.tbPostal.Text = "" + klient.postal;
            this.tbNIP.Text = "" + klient.nip;
            this.tbTelefon.Text = "" + klient.nrTelefonu;
            this.clientID = klient.nr_klienta;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient();
            klient.nr_klienta = this.clientID;
            klient.imie = this.tbImie.Text;
            klient.nazwisko = this.tbNazwisko.Text;
            klient.pesel = this.tbPesel.Text;
            klient.ulica = this.tbUlica.Text;
            klient.numerDomu = this.tbNumerDomu.Text;
            klient.miasto = this.tbMiasto.Text;
            klient.postal = this.tbPostal.Text;
            klient.nip = this.tbNIP.Text;
            klient.nrTelefonu = this.tbTelefon.Text;
            var repo = new RepozytoriumKlienta();
            if (clientID == 0)
            {
                repo.StworzKlienta(klient);
            }
            else
            {
                repo.EdytujKlienta(klient);
            }

                this.DialogResult = DialogResult.OK;
        }
        private void bntAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
