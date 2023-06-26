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
    public partial class ThoiKhoaBieu : Form
    {
        BUS_TKB tkb = new BUS_TKB();
        BUS_Lop lop = new BUS_Lop();
        public ThoiKhoaBieu()
        {
            InitializeComponent();
        }
        private void binding()
        {
            cboLopMH.DataBindings.Clear();
            cboLopMH.DataBindings.Add("Text", dataTKB.DataSource, "LOPMH");
            dtpBD.DataBindings.Clear();
            dtpBD.DataBindings.Add("Text", dataTKB.DataSource, "NGAYBATDAU");
            dtpKT.DataBindings.Clear();
            dtpKT.DataBindings.Add("Text", dataTKB.DataSource, "NGAYKETTHUC");
            txtPhong.DataBindings.Clear();
            txtPhong.DataBindings.Add("Text", dataTKB.DataSource, "DIADIEM");
            txtTietBD.DataBindings.Clear();
            txtTietBD.DataBindings.Add("Text", dataTKB.DataSource, "TIETBD");
            txtTietKT.DataBindings.Clear();
            txtTietKT.DataBindings.Add("Text", dataTKB.DataSource, "TIETKT");
            txtThu.DataBindings.Clear();
            txtThu.DataBindings.Add("Text", dataTKB.DataSource, "THU");
        }

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            cboLopMH.DataSource = tkb.LopMH();
            cboLopMH.DisplayMember = "LOPMH";
            cboLopMH.ValueMember = "LOPMH";
            dataTKB.DataSource = tkb.ThoiKhoaBieu();

            dataTKB.Columns[0].HeaderText = "Lớp môn học";
            dataTKB.Columns[1].HeaderText = "Ngày bắt đầu";
            dataTKB.Columns[2].HeaderText = "Ngày kết thúc";
            dataTKB.Columns[3].HeaderText = "Phòng";
            dataTKB.Columns[4].HeaderText = "Tiết bắt đầu";
            dataTKB.Columns[5].HeaderText = "Tiết kết thúc";
            dataTKB.Columns[6].HeaderText = "Thứ";
            
            dataTKB.Columns[0].Width = 150;
            dataTKB.Columns[1].Width = 100;
            dataTKB.Columns[2].Width = 100;
            dataTKB.Columns[3].Width = 100;
            dataTKB.Columns[4].Width = 80;
            dataTKB.Columns[5].Width = 80;
            dataTKB.Columns[6].Width = 80;

            dataTKB.AllowUserToAddRows = false;
            dataTKB.AllowUserToDeleteRows = false;
            dataTKB.Width = this.ClientSize.Width;
            dataTKB.Height = this.ClientSize.Height;
            binding();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_TKB TKB = new DTO_TKB(cboLopMH.SelectedValue.ToString(), dtpBD.Text, dtpKT.Text,txtPhong.Text,txtTietBD.Text,txtTietKT.Text, txtThu.Text);
                tkb.themTKB(TKB);
                MessageBox.Show(" Thêm thành công ");
                cboLopMH.Text = "";
                dtpBD.Text = "";
                dtpKT.Text = "";
                txtPhong.Text = "";
                txtTietKT.Text = "";
                txtThu.Text = "";
                this.ThoiKhoaBieu_Load(sender, e);
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
                DTO_TKB TKB = new DTO_TKB(cboLopMH.SelectedValue.ToString(), dtpBD.Text, dtpKT.Text, txtPhong.Text,txtTietBD.Text, txtTietKT.Text, txtThu.Text);
                tkb.suaTKB(TKB);
                MessageBox.Show("Sửa thành công!!!");
                cboLopMH.Text = "";
                dtpBD.Text = "";
                dtpKT.Text = "";
                txtPhong.Text = "";
                txtTietBD.Text = "";
                txtTietKT.Text = "";
                txtThu.Text = "";
                this.ThoiKhoaBieu_Load(sender, e);
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
                tkb.xoaTKB(cboLopMH.SelectedValue.ToString());
                MessageBox.Show("Xóa thành công");
                cboLopMH.Text = "";
                dtpBD.Text = "";
                dtpKT.Text = "";
                txtPhong.Text = "";
                txtTietBD.Text = "";
                txtTietKT.Text = "";
                txtThu.Text = "";
                this.ThoiKhoaBieu_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboLopMH.Text = "";
            dtpBD.Text = "";
            dtpKT.Text = "";
            txtPhong.Text = "";
            txtTietBD.Text = "";
            txtTietKT.Text = "";
            txtThu.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
