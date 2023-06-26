
namespace GUI
{
    partial class KQHTtheoNamHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KQHTtheoNamHoc));
            this.ketquatheonamhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetKQHTNH = new GUI.DataSetKQHTNH();
            this.label5 = new System.Windows.Forms.Label();
            this.cbNamHoc = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ketquatheonamhocTableAdapter = new GUI.DataSetKQHTNHTableAdapters.ketquatheonamhocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ketquatheonamhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetKQHTNH)).BeginInit();
            this.SuspendLayout();
            // 
            // ketquatheonamhocBindingSource
            // 
            this.ketquatheonamhocBindingSource.DataMember = "ketquatheonamhoc";
            this.ketquatheonamhocBindingSource.DataSource = this.DataSetKQHTNH;
            // 
            // DataSetKQHTNH
            // 
            this.DataSetKQHTNH.DataSetName = "DataSetKQHTNH";
            this.DataSetKQHTNH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Năm học:";
            // 
            // cbNamHoc
            // 
            this.cbNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNamHoc.FormattingEnabled = true;
            this.cbNamHoc.Items.AddRange(new object[] {
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cbNamHoc.Location = new System.Drawing.Point(746, 61);
            this.cbNamHoc.Name = "cbNamHoc";
            this.cbNamHoc.Size = new System.Drawing.Size(200, 33);
            this.cbNamHoc.TabIndex = 20;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ketquatheonamhocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.KQHTtheoNamHoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(46, 167);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1319, 834);
            this.reportViewer1.TabIndex = 17;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(1057, 49);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 59);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(309, 62);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(189, 26);
            this.txtMaSV.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã sinh viên:";
            // 
            // ketquatheonamhocTableAdapter
            // 
            this.ketquatheonamhocTableAdapter.ClearBeforeFill = true;
            // 
            // KQHTtheoNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 1050);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbNamHoc);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KQHTtheoNamHoc";
            this.Text = "Thống kê kết quả học tập theo năm học";
            this.Load += new System.EventHandler(this.KQHTtheoNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ketquatheonamhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetKQHTNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNamHoc;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ketquatheonamhocBindingSource;
        private DataSetKQHTNH DataSetKQHTNH;
        private DataSetKQHTNHTableAdapters.ketquatheonamhocTableAdapter ketquatheonamhocTableAdapter;
    }
}