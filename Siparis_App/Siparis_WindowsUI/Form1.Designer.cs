namespace Siparis_WindowsUI
{
    partial class Form1
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
            btnCategories = new Button();
            btnProduct = new Button();
            btnWorker = new Button();
            groupBox1 = new GroupBox();
            btnAddToCard = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            tbxQuantity = new TextBox();
            btnRemoveFromCard = new Button();
            cbxCategory = new ComboBox();
            cbxProduct = new ComboBox();
            lblCategory = new Label();
            lblProduct = new Label();
            btnAddToOrder = new Button();
            lblCard = new Label();
            lstCardItems = new ListView();
            c1 = new ColumnHeader();
            c2 = new ColumnHeader();
            c3 = new ColumnHeader();
            c4 = new ColumnHeader();
            c5 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCategories
            // 
            btnCategories.Location = new Point(41, 25);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(75, 23);
            btnCategories.TabIndex = 0;
            btnCategories.Text = "Kategoriler";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(144, 25);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(75, 23);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Ürünler";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnWorker
            // 
            btnWorker.Location = new Point(258, 25);
            btnWorker.Name = "btnWorker";
            btnWorker.Size = new Size(75, 23);
            btnWorker.TabIndex = 2;
            btnWorker.Text = "Çalışanlar";
            btnWorker.UseVisualStyleBackColor = true;
            btnWorker.Click += btnWorker_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddToCard);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbxQuantity);
            groupBox1.Controls.Add(btnRemoveFromCard);
            groupBox1.Controls.Add(cbxCategory);
            groupBox1.Controls.Add(cbxProduct);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(lblProduct);
            groupBox1.Location = new Point(41, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 241);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sipariş";
            // 
            // btnAddToCard
            // 
            btnAddToCard.Location = new Point(239, 178);
            btnAddToCard.Name = "btnAddToCard";
            btnAddToCard.Size = new Size(120, 57);
            btnAddToCard.TabIndex = 17;
            btnAddToCard.Text = "Sepete Ekle";
            btnAddToCard.UseVisualStyleBackColor = true;
            btnAddToCard.Click += btnAddToCard_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 185);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 19);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mayonez";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 144);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ketçap";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 103);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 14;
            label1.Text = "Adet";
            // 
            // tbxQuantity
            // 
            tbxQuantity.Location = new Point(80, 100);
            tbxQuantity.Name = "tbxQuantity";
            tbxQuantity.Size = new Size(100, 23);
            tbxQuantity.TabIndex = 13;
            tbxQuantity.Text = "1";
            // 
            // btnRemoveFromCard
            // 
            btnRemoveFromCard.Location = new Point(365, 180);
            btnRemoveFromCard.Name = "btnRemoveFromCard";
            btnRemoveFromCard.Size = new Size(120, 55);
            btnRemoveFromCard.TabIndex = 12;
            btnRemoveFromCard.Text = "Sepetten Çıkar";
            btnRemoveFromCard.UseVisualStyleBackColor = true;
            btnRemoveFromCard.Click += btnRemoveFromCard_Click;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(80, 31);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(184, 23);
            cbxCategory.TabIndex = 8;
            cbxCategory.SelectedValueChanged += cbxCategory_SelectedValueChanged;
            cbxCategory.MouseClick += cbxCategory_MouseClick;
            // 
            // cbxProduct
            // 
            cbxProduct.FormattingEnabled = true;
            cbxProduct.Location = new Point(80, 67);
            cbxProduct.Name = "cbxProduct";
            cbxProduct.Size = new Size(184, 23);
            cbxProduct.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(5, 34);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(67, 15);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Kategoriler ";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(6, 69);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(33, 15);
            lblProduct.TabIndex = 4;
            lblProduct.Text = "Ürün";
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(41, 509);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(491, 57);
            btnAddToOrder.TabIndex = 10;
            btnAddToOrder.Text = "Sipariş Oluştur";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // lblCard
            // 
            lblCard.AutoSize = true;
            lblCard.Location = new Point(47, 323);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(68, 15);
            lblCard.TabIndex = 12;
            lblCard.Text = "Sepettekiler";
            // 
            // lstCardItems
            // 
            lstCardItems.Columns.AddRange(new ColumnHeader[] { c1, c2, c3, c4, c5 });
            lstCardItems.FullRowSelect = true;
            lstCardItems.GridLines = true;
            lstCardItems.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstCardItems.Location = new Point(46, 301);
            lstCardItems.MultiSelect = false;
            lstCardItems.Name = "lstCardItems";
            lstCardItems.Size = new Size(486, 202);
            lstCardItems.TabIndex = 13;
            lstCardItems.UseCompatibleStateImageBehavior = false;
            lstCardItems.View = View.Details;
            // 
            // c1
            // 
            c1.Text = "Ürün";
            // 
            // c2
            // 
            c2.Text = "Fiyat";
            // 
            // c3
            // 
            c3.Text = "Adet";
            // 
            // c4
            // 
            c4.Text = "Ketçap";
            // 
            // c5
            // 
            c5.Text = "Mayonez";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(563, 591);
            Controls.Add(lstCardItems);
            Controls.Add(lblCard);
            Controls.Add(groupBox1);
            Controls.Add(btnWorker);
            Controls.Add(btnProduct);
            Controls.Add(btnCategories);
            Controls.Add(btnAddToOrder);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCategories;
        private Button btnProduct;
        private Button btnWorker;
        private GroupBox groupBox1;
        private Button btnRemoveFromCard;
        private Button btnAddToOrder;
        private ComboBox cbxCategory;
        private ComboBox cbxProduct;
        private Label lblCategory;
        private Label lblProduct;
        private Label label1;
        private TextBox tbxQuantity;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnAddToCard;
        private Label lblCard;
        private ListView lstCardItems;
        private ColumnHeader c1;
        private ColumnHeader c2;
        private ColumnHeader c3;
        private ColumnHeader c4;
        private ColumnHeader c5;
    }
}
