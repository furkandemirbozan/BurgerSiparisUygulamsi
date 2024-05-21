namespace Siparis_WindowsUI
{
    partial class FormWorker
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
            dgwWorkers = new DataGridView();
            btnWorkerAdd = new Button();
            btnWorkerDeleted = new Button();
            label1 = new Label();
            tbxWorkerName = new TextBox();
            tbxTelefonNO = new TextBox();
            label2 = new Label();
            tbxMaas = new TextBox();
            label3 = new Label();
            tbxPozisyon = new TextBox();
            label4 = new Label();
            btnWorkerUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwWorkers).BeginInit();
            SuspendLayout();
            // 
            // dgwWorkers
            // 
            dgwWorkers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwWorkers.Location = new Point(12, 255);
            dgwWorkers.Name = "dgwWorkers";
            dgwWorkers.RowHeadersWidth = 51;
            dgwWorkers.Size = new Size(776, 150);
            dgwWorkers.TabIndex = 0;
            dgwWorkers.CellClick += dgwWorkers_CellClick;
            // 
            // btnWorkerAdd
            // 
            btnWorkerAdd.Location = new Point(417, 24);
            btnWorkerAdd.Name = "btnWorkerAdd";
            btnWorkerAdd.Size = new Size(75, 166);
            btnWorkerAdd.TabIndex = 1;
            btnWorkerAdd.Text = "Çalışan Ekle";
            btnWorkerAdd.UseVisualStyleBackColor = true;
            btnWorkerAdd.Click += btnWorkerAdd_Click;
            // 
            // btnWorkerDeleted
            // 
            btnWorkerDeleted.Location = new Point(508, 24);
            btnWorkerDeleted.Name = "btnWorkerDeleted";
            btnWorkerDeleted.Size = new Size(75, 166);
            btnWorkerDeleted.TabIndex = 2;
            btnWorkerDeleted.Text = "İşten Çıkar KOV!";
            btnWorkerDeleted.UseVisualStyleBackColor = true;
            btnWorkerDeleted.Click += btnWorkerDeleted_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 4;
            label1.Text = "Çalışan Ad Soyad";
            // 
            // tbxWorkerName
            // 
            tbxWorkerName.Location = new Point(140, 57);
            tbxWorkerName.Name = "tbxWorkerName";
            tbxWorkerName.Size = new Size(100, 23);
            tbxWorkerName.TabIndex = 5;
            // 
            // tbxTelefonNO
            // 
            tbxTelefonNO.Location = new Point(140, 102);
            tbxTelefonNO.Name = "tbxTelefonNO";
            tbxTelefonNO.Size = new Size(100, 23);
            tbxTelefonNO.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefon Numarası";
            // 
            // tbxMaas
            // 
            tbxMaas.Location = new Point(140, 190);
            tbxMaas.Name = "tbxMaas";
            tbxMaas.Size = new Size(100, 23);
            tbxMaas.TabIndex = 11;
            tbxMaas.KeyPress += tbxMaas_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 10;
            label3.Text = "Maaş";
            // 
            // tbxPozisyon
            // 
            tbxPozisyon.Location = new Point(140, 146);
            tbxPozisyon.Name = "tbxPozisyon";
            tbxPozisyon.Size = new Size(100, 23);
            tbxPozisyon.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Pozisyon";
            // 
            // btnWorkerUpdate
            // 
            btnWorkerUpdate.Location = new Point(608, 24);
            btnWorkerUpdate.Margin = new Padding(3, 2, 3, 2);
            btnWorkerUpdate.Name = "btnWorkerUpdate";
            btnWorkerUpdate.Size = new Size(82, 166);
            btnWorkerUpdate.TabIndex = 12;
            btnWorkerUpdate.Text = "Çalışan bilgisi Güncelle";
            btnWorkerUpdate.UseVisualStyleBackColor = true;
            btnWorkerUpdate.Click += btnWorkerUpdate_Click;
            // 
            // FormWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(924, 514);
            Controls.Add(btnWorkerUpdate);
            Controls.Add(tbxMaas);
            Controls.Add(label3);
            Controls.Add(tbxPozisyon);
            Controls.Add(label4);
            Controls.Add(tbxTelefonNO);
            Controls.Add(label2);
            Controls.Add(tbxWorkerName);
            Controls.Add(label1);
            Controls.Add(btnWorkerDeleted);
            Controls.Add(btnWorkerAdd);
            Controls.Add(dgwWorkers);
            Name = "FormWorker";
            Text = "FormWorker";
            ((System.ComponentModel.ISupportInitialize)dgwWorkers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwWorkers;
        private Button btnWorkerAdd;
        private Button btnWorkerDeleted;
        private Label label1;
        private TextBox tbxWorkerName;
        private TextBox tbxTelefonNO;
        private Label label2;
        private TextBox tbxMaas;
        private Label label3;
        private TextBox tbxPozisyon;
        private Label label4;
        private Button btnWorkerUpdate;
    }
}