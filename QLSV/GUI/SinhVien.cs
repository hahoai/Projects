using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class SinhVien : Form
    {
        BindingSource binSV;
        BUS_SinhVien sv = new BUS_SinhVien();
        public SinhVien()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            binSV=new BindingSource();
            binSV.DataSource = sv.SinhVien();
            dataSV.DataSource = binSV;
        }

        private void binding()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dataSV.DataSource, "MASV");
            txtHoTenSV.DataBindings.Clear();
            txtHoTenSV.DataBindings.Add("Text", dataSV.DataSource, "HOTENSV");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dataSV.DataSource, "NGAYSINH");
            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Text", dataSV.DataSource, "GIOITINH");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dataSV.DataSource, "DIACHI");
        }

        private void dsSinhVien_Load(object sender, EventArgs e)
        {
            dataSV.DataSource = sv.SinhVien();
            binding();
           
        }

        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataSV.DataSource = sv.timkiemSV(txtTimKiem.Text);
            binding();
        }


        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {

        }
        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (sv.kiemtratontai(txtMaSV.Text))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại, mời nhập lại", "Cảnh báo");
            }
            else
            {
                try
                {

                    DTO_SinhVien SinhVien = new DTO_SinhVien(txtMaSV.Text, txtHoTenSV.Text, dtpNgaySinh.Text, cbGioiTinh.Text, txtDiaChi.Text);
                    sv.themSV(SinhVien);
                    
                    MessageBox.Show(" Thêm sinh viên " + txtHoTenSV.Text + " có mã " + txtMaSV.Text + " !!! thành công  ");
                    dsSinhVien_Load(sender, e);
                }
                catch
                {

                    MessageBox.Show( "Thêm không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng");
                }
            }
            
            
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                DTO_SinhVien SinhVien = new DTO_SinhVien(txtMaSV.Text, txtHoTenSV.Text, dtpNgaySinh.Text, cbGioiTinh.Text, txtDiaChi.Text);
                sv.suaSV(SinhVien);
                MessageBox.Show(" Sửa sinh viên " + txtHoTenSV.Text + " có mã " + txtMaSV.Text + " !!! thành công  ");
                dsSinhVien_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
                      

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHoTenSV.Text = "";
            txtDiaChi.Text = "";
            cbGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dataSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnXoa_Click_2(object sender, EventArgs e)
        {
            if (txtMaSV.TextLength == 0 || dataSV.SelectedRows.Count < 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu xóa ");
            }
            else
           if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa sinh viên '" + txtHoTenSV.Text + "' với mã '" + txtMaSV.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

                sv.xoaSV(txtMaSV.Text);
                MessageBox.Show("Xóa sinh viên có tên là :  " + txtHoTenSV.Text + " thành công");
                dsSinhVien_Load(sender, e);
            }
        }
    }
}
 