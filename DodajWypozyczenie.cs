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
    public partial class DodajWypozyczenie : Form
    {
        private RepozytoriumWypozyczen repo = new RepozytoriumWypozyczen();
        public DodajWypozyczenie()
        {
            InitializeComponent();
            int nextId = repo.PobierzNastepneIDWypozyczenia();
            lbID.Text = nextId.ToString();
            lbID.Enabled = false;
            AktualizujPola();
        }
        private int clientID = 0;
        public void EdycjaWypozyczenia(Wypozyczenia wypozyczenie)
        {
            Text = "Dodaj Wypozyczenie";
            lbTitle.Text = "Dodaj Wypozyczenie";
            this.lbID.Text = "" + wypozyczenie.nr_wypozyczenia.ToString();
            this.lbID.Enabled = false;
            tbImie.Text = "" + wypozyczenie.pk_klienta;
            tbNazwisko.Text = "" + wypozyczenie.pk_pracownika;
            tbPesel.Text = "" + wypozyczenie.pk_sprzetN;
            tbUlica.Text = "" + wypozyczenie.pk_sprzetS;
            tbNumerDomu.Text = "" + wypozyczenie.pk_akcesoria;
            tbMiasto.Text = "" + wypozyczenie.koszt_wypozyczenia;
            tbPostal.Text = "" + wypozyczenie.data_wypozyczenia;
            tbNIP.Text = "" + wypozyczenie.data_oddanie;
            clientID = wypozyczenie.nr_wypozyczenia;
            label2.Text = "ID Klienta";
            label3.Text = "ID Pracownika";
            label8.Text = "ID Sprzętu N";
            label4.Text = "ID sprzętu S";
            label5.Text = "ID Akcesoria";
            label6.Text = "Koszt wyp.";
            label7.Text = "Data wyp.";
            label10.Text = "Data odd.";
            label9.Visible = false;
            label10.Visible = true;
            tbTelefon.Visible = true;
            tbNIP.Visible = false;
        }
        private void AktualizujPola()
        {
            label2.Text = "ID Klienta";
            label3.Text = "ID Pracownika";
            label8.Text = "ID Sprzętu N";
            label4.Text = "ID sprzętu S";
            label5.Text = "ID Akcesoria";
            label6.Text = "Koszt wyp.";
            label7.Text = "Data wyp.";
            label10.Text = "Data odd.";
            label9.Visible = false;
            label10.Visible = true;
            tbTelefon.Visible = true;
            tbNIP.Visible = false;
        }
        private void btnDodajSprzet_Click(object sender, EventArgs e)
        {
            Wypozyczenia wypozyczenie = new Wypozyczenia();
            wypozyczenie.nr_wypozyczenia = clientID;
            wypozyczenie.pk_klienta = int.Parse(this.tbImie.Text);
            wypozyczenie.pk_pracownika = int.Parse(tbNazwisko.Text);
            wypozyczenie.pk_sprzetN = int.Parse(tbPesel.Text);
            wypozyczenie.pk_sprzetS = int.Parse(tbUlica.Text);
            wypozyczenie.pk_akcesoria = int.Parse(tbNumerDomu.Text);
            wypozyczenie.koszt_wypozyczenia = int.Parse(tbMiasto.Text);
            wypozyczenie.data_wypozyczenia = DateTime.Parse(this.tbPostal.Text);
            wypozyczenie.data_oddanie = this.tbNIP.Text;
            Text = "Dodaj Wypozyczenie";
            lbTitle.Text = "Dodaj Wypozyczenie";
            this.lbID.Text = "" + wypozyczenie.nr_wypozyczenia.ToString();
            this.lbID.Enabled = false;
            this.tbImie.Text = "" + wypozyczenie.pk_klienta;
            this.tbNazwisko.Text = "" + wypozyczenie.pk_pracownika;
            this.tbPesel.Text = "" + wypozyczenie.pk_sprzetN;
            this.tbUlica.Text = "" + wypozyczenie.pk_sprzetS;
            this.tbNumerDomu.Text = "" + wypozyczenie.pk_akcesoria;
            this.tbMiasto.Text = "" + wypozyczenie.koszt_wypozyczenia;
            this.tbPostal.Text = "" + wypozyczenie.data_wypozyczenia;
            this.tbNIP.Text = "" + wypozyczenie.data_oddanie;
            this.clientID = wypozyczenie.nr_wypozyczenia;
            var repo = new RepozytoriumWypozyczen();
            if (clientID == 0)
            {
                repo.StworzWypozyczenie(wypozyczenie);
            }
            else
            {
                repo.EdytujWypozyczenie(wypozyczenie);
            }
        }

        private void bntAnuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
