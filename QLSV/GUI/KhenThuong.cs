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
    public partial class KhenThuong : Form
    {
        BUS_KhenThuong bus_KT = new BUS_KhenThuong();
        public KhenThuong()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaKT.DataBindings.Clear();
            txtMaKT.DataBindings.Add("Text", dataKT.DataSource, "MAKT");
            txtTenKT.DataBindings.Clear();
            txtTenKT.DataBindings.Add("Text", dataKT.DataSource, "TENKT");
            


        }

        private void KhenThuong_Load(object sender, EventArgs e)
        {
            dataKT.DataSource = bus_KT.KT();
            dataKT.Columns[0].HeaderText = "Mã khen thưởng";
            dataKT.Columns[1].HeaderText = "Tên khen thưởng";

            dataKT.Columns[0].Width = 150;
            dataKT.Columns[1].Width = 250;

            dataKT.AllowUserToAddRows = false;
            dataKT.AllowUserToDeleteRows = false;
            dataKT.Width = this.ClientSize.Width;
            dataKT.Height = this.ClientSize.Height;

            binding();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
               
            }
        

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtMaKT.Text = "";
            txtTenKT.Text = "";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DTO_KhenThuong dto_KT = new DTO_KhenThuong(txtMaKT.Text, txtTenKT.Text);
            bus_KT.themKT(dto_KT);
            MessageBox.Show("Thêm thành công");
            KhenThuong_Load(sender, e);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DTO_KhenThuong dto_KT = new DTO_KhenThuong(txtMaKT.Text, txtTenKT.Text);
            bus_KT.suaKT(dto_KT);
            MessageBox.Show("Sửa thành công");
            KhenThuong_Load(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNoCancel);
            bus_KT.xoaKT(txtMaKT.Text);
            MessageBox.Show("Xóa thành công");
            KhenThuong_Load(sender, e);
        }
    }
}
