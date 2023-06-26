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

namespace GUI
{
    public partial class PhanCongGD : Form
    {
        BUS_PCGD PCGD = new BUS_PCGD();

        public PhanCongGD()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtLopMH.DataBindings.Clear();
            txtLopMH.DataBindings.Add("Text", dataPCGD.DataSource, "LOPMH");
            cboMH.DataBindings.Clear();
            cboMH.DataBindings.Add("Text", dataPCGD.DataSource, "MAMH");
            cboMaLop.DataBindings.Clear();
            cboMaLop.DataBindings.Add("Text", dataPCGD.DataSource, "MALOP");
            cboMaGV.DataBindings.Clear();
            cboMaGV.DataBindings.Add("Text", dataPCGD.DataSource, "MAGV");
            cbNamHoc.DataBindings.Clear();
            cbNamHoc.DataBindings.Add("Text", dataPCGD.DataSource, "NAMHOC");
            cboHocKy.DataBindings.Clear();
            cboHocKy.DataBindings.Add("Text", dataPCGD.DataSource, "HOCKY");

        }
        private void PhanCongGD_Load(object sender, EventArgs e)
        {
            dataPCGD.DataSource = PCGD.PCGD();
            cboMH.DataSource = PCGD.MonHoc();
            cboMH.DisplayMember = "TENMH";
            cboMH.ValueMember = "MAMH";
            cboMH.SelectedIndex = -1;
            cboMaLop.DataSource = PCGD.Lop();
            cboMaLop.DisplayMember = "TENLOP";
            cboMaLop.ValueMember = "MALOP";
            cboMaLop.SelectedIndex = -1;
            cboMaGV.DataSource = PCGD.GiaoVien();
            cboMaGV.DisplayMember = "TENGV";
            cboMaGV.ValueMember = "MAGV";
            cboMaGV.SelectedIndex = -1;
            comboBox1.DataSource = PCGD.ChuyenNganh();
            comboBox1.DisplayMember = "TENNGANH";
            comboBox1.ValueMember = "MANGANH";
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (PCGD.kiemtratontai(txtLopMH.Text, cboMH.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString()))
            {
                MessageBox.Show("Đã tồn tại!");

            }
            try
            {
                DTO_PCGD pcgd = new DTO_PCGD(txtLopMH.Text, cboMH.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString(), cboMaGV.SelectedValue.ToString(),cbNamHoc.SelectedItem.ToString(),cboHocKy.SelectedItem.ToString());
                PCGD.themPCGD(pcgd);
                MessageBox.Show(" Thêm thành công ");
                txtLopMH.Text = "";
                cboMH.Text = "";
                cboMaLop.Text = "";
                cboMaGV.Text = "";
                cbNamHoc.Text = "";
                cbNamHoc.Text = "";
                this.PhanCongGD_Load(sender, e);
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
                DTO_PCGD pcgd = new DTO_PCGD(txtLopMH.Text, cboMH.SelectedValue.ToString(), cboMaLop.SelectedValue.ToString(), cboMaGV.SelectedValue.ToString(), cbNamHoc.SelectedItem.ToString(), cboHocKy.SelectedItem.ToString());
                PCGD.suaPCGD(pcgd);
                MessageBox.Show("Sửa thành công!!!");
                txtLopMH.Text = "";
                cboMH.Text = "";
                cboMaLop.Text = "";
                cboMaGV.Text = "";
                cbNamHoc.Text = "";
                cbNamHoc.Text = "";
                this.PhanCongGD_Load(sender, e);
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
                PCGD.xoaPCGD(txtLopMH.Text);
                MessageBox.Show("Xóa thành công");
                txtLopMH.Text = "";
                cboMH.Text = "";
                cboMaLop.Text = "";
                cboMaGV.Text = "";
                cbNamHoc.Text = "";
                cbNamHoc.Text = "";
                this.PhanCongGD_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLopMH.Text = "";
            cboMH.Text = "";
            cboMaLop.Text = "";
            cboMaGV.Text = "";
            cbNamHoc.Text = "";
            cboHocKy.Text = "";
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMaLop.DataSource = PCGD.Lop1(comboBox1.SelectedValue.ToString());
            cboMH.DataSource = PCGD.MonHoc1(comboBox1.SelectedValue.ToString());
        }

        private void dataPCGD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLopMH.Text = dataPCGD.CurrentRow.Cells[0].Value.ToString();
            cboMH.Text= dataPCGD.CurrentRow.Cells[1].Value.ToString();
            cboMaLop.Text = dataPCGD.CurrentRow.Cells[2].Value.ToString();
            cboMaGV.Text = dataPCGD.CurrentRow.Cells[3].Value.ToString();
            cbNamHoc.Text = dataPCGD.CurrentRow.Cells[4].Value.ToString();
            cboHocKy.Text = dataPCGD.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
