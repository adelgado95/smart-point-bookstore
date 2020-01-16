namespace LibreriaParraJr
{
    partial class CONTENEDORREPORTETODOS
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
            this.DataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Conjunto1 = new LibreriaParraJr.Conjunto1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable4TableAdapter = new LibreriaParraJr.Conjunto1TableAdapters.DataTable4TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conjunto1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable4BindingSource
            // 
            this.DataTable4BindingSource.DataMember = "DataTable4";
            this.DataTable4BindingSource.DataSource = this.Conjunto1;
            // 
            // Conjunto1
            // 
            this.Conjunto1.DataSetName = "Conjunto1";
            this.Conjunto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibreriaParraJr.ReporteTODOSRDLC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(989, 620);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataTable4TableAdapter
            // 
            this.DataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // CONTENEDORREPORTETODOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 620);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CONTENEDORREPORTETODOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTENEDORREPORTETODOS";
            this.Load += new System.EventHandler(this.CONTENEDORREPORTETODOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conjunto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable4BindingSource;
        private Conjunto1 Conjunto1;
        private Conjunto1TableAdapters.DataTable4TableAdapter DataTable4TableAdapter;
    }
}