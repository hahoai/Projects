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
    public partial class ThongKeSVtheoLop : Form
    {
        BUS_SinhVien sv = new BUS_SinhVien();

            public ThongKeSVtheoLop()
        {
            InitializeComponent();
        }

        private void ThongKeSVtheoLop_Load(object sender, EventArgs e)
        {
            cboMaLop.DisplayMember = "TENLOP";
            cboMaLop.ValueMember = "MALOP";
            cboMaLop.DataSource = sv.Lop();
            this.reportViewer1.RefreshReport();
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetSinhVientheoLop.SINHVIEN_selectMALOP' table. You can move, or remove it, as needed.
           
        }

        private void btRPT_Click(object sender, EventArgs e)
        {
            this.SINHVIEN_selectMALOPTableAdapter.Fill(this.DataSetSinhVientheoLop.SINHVIEN_selectMALOP, cboMaLop.SelectedValue.ToString(),cboNH.SelectedItem.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
