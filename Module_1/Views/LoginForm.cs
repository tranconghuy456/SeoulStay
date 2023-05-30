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
using Module_1.Context;

namespace Module_1
{
    public partial class LoginForm : Form
    {
        Thread thread;
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool isSaved = false;
        private LoginModel login;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            UserContext.isEmp = Properties.Settings.Default.isEmp < 0 ? -1 : Properties.Settings.Default.isEmp;
            UserContext.Username = string.IsNullOrEmpty(Properties.Settings.Default.Username) ? null : Properties.Settings.Default.Username;
            UserContext.Password = string.IsNullOrEmpty(Properties.Settings.Default.Password) ? null : Properties.Settings.Default.Password;

            if (string.IsNullOrEmpty(UserContext.Username) && (string.IsNullOrEmpty(UserContext.Password)) && (UserContext.isEmp < 0))
            {
                this.ActiveControl = txt_Emp;
                Properties.Settings.Default.Reset();
            }
            else
            {
                isSaved = true;
                Login();
            }
        }

        private void chk_PassShow_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = chk_PassShow.Checked ? '\0' : '*';
        }

        private void Login()
        {
            login = new LoginModel();
            if (login.Connect())
            {
                switch (login.LoginCheckPoint())
                {
                    case -1:
                        MessageBox.Show("Username or Password is incorrect.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                    case 2:
                        if (chk_KeepMeSignedIn.Checked)
                        {
                            isSaved = true;
                            try
                            {
                                Properties.Settings.Default.Username = UserContext.Username;
                                Properties.Settings.Default.Password = UserContext.Password;
                                Properties.Settings.Default.isEmp = UserContext.isEmp;
                                Properties.Settings.Default.Save();
                            }
                            catch
                            {
                                MessageBox.Show("Something went wrong. Please try again!", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                this.Close();
                                thread = new Thread(OpenManagementForm);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                            }
                        } else
                        {
                            this.Close();
                            thread = new Thread(OpenManagementForm);
                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                        }
                        break;
                    default:
                        MessageBox.Show("Your profile data is missing.\nPlease contact your System Administrator", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (ValidateEmpField() && ValidatePasswordField())
                Login();
        }

        private void OpenManagementForm()
        {
            Application.Run(new frm_Management());
        }

        private void txt_Emp_TextChanged(object sender, EventArgs e)
        {
            txt_Username.ReadOnly = txt_Emp.TextLength > 0 ? true : false;
            UserContext.isEmp = 1;
            UserContext.Username = txt_Emp.Text;
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            txt_Emp.ReadOnly = txt_Username.TextLength > 0 ? true : false;
            UserContext.isEmp = 2;
            UserContext.Username = txt_Username.Text;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((sender as Form).ActiveControl is Button)
            {
              // do something
            } else if(!isSaved)
            {
                if (MessageBox.Show("Are you sure want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    e.Cancel = true;                
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (exit == DialogResult.OK) Application.Exit();
        }

        private void txt_Emp_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmpField();
        }
        private bool ValidateEmpField()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txt_Emp.Text) && string.IsNullOrEmpty(txt_Username.Text))
            {
                status = false;
                errorProvider.SetError(txt_Emp, "Employee or User field is REQUIRED.");
                errorProvider.SetError(txt_Username, "Employee or User field is REQUIRED.");
                return status;
            }
            else
            {
                errorProvider.SetError(txt_Emp, "");
                errorProvider.SetError(txt_Username, "");
                return status;                
            }
        }

        private void txt_Username_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmpField();
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            UserContext.Password = txt_Password.Text;
        }
        private bool ValidatePasswordField()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txt_Emp.Text) && string.IsNullOrEmpty(txt_Username.Text))
            {
                status = false;
                errorProvider.SetError(txt_Emp, "Password field is REQUIRED.");
                return status;
            }
            else
            {
                errorProvider.SetError(txt_Password, "");
                return status;
            }

        }

        private void txt_Password_Validating(object sender, CancelEventArgs e)
        {
            ValidatePasswordField();
        }
    }
}
