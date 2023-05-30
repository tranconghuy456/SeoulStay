using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_1.Models;
using Module_1.Context;

namespace Module_1.Views
{
    public partial class frm_Management : Form
    {
        public frm_Management()
        {
            InitializeComponent();
        }

        private void frm_Management_Load(object sender, EventArgs e)
        {
            switch (UserContext.isEmp)
            {
                case 2:
                    LoadTravlerData();
                    break;
                case 1:
                    LoadEmpData();
                    break;
                default:
                    MessageBox.Show("Something went wrong. Please try again!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }
        }

        private void LoadEmpData()
        {
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn()
            {
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn btnDetails = new DataGridViewButtonColumn()
            {
                Text = "Details",
                UseColumnTextForButtonValue = true
            };

            // Listing all Data
            DataTable tableTraveller = new DataTable();
            DataTable tableEmp = new DataTable();
            ManagementModel listing = new ManagementModel();
            tableTraveller = listing.GetTravellerData();
            tableEmp = listing.GetEmpData();
            dgv_travel.DataSource = tableTraveller;
            dgv_Emp.DataSource = tableEmp;

            // Add buttons
            dgv_Emp.Columns.Add(btnEdit);
            dgv_Emp.Columns.Add(btnDetails);
        }

        private void LoadTravlerData()
        {
            DataTable tableTraveller = new DataTable();
            ManagementModel listing = new ManagementModel();
            tableTraveller = listing.GetTravellerData();
            dgv_travel.DataSource = tableTraveller;
            tabCtr_Client.TabPages.Remove(tabpg_Owner);
        }

        private void frm_Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to log out?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    Properties.Settings.Default.Reset();
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Please try again!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AddListing_Click(object sender, EventArgs e)
        {
            Form ActionForm = new frm_Action();
            ActionForm.ShowDialog();
        }
    }
}
