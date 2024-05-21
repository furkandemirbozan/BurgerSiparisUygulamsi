using Siparis_Bussiness.Concrete;
using Siparis_DAL.Concrete.EfCore;
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
    public partial class FormWorker : Form
    {
        WorkerManager workerManager = new WorkerManager();

        int _id = 0;
        public FormWorker()
        {
            InitializeComponent();
            dgwWorkers.DataSource = workerManager.GetAll();
            dgwWorkers.Columns[0].Visible = false;
            dgwWorkers.Columns[5].Visible = false;



        }

        private void btnWorkerAdd_Click(object sender, EventArgs e)
        {
            if (!(tbxWorkerName.Text == "" ||
                tbxTelefonNO.Text == "" ||
                tbxPozisyon.Text == "" ||
                  tbxMaas.Text == ""))
            {
                Worker worker = new Worker();

                worker.FullName = tbxWorkerName.Text;
                worker.PhoneNumber = tbxTelefonNO.Text;
                worker.Position = tbxPozisyon.Text;
                worker.Salary = Convert.ToInt32(tbxMaas.Text);
                workerManager.Add(worker);
                dgwWorkers.DataSource = workerManager.GetAll();
                tbxWorkerName.Text = String.Empty;
                tbxTelefonNO.Text = String.Empty;
                tbxPozisyon.Text = String.Empty;
                tbxMaas.Text = String.Empty;
            }



        }

        private void btnWorkerDeleted_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Müşteri Seç aq");
                return;
            }

            Worker silWorker = workerManager.GetById(_id);
            if (silWorker != null)
            {

                workerManager.Delete(silWorker);
                dgwWorkers.DataSource = workerManager.GetAll();

                tbxWorkerName.Text = "";
            }
        }

        private void tbxMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Karakter validasyonu 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnWorkerUpdate_Click(object sender, EventArgs e)
        {

            Worker editWorker = workerManager.GetById(_id);

            editWorker.FullName = tbxWorkerName.Text;
            editWorker.PhoneNumber = tbxTelefonNO.Text;
            editWorker.Position = tbxPozisyon.Text;
            editWorker.Salary = Convert.ToInt32(tbxMaas.Text);
            workerManager.Update(editWorker);

            dgwWorkers.DataSource = workerManager.GetAll();
            dgwWorkers.Refresh();



        }
        private void dgwWorkers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwWorkers.Rows[e.RowIndex];
                _id = Int32.Parse(row.Cells[0].Value.ToString());
            }
        }


    }
}
