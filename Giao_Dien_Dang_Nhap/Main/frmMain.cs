using Giao_Dien_Dang_Nhap.View.Reader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_Dien_Dang_Nhap.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLíDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibrarian frmLibrarian = new frmLibrarian();
            frmLibrarian.ShowDialog();
            this.Close();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReader frmReader = new frmReader(); 
            frmReader.ShowDialog();
            this.Close();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChart frmChart = new frmChart();
            frmChart.ShowDialog();
            this.Close();
        }
    }
}
