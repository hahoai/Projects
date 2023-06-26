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
using BUS;
using DAL;

namespace GUI
{
    public partial class Lop : Form
    {

        BindingSource binL;
        BUS_Lop bus_lop = new BUS_Lop();
 

        public Lop()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dataLop.DataSource, "MALOP");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dataLop.DataSource, "TENLOP");
            cboNganh.DataBindings.Clear();
            cboNganh.DataBindings.Add("Text", dataLop.DataSource, "MANGANH");
        }
        private void Lop_Load(object sender, EventArgs e)
        {
            cboNganh.DataSource = bus_lop.Nganh();
            cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
            cboNganh.SelectedIndex = -1;
            cboNganh.Text = "[Chọn ngành ...]";
            dataLop.DataSource = bus_lop.LOP();
            dataLop.Columns[0].HeaderText = "Mã lớp";
            dataLop.Columns[1].HeaderText = "Tên lớp";
            dataLop.Columns[2].HeaderText = "Mã ngành";

            dataLop.Columns[0].Width = 70;
            dataLop.Columns[1].Width = 250;
            dataLop.Columns[2].Width = 70;

            dataLop.AllowUserToAddRows = false;
            dataLop.AllowUserToDeleteRows = false;
            dataLop.Width = this.ClientSize.Width;
            dataLop.Height = this.ClientSize.Height;

            binding();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bus_lop.kiemtratontai(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp "+txtMaLop.Text+" đã tồn tại", "Cảnh báo");

            }
            else
            {

                try
                {
                    DTO_Lop Lop = new DTO_Lop(txtMaLop.Text, txtTenLop.Text, cboNganh.SelectedValue.ToString());
                    bus_lop.themLop(Lop);
                    MessageBox.Show(" Thêm lớp " + txtTenLop.Text + " thành công  ");
                    txtMaLop.Text = "";
                    txtTenLop.Text = "";
                    this.Lop_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại", "Thông báo");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Lop Lop = new DTO_Lop(txtMaLop.Text, txtTenLop.Text, cboNganh.SelectedValue.ToString());
                bus_lop.suaLop(Lop);
                txtMaLop.Text = "";
                txtTenLop.Text = "";
                MessageBox.Show(" Sửa lớp thành công  ");
                this.Lop_Load(sender, e);
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
                bus_lop.xoaLop(txtMaLop.Text);
                MessageBox.Show(" Xóa thành công  ");
                txtMaLop.Text = "";
                txtTenLop.Text = "";
                this.Lop_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboNganh.Text = "";
            txtMaLop.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
