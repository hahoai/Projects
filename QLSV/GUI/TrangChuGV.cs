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
    public partial class TrangChuGV : Form
    {
        public TrangChuGV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TrangChuGV_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýĐiểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem f = new Diem();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }
    }
}
