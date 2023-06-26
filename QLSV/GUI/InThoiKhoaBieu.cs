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
    public partial class InThoiKhoaBieu : Form
    {
        BUS_TKB tkb = new BUS_TKB();
        public InThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void InThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            cboMaLop.DisplayMember = "TENLOP";
            cboMaLop.ValueMember = "MALOP";
            cboMaLop.DataSource = tkb.Lop();
            this.reportViewer1.RefreshReport();

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetInThoiKhoaBieu.tkb' table. You can move, or remove it, as needed.
            this.tkbTableAdapter.Fill(this.DataSetInThoiKhoaBieu.tkb, cboMaLop.SelectedValue.ToString(), comboBox1.SelectedItem.ToString(),cbNamHoc.SelectedItem.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
