using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class KYLUAT : Form
    {
        BUS_KyLuat bus_KL = new BUS_KyLuat();
        public KYLUAT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHocKy_TextChanged(object sender, EventArgs e)
        {

        }
        private void binding()
        {
            txtMaKL.DataBindings.Clear();
            txtMaKL.DataBindings.Add("Text", dataKL.DataSource, "MAKL");
            txtTenKL.DataBindings.Clear();
            txtTenKL.DataBindings.Add("Text", dataKL.DataSource, "TENKL");



        }

        private void KYLUAT_Load(object sender, EventArgs e)
        {
            dataKL.DataSource = bus_KL.KL();
            dataKL.Columns[0].HeaderText = "Mã kỷ luật";
            dataKL.Columns[1].HeaderText = "Tên kỷ luật";

            dataKL.Columns[0].Width = 150;
            dataKL.Columns[1].Width = 250;

            dataKL.AllowUserToAddRows = false;
            dataKL.AllowUserToDeleteRows = false;
            dataKL.Width = this.ClientSize.Width;
            dataKL.Height = this.ClientSize.Height;

            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_KyLuat dto_KL = new DTO_KyLuat(txtMaKL.Text, txtTenKL.Text);
            bus_KL.themKL(dto_KL);
            MessageBox.Show("Thêm thành công");
            KYLUAT_Load(sender, e);
            txtMaKL.Text = "";
            txtTenKL.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_KyLuat dto_KL = new DTO_KyLuat(txtMaKL.Text, txtTenKL.Text);
            bus_KL.suaKL(dto_KL);
            MessageBox.Show("Sửa thành công");
            KYLUAT_Load(sender, e);
            txtMaKL.Text = "";
            txtTenKL.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn xóa không?",
               "Thông báo", MessageBoxButtons.YesNoCancel);
            bus_KL.xoaKL(txtMaKL.Text);
            MessageBox.Show("Xóa thành công");
            KYLUAT_Load(sender, e);
            txtMaKL.Text = "";
            txtTenKL.Text = "";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaKL.Text = "";
            txtTenKL.Text = "";
        }
    }
}
