using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChuSV : Form
    {
        public TrangChuSV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TrangChuSV_Load(object sender, EventArgs e)
        {

        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
