using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.UI;
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

namespace LHMS_Application.Dashboard
{
    public partial class FrmFHDashboard : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FrmFHDashboard()
        {
            InitializeComponent();
            btncloseChildFrom.Visible = false;
            customizeDesign();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btncloseChildFrom.Visible = true;
                }
            }
        }
        private void OpenChildForm(Form childFrom, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            this.pnldashboard.Controls.Add(childFrom);
            this.pnldashboard.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            lblbtitle.Text = childFrom.Text;
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void Reset()
        {
            DisableButton();
            lblbtitle.Text = "HOME DASHBOARD";
            currentButton = null;
            btncloseChildFrom.Visible = false;
        }
        //creaing sub menu to hid the buttons
        private void customizeDesign()
        {
            pnlSubreportmenu.Visible = false;
        }
        private void hidsubmenu()
        {
            if (pnlSubreportmenu.Visible == true)
                pnlSubreportmenu.Visible = false;
        }
        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidsubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btncloseChildFrom_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            LogTrackDal dal = new LogTrackDal();
            LogTrackBll logTrackBillModel = new LogTrackBll();
            loginDal loginDal = new loginDal();

            if (File.Exists("setting.txt"))
            {
                using (StreamReader streamReader = new StreamReader("setting.txt"))
                {
                    var userId = streamReader.ReadLine();
                    var data = loginDal.GetUserByUserId(Convert.ToInt32(userId));
                    logTrackBillModel.id = 1;
                    logTrackBillModel.username = data.username;
                    logTrackBillModel.UserD_id = Convert.ToInt32(userId);
                    logTrackBillModel.InOut = "LogOut";
                    dal.UsrAuthor(logTrackBillModel);
                }
            }
            log.Show();
            this.Hide();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnmaximuze_Click(object sender, EventArgs e)
        {
            {
                if (WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            LogTrackDal dal = new LogTrackDal();
            LogTrackBll logTrackBillModel = new LogTrackBll();
            loginDal loginDal = new loginDal();

            if (File.Exists("setting.txt"))
            {
                using (StreamReader streamReader = new StreamReader("setting.txt"))
                {
                    var userId = streamReader.ReadLine();
                    var data = loginDal.GetUserByUserId(Convert.ToInt32(userId));
                    logTrackBillModel.id = 1;
                    logTrackBillModel.username = data.username;
                    logTrackBillModel.UserD_id = Convert.ToInt32(userId);
                    logTrackBillModel.InOut = "LogOut";
                    dal.UsrAuthor(logTrackBillModel);
                }
            }
            Application.Exit();

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EMForms.FrmuserDetails(), sender);

        }

        private void btntaskr_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports.FrmADtaskprograss(), sender);

        }

        private void btnuserd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports.FrmADUserReports(), sender);

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowSubmenu(pnlSubreportmenu);
        }

        private void btninventorystck_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports.FrmInvenReports(), sender);

        }

        private void btndealersl_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports.FrmDelaerreport(), sender);

        }
    }
}
