using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace GUI
{
    public partial class MonHoc : Form
    {
        BindingSource binMH;
        BUS_MonHoc bus_MonHoc = new BUS_MonHoc();
        public MonHoc()
        {
            InitializeComponent();
        }
        
        
        private void binding()
        {
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", gridDS.DataSource, "MAMH");
            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("Text", gridDS.DataSource, "TENMH");
            txtSoTiet.DataBindings.Clear();
            txtSoTiet.DataBindings.Add("Text", gridDS.DataSource, "SOTIET");
            txtSoTC.DataBindings.Clear();
            txtSoTC.DataBindings.Add("Text", gridDS.DataSource, "SOTINCHI");
            cbMaNganh.DataBindings.Clear();
            cbMaNganh.DataBindings.Add("Text", gridDS.DataSource, "MANGANH");
            cbMonChung.DataBindings.Clear();
            cbMonChung.DataBindings.Add("Text", gridDS.DataSource, "MONCHUNG");


        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            cbMaNganh.DataSource = bus_MonHoc.Nganh();
            cbMaNganh.DisplayMember = "TENNGANH";
            cbMaNganh.ValueMember = "MANGANH";
            
            gridDS.DataSource = bus_MonHoc.MonHoc1();
            gridDS.Columns[0].HeaderText = "Mã MH";
            gridDS.Columns[1].HeaderText = "Tên môn học";
            
            gridDS.Columns[2].HeaderText = "Số tiết";
            gridDS.Columns[3].HeaderText = "Số tín chỉ";
            gridDS.Columns[4].HeaderText = "Ngành";
            gridDS.Columns[5].HeaderText = "Môn chung";





            gridDS.Columns[0].Width = 70;
            gridDS.Columns[1].Width = 100;
            gridDS.Columns[2].Width = 70;
            gridDS.Columns[3].Width = 70;
            gridDS.Columns[4].Width = 70;
            gridDS.Columns[5].Width = 70;



            gridDS.AllowUserToAddRows = false;
            gridDS.AllowUserToDeleteRows = false;
            gridDS.Width = this.ClientSize.Width;
            gridDS.Height = this.ClientSize.Height;

            binding();
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bus_MonHoc.kiemtratontai(txtMaMH.Text))
            {
                MessageBox.Show("Môn học đã tồn tại", "Cảnh báo");
            }
            else
            {
                
                DTO_MonHoc dto_MonHoc = new DTO_MonHoc(txtMaMH.Text, txtTenMH.Text, txtSoTiet.Text, txtSoTC.Text,cbMaNganh.SelectedValue.ToString(), cbMonChung.SelectedItem.ToString());
                bus_MonHoc.themMH(dto_MonHoc);
                MessageBox.Show("Thêm thành công");
                MonHoc_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            DTO_MonHoc dto_MonHoc = new DTO_MonHoc(txtMaMH.Text, txtTenMH.Text, txtSoTiet.Text, txtSoTC.Text, cbMaNganh.SelectedValue.ToString(), cbMonChung.SelectedItem.ToString());
            bus_MonHoc.suaMH(dto_MonHoc);
            MessageBox.Show("Sửa thành công");
            MonHoc_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn xóa không?",
                 "Thông báo", MessageBoxButtons.YesNoCancel);
            bus_MonHoc.xoaMH(txtMaMH.Text);
            MessageBox.Show("Xóa thành công");
            MonHoc_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            txtTenMH.Text = "";
            txtMaMH.Text = "";
            txtSoTC.Text = "";
            txtSoTiet.Text = "";
           
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
