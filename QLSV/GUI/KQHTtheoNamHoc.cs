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
    public partial class KQHTtheoNamHoc : Form
    {
        BUS_SinhVien sv = new BUS_SinhVien();
        public KQHTtheoNamHoc()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetKQHTNH.ketquatheonamhoc' table. You can move, or remove it, as needed.
            this.ketquatheonamhocTableAdapter.Fill(this.DataSetKQHTNH.ketquatheonamhoc,txtMaSV.Text,cbNamHoc.SelectedItem.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void KQHTtheoNamHoc_Load(object sender, EventArgs e)
        {

            sv.SinhVien();
            this.reportViewer1.RefreshReport();
        }
    }
}
