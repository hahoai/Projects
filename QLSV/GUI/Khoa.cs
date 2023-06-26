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
using DTO;
using DAL;
using BUS;

namespace GUI
{
    
    public partial class Khoa : Form
    {
       BUS_Khoa bus_Khoa = new BUS_Khoa();

        public Khoa()
        {
            InitializeComponent();
        }

        private void binding()
        {
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dataKhoa.DataSource, "MAKHOA");
            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", dataKhoa.DataSource, "TENKHOA");
        }
        private void Khoa_Load(object sender, EventArgs e)
        {
            dataKhoa.DataSource = bus_Khoa.KHOA();
            dataKhoa.Columns[0].HeaderText = "Mã khoa";
            dataKhoa.Columns[1].HeaderText = "Tên khoa";

            dataKhoa.Columns[0].Width = 70;
            dataKhoa.Columns[1].Width = 150;

            dataKhoa.AllowUserToAddRows = false;
            dataKhoa.AllowUserToDeleteRows = false;
            dataKhoa.Width = this.ClientSize.Width;
            dataKhoa.Height = this.ClientSize.Height;
            binding();
        }
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Khoa_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bus_Khoa.kiemtratontai(txtMaKhoa.Text))
            {
                MessageBox.Show("Mã khoa đã tồn tại", "Cảnh báo");
            }
            else
                try
                {
                    DTO_Khoa khoa = new DTO_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
                    bus_Khoa.themKhoa(khoa);
                    MessageBox.Show("Thêm khoa thành công!!!");
                    txtMaKhoa.Text = "";
                    txtTenKhoa.Text = "";
                    this.Khoa_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại", "Thông báo");
                }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Khoa khoa = new DTO_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
                bus_Khoa.suaKhoa(khoa);
                MessageBox.Show("Sửa thành công!!!");
                txtMaKhoa.Text = "";
                txtTenKhoa.Text = "";
                this.Khoa_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bus_Khoa.xoaKhoa(txtMaKhoa.Text);
                MessageBox.Show("Xóa thành công!!!");
                txtMaKhoa.Text = "";
                txtTenKhoa.Text = "";
                this.Khoa_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtMaKhoa.Focus();
            
        }
    }
}
