namespace Siparis_WindowsUI
{
    partial class LoginForms_1
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
            btnGiris_Login_Forms = new Button();
            tbxParola = new TextBox();
            tbxKullanıcıAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGiris_Login_Forms
            // 
            btnGiris_Login_Forms.Location = new Point(140, 114);
            btnGiris_Login_Forms.Name = "btnGiris_Login_Forms";
            btnGiris_Login_Forms.Size = new Size(75, 23);
            btnGiris_Login_Forms.TabIndex = 9;
            btnGiris_Login_Forms.Text = "Giriş";
            btnGiris_Login_Forms.UseVisualStyleBackColor = true;
            btnGiris_Login_Forms.Click += btnGiris_Login_Forms_Click;
            // 
            // tbxParola
            // 
            tbxParola.Location = new Point(115, 69);
            tbxParola.Name = "tbxParola";
            tbxParola.Size = new Size(100, 23);
            tbxParola.TabIndex = 8;
            // 
            // tbxKullanıcıAdi
            // 
            tbxKullanıcıAdi.Location = new Point(115, 32);
            tbxKullanıcıAdi.Name = "tbxKullanıcıAdi";
            tbxKullanıcıAdi.Size = new Size(100, 23);
            tbxKullanıcıAdi.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 77);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı";
            // 
            // LoginForms_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 159);
            Controls.Add(btnGiris_Login_Forms);
            Controls.Add(tbxParola);
            Controls.Add(tbxKullanıcıAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForms_1";
            Text = "Admin Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris_Login_Forms;
        private TextBox tbxParola;
        private TextBox tbxKullanıcıAdi;
        private Label label2;
        private Label label1;
    }
}