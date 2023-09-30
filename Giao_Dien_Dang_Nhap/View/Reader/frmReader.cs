using Giao_Dien_Dang_Nhap.Main;
using Giao_Dien_Dang_Nhap.View.Reader.frmConReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_Dien_Dang_Nhap.View.Reader
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            label1.Parent = guna2PictureBox2;
            label1.BackColor = Color.Transparent;
         
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmGopY frmGopY = new frmGopY();
            frmGopY.MdiParent = this;
            frmGopY.Show();
            frmGopY.Dock = DockStyle.Fill;
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            frmReSachTKhao frmSTK = new frmReSachTKhao();
            frmSTK.MdiParent = this;
            frmSTK.Show();
            frmSTK.Dock = DockStyle.Fill;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmReAllDocument frmReSearch = new frmReAllDocument(); 
            frmReSearch.MdiParent = this;
            frmReSearch.Show();
            frmReSearch.Dock = DockStyle.Fill;
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            frmReResearch1 frmReResearch1 = new frmReResearch1();
            frmReResearch1.MdiParent = this;
            frmReResearch1.Show();
            frmReResearch1.Dock = DockStyle.Fill;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frmReGiaoTrinh frmReGiaoTrinh = new frmReGiaoTrinh();
            frmReGiaoTrinh.MdiParent = this;
            frmReGiaoTrinh.Show();
            frmReGiaoTrinh.Dock = DockStyle.Fill;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frmReSachMuon frmReSachMuon = new frmReSachMuon();
            frmReSachMuon.MdiParent = this;
            frmReSachMuon.Show();
            frmReSachMuon.Dock = DockStyle.Fill;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmReBao frmReBao = new frmReBao();
            frmReBao.MdiParent = this;
            frmReBao.Show();
            frmReBao.Dock = DockStyle.Fill;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
            this.Close();
              
        }
    }
}
