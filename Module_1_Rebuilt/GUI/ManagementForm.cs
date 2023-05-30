using Module_1_Rebuilt.BLL;
using Module_1_Rebuilt.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_1_Rebuilt.GUI
{
    public partial class ManagementForm : Form
    {
        private ManagementModel management = new ManagementModel();
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to log out?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Properties.Settings.Default.Reset();
                ThreadForm();
            }
        }
        private void ThreadForm()
        {
            this.Close();
            Thread thread = new Thread(OpenLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenLoginForm()
        {
            Application.Run(new frm_Login());
        }

        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
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

            switch (UserContext.Instance.UserTypeID)
            {
                case 1:
                    // is Employee
                    // Load Employee Data
                    dgv_Employee.DataSource = management.LoadUserData(1);
                    lbl_resultEmpCount.Text = management.LoadUserData(1).Rows.Count.ToString() + " item(s) found.";
                    // + Load Traveler Data
                    dgv_Traveler.DataSource = management.LoadUserData(2);
                    dgv_Employee.Columns.Add(btnEdit);
                    dgv_Employee.Columns.Add(btnDetails);
                    break;
                case 2:
                    // is User
                    // Hide Employee Tabpage
                    accessTabCtr.TabPages.Remove(tab_Emp);
                    dgv_Traveler.DataSource = management.LoadUserData(2);
                    lbl_resultTravelCount.Text = management.LoadUserData(1).Rows.Count.ToString() + " item(s) found.";
                    break;
                default:
                    MessageBox.Show("Something went wrong. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Properties.Settings.Default.Reset();
                    ThreadForm();
                    break;
            }
        }

        private void btn_AddListing_Click(object sender, EventArgs e)
        {
            Form frm_ActionForm = new ActionForm();
            frm_ActionForm.ShowDialog();
        }
    }
}
