using Module_1.Controllers;
using Module_1.Models;
using Module_1.Views;
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

namespace Module_1
{
    public partial class LoginForm : Form
    {
        Thread thread;
        public LoginForm()
        {
            InitializeComponent();
        }

        private string strUsername, strPassword, strEmp;
        private int iIsEmp = 2;
        private LoginModel login;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != string.Empty)
                txt_Username.Text = Properties.Settings.Default.Username;
            this.ActiveControl = txt_Emp;            
        }

        private void chk_PassShow_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = chk_PassShow.Checked ? '\0' : '*';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (ValidateField() != null)
            {
                string errMessage = ValidateField();
                MessageBox.Show(errMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                login = new LoginModel(strEmp, strUsername, strPassword, iIsEmp);
                if (login.Connect())
                {
                    int iUserRole = login.LoginCheckPoint();
                    switch(iUserRole)
                    {
                    case 0:
                            MessageBox.Show("Username or Password is incorrect.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    case 1:
                    case 2:
                            if (RememberMe(iUserRole) > 0) { 
                                this.Close();
                                thread = new Thread(OpenManagementForm);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                            } else
                                MessageBox.Show("Something went wrong. Please try again!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    default:
                            MessageBox.Show("Your profile data is missing.\nPlease contact your System Administrator", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }

        private int RememberMe(int iUserRole)
        {
            if (chk_KeepMeSignedIn.Checked == true)
            {
                try { 
                    Properties.Settings.Default.Username = strUsername;
                    Properties.Settings.Default.Password = strPassword;
                    Properties.Settings.Default.UserRole = iUserRole.ToString();
                    Properties.Settings.Default.Save();
                    return 1;
                } catch
                {
                    return -1;
                }
            } else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.UserRole = "";
                Properties.Settings.Default.Save();
                return 1;
            }
        }

        private void OpenManagementForm()
        {
            Application.Run(new frm_Management());
        }

        private void txt_Emp_TextChanged(object sender, EventArgs e)
        {
            txt_Username.ReadOnly = txt_Emp.TextLength > 0 ? true : false;
            iIsEmp = 1;
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            txt_Emp.ReadOnly = txt_Username.TextLength > 0 ? true : false;
            iIsEmp = 2;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).ActiveControl is Button)
            {
                // do something
            } else
            {
                if (MessageBox.Show("Are you sure want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private string ValidateField()
        {
            strUsername = txt_Username.Text;
            strPassword = txt_Password.Text;
            strEmp = txt_Emp.Text;
            
            if (strUsername == "" && strEmp == "")
            {
                txt_Emp.Focus();
                return "Employee or User field is REQUIRED.";
            }
            else if (strPassword == "")
            {
                txt_Password.Focus();
                return (strPassword == "" ? "Password field is REQUIRED." : null);
            }
            return null;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK) Application.Exit();
        }
    }
}
