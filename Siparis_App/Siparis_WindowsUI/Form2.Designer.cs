namespace Siparis_WindowsUI
{
    partial class Form2
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
            gbxCategory = new GroupBox();
            dgwCategory2 = new DataGridView();
            btnCategoryDeleted = new Button();
            btnCategoryUpdated = new Button();
            btnCategoryAdd = new Button();
            label1 = new Label();
            tbxCategoryName = new TextBox();
            gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCategory2).BeginInit();
            SuspendLayout();
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(dgwCategory2);
            gbxCategory.Controls.Add(btnCategoryDeleted);
            gbxCategory.Controls.Add(btnCategoryUpdated);
            gbxCategory.Controls.Add(btnCategoryAdd);
            gbxCategory.Controls.Add(label1);
            gbxCategory.Controls.Add(tbxCategoryName);
            gbxCategory.Location = new Point(15, 27);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(618, 220);
            gbxCategory.TabIndex = 0;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategori";
            // 
            // dgwCategory2
            // 
            dgwCategory2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCategory2.Location = new Point(255, 26);
            dgwCategory2.Name = "dgwCategory2";
            dgwCategory2.RowHeadersWidth = 51;
            dgwCategory2.Size = new Size(356, 174);
            dgwCategory2.TabIndex = 5;
            dgwCategory2.CellClick += dgwCategory2_CellClick;
            // 
            // btnCategoryDeleted
            // 
            btnCategoryDeleted.Location = new Point(130, 177);
            btnCategoryDeleted.Name = "btnCategoryDeleted";
            btnCategoryDeleted.Size = new Size(75, 23);
            btnCategoryDeleted.TabIndex = 4;
            btnCategoryDeleted.Text = "Sil";
            btnCategoryDeleted.UseVisualStyleBackColor = true;
            btnCategoryDeleted.Click += btnCategoryDeleted_Click;
            // 
            // btnCategoryUpdated
            // 
            btnCategoryUpdated.Location = new Point(130, 126);
            btnCategoryUpdated.Name = "btnCategoryUpdated";
            btnCategoryUpdated.Size = new Size(75, 23);
            btnCategoryUpdated.TabIndex = 3;
            btnCategoryUpdated.Text = "Gücelle";
            btnCategoryUpdated.UseVisualStyleBackColor = true;
            btnCategoryUpdated.Click += btnCategoryUpdated_Click;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.Location = new Point(130, 84);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(75, 23);
            btnCategoryAdd.TabIndex = 2;
            btnCategoryAdd.Text = "Ekle";
            btnCategoryAdd.UseVisualStyleBackColor = true;
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-4, 32);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Kategori  Adı : ";
            // 
            // tbxCategoryName
            // 
            tbxCategoryName.Location = new Point(105, 26);
            tbxCategoryName.Name = "tbxCategoryName";
            tbxCategoryName.Size = new Size(100, 23);
            tbxCategoryName.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(655, 250);
            Controls.Add(gbxCategory);
            Name = "Form2";
            Text = "Form2";
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCategory2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxCategory;
        private TextBox tbxCategoryName;
        private DataGridView dgwCategory2;
        private Button btnCategoryDeleted;
        private Button btnCategoryUpdated;
        private Button btnCategoryAdd;
        private Label label1;
    }
}