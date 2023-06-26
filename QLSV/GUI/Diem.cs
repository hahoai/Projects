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
using System.Data.SqlClient;
using DAL;


namespace GUI
{
    public partial class Diem : Form
    {
        BindingSource binD;
        BUS_Lop bus_lop = new BUS_Lop();
        BUS_Diem bus_Diem = new BUS_Diem();
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SOJM7CD\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");

        public Diem()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        private void Loaddata()
        {
            binD = new BindingSource();
            binD.DataSource = bus_Diem.Diem();
            dataD.DataSource = binD;

        }
        private void Diem_Load(object sender, EventArgs e)
        {
            


            

            cboLopMH.DataSource = bus_Diem.LopMH();
            cboLopMH.DisplayMember = "LOPMH";
            cboLopMH.ValueMember = "LOPMH";
            cboLopMH.SelectedIndex = -1;

            
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select sinhvien.masv, sinhvien.hotensv, diem.lopmh, diem.diemcc, diem.diemkt1, diem.diemthi from sinhvien inner join DIEM on sinhvien.masv = diem.masv inner join phanconggd on phanconggd.lopmh = diem.lopmh where phanconggd.LOPMH = @lopmh", conn);
            cmd.Parameters.AddWithValue("@lopmh", cboLopMH.SelectedValue.ToString());           
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataD.DataSource = dt;
            dataD.AllowUserToAddRows = false;
    
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for (int item=0; item <= dataD.Rows.Count - 1; item++)
            {
                SqlCommand cmd2 = new SqlCommand("update diem set diemcc=@diemcc, diemkt1=@diemkt1, diemthi=@diemthi where masv=@masv and lopmh=@lopmh", conn);
                cmd2.Parameters.AddWithValue("@masv", dataD.Rows[item].Cells[0].Value);
                cmd2.Parameters.AddWithValue("@lopmh", dataD.Rows[item].Cells[2].Value);
                cmd2.Parameters.AddWithValue("@diemcc", dataD.Rows[item].Cells[3].Value);
                cmd2.Parameters.AddWithValue("@diemkt1", dataD.Rows[item].Cells[4].Value);
                cmd2.Parameters.AddWithValue("@diemthi", dataD.Rows[item].Cells[5].Value);

                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
                
                }
            MessageBox.Show("Luu thanh cong!");
           
        }

        private void btnDSSV_Click(object sender, EventArgs e)
        {
            bus_Diem.DS_SV();
            Diem_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            bus_Diem.DS_SV();
            Diem_Load(sender, e);
        }

        private void dataD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
