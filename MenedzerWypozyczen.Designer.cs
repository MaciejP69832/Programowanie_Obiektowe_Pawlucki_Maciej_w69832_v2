namespace WypozyczalniaSprzetuNarciarskiego
{
    partial class MenedzerWypozyczen
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
            bntPowrotdoMenu = new Button();
            tabelaKlientow = new DataGridView();
            btnUsunKlienta = new Button();
            btnEdytujKlienta = new Button();
            btnDodajKlienta = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabelaKlientow).BeginInit();
            SuspendLayout();
            // 
            // bntPowrotdoMenu
            // 
            bntPowrotdoMenu.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bntPowrotdoMenu.Location = new Point(5, 1);
            bntPowrotdoMenu.Name = "bntPowrotdoMenu";
            bntPowrotdoMenu.Size = new Size(75, 23);
            bntPowrotdoMenu.TabIndex = 11;
            bntPowrotdoMenu.Text = "Powrót";
            bntPowrotdoMenu.UseVisualStyleBackColor = true;
            bntPowrotdoMenu.Click += bntPowrotdoMenu_Click;
            // 
            // tabelaKlientow
            // 
            tabelaKlientow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabelaKlientow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaKlientow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaKlientow.Location = new Point(5, 56);
            tabelaKlientow.MultiSelect = false;
            tabelaKlientow.Name = "tabelaKlientow";
            tabelaKlientow.RowHeadersVisible = false;
            tabelaKlientow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaKlientow.Size = new Size(1201, 543);
            tabelaKlientow.TabIndex = 10;
            // 
            // btnUsunKlienta
            // 
            btnUsunKlienta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUsunKlienta.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnUsunKlienta.Location = new Point(1131, 30);
            btnUsunKlienta.Name = "btnUsunKlienta";
            btnUsunKlienta.Size = new Size(75, 23);
            btnUsunKlienta.TabIndex = 9;
            btnUsunKlienta.Text = "Usuń";
            btnUsunKlienta.UseVisualStyleBackColor = true;
            // 
            // btnEdytujKlienta
            // 
            btnEdytujKlienta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdytujKlienta.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnEdytujKlienta.Location = new Point(1040, 30);
            btnEdytujKlienta.Name = "btnEdytujKlienta";
            btnEdytujKlienta.Size = new Size(75, 23);
            btnEdytujKlienta.TabIndex = 8;
            btnEdytujKlienta.Text = "Edytuj";
            btnEdytujKlienta.UseVisualStyleBackColor = true;
            btnEdytujKlienta.Click += btnEdytujKlienta_Click;
            // 
            // btnDodajKlienta
            // 
            btnDodajKlienta.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodajKlienta.Location = new Point(5, 30);
            btnDodajKlienta.Name = "btnDodajKlienta";
            btnDodajKlienta.Size = new Size(75, 23);
            btnDodajKlienta.TabIndex = 7;
            btnDodajKlienta.Text = "Dodaj";
            btnDodajKlienta.UseVisualStyleBackColor = true;
            btnDodajKlienta.Click += btnDodajKlienta_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Copperplate Gothic Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 3);
            label1.Name = "label1";
            label1.Size = new Size(1201, 24);
            label1.TabIndex = 6;
            label1.Text = "Aktualne Wypozyczenia";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenedzerWypozyczen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 601);
            Controls.Add(bntPowrotdoMenu);
            Controls.Add(tabelaKlientow);
            Controls.Add(btnUsunKlienta);
            Controls.Add(btnEdytujKlienta);
            Controls.Add(btnDodajKlienta);
            Controls.Add(label1);
            Name = "MenedzerWypozyczen";
            Text = "MenedzerWypozyczen";
            ((System.ComponentModel.ISupportInitialize)tabelaKlientow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bntPowrotdoMenu;
        private DataGridView tabelaKlientow;
        private Button btnUsunKlienta;
        private Button btnEdytujKlienta;
        private Button btnDodajKlienta;
        private Label label1;
    }
}