using Module_1_Rebuilt.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module_1_Rebuilt.BLL;
using Module_1_Rebuilt.GUI;
using System.Threading;
using System.Configuration;

namespace Module_1_Rebuilt
{
    public partial class frm_Login : Form
    {
        private LoginRegister login = new LoginRegister();
        private bool isSaved = Properties.Settings.Default.RememberMe;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).ActiveControl is Button)
            {
                // do something
            }
            else if (!isSaved)
            {
                if (MessageBox.Show("Are you sure want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            ValidationContext context = new ValidationContext(UserContext.Instance, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(UserContext.Instance, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    if (result.ErrorMessage.Contains("Username"))
                        MessageBox.Show("The Employee or " + result.ErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show(result.ErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
                ActionLogin();
        }

        private void ActionLogin()
        {
            DataTable result = new DataTable();
            result = login.LoginCheckPoint();
            if (result != null) {
                long res_code = (long)result.Rows[0]["RES_CODE"];
                string res_msg = result.Rows[0]["RES_MSG"].ToString();

                switch (res_code)
                {
                    case -1:
                        MessageBox.Show(res_msg, "Authentication Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                    case 2:
                        // Binding userdata to Project settings
                        Properties.Settings.Default.UID = UserContext.Instance.UID = (long)result.Rows[0]["ID"];
                        Properties.Settings.Default.UserTypeID = UserContext.Instance.UserTypeID = (long)result.Rows[0]["RES_CODE"];
                        Properties.Settings.Default.Username = UserContext.Instance.Username;
                        Properties.Settings.Default.Password = UserContext.Instance.Password;
                        Properties.Settings.Default.RememberMe = isSaved;
                        Properties.Settings.Default.Save();

                        // Binding userdata to UserContext
                        UserContext.Instance.FullName = (string)result.Rows[0]["FullName"];
                        UserContext.Instance.Gender = (Boolean)result.Rows[0]["Gender"];
                        UserContext.Instance.BirthDate = (DateTime)result.Rows[0]["BirthDate"];
                        UserContext.Instance.FamilyCount = (int)result.Rows[0]["FamilyCount"];

                        // Redirect to Management form
                        ThreadForm();
                        break;
                    default:
                        MessageBox.Show("Something went wrong. Please try again!", "Authentication Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                
            } else
                MessageBox.Show("Something went wrong. Please try again!", "Authentication Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_Emp_TextChanged(object sender, EventArgs e)
        {
            txt_Username.Enabled = string.IsNullOrEmpty(txt_Emp.Text) ? true : false;
            UserContext.Instance.Username = txt_Emp.Text;
            UserContext.Instance.UserTypeID = 1;
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            txt_Emp.Enabled = string.IsNullOrEmpty(txt_Username.Text) ? true : false;
            UserContext.Instance.Username = txt_Username.Text;
            UserContext.Instance.UserTypeID = 2;
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            UserContext.Instance.Password = txt_Password.Text;
        }


        private void ThreadForm()
        {
            this.Close();
            Thread thread = new Thread(OpenManagementForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void OpenManagementForm()
        {
            Application.Run(new ManagementForm());
        }

        private void chk_ShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = chk_ShowPwd.Checked ? '\0' : '*';
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            bool isNull = false;
            if (isSaved)
            {
                // Loop through Properties.Settings.Default
                foreach (SettingsProperty currentProp in Properties.Settings.Default.Properties)
                    isNull = Properties.Settings.Default[currentProp.Name] == null ? false : true;
                if (isNull == true)
                {
                    // Binding to UserContext
                    UserContext.Instance.Username = Properties.Settings.Default.Username;
                    UserContext.Instance.Password = Properties.Settings.Default.Password;
                    UserContext.Instance.UserTypeID = Properties.Settings.Default.UserTypeID;
                    ActionLogin();
                }
            }
        }

        private void chk_RememberMe_CheckedChanged(object sender, EventArgs e)
        {
            isSaved = chk_RememberMe.Checked ? true : false;
        }
    }
}
