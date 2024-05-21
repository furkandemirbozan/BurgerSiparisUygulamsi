namespace Siparis_WindowsUI
{
    partial class ProductForm
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
            components = new System.ComponentModel.Container();
            gbxProduct = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            cbxCategory2 = new ComboBox();
            tbxPrice = new TextBox();
            dgwProduct = new DataGridView();
            tbxProductDescription = new TextBox();
            label2 = new Label();
            btnProductDeleted = new Button();
            btnProductUpdated = new Button();
            btnProductAdd = new Button();
            label1 = new Label();
            tbxProductdName = new TextBox();
            productBindingSource = new BindingSource(components);
            productManagerBindingSource = new BindingSource(components);
            gbxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productManagerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gbxProduct
            // 
            gbxProduct.Controls.Add(label4);
            gbxProduct.Controls.Add(label3);
            gbxProduct.Controls.Add(cbxCategory2);
            gbxProduct.Controls.Add(tbxPrice);
            gbxProduct.Controls.Add(dgwProduct);
            gbxProduct.Controls.Add(tbxProductDescription);
            gbxProduct.Controls.Add(label2);
            gbxProduct.Controls.Add(btnProductDeleted);
            gbxProduct.Controls.Add(btnProductUpdated);
            gbxProduct.Controls.Add(btnProductAdd);
            gbxProduct.Controls.Add(label1);
            gbxProduct.Controls.Add(tbxProductdName);
            gbxProduct.Location = new Point(0, 12);
            gbxProduct.Name = "gbxProduct";
            gbxProduct.Size = new Size(616, 410);
            gbxProduct.TabIndex = 1;
            gbxProduct.TabStop = false;
            gbxProduct.Text = "Ürünler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 245);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 12;
            label4.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 196);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "Fiyat :";
            // 
            // cbxCategory2
            // 
            cbxCategory2.Location = new Point(105, 245);
            cbxCategory2.Margin = new Padding(3, 2, 3, 2);
            cbxCategory2.Name = "cbxCategory2";
            cbxCategory2.Size = new Size(106, 23);
            cbxCategory2.TabIndex = 13;
            cbxCategory2.MouseClick += cbxCategory2_MouseClick;
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(105, 189);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(100, 23);
            tbxPrice.TabIndex = 9;
            // 
            // dgwProduct
            // 
            dgwProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProduct.Location = new Point(272, 26);
            dgwProduct.Name = "dgwProduct";
            dgwProduct.RowHeadersWidth = 51;
            dgwProduct.Size = new Size(317, 312);
            dgwProduct.TabIndex = 8;
            dgwProduct.CellClick += dgwProduct_CellClick;
            // 
            // tbxProductDescription
            // 
            tbxProductDescription.Location = new Point(105, 73);
            tbxProductDescription.Multiline = true;
            tbxProductDescription.Name = "tbxProductDescription";
            tbxProductDescription.Size = new Size(100, 91);
            tbxProductDescription.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 81);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "Açıklama :";
            // 
            // btnProductDeleted
            // 
            btnProductDeleted.Location = new Point(136, 370);
            btnProductDeleted.Name = "btnProductDeleted";
            btnProductDeleted.Size = new Size(75, 23);
            btnProductDeleted.TabIndex = 4;
            btnProductDeleted.Text = "Sil";
            btnProductDeleted.UseVisualStyleBackColor = true;
            btnProductDeleted.Click += btnProductDeleted_Click;
            // 
            // btnProductUpdated
            // 
            btnProductUpdated.Location = new Point(136, 327);
            btnProductUpdated.Name = "btnProductUpdated";
            btnProductUpdated.Size = new Size(75, 23);
            btnProductUpdated.TabIndex = 3;
            btnProductUpdated.Text = "Gücelle";
            btnProductUpdated.UseVisualStyleBackColor = true;
            btnProductUpdated.Click += btnProductUpdated_Click;
            // 
            // btnProductAdd
            // 
            btnProductAdd.Location = new Point(136, 287);
            btnProductAdd.Name = "btnProductAdd";
            btnProductAdd.Size = new Size(75, 23);
            btnProductAdd.TabIndex = 2;
            btnProductAdd.Text = "Ekle";
            btnProductAdd.UseVisualStyleBackColor = true;
            btnProductAdd.Click += btnProductAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı : ";
            // 
            // tbxProductdName
            // 
            tbxProductdName.Location = new Point(105, 26);
            tbxProductdName.Name = "tbxProductdName";
            tbxProductdName.Size = new Size(100, 23);
            tbxProductdName.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Siparis_Entities.Concrete.Product);
            // 
            // productManagerBindingSource
            // 
            productManagerBindingSource.DataSource = typeof(Siparis_Bussiness.Concrete.ProductManager);
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(771, 456);
            Controls.Add(gbxProduct);
            Name = "ProductForm";
            Text = "ProductForm";
            gbxProduct.ResumeLayout(false);
            gbxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productManagerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxProduct;
        private Button btnProductDeleted;
        private Button btnProductUpdated;
        private Button btnProductAdd;
        private Label label1;
        private TextBox tbxProductdName;
        private TextBox tbxProductDescription;
        private Label label2;
        private BindingSource productManagerBindingSource;
        private BindingSource productBindingSource;
        private DataGridView dgwProduct;
        private Label label3;
        private TextBox tbxPrice;
        private ComboBox cbxCategory2;
        private Label label4;
    }
}