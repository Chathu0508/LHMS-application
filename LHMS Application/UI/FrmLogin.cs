using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        LoginBll l = new LoginBll();
        loginDal dal = new loginDal();
        public static string LoggedIn;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtusername.Text.Trim();
            l.password = txtpassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            // checking the login credentials
            bool sucess = dal.loginCheck(l);

            
            //Error Provider for the Username and Error Provider for the password

            if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                usernameerr.SetError(txtusername, "Username is Required");
            }
            else
            {
                usernameerr.SetError(txtusername, string.Empty);

            }
            if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
            {
                passworderr.SetError(txtpassword, "Password is Required");
            }
            else
            {
                passworderr.SetError(txtpassword, string.Empty);
            }

            //if the both textboxs were fill the following code will run
            if (sucess == true)
            {
                //login successful
                MessageBox.Show("Login Success.");
                LoggedIn = l.username;

                using(StreamWriter streamWriter = new StreamWriter("setting.txt"))
                {
                    var data = dal.GetUserIdByUserName(l.username,l.user_type);

                    streamWriter.WriteLine(data.id);
                }

                // need to open Respective Forms based on the User type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //display admin Dashboard
                            FrmAdminDashboard admin = new FrmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "Factory Head":
                        {
                            //display user Dashboard
                            FrmFHDashboard user = new FrmFHDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    case "Department Head":
                        {
                            //display user Dashboard
                            FrmDpDashboard user = new FrmDpDashboard();
                            user.Show();
                            this.Hide();

                            break;
                        }
                    case "Supervisor":
                        {
                            //display user Dashboard
                            FrmSupervisorDashboard user = new FrmSupervisorDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    //case "Department Employees IT":
                    //    {
                    //        //display user Dashboard
                    //        FrmICTDashboard user = new FrmICTDashboard ();
                    //        user.Show();
                    //        this.Hide();
                    //    }
                    //    break;
                    //case "Department Employees Finance":
                    //    {
                    //        //display user Dashboard
                    //        //FrmFinanceDashboard user = new FrmFinanceDashboard();
                    //        //user.Show();
                    //        //this.Hide();
                    //    }
                    //    break;
                    //case "Department Employees HR":
                    //    {
                    //        //display user Dashboard
                    //        //FrmHRDashboard user = new FrmHRDashboard();
                    //        //user.Show();
                    //        //this.Hide();
                    //    }
                    //    break;
                    default:
                        {
                            // Display an Eorror Messsage 
                            MessageBox.Show("Invaild User type");
                        }
                        break;
                }
            }
            else
            {
                //login failed
                MessageBox.Show("Fail to login");
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
