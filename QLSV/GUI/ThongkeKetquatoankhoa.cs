using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class ThongkeKetquatoankhoa : Form
    {
        BUS_SinhVien sv = new BUS_SinhVien();
        public ThongkeKetquatoankhoa()
        {
            InitializeComponent();
        }

        private void ThongkeKetquatoankhoa_Load(object sender, EventArgs e)
        {
            sv.SinhVien();
            this.reportViewer1.RefreshReport();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'DataSetKetquatoankhoa.ketquatoankhoa' table. You can move, or remove it, as needed.
            this.ketquatoankhoaTableAdapter.Fill(this.DataSetKetquatoankhoa.ketquatoankhoa, txtMaSV.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
