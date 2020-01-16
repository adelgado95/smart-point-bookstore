namespace LibreriaParraJr
{
    partial class ControlReporteCaja
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_reporte_caja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgtbc_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbc_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte_caja)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_reporte_caja
            // 
            this.dg_reporte_caja.AllowUserToAddRows = false;
            this.dg_reporte_caja.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_reporte_caja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_reporte_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_reporte_caja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtbc_usuario,
            this.dgtbc_total});
            this.dg_reporte_caja.Location = new System.Drawing.Point(15, 63);
            this.dg_reporte_caja.Name = "dg_reporte_caja";
            this.dg_reporte_caja.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_reporte_caja.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_reporte_caja.Size = new System.Drawing.Size(240, 150);
            this.dg_reporte_caja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte de Caja";
            // 
            // dgtbc_usuario
            // 
            this.dgtbc_usuario.HeaderText = "Usuario";
            this.dgtbc_usuario.Name = "dgtbc_usuario";
            this.dgtbc_usuario.ReadOnly = true;
            this.dgtbc_usuario.Width = 142;
            // 
            // dgtbc_total
            // 
            this.dgtbc_total.HeaderText = "Total";
            this.dgtbc_total.Name = "dgtbc_total";
            this.dgtbc_total.ReadOnly = true;
            this.dgtbc_total.Width = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total =>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(160, 224);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(24, 25);
            this.lb_total.TabIndex = 3;
            this.lb_total.Text = "0";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlReporteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_reporte_caja);
            this.Name = "ControlReporteCaja";
            this.Size = new System.Drawing.Size(268, 258);
            this.Load += new System.EventHandler(this.ControlReporteCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte_caja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_reporte_caja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_total;
    }
}
