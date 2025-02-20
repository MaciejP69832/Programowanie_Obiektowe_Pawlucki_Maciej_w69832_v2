namespace WypozyczalniaSprzetuNarciarskiego
{
    partial class MenuGlowne
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
            label1 = new Label();
            btnMenedzerSprzetu = new Button();
            btnMenedzerKlientow = new Button();
            btnMenedzerWypozyczen = new Button();
            btnLogoff = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 60);
            label1.TabIndex = 0;
            label1.Text = "Menu Główne";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMenedzerSprzetu
            // 
            btnMenedzerSprzetu.Location = new Point(204, 72);
            btnMenedzerSprzetu.Name = "btnMenedzerSprzetu";
            btnMenedzerSprzetu.Size = new Size(122, 63);
            btnMenedzerSprzetu.TabIndex = 1;
            btnMenedzerSprzetu.Text = "Zarządzanie Sprzętem";
            btnMenedzerSprzetu.UseVisualStyleBackColor = true;
            btnMenedzerSprzetu.Click += btnMenedzerSprzetu_Click;
            // 
            // btnMenedzerKlientow
            // 
            btnMenedzerKlientow.Location = new Point(332, 72);
            btnMenedzerKlientow.Name = "btnMenedzerKlientow";
            btnMenedzerKlientow.Size = new Size(122, 63);
            btnMenedzerKlientow.TabIndex = 2;
            btnMenedzerKlientow.Text = "Zarządzanie Klientami";
            btnMenedzerKlientow.UseVisualStyleBackColor = true;
            btnMenedzerKlientow.Click += btnMenedzerKlientow_Click;
            // 
            // btnMenedzerWypozyczen
            // 
            btnMenedzerWypozyczen.Location = new Point(460, 72);
            btnMenedzerWypozyczen.Name = "btnMenedzerWypozyczen";
            btnMenedzerWypozyczen.Size = new Size(122, 63);
            btnMenedzerWypozyczen.TabIndex = 3;
            btnMenedzerWypozyczen.Text = "Zarządzanie Wypożyczeniami";
            btnMenedzerWypozyczen.UseVisualStyleBackColor = true;
            btnMenedzerWypozyczen.Click += btnMenedzerWypozyczen_Click;
            // 
            // btnLogoff
            // 
            btnLogoff.Location = new Point(332, 343);
            btnLogoff.Name = "btnLogoff";
            btnLogoff.Size = new Size(122, 63);
            btnLogoff.TabIndex = 4;
            btnLogoff.Text = "Wyloguj";
            btnLogoff.UseVisualStyleBackColor = true;
            btnLogoff.Click += btnLogoff_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(352, 293);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 5;
            label2.Text = "Zalogowany/a:";
            // 
            // label3
            // 
            label3.Location = new Point(352, 317);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 6;
            // 
            // MenuGlowne
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogoff);
            Controls.Add(btnMenedzerWypozyczen);
            Controls.Add(btnMenedzerKlientow);
            Controls.Add(btnMenedzerSprzetu);
            Controls.Add(label1);
            Name = "MenuGlowne";
            Text = "MenuGlowne";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMenedzerSprzetu;
        private Button btnMenedzerKlientow;
        private Button btnMenedzerWypozyczen;
        private Button btnLogoff;
        private Label label2;
        private Label label3;
    }
}