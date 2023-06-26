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
    public partial class ThongKeDiemSVtheoki : Form
    {
        BUS_SinhVien sv = new BUS_SinhVien();
        public ThongKeDiemSVtheoki()
        {
            InitializeComponent();
        }

        private void ThongKeDiemSVtheoky_Load(object sender, EventArgs e)
        {

            sv.SinhVien();
            this.reportViewer1.RefreshReport();
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetKetquatheoki.diemSVtheoki' table. You can move, or remove it, as needed.
            this.diemSVtheokiTableAdapter.Fill(this.DataSetKetquatheoki.diemSVtheoki, txtMaSV.Text,comboBox1.SelectedItem.ToString(),cbNamHoc.SelectedItem.ToString());


            this.reportViewer1.RefreshReport();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
