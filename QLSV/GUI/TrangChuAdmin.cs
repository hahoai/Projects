using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChuAdmin : Form
    {
        
        public TrangChuAdmin()
        {
            InitializeComponent();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khoa f = new Khoa();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTaiKoan f = new QuanLyTaiKoan();
            f.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void danhMụcĐầuVàoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop f = new Lop();
            f.Show();
        }

        private void quảnLýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChuyenNganh f = new ChuyenNganh();
            f.Show();
        }

        
        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kỹLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHoc f = new MonHoc();
            f.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ptb.Image = GUI.Properties.Resources.dhthudomoi;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lop f = new Lop();
            f.Show();
        }

        private void labHoTen_Click(object sender, EventArgs e)
        {
          
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void điểmSinhViênTheoLớpkhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void danhSáchSinhViênLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsSinhVienTheoLopKhoa f = new dsSinhVienTheoLopKhoa();
            f.Show();
        }

        private void danhSáchSinhViênKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dsSingVienTheoKhoa f = new dsSingVienTheoKhoa();
            //f.Show();
        }

       

        private void danhSáchSinhViênChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsSingVienChuyenNganh f = new dsSingVienChuyenNganh();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Khoa f = new Khoa();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MonHoc f = new MonHoc();
            f.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien f = new SinhVien();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Diem f = new Diem();
            f.Show();
        }

        private void điểmSinhViênTheoMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quảnLýSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SinhVien f = new SinhVien();
            f.Show();
        }

        private void inDanhSáchSinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InDanhSachSinhVienTheoLop f = new InDanhSachSinhVienTheoLop();
            //f.Show();
        }

        private void quảnLýĐiểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem f = new Diem();
            f.Show();
        }

        

        private void thốngKêĐiểmCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            SinhVien f = new SinhVien();
            f.Show();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GV f = new GV();
            f.Show();
        }

        private void đăngKýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void thờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThoiKhoaBieu f = new ThoiKhoaBieu();
            f.Show();
        }

        private void phânCôngGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanCongGD f = new PhanCongGD();
            f.Show();
        }

        private void chươngTrìnhĐàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CHUONGTRINHDT f = new CHUONGTRINHDT();
            f.Show();
        }

        private void thốngKêDanhSáchSinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ThongKeSVtheoLop f = new ThongKeSVtheoLop();
            f.Show();
        }

        private void thốngKêĐiểmTheoKìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDiemSVtheoki f = new ThongKeDiemSVtheoki();
            f.Show();
        }

        private void thốngKêKếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongkeKetquatoankhoa f = new ThongkeKetquatoankhoa();
            f.Show();
        }

        private void thôngTinLịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThoiKhoaBieu f = new ThoiKhoaBieu();
            f.Show();
        }

        private void inThờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InThoiKhoaBieu f = new InThoiKhoaBieu();
            f.Show();
        }

        private void thốngKêĐiểmTBCCủaCảLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void quáTrìnhKhenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quáTrìnhKỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void khenThưởngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            KhenThuong f = new KhenThuong();
            f.Show();
        }

        private void quáTrinhKhenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QTKhenThuong f = new QTKhenThuong();
            f.Show();
        }

        private void kỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KYLUAT f = new KYLUAT();
            f.Show();
        }

        private void quáTrìnhKỷLuậtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QTKYLUAT f = new QTKYLUAT();
            f.Show();
        }

        private void ptb_Click(object sender, EventArgs e)
        {

        }

        private void quáTrìnhHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuaTrinhHT f = new QuaTrinhHT();
            f.Show();
        }

        private void thốngKêKếtQuảHọcTậpTheoNămHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KQHTtheoNamHoc f = new KQHTtheoNamHoc();
            f.Show();
        }
    }
}
