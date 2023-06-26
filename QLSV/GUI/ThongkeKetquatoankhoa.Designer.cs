
namespace GUI
{
    partial class ThongkeKetquatoankhoa
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongkeKetquatoankhoa));
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnReport = new System.Windows.Forms.Button();
            this.ketquatoankhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetKetquatoankhoa = new GUI.DataSetKetquatoankhoa();
            this.ketquatoankhoaTableAdapter = new GUI.DataSetKetquatoankhoaTableAdapters.ketquatoankhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ketquatoankhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetKetquatoankhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(456, 62);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(164, 26);
            this.txtMaSV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên:";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ketquatoankhoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ThongkeKetquatoankhoa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(81, 143);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1154, 831);
            this.reportViewer1.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(730, 48);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(110, 55);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // ketquatoankhoaBindingSource
            // 
            this.ketquatoankhoaBindingSource.DataMember = "ketquatoankhoa";
            this.ketquatoankhoaBindingSource.DataSource = this.DataSetKetquatoankhoa;
            // 
            // DataSetKetquatoankhoa
            // 
            this.DataSetKetquatoankhoa.DataSetName = "DataSetKetquatoankhoa";
            this.DataSetKetquatoankhoa.EnforceConstraints = false;
            this.DataSetKetquatoankhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ketquatoankhoaTableAdapter
            // 
            this.ketquatoankhoaTableAdapter.ClearBeforeFill = true;
            // 
            // ThongkeKetquatoankhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 986);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongkeKetquatoankhoa";
            this.Text = "ThongkeKetquatoankhoa";
            this.Load += new System.EventHandler(this.ThongkeKetquatoankhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ketquatoankhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetKetquatoankhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ketquatoankhoaBindingSource;
        private DataSetKetquatoankhoa DataSetKetquatoankhoa;
        private System.Windows.Forms.Button btnReport;
        private DataSetKetquatoankhoaTableAdapters.ketquatoankhoaTableAdapter ketquatoankhoaTableAdapter;
    }
}