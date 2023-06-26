using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuanLyTaiKoan : Form
    {
        BUS_DangNhap bus_DN = new BUS_DangNhap();
        DTO_DangNhap dn = new DTO_DangNhap();

        public QuanLyTaiKoan()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtTenDN.DataBindings.Clear();
            txtTenDN.DataBindings.Add("Text", dataGridView1.DataSource, "tenDangNhap");
            txtMK.DataBindings.Clear();
            txtMK.DataBindings.Add("Text", dataGridView1.DataSource, "matKhau");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dataGridView1.DataSource, "hoTen");
            cboQuyen.DataBindings.Clear();
            cboQuyen.DataBindings.Add("Text", dataGridView1.DataSource, "quyen");
        }
            private void QuanLyTaiKoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus_DN.DN();
            dataGridView1.Columns[0].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns[1].HeaderText = "Mật khẩu";
            dataGridView1.Columns[2].HeaderText = "Họ tên";
            dataGridView1.Columns[3].HeaderText = "Quyền";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 225;
            dataGridView1.Columns[2].Width = 255;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
            binding();
        }
        
        
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
            dn.TenDN = row.Cells["tenDangNhap"].Value.ToString();
            dn.MK1 = row.Cells["matKhau"].Value.ToString();
            dn.HoTen = row.Cells["hoTen"].Value.ToString();
            dn.Quyen = row.Cells["quyen"].Value.ToString();
            MessageBox.Show("Bạn có chắc muốn xóa không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            bus_DN.xoaDN(dn.TenDN);
            MessageBox.Show("Xóa thành công");
            this.QuanLyTaiKoan_Load(sender, e);
            txtHoTen.Text = "";
            txtTenDN.Text = "";
            txtMK.Text = "";
            cboQuyen.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
            dn.TenDN = row.Cells["tenDangNhap"].Value.ToString();
            dn.MK1 = row.Cells["matKhau"].Value.ToString();
            dn.HoTen = row.Cells["hoTen"].Value.ToString();
            dn.Quyen = row.Cells["quyen"].Value.ToString();
            DTO_DangNhap dto_dn = new DTO_DangNhap(dn.TenDN, dn.MK1, dn.HoTen, dn.Quyen);
            bus_DN.suaDN(dto_dn);
            this.QuanLyTaiKoan_Load(sender, e);
            MessageBox.Show("Sửa thành công");
            txtHoTen.Text = "";
            txtTenDN.Text = "";
            txtMK.Text = "";
            cboQuyen.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bus_DN.kiemtratontai(txtTenDN.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Cảnh báo");
            }
            else
            {
                try
                {
                    DTO_DangNhap dn = new DTO_DangNhap(txtTenDN.Text, txtMK.Text, txtHoTen.Text, cboQuyen.SelectedItem.ToString());
                    bus_DN.themDN(dn);
                    MessageBox.Show("Thêm thành công");
                    this.QuanLyTaiKoan_Load(sender, e);
                    txtHoTen.Text = "";
                    txtTenDN.Text = "";
                    txtMK.Text = "";
                    cboQuyen.Text = "";

                }
                catch
                {
                    MessageBox.Show("Thêm không thành công xin kiểm tra lại");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtMK.Text = "";
            txtTenDN.Text = "";
            cboQuyen.Text = "";
        }
    }
}
