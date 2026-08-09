using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBacSi_Click(object sender, EventArgs e)
        {
            FrmQuanLyBacSi frm = new FrmQuanLyBacSi();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
