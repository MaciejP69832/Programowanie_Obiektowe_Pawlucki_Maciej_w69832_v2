namespace WypozyczalniaSprzetuNarciarskiego
{
    partial class MenedzerSprzetu
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
            tabelaSprzet = new DataGridView();
            label1 = new Label();
            btnDodajSprzet = new Button();
            btnEdycjaSprzetu = new Button();
            btnUsunSprzet = new Button();
            btnPowrotdomenu = new Button();
            ((System.ComponentModel.ISupportInitialize)tabelaSprzet).BeginInit();
            SuspendLayout();
            // 
            // tabelaSprzet
            // 
            tabelaSprzet.AllowUserToAddRows = false;
            tabelaSprzet.AllowUserToDeleteRows = false;
            tabelaSprzet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabelaSprzet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaSprzet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaSprzet.Location = new Point(12, 69);
            tabelaSprzet.MultiSelect = false;
            tabelaSprzet.Name = "tabelaSprzet";
            tabelaSprzet.RowHeadersVisible = false;
            tabelaSprzet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaSprzet.Size = new Size(1202, 506);
            tabelaSprzet.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Copperplate Gothic Light", 15.75F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1209, 28);
            label1.TabIndex = 1;
            label1.Text = "Lista Sprzetu";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnDodajSprzet
            // 
            btnDodajSprzet.Location = new Point(12, 40);
            btnDodajSprzet.Name = "btnDodajSprzet";
            btnDodajSprzet.Size = new Size(75, 23);
            btnDodajSprzet.TabIndex = 2;
            btnDodajSprzet.Text = "Dodaj";
            btnDodajSprzet.UseVisualStyleBackColor = true;
            btnDodajSprzet.Click += btnDodajSprzet_Click;
            // 
            // btnEdycjaSprzetu
            // 
            btnEdycjaSprzetu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdycjaSprzetu.Location = new Point(1038, 40);
            btnEdycjaSprzetu.Name = "btnEdycjaSprzetu";
            btnEdycjaSprzetu.Size = new Size(75, 23);
            btnEdycjaSprzetu.TabIndex = 3;
            btnEdycjaSprzetu.Text = "Edycja";
            btnEdycjaSprzetu.UseVisualStyleBackColor = true;
            btnEdycjaSprzetu.Click += btnEdycjaSprzetu_Click;
            // 
            // btnUsunSprzet
            // 
            btnUsunSprzet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUsunSprzet.Location = new Point(1139, 40);
            btnUsunSprzet.Name = "btnUsunSprzet";
            btnUsunSprzet.Size = new Size(75, 23);
            btnUsunSprzet.TabIndex = 4;
            btnUsunSprzet.Text = "Usuń";
            btnUsunSprzet.UseVisualStyleBackColor = true;
            btnUsunSprzet.Click += btnUsunSprzet_Click;
            // 
            // btnPowrotdomenu
            // 
            btnPowrotdomenu.Location = new Point(12, 9);
            btnPowrotdomenu.Name = "btnPowrotdomenu";
            btnPowrotdomenu.Size = new Size(75, 23);
            btnPowrotdomenu.TabIndex = 5;
            btnPowrotdomenu.Text = "Powrót";
            btnPowrotdomenu.UseVisualStyleBackColor = true;
            btnPowrotdomenu.Click += btnPowrotdomenu_Click;
            // 
            // MenedzerSprzetu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 587);
            Controls.Add(btnPowrotdomenu);
            Controls.Add(btnUsunSprzet);
            Controls.Add(btnEdycjaSprzetu);
            Controls.Add(btnDodajSprzet);
            Controls.Add(label1);
            Controls.Add(tabelaSprzet);
            Name = "MenedzerSprzetu";
            Text = "Menedżer sprzętu";
            ((System.ComponentModel.ISupportInitialize)tabelaSprzet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaSprzet;
        private Label label1;
        private Button btnDodajSprzet;
        private Button btnEdycjaSprzetu;
        private Button btnUsunSprzet;
        private Button btnPowrotdomenu;
    }
}