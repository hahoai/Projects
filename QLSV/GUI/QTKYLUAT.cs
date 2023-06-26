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
using BUS;
using DAL;

namespace GUI
{
    public partial class QTKYLUAT : Form
    {
        BUS_QTKyLuat bus_QTKL = new BUS_QTKyLuat();

        public QTKYLUAT()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dataQTKL.DataSource, "MASV");
            txtHocKy.DataBindings.Clear();
            txtHocKy.DataBindings.Add("Text", dataQTKL.DataSource, "HOCKY");
            cboLoaiKL.DataBindings.Clear();
            cboLoaiKL.DataBindings.Add("Text", dataQTKL.DataSource, "MAKL");
            txtSoQD.DataBindings.Clear();
            txtSoQD.DataBindings.Add("Text", dataQTKL.DataSource, "SOQD");
            dtpNgayQD.DataBindings.Clear();
            dtpNgayQD.DataBindings.Add("Text", dataQTKL.DataSource, "NGAYQD");

            cboHT.DataBindings.Clear();
            cboHT.DataBindings.Add("Text", dataQTKL.DataSource, "HINHTHUC");
        }

        private void QTKYLUAT_Load(object sender, EventArgs e)
        {
            cboLoaiKL.DataSource = bus_QTKL.LoaiKL();
            cboLoaiKL.DisplayMember = "TENKL";
            cboLoaiKL.ValueMember = "MAKL";

            dataQTKL.DataSource = bus_QTKL.QTKL();
            dataQTKL.Columns[0].HeaderText = "Mã sinh viên";
            dataQTKL.Columns[1].HeaderText = "Học kỳ";
            dataQTKL.Columns[2].HeaderText = "Loại kỷ luật";
            dataQTKL.Columns[3].HeaderText = "Số quyết định";
            dataQTKL.Columns[4].HeaderText = "Ngày quyết định";
            dataQTKL.Columns[5].HeaderText = "Hình thức";

            dataQTKL.Columns[0].Width = 70;
            dataQTKL.Columns[1].Width = 40;
            dataQTKL.Columns[2].Width = 90;
            dataQTKL.Columns[3].Width = 40;
            dataQTKL.Columns[4].Width = 60;
            dataQTKL.Columns[5].Width = 110;

            dataQTKL.AllowUserToAddRows = false;
            dataQTKL.AllowUserToDeleteRows = false;
            dataQTKL.Width = this.ClientSize.Width;
            dataQTKL.Height = this.ClientSize.Height;
            binding();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_QTKyLuat dto_QTKL = new DTO_QTKyLuat(txtMaSV.Text, txtHocKy.Text, cboLoaiKL.SelectedValue.ToString(), txtSoQD.Text, dtpNgayQD.Text, cboHT.SelectedItem.ToString());
            bus_QTKL.suaQTKL(dto_QTKL);
            MessageBox.Show("Sửa thành công");
            QTKYLUAT_Load(sender, e);

            txtMaSV.Text = "";
            txtHocKy.Text = "";
            txtSoQD.Text = "";
            dtpNgayQD.Text = "";
            cboLoaiKL.Text = "";
            cboHT.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNoCancel);
            bus_QTKL.xoaQTKL(txtMaSV.Text, txtHocKy.Text, cboLoaiKL.SelectedValue.ToString());
            MessageBox.Show("Xóa thành công");
            QTKYLUAT_Load(sender, e);

            txtMaSV.Text = "";
            txtHocKy.Text = "";
            txtSoQD.Text = "";
            dtpNgayQD.Text = "";
            cboLoaiKL.Text = "";
            cboHT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DTO_QTKyLuat dto_QTKL = new DTO_QTKyLuat(txtMaSV.Text, txtHocKy.Text, cboLoaiKL.SelectedValue.ToString(), txtSoQD.Text, dtpNgayQD.Text, cboHT.SelectedItem.ToString());
            bus_QTKL.themQTKL(dto_QTKL);
            MessageBox.Show("Thêm thành công");
            QTKYLUAT_Load(sender, e);

            txtMaSV.Text = "";
            txtHocKy.Text = "";
            txtSoQD.Text = "";
            dtpNgayQD.Text = "";
            cboLoaiKL.Text = "";
            cboHT.Text = "";
        }
    }
}
