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
    public partial class MenuGlowne : Form
    {
        public static class Session
        {
            public static string currentUser { get; set; }
        }
        public MenuGlowne()
        {
            InitializeComponent();
            label3.Text = Session.currentUser;
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            // Przeniesienie do panelu logowania
            Authorize authorize = new Authorize();
            authorize.Show();
            this.Hide(); // Ukryj stronę logowania
        }

        private void btnMenedzerKlientow_Click(object sender, EventArgs e)
        {
            MenedzerKlientow menedzerKlientow = new MenedzerKlientow();
            menedzerKlientow.Show();
            this.Hide();
        }

        private void btnMenedzerSprzetu_Click(object sender, EventArgs e)
        {
            MenedzerSprzetu menedzerSprzetu = new MenedzerSprzetu();
            menedzerSprzetu.Show();
            this.Hide();
        }

        private void btnMenedzerWypozyczen_Click(object sender, EventArgs e)
        {
            MenedzerWypozyczen menedzerWypozyczen = new MenedzerWypozyczen();
            menedzerWypozyczen.Show();
            this.Hide();
        }
    }
}
