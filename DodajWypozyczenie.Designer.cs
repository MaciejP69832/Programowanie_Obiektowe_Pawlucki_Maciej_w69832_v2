namespace WypozyczalniaSprzetuNarciarskiego
{
    partial class DodajWypozyczenie
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
            tbImie = new TextBox();
            bntAnuluj = new Button();
            btnDodajSprzet = new Button();
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
            SuspendLayout();
            // 
            // tbUlica
            // 
            tbUlica.Location = new Point(298, 210);
            tbUlica.Name = "tbUlica";
            tbUlica.Size = new Size(220, 23);
            tbUlica.TabIndex = 38;
            // 
            // tbPesel
            // 
            tbPesel.Location = new Point(298, 181);
            tbPesel.Name = "tbPesel";
            tbPesel.Size = new Size(220, 23);
            tbPesel.TabIndex = 37;
            // 
            // tbImie
            // 
            tbImie.ForeColor = SystemColors.WindowText;
            tbImie.Location = new Point(298, 123);
            tbImie.Name = "tbImie";
            tbImie.Size = new Size(220, 23);
            tbImie.TabIndex = 35;
            // 
            // bntAnuluj
            // 
            bntAnuluj.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bntAnuluj.Location = new Point(443, 399);
            bntAnuluj.Name = "bntAnuluj";
            bntAnuluj.Size = new Size(75, 23);
            bntAnuluj.TabIndex = 45;
            bntAnuluj.Text = "Anuluj";
            bntAnuluj.UseVisualStyleBackColor = true;
            bntAnuluj.Click += bntAnuluj_Click;
            // 
            // btnDodajSprzet
            // 
            btnDodajSprzet.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodajSprzet.Location = new Point(298, 399);
            btnDodajSprzet.Name = "btnDodajSprzet";
            btnDodajSprzet.Size = new Size(75, 23);
            btnDodajSprzet.TabIndex = 44;
            btnDodajSprzet.Text = "Dodaj";
            btnDodajSprzet.UseVisualStyleBackColor = true;
            btnDodajSprzet.Click += btnDodajSprzet_Click;
            // 
            // tbTelefon
            // 
            tbTelefon.Location = new Point(298, 326);
            tbTelefon.Name = "tbTelefon";
            tbTelefon.Size = new Size(220, 23);
            tbTelefon.TabIndex = 42;
            // 
            // tbPostal
            // 
            tbPostal.Location = new Point(298, 297);
            tbPostal.Name = "tbPostal";
            tbPostal.Size = new Size(220, 23);
            tbPostal.TabIndex = 41;
            // 
            // tbNazwisko
            // 
            tbNazwisko.Location = new Point(298, 152);
            tbNazwisko.Name = "tbNazwisko";
            tbNazwisko.Size = new Size(220, 23);
            tbNazwisko.TabIndex = 36;
            // 
            // tbNIP
            // 
            tbNIP.Location = new Point(298, 355);
            tbNIP.Name = "tbNIP";
            tbNIP.Size = new Size(220, 23);
            tbNIP.TabIndex = 43;
            // 
            // tbMiasto
            // 
            tbMiasto.Location = new Point(298, 268);
            tbMiasto.Name = "tbMiasto";
            tbMiasto.Size = new Size(220, 23);
            tbMiasto.TabIndex = 40;
            // 
            // tbNumerDomu
            // 
            tbNumerDomu.Location = new Point(298, 239);
            tbNumerDomu.Name = "tbNumerDomu";
            tbNumerDomu.Size = new Size(220, 23);
            tbNumerDomu.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(212, 329);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 34;
            label10.Text = "Telefon";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(212, 358);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 33;
            label9.Text = "NIP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 184);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 32;
            label8.Text = "PESEL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 300);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 31;
            label7.Text = "Kod pocztowy";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 276);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 30;
            label6.Text = "Miasto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 242);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 29;
            label5.Text = "Numer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 213);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 28;
            label4.Text = "Ulica";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 155);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 27;
            label3.Text = "Nazwisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 126);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 26;
            label2.Text = "Imię";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(394, 79);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 15);
            lbID.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 79);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 24;
            label1.Text = "ID Klienta";
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.Font = new Font("Copperplate Gothic Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 28);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(776, 26);
            lbTitle.TabIndex = 23;
            lbTitle.Text = "Dodaj Klienta";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // DodajWypozyczenie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbUlica);
            Controls.Add(tbPesel);
            Controls.Add(tbImie);
            Controls.Add(bntAnuluj);
            Controls.Add(btnDodajSprzet);
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
            Name = "DodajWypozyczenie";
            Text = "DodajWypozyczenie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUlica;
        private TextBox tbPesel;
        private TextBox tbImie;
        private Button bntAnuluj;
        private Button btnDodajSprzet;
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
    }
}