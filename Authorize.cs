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
using static WypozyczalniaSprzetuNarciarskiego.MenuGlowne;

namespace WypozyczalniaSprzetuNarciarskiego
{
    public partial class Authorize : Form
    {
        public Authorize()
        {
            InitializeComponent();
            Authorize_Load();
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);
        }
        private void Authorize_Load()
        {
            cbLogins.Items.Add("Maciek");
            cbLogins.Items.Add("Krzysiek");
            cbLogins.Items.Add("Marcin");
            cbLogins.Items.Add("Andrzej");
            cbLogins.Items.Add("Beata");
            cbLogins.Items.Add("Kasia");
            cbLogins.SelectedIndex = 0; 
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            if (cbLogins.SelectedIndex != -1)
            {
                string selectedLogin = cbLogins.SelectedItem.ToString();
                Session.currentUser = selectedLogin;
                MenuGlowne menuGlowne = new MenuGlowne();
                this.Hide();
                menuGlowne.Show();
            }
            else
            {
                MessageBox.Show("Proszę wybrać login.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
