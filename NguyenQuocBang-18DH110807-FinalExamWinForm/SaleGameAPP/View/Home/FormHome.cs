using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace SaleGameAPP.View.Home
{
    public partial class FormHome : Form
    {
        private static string mSNV = "";
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public static string MSNV { get => mSNV; set => mSNV = value; }

        public FormHome()
        {
            InitializeComponent();
            timer1.Start();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            mSNV = Properties.Settings.Default.Username;
            if (mSNV !="NV01")
            {
                this.btnManageWorker.Visible = false;
                this.btnManageBill.Visible = false;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lbTitleChildForm.Text = "Home";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            SaleGameAPP.View.Service.FormOrder formOrder = new Service.FormOrder();
            OpenChildForm(formOrder);
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            SaleGameAPP.View.Service.FormGame formGame = new Service.FormGame();
            OpenChildForm(formGame);
        }

        private void btnManageWorker_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            SaleGameAPP.View.Service.FormWorker formWorker = new Service.FormWorker();
            OpenChildForm(formWorker);
        }

        private void btnManageBill_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            SaleGameAPP.View.Service.FormBill formBill = new Service.FormBill();
            OpenChildForm(formBill);
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            SaleGameAPP.View.Service.FormHelp formHelp = new Service.FormHelp();
            OpenChildForm(formHelp);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            int id = dp.AutoIdLogin();
            dp.HistoryLogIn(id, mSNV, "Logout", DateTime.Now);
            Application.Exit();
        }
        private void iconBtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Warning", MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
            {
                MessageBox.Show("GoodBye!");
                DataProvider dp = new DataProvider();
                int id = dp.AutoIdLogin();
                dp.HistoryLogIn(id, mSNV, "Logout", DateTime.Now);
                this.Close();
            }
            
        }
    }
}
