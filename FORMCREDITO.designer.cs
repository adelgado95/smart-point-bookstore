namespace LibreriaParraJr
{
    partial class FORMCREDITO
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
            this.dgv_creditos = new System.Windows.Forms.DataGridView();
            this.orden = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.RadioButton();
            this.fecha_final = new System.Windows.Forms.RadioButton();
            this.orden2 = new System.Windows.Forms.GroupBox();
            this.desc = new System.Windows.Forms.RadioButton();
            this.asc = new System.Windows.Forms.RadioButton();
            this.btn_ver = new System.Windows.Forms.Button();
            this.cb_proveedor = new System.Windows.Forms.ComboBox();
            this.label_empresa = new System.Windows.Forms.Label();
            this.btn_ver_pagos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_creditos)).BeginInit();
            this.orden.SuspendLayout();
            this.orden2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_creditos
            // 
            this.dgv_creditos.AllowUserToAddRows = false;
            this.dgv_creditos.AllowUserToDeleteRows = false;
            this.dgv_creditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_creditos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_creditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_creditos.Location = new System.Drawing.Point(9, 121);
            this.dgv_creditos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_creditos.Name = "dgv_creditos";
            this.dgv_creditos.ReadOnly = true;
            this.dgv_creditos.RowHeadersWidth = 42;
            this.dgv_creditos.RowTemplate.Height = 24;
            this.dgv_creditos.Size = new System.Drawing.Size(508, 261);
            this.dgv_creditos.TabIndex = 0;
            this.dgv_creditos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // orden
            // 
            this.orden.Controls.Add(this.total);
            this.orden.Controls.Add(this.fecha_final);
            this.orden.Location = new System.Drawing.Point(184, 32);
            this.orden.Margin = new System.Windows.Forms.Padding(2);
            this.orden.Name = "orden";
            this.orden.Padding = new System.Windows.Forms.Padding(2);
            this.orden.Size = new System.Drawing.Size(151, 42);
            this.orden.TabIndex = 1;
            this.orden.TabStop = false;
            this.orden.Text = "Ordenar Por:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(73, 17);
            this.total.Margin = new System.Windows.Forms.Padding(2);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(67, 17);
            this.total.TabIndex = 1;
            this.total.Text = "Cantidad";
            this.total.UseVisualStyleBackColor = true;
            // 
            // fecha_final
            // 
            this.fecha_final.AutoSize = true;
            this.fecha_final.Checked = true;
            this.fecha_final.Location = new System.Drawing.Point(4, 17);
            this.fecha_final.Margin = new System.Windows.Forms.Padding(2);
            this.fecha_final.Name = "fecha_final";
            this.fecha_final.Size = new System.Drawing.Size(55, 17);
            this.fecha_final.TabIndex = 0;
            this.fecha_final.TabStop = true;
            this.fecha_final.Text = "Fecha";
            this.fecha_final.UseVisualStyleBackColor = true;
            // 
            // orden2
            // 
            this.orden2.Controls.Add(this.desc);
            this.orden2.Controls.Add(this.asc);
            this.orden2.Location = new System.Drawing.Point(339, 32);
            this.orden2.Margin = new System.Windows.Forms.Padding(2);
            this.orden2.Name = "orden2";
            this.orden2.Padding = new System.Windows.Forms.Padding(2);
            this.orden2.Size = new System.Drawing.Size(178, 42);
            this.orden2.TabIndex = 2;
            this.orden2.TabStop = false;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Checked = true;
            this.desc.Location = new System.Drawing.Point(81, 15);
            this.desc.Margin = new System.Windows.Forms.Padding(2);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(89, 17);
            this.desc.TabIndex = 1;
            this.desc.TabStop = true;
            this.desc.Text = "Descendente";
            this.desc.UseVisualStyleBackColor = true;
            // 
            // asc
            // 
            this.asc.AutoSize = true;
            this.asc.Location = new System.Drawing.Point(4, 15);
            this.asc.Margin = new System.Windows.Forms.Padding(2);
            this.asc.Name = "asc";
            this.asc.Size = new System.Drawing.Size(76, 17);
            this.asc.TabIndex = 0;
            this.asc.Text = "Ascedente";
            this.asc.UseVisualStyleBackColor = true;
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(344, 79);
            this.btn_ver.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(80, 30);
            this.btn_ver.TabIndex = 3;
            this.btn_ver.Text = "Listar";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // cb_proveedor
            // 
            this.cb_proveedor.FormattingEnabled = true;
            this.cb_proveedor.Location = new System.Drawing.Point(9, 48);
            this.cb_proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cb_proveedor.Name = "cb_proveedor";
            this.cb_proveedor.Size = new System.Drawing.Size(167, 21);
            this.cb_proveedor.TabIndex = 4;
            this.cb_proveedor.SelectedIndexChanged += new System.EventHandler(this.combo_empresas_SelectedIndexChanged);
            // 
            // label_empresa
            // 
            this.label_empresa.AutoSize = true;
            this.label_empresa.Location = new System.Drawing.Point(9, 32);
            this.label_empresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_empresa.Name = "label_empresa";
            this.label_empresa.Size = new System.Drawing.Size(117, 13);
            this.label_empresa.TabIndex = 5;
            this.label_empresa.Text = "Seleccionar proveedor:";
            // 
            // btn_ver_pagos
            // 
            this.btn_ver_pagos.Enabled = false;
            this.btn_ver_pagos.Location = new System.Drawing.Point(434, 79);
            this.btn_ver_pagos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ver_pagos.Name = "btn_ver_pagos";
            this.btn_ver_pagos.Size = new System.Drawing.Size(80, 30);
            this.btn_ver_pagos.TabIndex = 6;
            this.btn_ver_pagos.Text = "Ver Pagos";
            this.btn_ver_pagos.UseVisualStyleBackColor = true;
            this.btn_ver_pagos.Click += new System.EventHandler(this.btn_ver_pagos_Click);
            // 
            // FORMCREDITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 402);
            this.Controls.Add(this.btn_ver_pagos);
            this.Controls.Add(this.label_empresa);
            this.Controls.Add(this.cb_proveedor);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.orden2);
            this.Controls.Add(this.orden);
            this.Controls.Add(this.dgv_creditos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORMCREDITO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos del proveedor";
            this.Load += new System.EventHandler(this.FORMCREDITO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_creditos)).EndInit();
            this.orden.ResumeLayout(false);
            this.orden.PerformLayout();
            this.orden2.ResumeLayout(false);
            this.orden2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_creditos;
        private System.Windows.Forms.GroupBox orden;
        private System.Windows.Forms.RadioButton total;
        private System.Windows.Forms.RadioButton fecha_final;
        private System.Windows.Forms.GroupBox orden2;
        private System.Windows.Forms.RadioButton desc;
        private System.Windows.Forms.RadioButton asc;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.ComboBox cb_proveedor;
        private System.Windows.Forms.Label label_empresa;
        private System.Windows.Forms.Button btn_ver_pagos;
    }
}