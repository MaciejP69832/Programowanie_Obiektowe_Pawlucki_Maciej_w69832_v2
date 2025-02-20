namespace WypozyczalniaSprzetuNarciarskiego
{
    partial class MenedzerKlientow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnDodajKlienta = new Button();
            btnEdytujKlienta = new Button();
            btnUsunKlienta = new Button();
            tabelaKlientow = new DataGridView();
            bntPowrotdoMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)tabelaKlientow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Copperplate Gothic Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1230, 24);
            label1.TabIndex = 0;
            label1.Text = "Lista Klientów";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDodajKlienta
            // 
            btnDodajKlienta.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDodajKlienta.Location = new Point(12, 36);
            btnDodajKlienta.Name = "btnDodajKlienta";
            btnDodajKlienta.Size = new Size(75, 23);
            btnDodajKlienta.TabIndex = 1;
            btnDodajKlienta.Text = "Dodaj";
            btnDodajKlienta.UseVisualStyleBackColor = true;
            btnDodajKlienta.Click += btnDodajKlienta_Click;
            // 
            // btnEdytujKlienta
            // 
            btnEdytujKlienta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdytujKlienta.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnEdytujKlienta.Location = new Point(1076, 36);
            btnEdytujKlienta.Name = "btnEdytujKlienta";
            btnEdytujKlienta.Size = new Size(75, 23);
            btnEdytujKlienta.TabIndex = 2;
            btnEdytujKlienta.Text = "Edytuj";
            btnEdytujKlienta.UseVisualStyleBackColor = true;
            btnEdytujKlienta.Click += btnEdytujKlienta_Click;
            // 
            // btnUsunKlienta
            // 
            btnUsunKlienta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUsunKlienta.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnUsunKlienta.Location = new Point(1167, 36);
            btnUsunKlienta.Name = "btnUsunKlienta";
            btnUsunKlienta.Size = new Size(75, 23);
            btnUsunKlienta.TabIndex = 3;
            btnUsunKlienta.Text = "Usuń";
            btnUsunKlienta.UseVisualStyleBackColor = true;
            btnUsunKlienta.Click += btnUsunKlienta_Click;
            // 
            // tabelaKlientow
            // 
            tabelaKlientow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabelaKlientow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaKlientow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaKlientow.Location = new Point(12, 62);
            tabelaKlientow.MultiSelect = false;
            tabelaKlientow.Name = "tabelaKlientow";
            tabelaKlientow.RowHeadersVisible = false;
            tabelaKlientow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaKlientow.Size = new Size(1230, 573);
            tabelaKlientow.TabIndex = 4;
            // 
            // bntPowrotdoMenu
            // 
            bntPowrotdoMenu.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            bntPowrotdoMenu.Location = new Point(12, 7);
            bntPowrotdoMenu.Name = "bntPowrotdoMenu";
            bntPowrotdoMenu.Size = new Size(75, 23);
            bntPowrotdoMenu.TabIndex = 5;
            bntPowrotdoMenu.Text = "Powrót";
            bntPowrotdoMenu.UseVisualStyleBackColor = true;
            bntPowrotdoMenu.Click += bntPowrotdoMenu_Click;
            // 
            // MenedzerKlientow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1254, 647);
            Controls.Add(bntPowrotdoMenu);
            Controls.Add(tabelaKlientow);
            Controls.Add(btnUsunKlienta);
            Controls.Add(btnEdytujKlienta);
            Controls.Add(btnDodajKlienta);
            Controls.Add(label1);
            Name = "MenedzerKlientow";
            Text = "Menedżer Klientów";
            ((System.ComponentModel.ISupportInitialize)tabelaKlientow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnDodajKlienta;
        private Button btnEdytujKlienta;
        private Button btnUsunKlienta;
        private DataGridView tabelaKlientow;
        private Button bntPowrotdoMenu;
    }
}
