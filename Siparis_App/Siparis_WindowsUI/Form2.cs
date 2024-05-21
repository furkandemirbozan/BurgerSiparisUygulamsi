using Siparis_Bussiness.Concrete;
using Siparis_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis_WindowsUI
{
    public partial class Form2 : Form
    {
        CategoryManager categoryManager = new CategoryManager();
        int _id = 0;
        public Form2()
        {
            InitializeComponent();
            dgwCategory2.DataSource = categoryManager.GetAll();
            dgwCategory2.Columns[0].Visible = false;
            dgwCategory2.Columns[2].Visible = false;
            dgwCategory2.Columns[3].Visible = false;


            btnCategoryUpdated.Enabled = false;
            btnCategoryDeleted.Enabled = false;

        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (tbxCategoryName.Text != "")
            {
                Category category = new Category();
                category.Name = tbxCategoryName.Text;
                categoryManager.Add(category);

                dgwCategory2.DataSource = categoryManager.GetAll();
                tbxCategoryName.Text = "";
            }

        }

        private void btnCategoryUpdated_Click(object sender, EventArgs e)
        {
            Category editcategory = categoryManager.GetById(_id);
            editcategory.Name = tbxCategoryName.Text;
            categoryManager.Update(editcategory);
            btnCategoryUpdated.Enabled = false;
            btnCategoryDeleted.Enabled = false;
            tbxCategoryName.Text = "";
        }

        private void dgwCategory2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwCategory2.Rows[e.RowIndex];
                _id = Int32.Parse(row.Cells[0].Value.ToString());
                Category editCategory = categoryManager.GetById(_id);
                tbxCategoryName.Text = editCategory.Name;
                btnCategoryUpdated.Enabled = true;
                btnCategoryDeleted.Enabled = true;

            }
        }

        private void btnCategoryDeleted_Click(object sender, EventArgs e)
        {
            Category silCategory=categoryManager.GetById(_id);
            if (silCategory!=null)
            {
                categoryManager.Delete(silCategory);
                dgwCategory2.DataSource=categoryManager.GetAll();
                btnCategoryUpdated.Enabled = true;
                btnCategoryDeleted.Enabled = true;
                tbxCategoryName.Text = "";
            }

        }
    }
}
