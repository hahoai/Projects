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
using System.Data.SqlClient;
using DAL;

namespace GUI
{
    public partial class GV : Form
    {
        BindingSource binGV;
        BUS_GiaoVien bus_GV = new BUS_GiaoVien();
        public GV()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", dataGV.DataSource, "MAGV");
            txtTenGV.DataBindings.Clear();
            txtTenGV.DataBindings.Add("Text", dataGV.DataSource, "TENGV");
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(bus_GV.kiemtratontai(txtMaGV.Text)){
                MessageBox.Show("Mã giáo viên đã tồn tại", "Cảnh báo");
            }
            try
            {
                DTO_GiaoVien GV = new DTO_GiaoVien(txtMaGV.Text, txtTenGV.Text);
                bus_GV.themGV(GV);
                MessageBox.Show(" Thêm giáo viên " + txtTenGV.Text + " thành công  ");
                txtMaGV.Text = "";
                txtTenGV.Text = "";
                this.GV_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void GV_Load(object sender, EventArgs e)
        {
            
            dataGV.DataSource = bus_GV.GV();
           dataGV.Columns[0].HeaderText = "Mã giáo viên";
           dataGV.Columns[1].HeaderText = "Tên giáo viên";

           dataGV.Columns[0].Width = 10;
           dataGV.Columns[1].Width = 150;

           dataGV.AllowUserToAddRows = false;
           dataGV.AllowUserToDeleteRows = false;
           dataGV.Width = this.ClientSize.Width;
           dataGV.Height = this.ClientSize.Height;
           binding();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_GiaoVien GV = new DTO_GiaoVien(txtMaGV.Text, txtTenGV.Text);
                bus_GV.suaGV(GV);
                MessageBox.Show("Sửa thành công!!!");
                txtMaGV.Text = "";
                txtTenGV.Text = "";
                this.GV_Load(sender, e);
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
                bus_GV.xoaGV(txtMaGV.Text);
                MessageBox.Show("Xóa thành công");
                txtMaGV.Text = "";
                txtTenGV.Text = "";
                this.GV_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
        }
    }
}
