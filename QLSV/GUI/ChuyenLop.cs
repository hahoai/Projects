using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class ChuyenLop : Form
    {
        connect cnn = new connect();
        public ChuyenLop()
        {
            InitializeComponent();
        }

        private void ChuyenLop_Load(object sender, EventArgs e)
        {
            
        }
    }
}
