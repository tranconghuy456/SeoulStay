﻿using Module_1.Controllers;
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
        private int iIsEmp = -1;
        private int iUID;
        private int[] dbReturn;
        private bool isSaved = false;
        private LoginModel login;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string Emp = string.IsNullOrEmpty(Properties.Settings.Default.Emp) ? null : Properties.Settings.Default.Emp;
            string Username = string.IsNullOrEmpty(Properties.Settings.Default.Username) ? null : Properties.Settings.Default.Username;
            string Password = string.IsNullOrEmpty(Properties.Settings.Default.Password) ? null : Properties.Settings.Default.Password;
            int isEmp = string.IsNullOrEmpty(Properties.Settings.Default.UserRole) ? -1 : int.Parse(Properties.Settings.Default.UserRole);

            if (((string.IsNullOrEmpty(Emp)) || (string.IsNullOrEmpty(Username))) && (string.IsNullOrEmpty(Password)) && (isEmp < 0))
            {
                this.ActiveControl = txt_Emp;
            }
            else
            {
                isSaved = true;
                Login(Emp, Username, Password, isEmp);
            }
        }

        private void chk_PassShow_CheckedChanged(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = chk_PassShow.Checked ? '\0' : '*';
        }

        private void Login(string Emp, string Username, string Password, int isEmp)
        {
            login = new LoginModel(Emp, Username, Password, isEmp);
            if (login.Connect())
            {
                dbReturn = login.LoginCheckPoint();
                iIsEmp = dbReturn[0];
                iUID = dbReturn[1];

                switch (iIsEmp)
                {
                    case 0:
                        MessageBox.Show("Username or Password is incorrect.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1:
                    case 2:
                        //iIsEmp = iUserRole;
                        if (chk_KeepMeSignedIn.Checked)
                        {
                            isSaved = true;
                            try
                            {
                                Properties.Settings.Default.Emp = strEmp;
                                Properties.Settings.Default.Username = strUsername;
                                Properties.Settings.Default.Password = strPassword;
                                Properties.Settings.Default.UserRole = iIsEmp.ToString();
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
            if (ValidateField() != null)
            {
                string errMessage = ValidateField();
                MessageBox.Show(errMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                Login(strEmp, strUsername, strPassword, iIsEmp);
        }

        //private int RememberMe(int iUserRole)
        //{
        //    if (chk_KeepMeSignedIn.Checked)
        //    {
        //        isSaved = true;
        //        try {
        //            Properties.Settings.Default.Emp = strEmp;
        //            Properties.Settings.Default.Username = strUsername;
        //            Properties.Settings.Default.Password = strPassword;
        //            Properties.Settings.Default.UserRole = iUserRole.ToString();
        //            Properties.Settings.Default.Save();
        //            return 1;
        //        } catch
        //        {
        //            throw;
        //        }
        //    }
        //    return -1;
        //}

        private void OpenManagementForm()
        {
            Application.Run(new frm_Management(iIsEmp, iUID));
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
            } else if(!isSaved)
            {
                if (MessageBox.Show("Are you sure want to exit?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    e.Cancel = true;                
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
