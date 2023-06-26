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

namespace GUI
{

    public partial class ChuyenNganh : Form
    {
        BindingSource binN;
        BUS_Nganh bus_Nganh = new BUS_Nganh();
        public ChuyenNganh()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            binN = new BindingSource();
            binN.DataSource = bus_Nganh.NGANH();
            dataCN.DataSource = binN;
        }

        private void ChuyenNganh_Load(object sender, EventArgs e)
        {
            cboKhoa.DataSource = bus_Nganh.Khoa();
            cboKhoa.DisplayMember = "TENKHOA";
            cboKhoa.ValueMember = "MAKHOA";
            cboKhoa.SelectedIndex = -1;
            cboKhoa.Text = "[Chọn khoa ...]";
            loadData();
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bus_Nganh.kt(txtMaCN.Text))
            {
                MessageBox.Show("Mã ngành đã tồn tại", "Cảnh báo");
            }
            try
            {
                DTO_ChuyenNganh Nganh = new DTO_ChuyenNganh(txtMaCN.Text, txtTenCN.Text,  cboKhoa.SelectedValue.ToString());
                bus_Nganh.themNganh(Nganh);
                MessageBox.Show(" Thêm ngành " + txtTenCN.Text + " thành công  ");
                txtMaCN.Text = "";
                txtTenCN.Text = "";
                
                cboKhoa.Text = "";
                this.ChuyenNganh_Load(sender, e);
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
                DTO_ChuyenNganh Nganh = new DTO_ChuyenNganh(txtMaCN.Text, txtTenCN.Text,  cboKhoa.SelectedValue.ToString());
                bus_Nganh.suaNganh(Nganh);
                MessageBox.Show(" Sửa chuyên ngành thành công  ");
                txtMaCN.Text = "";
                txtTenCN.Text = "";
               
                cboKhoa.Text = "";

                this.ChuyenNganh_Load(sender, e);
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
                MessageBox.Show("Bạn có chắc muốn thoát không?",
                     "Error", MessageBoxButtons.YesNoCancel);
                bus_Nganh.xoaNganh(txtMaCN.Text);
                txtMaCN.Text = "";
                txtTenCN.Text = "";
                
                cboKhoa.Text = "";
                this.ChuyenNganh_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCN.Text = dataCN.CurrentRow.Cells[0].Value.ToString();
            txtTenCN.Text = dataCN.CurrentRow.Cells[1].Value.ToString();
            
            cboKhoa.Text = dataCN.CurrentRow.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaCN.Text = "";
            txtTenCN.Text = "";
           
            cboKhoa.Text = "";
        }
    }
}
