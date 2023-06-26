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
using System.Data.SqlClient;

namespace GUI
{
    public partial class QuaTrinhHT : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SOJM7CD\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");

        BUS_QTHT bus_QTHT = new BUS_QTHT();
        public QuaTrinhHT()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dataQTHT.DataSource, "MASV");
            txtNamHoc.DataBindings.Clear();
            txtNamHoc.DataBindings.Add("Text", dataQTHT.DataSource, "NAMHOC");
            comboLop.DataBindings.Clear();
            comboLop.DataBindings.Add("Text", dataQTHT.DataSource, "LOP");
            cbTT.DataBindings.Clear();
            cbTT.DataBindings.Add("Text", dataQTHT.DataSource, "TRANGTHAI");
            txtSoQD.DataBindings.Clear();
            txtSoQD.DataBindings.Add("Text", dataQTHT.DataSource, "SOQD");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (bus_QTHT.kt(txtMaSV.Text, txtNamHoc.Text, cbTT.SelectedValue.ToString()))
            {
                MessageBox.Show("Mời nhập lại", "Cảnh báo");
            }
            else
            {

                try
                {
                    DTO_QTHT QTHT = new DTO_QTHT(txtMaSV.Text, txtSoQD.Text, txtNamHoc.Text, comboLop.SelectedValue.ToString(), cbTT.SelectedValue.ToString());
                    bus_QTHT.themQTHT(QTHT);
                    MessageBox.Show("Thêm thành công");
                    QuaTrinhHT_Load(sender, e);
                    txtMaSV.Text = "";
                    txtNamHoc.Text = "";
                    comboLop.Text = "";
                    cbTT.Text = "";
                    txtSoQD.Text = "";

                }
                catch
                {
                    MessageBox.Show("Thêm không thành công xin kiểm tra lại");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtNamHoc.Text = "";
            comboLop.Text = "";
            cbTT.Text = "";
            txtSoQD.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_QTHT QTHT = new DTO_QTHT(txtMaSV.Text,txtSoQD.Text, txtNamHoc.Text, comboLop.SelectedValue.ToString(),cbTT.SelectedValue.ToString());
                bus_QTHT.suaQTHT(QTHT);
                MessageBox.Show("Sửa thành công!!!");
                QuaTrinhHT_Load(sender, e);
                txtMaSV.Text = "";
                txtNamHoc.Text = "";
                comboLop.Text = "";
                cbTT.Text = "";
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
                bus_QTHT.xoaQTHT(txtMaSV.Text, txtNamHoc.Text, comboLop.SelectedValue.ToString(), cbTT.SelectedValue.ToString());
                MessageBox.Show("Xóa thành công!!!");
                QuaTrinhHT_Load(sender, e);
                txtMaSV.Text = "";
                txtNamHoc.Text = "";
                comboLop.Text = "";
                cbTT.Text = "";
                txtSoQD.Text = "";
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void QuaTrinhHT_Load(object sender, EventArgs e)
        {
            dataQTHT.DataSource = bus_QTHT.QTHT();
            comboLop.DataSource = bus_QTHT.Lop();
            comboLop.DisplayMember = "TENLOP";
            comboLop.ValueMember = "MALOP";
            comboLop.SelectedIndex = -1;

            cbTT.DataSource = bus_QTHT.TrangThai();
            cbTT.DisplayMember = "TENTT";
            cbTT.ValueMember = "MATT";
            cbTT.SelectedIndex = -1;
            

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //bus_QTHT.TIMKIEM(txtTimKiem.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void cbTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            dataQTHT.DataSource = bus_QTHT.TIMKIEM(txtMaSV.Text);
            string MaSV = txtMaSV.Text;
            SqlCommand cmd = new SqlCommand("SELECT TRANGTHAI FROM QTHT WHERE MASV='" + MaSV + "'", conn);
            List<string> str = new List<string>();
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();  // Changed
            while (dr.Read())
            {
                str.Add(dr.GetValue(0).ToString());  // Changed
            }
            if (str.Count == 0)
            {
                cbTT.DataSource = bus_QTHT.TrangThai1();
            }
            if (str.Count == 1)
            {
                cbTT.DataSource = bus_QTHT.TrangThai2();
            }
            if (str.Count == 2)
            {
                cbTT.DataSource = bus_QTHT.TrangThai3();
            }
            if (str.Count == 3)
            {

                if (str.Contains("2"))
                {
                    cbTT.DataSource = bus_QTHT.TrangThai4();
                }

            }
            if (str.LastIndexOf("1") == 2)
            {
                cbTT.DataSource = bus_QTHT.TrangThai8();
            }
            if (str.LastIndexOf("1") == 2 && str.LastIndexOf("2") == 4)
            {
                cbTT.DataSource = bus_QTHT.TrangThai9();
            }
            if (str.LastIndexOf("1") == 1 && str.LastIndexOf("2") == 3)
            {
                cbTT.DataSource = bus_QTHT.TrangThai9();
            }
            if (str.Count == 4)
            {
                if (str.Contains("3"))
                    cbTT.DataSource = bus_QTHT.TrangThai5();
            }
            if (str.Contains("4"))
            {
                cbTT.DataSource = bus_QTHT.TrangThai6();
            }
            if (str.Contains("5"))
            {
                cbTT.DataSource = bus_QTHT.TrangThai6();
            }
            if (str.Contains("6"))
            {
                cbTT.DataSource = bus_QTHT.TrangThai6();
            }

            conn.Close();
            }

        private void dataQTHT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dataQTHT.CurrentRow.Cells[0].Value.ToString();
            txtSoQD.Text = dataQTHT.CurrentRow.Cells[4].Value.ToString();
            txtNamHoc.Text = dataQTHT.CurrentRow.Cells[1].Value.ToString();
            comboLop.Text = dataQTHT.CurrentRow.Cells[2].Value.ToString();
            cbTT.Text = dataQTHT.CurrentRow.Cells[3].Value.ToString();
            
        }
    }
}
