
namespace GUI
{
    partial class ThongKeSVtheoLop
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeSVtheoLop));
            this.SINHVIEN_selectMALOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetSinhVientheoLop = new GUI.DataSetSinhVientheoLop();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.SINHVIEN_selectMALOPTableAdapter = new GUI.DataSetSinhVientheoLopTableAdapters.SINHVIEN_selectMALOPTableAdapter();
            this.cboNH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btRPT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIEN_selectMALOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSinhVientheoLop)).BeginInit();
            this.SuspendLayout();
            // 
            // SINHVIEN_selectMALOPBindingSource
            // 
            this.SINHVIEN_selectMALOPBindingSource.DataMember = "SINHVIEN_selectMALOP";
            this.SINHVIEN_selectMALOPBindingSource.DataSource = this.DataSetSinhVientheoLop;
            // 
            // DataSetSinhVientheoLop
            // 
            this.DataSetSinhVientheoLop.DataSetName = "DataSetSinhVientheoLop";
            this.DataSetSinhVientheoLop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SINHVIEN_selectMALOPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ThongKeSVtheoLop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(69, 157);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1186, 881);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn lớp:";
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(271, 62);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(243, 28);
            this.cboMaLop.TabIndex = 2;
            this.cboMaLop.SelectedIndexChanged += new System.EventHandler(this.cboMaLop_SelectedIndexChanged);
            // 
            // SINHVIEN_selectMALOPTableAdapter
            // 
            this.SINHVIEN_selectMALOPTableAdapter.ClearBeforeFill = true;
            // 
            // cboNH
            // 
            this.cboNH.FormattingEnabled = true;
            this.cboNH.Items.AddRange(new object[] {
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cboNH.Location = new System.Drawing.Point(765, 62);
            this.cboNH.Name = "cboNH";
            this.cboNH.Size = new System.Drawing.Size(243, 28);
            this.cboNH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm học:";
            // 
            // btRPT
            // 
            this.btRPT.Location = new System.Drawing.Point(1094, 55);
            this.btRPT.Name = "btRPT";
            this.btRPT.Size = new System.Drawing.Size(100, 41);
            this.btRPT.TabIndex = 5;
            this.btRPT.Text = "Report";
            this.btRPT.UseVisualStyleBackColor = true;
            this.btRPT.Click += new System.EventHandler(this.btRPT_Click);
            // 
            // ThongKeSVtheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 1050);
            this.Controls.Add(this.btRPT);
            this.Controls.Add(this.cboNH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKeSVtheoLop";
            this.Text = "Thống kê danh sách sinh viên theo lớp";
            this.Load += new System.EventHandler(this.ThongKeSVtheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SINHVIEN_selectMALOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSinhVientheoLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SINHVIEN_selectMALOPBindingSource;
        private DataSetSinhVientheoLop DataSetSinhVientheoLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaLop;
        private DataSetSinhVientheoLopTableAdapters.SINHVIEN_selectMALOPTableAdapter SINHVIEN_selectMALOPTableAdapter;
        private System.Windows.Forms.ComboBox cboNH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRPT;
    }
}