using Siparis_Bussiness.Concrete;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis_WindowsUI
{
    public partial class ProductForm : Form
    {
        ProductManager productManager = new ProductManager();
        CategoryManager categoryManager = new CategoryManager();
        int _id = 0;
        public ProductForm()
        {
            InitializeComponent();
            dgwProduct.DataSource = productManager.GetAll();
            dgwProduct.Refresh();
            dgwProduct.Columns[0].Visible = false;
            dgwProduct.Columns[4].Visible = false;


            cbxCategory2.DataSource = categoryManager.GetAll();
            cbxCategory2.DisplayMember = nameof(Name);
            cbxCategory2.ValueMember = "Id";

            
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {

            if (tbxProductdName.Text != String.Empty)
            {
                var selectedcategory = (Category)cbxCategory2.SelectedItem;
                Product product = new()
                {
                    Name = tbxProductdName.Text,
                    Description = tbxProductDescription.Text,
                    Price = Convert.ToInt32(tbxPrice.Text),
                    CategoryId = selectedcategory.Id

                };
                productManager.Add(product);
                dgwProduct.DataSource = productManager.GetAll();
                dgwProduct.Refresh();

                tbxProductdName.Text = String.Empty;
            }

        }

        private void btnProductUpdated_Click(object sender, EventArgs e)
        {
            Product editProduct = productManager.GetById(_id);

            editProduct.Name = tbxProductdName.Text;
            editProduct.Description = tbxProductDescription.Text;
            editProduct.Price = Convert.ToInt32(tbxPrice.Text);
            productManager.Update(editProduct);


            dgwProduct.DataSource = productManager.GetAll();
            dgwProduct.Refresh();
        }

        private void btnProductDeleted_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Ürüm Seçmediniz!!");
                return;
            }

            Product silProduct = productManager.GetById(_id);
            if (silProduct != null)
            {

                productManager.Delete(silProduct);
                dgwProduct.DataSource = productManager.GetAll();


            }

        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwProduct.Rows[e.RowIndex];
                _id = Int32.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void cbxCategory2_MouseClick(object sender, MouseEventArgs e)
        {
            cbxCategory2.DataSource= categoryManager.GetAll();
        }
    }
}
