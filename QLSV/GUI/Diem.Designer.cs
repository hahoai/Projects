
namespace GUI
{
    partial class Diem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diem));
            this.btnLoc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLopMH = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataD = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOPMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDS = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataD)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(894, 79);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(177, 51);
            this.btnLoc.TabIndex = 55;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Lớp môn học:";
            // 
            // cboLopMH
            // 
            this.cboLopMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLopMH.FormattingEnabled = true;
            this.cboLopMH.Location = new System.Drawing.Point(239, 26);
            this.cboLopMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLopMH.Name = "cboLopMH";
            this.cboLopMH.Size = new System.Drawing.Size(292, 33);
            this.cboLopMH.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataD);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(31, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1112, 361);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách điểm môn học";
            // 
            // dataD
            // 
            this.dataD.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.HOTENSV,
            this.LOPMH,
            this.DIEMCC,
            this.DIEMKT1,
            this.DIEMTHI});
            this.dataD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataD.Location = new System.Drawing.Point(3, 26);
            this.dataD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataD.Name = "dataD";
            this.dataD.RowHeadersWidth = 62;
            this.dataD.Size = new System.Drawing.Size(1106, 332);
            this.dataD.TabIndex = 2;
            this.dataD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataD_CellContentClick);
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "Mã SV";
            this.MASV.MinimumWidth = 8;
            this.MASV.Name = "MASV";
            this.MASV.Width = 110;
            // 
            // HOTENSV
            // 
            this.HOTENSV.DataPropertyName = "HOTENSV";
            this.HOTENSV.HeaderText = "Họ tên";
            this.HOTENSV.MinimumWidth = 8;
            this.HOTENSV.Name = "HOTENSV";
            this.HOTENSV.Width = 173;
            // 
            // LOPMH
            // 
            this.LOPMH.DataPropertyName = "LOPMH";
            this.LOPMH.HeaderText = "Lớp môn học";
            this.LOPMH.MinimumWidth = 8;
            this.LOPMH.Name = "LOPMH";
            this.LOPMH.Width = 150;
            // 
            // DIEMCC
            // 
            this.DIEMCC.DataPropertyName = "DIEMCC";
            this.DIEMCC.HeaderText = "Điểm CC ";
            this.DIEMCC.MinimumWidth = 8;
            this.DIEMCC.Name = "DIEMCC";
            this.DIEMCC.Width = 80;
            // 
            // DIEMKT1
            // 
            this.DIEMKT1.DataPropertyName = "DIEMKT1";
            this.DIEMKT1.HeaderText = "Điểm KT1";
            this.DIEMKT1.MinimumWidth = 8;
            this.DIEMKT1.Name = "DIEMKT1";
            this.DIEMKT1.Width = 80;
            // 
            // DIEMTHI
            // 
            this.DIEMTHI.DataPropertyName = "DIEMTHI";
            this.DIEMTHI.HeaderText = "Điểm thi";
            this.DIEMTHI.MinimumWidth = 8;
            this.DIEMTHI.Name = "DIEMTHI";
            this.DIEMTHI.Width = 80;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cboLopMH);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(93, 64);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(763, 78);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(894, 185);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(177, 52);
            this.btnSua.TabIndex = 56;
            this.btnSua.Text = "Lưu";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDS
            // 
            this.btnDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDS.Location = new System.Drawing.Point(622, 185);
            this.btnDS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDS.Name = "btnDS";
            this.btnDS.Size = new System.Drawing.Size(177, 51);
            this.btnDS.TabIndex = 57;
            this.btnDS.Text = "Danh sách";
            this.btnDS.UseVisualStyleBackColor = true;
            this.btnDS.Click += new System.EventHandler(this.btnDS_Click);
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 687);
            this.Controls.Add(this.btnDS);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Diem";
            this.Text = "Quản lý điểm sinh viên";
            this.Load += new System.EventHandler(this.Diem_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboLopMH;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOPMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMKT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHI;
        private System.Windows.Forms.Button btnDS;
    }
}