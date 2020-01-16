namespace LibreriaParraJr
{
    partial class CONSULTARFACTURAS_
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.r_asc = new System.Windows.Forms.RadioButton();
            this.r_desc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioFecha = new System.Windows.Forms.RadioButton();
            this.bt_recargar = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.tb_buscar_factura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.r_asc);
            this.groupBox2.Controls.Add(this.r_desc);
            this.groupBox2.Location = new System.Drawing.Point(96, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(194, 48);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // r_asc
            // 
            this.r_asc.AutoSize = true;
            this.r_asc.Location = new System.Drawing.Point(4, 23);
            this.r_asc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r_asc.Name = "r_asc";
            this.r_asc.Size = new System.Drawing.Size(82, 17);
            this.r_asc.TabIndex = 9;
            this.r_asc.Text = "Ascendente";
            this.r_asc.UseVisualStyleBackColor = true;
            // 
            // r_desc
            // 
            this.r_desc.AutoSize = true;
            this.r_desc.Checked = true;
            this.r_desc.Location = new System.Drawing.Point(92, 23);
            this.r_desc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.r_desc.Name = "r_desc";
            this.r_desc.Size = new System.Drawing.Size(89, 17);
            this.r_desc.TabIndex = 10;
            this.r_desc.TabStop = true;
            this.r_desc.Text = "Descendente";
            this.r_desc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioFecha);
            this.groupBox1.Location = new System.Drawing.Point(14, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(78, 48);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // RadioFecha
            // 
            this.RadioFecha.AutoSize = true;
            this.RadioFecha.Checked = true;
            this.RadioFecha.Location = new System.Drawing.Point(4, 23);
            this.RadioFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioFecha.Name = "RadioFecha";
            this.RadioFecha.Size = new System.Drawing.Size(55, 17);
            this.RadioFecha.TabIndex = 9;
            this.RadioFecha.TabStop = true;
            this.RadioFecha.Text = "Fecha";
            this.RadioFecha.UseVisualStyleBackColor = true;
            // 
            // bt_recargar
            // 
            this.bt_recargar.Location = new System.Drawing.Point(306, 58);
            this.bt_recargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_recargar.Name = "bt_recargar";
            this.bt_recargar.Size = new System.Drawing.Size(65, 40);
            this.bt_recargar.TabIndex = 19;
            this.bt_recargar.Text = "Recargar";
            this.bt_recargar.UseVisualStyleBackColor = true;
            this.bt_recargar.Click += new System.EventHandler(this.recargar_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(787, 68);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(55, 25);
            this.bt_buscar.TabIndex = 18;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // tb_buscar_factura
            // 
            this.tb_buscar_factura.Location = new System.Drawing.Point(649, 74);
            this.tb_buscar_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_buscar_factura.Name = "tb_buscar_factura";
            this.tb_buscar_factura.Size = new System.Drawing.Size(122, 20);
            this.tb_buscar_factura.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar Factura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Listado de Facturas";
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(465, 472);
            this.bt_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(106, 37);
            this.bt_salir.TabIndex = 14;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(11, 103);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(832, 364);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(306, 472);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(94, 37);
            this.bt_eliminar.TabIndex = 23;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CONSULTARFACTURAS_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 519);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_recargar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_buscar_factura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CONSULTARFACTURAS_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTARFACTURAS_";
            this.Load += new System.EventHandler(this.CONSULTARFACTURAS__Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton r_asc;
        private System.Windows.Forms.RadioButton r_desc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioFecha;
        private System.Windows.Forms.Button bt_recargar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox tb_buscar_factura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_eliminar;
    }
}