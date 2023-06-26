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
using DTO;
using DAL;

namespace GUI
{
    public partial class TrangThai : Form
    {
        BUS_TrangThai bus_TT = new BUS_TrangThai();
        public TrangThai()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void binding()
        {
            txtMaTT.DataBindings.Clear();
            txtMaTT.DataBindings.Add("Text", dataTrangThai.DataSource, "MATT");
            txtTenTT.DataBindings.Clear();
            txtTenTT.DataBindings.Add("Text", dataTrangThai.DataSource, "TENTT");
            



        }

        private void TrangThai_Load(object sender, EventArgs e)
        {
            dataTrangThai.DataSource = bus_TT.TrangThai();
            dataTrangThai.Columns[0].HeaderText = "Mã trạng thái";
            dataTrangThai.Columns[1].HeaderText = "Tên trạng thái";
           
           

            dataTrangThai.Columns[0].Width = 90;
            dataTrangThai.Columns[1].Width = 90;
           
            

            dataTrangThai.AllowUserToAddRows = false;
            dataTrangThai.AllowUserToDeleteRows = false;
            dataTrangThai.Width = this.ClientSize.Width;
            dataTrangThai.Height = this.ClientSize.Height;
            binding();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_TrangThai dto_TT = new DTO_TrangThai(txtMaTT.Text, txtTenTT.Text);
            bus_TT.themTT(dto_TT);
            MessageBox.Show("Thêm thành công");
            TrangThai_Load(sender, e);

            txtMaTT.Text = "";
            txtTenTT.Text = "";
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_TrangThai dto_TT = new DTO_TrangThai(txtMaTT.Text, txtTenTT.Text);
            bus_TT.suaTT(dto_TT);
            MessageBox.Show("Sửa thành công");
            TrangThai_Load(sender, e);

            txtMaTT.Text = "";
            txtTenTT.Text = "";
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bạn có chắc muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNoCancel);
            bus_TT.xoaTT(txtMaTT.Text);
            MessageBox.Show("Xóa thành công");
            TrangThai_Load(sender, e);

            txtMaTT.Text = "";
            txtTenTT.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaTT.Text = "";
            txtTenTT.Text = "";
            
        }
    }
}
