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
    public partial class LoginForms_1 : Form
    {
        public LoginForms_1()
        {
            InitializeComponent();
            tbxParola.UseSystemPasswordChar = true;
        }

        private void btnGiris_Login_Forms_Click(object sender, EventArgs e)
        {
            if (tbxKullanıcıAdi.Text == "Furkan" && tbxParola.Text == "123")
            {
                ProductForm productForm = new ProductForm();
                productForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("İZİNSİZ GİRİŞ!!!");
            }
        }
    }
}
