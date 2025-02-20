namespace WypozyczalniaSprzetuNarciarskiego
{
    partial class DodajSprzet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbUlica = new TextBox();
            tbPesel = new TextBox();
            bntAnuluj = new Button();
            btnDodaj = new Button();
            tbTelefon = new TextBox();
            tbPostal = new TextBox();
            tbNazwisko = new TextBox();
            tbNIP = new TextBox();
            tbMiasto = new TextBox();
            tbNumerDomu = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbID = new Label();
            label1 = new Label();
            lbTitle = new Label();
            cbRodzajSprzetu = new ComboBox();
            label11 = new Label();
            tb11 = new TextBox();
            SuspendLayout();
            // 
            // tbUlica
            // 
            tbUlica.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbUlica.Location = new Point(298, 194);
            tbUlica.Name = "tbUlica";
            tbUlica.Size = new Size(220, 23);
            tbUlica.TabIndex = 38;
            // 
            // tbPesel
            // 
            tbPesel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPesel.Location = new Point(298, 165);
            tbPesel.Name = "tbPesel";
            tbPesel.Size = new Size(220, 23);
            tbPesel.TabIndex = 37;
            // 
            // bntAnuluj
            // 
            bntAnuluj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bntAnuluj.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bntAnuluj.Location = new Point(443, 408);
            bntAnuluj.Name = "bntAnuluj";
            bntAnuluj.Size = new Size(75, 23);
            bntAnuluj.TabIndex = 45;
            bntAnuluj.Text = "Anuluj";
            bntAnuluj.UseVisualStyleBackColor = true;
            bntAnuluj.Click += bntAnuluj_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDodaj.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodaj.Location = new Point(298, 408);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(75, 23);
            btnDodaj.TabIndex = 44;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // tbTelefon
            // 
            tbTelefon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbTelefon.Location = new Point(298, 310);
            tbTelefon.Name = "tbTelefon";
            tbTelefon.Size = new Size(220, 23);
            tbTelefon.TabIndex = 42;
            // 
            // tbPostal
            // 
            tbPostal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbPostal.Location = new Point(298, 281);
            tbPostal.Name = "tbPostal";
            tbPostal.Size = new Size(220, 23);
            tbPostal.TabIndex = 41;

            // 
            // tbNazwisko
            // 
            tbNazwisko.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNazwisko.Location = new Point(298, 136);
            tbNazwisko.Name = "tbNazwisko";
            tbNazwisko.Size = new Size(220, 23);
            tbNazwisko.TabIndex = 36;
            // 
            // tbNIP
            // 
            tbNIP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNIP.Location = new Point(298, 339);
            tbNIP.Name = "tbNIP";
            tbNIP.Size = new Size(220, 23);
            tbNIP.TabIndex = 43;
            // 
            // tbMiasto
            // 
            tbMiasto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbMiasto.Location = new Point(298, 252);
            tbMiasto.Name = "tbMiasto";
            tbMiasto.Size = new Size(220, 23);
            tbMiasto.TabIndex = 40;
            // 
            // tbNumerDomu
            // 
            tbNumerDomu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNumerDomu.Location = new Point(298, 223);
            tbNumerDomu.Name = "tbNumerDomu";
            tbNumerDomu.Size = new Size(220, 23);
            tbNumerDomu.TabIndex = 39;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(212, 313);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 34;
            label10.Text = "Telefon";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(212, 342);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 33;
            label9.Text = "NIP";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(212, 168);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 32;
            label8.Text = "Typ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(212, 284);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 31;
            label7.Text = "Kod pocztowy";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(212, 260);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 30;
            label6.Text = "Opis akc.";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(212, 226);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 29;
            label5.Text = "Rozmiar";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(212, 197);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 28;
            label4.Text = "Barcode";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(212, 139);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 27;
            label3.Text = "Producent";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(212, 110);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 26;
            label2.Text = "Rodzaj Sprzętu";
            // 
            // lbID
            // 
            lbID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbID.AutoSize = true;
            lbID.Location = new Point(394, 88);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 15);
            lbID.TabIndex = 25;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(212, 88);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 24;
            label1.Text = "ID Sprzętu";
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.Font = new Font("Copperplate Gothic Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 28);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(776, 26);
            lbTitle.TabIndex = 23;
            lbTitle.Text = "Dodaj Sprzet";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbRodzajSprzetu
            // 
            cbRodzajSprzetu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbRodzajSprzetu.FormattingEnabled = true;
            cbRodzajSprzetu.Location = new Point(298, 107);
            cbRodzajSprzetu.Name = "cbRodzajSprzetu";
            cbRodzajSprzetu.Size = new Size(220, 23);
            cbRodzajSprzetu.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(212, 371);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 47;
            label11.Text = "Koszt wyp.";
            // 
            // tb11
            // 
            tb11.Location = new Point(298, 368);
            tb11.Name = "tb11";
            tb11.Size = new Size(220, 23);
            tb11.TabIndex = 48;
            // 
            // DodajSprzet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 459);
            Controls.Add(tb11);
            Controls.Add(label11);
            Controls.Add(cbRodzajSprzetu);
            Controls.Add(tbUlica);
            Controls.Add(tbPesel);
            Controls.Add(bntAnuluj);
            Controls.Add(btnDodaj);
            Controls.Add(tbTelefon);
            Controls.Add(tbPostal);
            Controls.Add(tbNazwisko);
            Controls.Add(tbNIP);
            Controls.Add(tbMiasto);
            Controls.Add(tbNumerDomu);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbID);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Name = "DodajSprzet";
            Text = "DodajSprzet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUlica;
        private TextBox tbPesel;
        private Button bntAnuluj;
        private Button btnDodaj;
        private TextBox tbTelefon;
        private TextBox tbPostal;
        private TextBox tbNazwisko;
        private TextBox tbNIP;
        private TextBox tbMiasto;
        private TextBox tbNumerDomu;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbID;
        private Label label1;
        private Label lbTitle;
        private ComboBox cbRodzajSprzetu;
        private Label label11;
        private TextBox tb11;
    }
}