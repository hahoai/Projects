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
    public partial class CHUONGTRINHDT : Form
    {
        BUS_CHUONGTRINHDT bus_ChiTiet= new BUS_CHUONGTRINHDT();

        public CHUONGTRINHDT()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void binding()
        {
            cbNganh.DataBindings.Clear();
            cbNganh.DataBindings.Add("Text", dataCTDT.DataSource, "MANGANH");
            cboMaMH.DataBindings.Clear();
            cboMaMH.DataBindings.Add("Text", dataCTDT.DataSource, "MAMH");
            txtKyThu.DataBindings.Clear();
            txtKyThu.DataBindings.Add("Text", dataCTDT.DataSource, "KYTHU");
           
        }
        private void ChiTietCTDT_Load(object sender, EventArgs e)
        {
            cboMaMH.DataSource = bus_ChiTiet.MonHoc();
            cboMaMH.DisplayMember = "TENMH";
            cboMaMH.ValueMember = "MAMH";

            cbNganh.DataSource = bus_ChiTiet.Nganh();
            cbNganh.DisplayMember = "TENNGANH";
            cbNganh.ValueMember = "MANGANH";


            dataCTDT.DataSource = bus_ChiTiet.ChiTietCTDT();
            binding();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bus_ChiTiet.kiemtratontai(cboMaMH.SelectedValue.ToString(),cbNganh.SelectedValue.ToString() )){

                MessageBox.Show("Đã tồn tại!");

            }
            try
            {
                
                DTO_CHUONGTRINHDT CTDT = new DTO_CHUONGTRINHDT(cbNganh.SelectedValue.ToString(), cboMaMH.SelectedValue.ToString(),  txtKyThu.Text);
                bus_ChiTiet.themCTDT(CTDT);
                MessageBox.Show(" Thêm thành công ");
                cboMaMH.Text = "";
                cbNganh.Text = "";
                txtKyThu.Text = "";
                this.ChiTietCTDT_Load(sender, e);
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

                DTO_CHUONGTRINHDT CTDT = new DTO_CHUONGTRINHDT(cbNganh.SelectedValue.ToString(), cboMaMH.SelectedValue.ToString(), txtKyThu.Text);
                bus_ChiTiet.suaCTDT(CTDT);
                MessageBox.Show("Sửa thành công!!!");
                cboMaMH.Text = "";
                cbNganh.Text = "";
                txtKyThu.Text = "";
                this.ChiTietCTDT_Load(sender, e);
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
                bus_ChiTiet.xoaCTDT(cbNganh.SelectedValue.ToString(),cboMaMH.SelectedValue.ToString());
                MessageBox.Show("Xóa thành công");
                cboMaMH.Text = "";
                cbNganh.Text = "";
                txtKyThu.Text = "";
                this.ChiTietCTDT_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboMaMH.Text = "";
            cbNganh.Text = "";
            txtKyThu.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaMH.DataSource = bus_ChiTiet.MonHoc1(cbNganh.SelectedValue.ToString());
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
