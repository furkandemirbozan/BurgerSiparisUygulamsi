namespace Siparis_WindowsUI
{
    partial class Login_Forms
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
            tbxKullanıcıAdi = new TextBox();
            tbxParola = new TextBox();
            btnGiris_Login_Forms = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Parola";
            // 
            // tbxKullanıcıAdi
            // 
            tbxKullanıcıAdi.Location = new Point(115, 31);
            tbxKullanıcıAdi.Name = "tbxKullanıcıAdi";
            tbxKullanıcıAdi.Size = new Size(100, 23);
            tbxKullanıcıAdi.TabIndex = 2;
            // 
            // tbxParola
            // 
            tbxParola.Location = new Point(115, 68);
            tbxParola.Name = "tbxParola";
            tbxParola.Size = new Size(100, 23);
            tbxParola.TabIndex = 3;
            // 
            // btnGiris_Login_Forms
            // 
            btnGiris_Login_Forms.Location = new Point(140, 113);
            btnGiris_Login_Forms.Name = "btnGiris_Login_Forms";
            btnGiris_Login_Forms.Size = new Size(75, 23);
            btnGiris_Login_Forms.TabIndex = 4;
            btnGiris_Login_Forms.Text = "Giriş";
            btnGiris_Login_Forms.UseVisualStyleBackColor = true;
            btnGiris_Login_Forms.Click += btnGiris_Login_Forms_Click;
            // 
            // Login_Forms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 150);
            Controls.Add(btnGiris_Login_Forms);
            Controls.Add(tbxParola);
            Controls.Add(tbxKullanıcıAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login_Forms";
            Text = "Admin Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxKullanıcıAdi;
        private TextBox tbxParola;
        private Button btnGiris_Login_Forms;
    }
}