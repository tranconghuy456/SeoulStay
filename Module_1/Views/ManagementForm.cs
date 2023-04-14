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

namespace Module_1.Views
{
    public partial class frm_Management : Form
    {
        private int userRole;
        private int UID;
        public frm_Management(int iIsEmp, int iUID)
        {
            InitializeComponent();
            userRole = iIsEmp;
            UID = iUID;
        }

        private void frm_Management_Load(object sender, EventArgs e)
        {
            switch (userRole)
            {
                case 1:
                    LoadTravlerData();
                    break;
                case 2:
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
            ListingData(dgv_Emp);
            ListingData(dgv_travel);
            dgv_Emp.Columns.Add(btnEdit);
            dgv_Emp.Columns.Add(btnDetails);
        }

        private void LoadTravlerData()
        {
            ListingData(dgv_travel);
            tabCtr_Client.TabPages.Remove(tabpg_Owner);
        }

        private void ListingData(DataGridView dgv)
        {
            DataTable table = new DataTable();
            ManagementModel listing = new ManagementModel();
            table = listing.GetAvailableAssets(UID);
            dgv.DataSource = table;
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
                    Properties.Settings.Default.Emp = null;
                    Properties.Settings.Default.Username = null;
                    Properties.Settings.Default.Password = null;
                    Properties.Settings.Default.UserRole = null;
                    Properties.Settings.Default.Save();
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
            Form ActionForm = new frm_Action(UID);
            ActionForm.ShowDialog();
        }
    }
}
