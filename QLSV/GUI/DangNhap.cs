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

namespace GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public void kiemTra(string tenDN, string MK, String Quyen)
        {
            SqlConnection dbConn = new SqlConnection(@"Data Source=DESKTOP-SOJM7CD\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");           
            string cmd2 = "SELECT * FROM DANGNHAP WHERE tenDangNhap = '" + tenDN + "' AND matKhau = '" + MK + "' AND QUYEN='" + Quyen + "'";
            SqlDataAdapter sql2 = new SqlDataAdapter(cmd2, dbConn);
            DataTable ds2 = new DataTable();
            sql2.Fill(ds2);
            if (ds2.Rows.Count == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.Xin vui lòng kiểm tra lại!");
                cboQuyen.Text = "";
                txtMatKhau.Text = "";
                txtTenDN.Text = "";
            }
            else if (ds2.Rows.Count == 1)
            {
                if (Quyen == "Admin")
                {
                    TrangChuAdmin f = new TrangChuAdmin();
                    f.Show();
                }
                else if (Quyen == "Sinh viên")
                {
                    TrangChuSV f = new TrangChuSV();
                    f.Show();
                }
                else if (Quyen == "Giáo viên")
                {
                    TrangChuGV f = new TrangChuGV();
                    f.Show();
                }
            }
            
                    

            }
            
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kiemTra(txtTenDN.Text, txtMatKhau.Text, cboQuyen.SelectedItem.ToString());
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cboQuyen.SelectedIndex = 0;
        }
    }
}
