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

namespace GUI
{
    public partial class QTKhenThuong : Form
    {
        BUS_QTKhenThuong bus_QTKT = new BUS_QTKhenThuong();
        public QTKhenThuong()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dataQDKT.DataSource, "MASV");
            txtHocKy.DataBindings.Clear();
            txtHocKy.DataBindings.Add("Text", dataQDKT.DataSource, "HOCKY");
            cboLoaiKT.DataBindings.Clear();
            cboLoaiKT.DataBindings.Add("Text", dataQDKT.DataSource, "MAKT");
            txtSoQD.DataBindings.Clear();
            txtSoQD.DataBindings.Add("Text", dataQDKT.DataSource, "SOQUYETDINH");
            dtpNgayQD.DataBindings.Clear();
            dtpNgayQD.DataBindings.Add("Text", dataQDKT.DataSource, "NGAYQUYETDINH");
            
            cboHT.DataBindings.Clear();
            cboHT.DataBindings.Add("Text", dataQDKT.DataSource, "HINHTHUC");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_QTKhenThuong dto_QTKT = new DTO_QTKhenThuong(txtMaSV.Text, txtHocKy.Text, cboLoaiKT.SelectedValue.ToString(), txtSoQD.Text, dtpNgayQD.Text, cboHT.SelectedItem.ToString());
            bus_QTKT.themQTKT(dto_QTKT);
            MessageBox.Show("Thêm thành công");
            QTKhenThuong_Load(sender, e);

            txtMaSV.Text = "";
            txtHocKy.Text = "";
            txtSoQD.Text = "";
            dtpNgayQD.Text = "";
            cboLoaiKT.Text = "";
            cboHT.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_QTKhenThuong dto_QTKT = new DTO_QTKhenThuong(txtMaSV.Text, txtHocKy.Text, cboLoaiKT.SelectedValue.ToString(), txtSoQD.Text, dtpNgayQD.Text, cboHT.SelectedItem.ToString());
            bus_QTKT.suaQTKT(dto_QTKT);
            MessageBox.Show("Sửa thành công");
            QTKhenThuong_Load(sender, e);

            txtMaSV.Text = "";
            txtHocKy.Text = "";
            txtSoQD.Text = "";
            dtpNgayQD.Text = "";
            cboLoaiKT.Text = "";
            cboHT.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn xóa không?",
                 "Thông báo", MessageBoxButtons.YesNoCancel);
            bus_QTKT.xoaQTKT(txtMaSV.Text, txtHocKy.Text, cboLoaiKT.SelectedValue.ToString());
            MessageBox.Show("Xóa thành công");
            QTKhenThuong_Load(sender, e);

            txtMaSV.Text = "";
            txtHocKy.Text = "";
            txtSoQD.Text = "";
            dtpNgayQD.Text = "";
            cboLoaiKT.Text = "";
            cboHT.Text = "";
        }

        private void QTKhenThuong_Load(object sender, EventArgs e)
        {
            cboLoaiKT.DataSource = bus_QTKT.LoaiKT();
            cboLoaiKT.DisplayMember = "TENKT";
            cboLoaiKT.ValueMember = "MAKT";

            dataQDKT.DataSource = bus_QTKT.QTKT();
            dataQDKT.Columns[0].HeaderText = "Mã sinh viên";
            dataQDKT.Columns[1].HeaderText = "Học kỳ";
            dataQDKT.Columns[2].HeaderText = "Loại khen thưởng";
            dataQDKT.Columns[3].HeaderText = "Số quyết định";
            dataQDKT.Columns[4].HeaderText = "Ngày quyết định";
            dataQDKT.Columns[5].HeaderText = "Hình thức";

            dataQDKT.Columns[0].Width = 70;
            dataQDKT.Columns[1].Width = 40;
            dataQDKT.Columns[2].Width = 70;
            dataQDKT.Columns[3].Width = 40;
            dataQDKT.Columns[4].Width = 60;
            dataQDKT.Columns[5].Width = 130;
            
            dataQDKT.AllowUserToAddRows = false;
            dataQDKT.AllowUserToDeleteRows = false;
            dataQDKT.Width = this.ClientSize.Width;
            dataQDKT.Height = this.ClientSize.Height;
            binding();

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHocKy.Text = "";
            txtSoQD.Text = "";
            dtpNgayQD.Text = "";
            cboLoaiKT.Text = "";
            cboHT.Text = "";
        }
    }
}
