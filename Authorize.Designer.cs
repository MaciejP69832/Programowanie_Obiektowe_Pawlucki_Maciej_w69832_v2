namespace WypozyczalniaSprzetuNarciarskiego
{
    partial class Authorize
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
            label2 = new Label();
            cbLogins = new ComboBox();
            btnZaloguj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 40);
            label1.TabIndex = 0;
            label1.Text = "Panel Logowania";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 49);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Wybierz użytkownika";
            // 
            // cbLogins
            // 
            cbLogins.FormattingEnabled = true;
            cbLogins.Location = new Point(339, 109);
            cbLogins.Name = "cbLogins";
            cbLogins.Size = new Size(121, 23);
            cbLogins.TabIndex = 2;
            cbLogins.Text = "Wybierz...";
            // 
            // btnZaloguj
            // 
            btnZaloguj.Location = new Point(365, 149);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(75, 23);
            btnZaloguj.TabIndex = 3;
            btnZaloguj.Text = "Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = true;
            btnZaloguj.Click += btnZaloguj_Click;
            // 
            // Authorize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZaloguj);
            Controls.Add(cbLogins);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Authorize";
            Text = "Authorize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbLogins;
        private Button btnZaloguj;
    }
}