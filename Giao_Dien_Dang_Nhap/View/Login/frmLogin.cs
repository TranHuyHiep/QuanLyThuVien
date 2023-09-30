using Giao_Dien_Dang_Nhap.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_Dien_Dang_Nhap
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmForgetPassword frmForgetPassword = new frmForgetPassword();  
            frmForgetPassword.ShowDialog();
            this.Close();
        }
    }
}
