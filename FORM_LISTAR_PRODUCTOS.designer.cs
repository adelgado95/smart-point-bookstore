namespace LibreriaParraJr
{
    partial class FORM_LISTAR_PRODUCTOS
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
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.bt_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nombre_producto = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.recargar = new System.Windows.Forms.Button();
            this.bt_generar_reportes = new System.Windows.Forms.Button();
            this.RadioNombre = new System.Windows.Forms.RadioButton();
            this.RadioStock = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioCategoria = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.r_asc = new System.Windows.Forms.RadioButton();
            this.r_desc = new System.Windows.Forms.RadioButton();
            this.Productos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_mandar_bodega = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_salir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Productos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(11, 109);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(1085, 364);
            this.dgv_productos.TabIndex = 0;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            // 
            // bt_Salir
            // 
            this.bt_Salir.Location = new System.Drawing.Point(610, 477);
            this.bt_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Salir.Name = "bt_Salir";
            this.bt_Salir.Size = new System.Drawing.Size(106, 37);
            this.bt_Salir.TabIndex = 1;
            this.bt_Salir.Text = "Salir";
            this.bt_Salir.UseVisualStyleBackColor = true;
            this.bt_Salir.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar nombre de producto:";
            // 
            // tb_nombre_producto
            // 
            this.tb_nombre_producto.Location = new System.Drawing.Point(822, 77);
            this.tb_nombre_producto.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nombre_producto.Name = "tb_nombre_producto";
            this.tb_nombre_producto.Size = new System.Drawing.Size(122, 20);
            this.tb_nombre_producto.TabIndex = 5;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(954, 72);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(55, 25);
            this.bt_buscar.TabIndex = 6;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // recargar
            // 
            this.recargar.Location = new System.Drawing.Point(1030, 64);
            this.recargar.Margin = new System.Windows.Forms.Padding(2);
            this.recargar.Name = "recargar";
            this.recargar.Size = new System.Drawing.Size(65, 40);
            this.recargar.TabIndex = 7;
            this.recargar.Text = "Recargar";
            this.recargar.UseVisualStyleBackColor = true;
            this.recargar.Click += new System.EventHandler(this.recargar_Click);
            // 
            // bt_generar_reportes
            // 
            this.bt_generar_reportes.Location = new System.Drawing.Point(483, 478);
            this.bt_generar_reportes.Margin = new System.Windows.Forms.Padding(2);
            this.bt_generar_reportes.Name = "bt_generar_reportes";
            this.bt_generar_reportes.Size = new System.Drawing.Size(103, 35);
            this.bt_generar_reportes.TabIndex = 8;
            this.bt_generar_reportes.Text = "Generar Reportes";
            this.bt_generar_reportes.UseVisualStyleBackColor = true;
            this.bt_generar_reportes.Click += new System.EventHandler(this.reportes_Click);
            // 
            // RadioNombre
            // 
            this.RadioNombre.AutoSize = true;
            this.RadioNombre.Checked = true;
            this.RadioNombre.Location = new System.Drawing.Point(4, 23);
            this.RadioNombre.Margin = new System.Windows.Forms.Padding(2);
            this.RadioNombre.Name = "RadioNombre";
            this.RadioNombre.Size = new System.Drawing.Size(62, 17);
            this.RadioNombre.TabIndex = 9;
            this.RadioNombre.TabStop = true;
            this.RadioNombre.Text = "Nombre";
            this.RadioNombre.UseVisualStyleBackColor = true;
            // 
            // RadioStock
            // 
            this.RadioStock.AutoSize = true;
            this.RadioStock.Location = new System.Drawing.Point(81, 23);
            this.RadioStock.Margin = new System.Windows.Forms.Padding(2);
            this.RadioStock.Name = "RadioStock";
            this.RadioStock.Size = new System.Drawing.Size(53, 17);
            this.RadioStock.TabIndex = 10;
            this.RadioStock.Text = "Stock";
            this.RadioStock.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioCategoria);
            this.groupBox1.Controls.Add(this.RadioNombre);
            this.groupBox1.Controls.Add(this.RadioStock);
            this.groupBox1.Location = new System.Drawing.Point(14, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(220, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // RadioCategoria
            // 
            this.RadioCategoria.AutoSize = true;
            this.RadioCategoria.Location = new System.Drawing.Point(142, 22);
            this.RadioCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.RadioCategoria.Name = "RadioCategoria";
            this.RadioCategoria.Size = new System.Drawing.Size(72, 17);
            this.RadioCategoria.TabIndex = 11;
            this.RadioCategoria.Text = "Categoría";
            this.RadioCategoria.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.r_asc);
            this.groupBox2.Controls.Add(this.r_desc);
            this.groupBox2.Location = new System.Drawing.Point(257, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(194, 48);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // r_asc
            // 
            this.r_asc.AutoSize = true;
            this.r_asc.Location = new System.Drawing.Point(4, 23);
            this.r_asc.Margin = new System.Windows.Forms.Padding(2);
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
            this.r_desc.Margin = new System.Windows.Forms.Padding(2);
            this.r_desc.Name = "r_desc";
            this.r_desc.Size = new System.Drawing.Size(89, 17);
            this.r_desc.TabIndex = 10;
            this.r_desc.TabStop = true;
            this.r_desc.Text = "Descendente";
            this.r_desc.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.Productos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_mandar_bodega,
            this.tsmi_salir});
            this.Productos.Name = "contextMenuStrip1";
            this.Productos.Size = new System.Drawing.Size(168, 48);
            // 
            // tsmi_mandar_bodega
            // 
            this.tsmi_mandar_bodega.Name = "tsmi_mandar_bodega";
            this.tsmi_mandar_bodega.Size = new System.Drawing.Size(167, 22);
            this.tsmi_mandar_bodega.Text = "Mandar a Bodega";
            this.tsmi_mandar_bodega.Click += new System.EventHandler(this.tsmi_mandar_bodega_click);
            // 
            // tsmi_salir
            // 
            this.tsmi_salir.Name = "tsmi_salir";
            this.tsmi_salir.Size = new System.Drawing.Size(167, 22);
            this.tsmi_salir.Text = "Salir";
            this.tsmi_salir.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // FORM_LISTAR_PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 519);
            this.ContextMenuStrip = this.Productos;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_generar_reportes);
            this.Controls.Add(this.recargar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_nombre_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Salir);
            this.Controls.Add(this.dgv_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_LISTAR_PRODUCTOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_LISTAR_PRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Productos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button bt_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nombre_producto;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button recargar;
        private System.Windows.Forms.Button bt_generar_reportes;
        private System.Windows.Forms.RadioButton RadioNombre;
        private System.Windows.Forms.RadioButton RadioStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton r_asc;
        private System.Windows.Forms.RadioButton r_desc;
        private System.Windows.Forms.RadioButton RadioCategoria;
        private System.Windows.Forms.ContextMenuStrip Productos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mandar_bodega;
        private System.Windows.Forms.ToolStripMenuItem tsmi_salir;
    }
}