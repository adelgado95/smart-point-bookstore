namespace LibreriaParraJr
{
    partial class FORM_LISTAR_BODEGA
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.r_asc = new System.Windows.Forms.RadioButton();
            this.r_desc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioCategoria = new System.Windows.Forms.RadioButton();
            this.RadioNombre = new System.Windows.Forms.RadioButton();
            this.RadioStock = new System.Windows.Forms.RadioButton();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.tb_nombre_producto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.bt_Salir = new System.Windows.Forms.Button();
            this.cms_mandar_a_inventario = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mandarAInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.cms_mandar_a_inventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de productos en Bodega";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.r_asc);
            this.groupBox2.Controls.Add(this.r_desc);
            this.groupBox2.Location = new System.Drawing.Point(252, 51);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(194, 48);
            this.groupBox2.TabIndex = 17;
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
            this.r_asc.CheckedChanged += new System.EventHandler(this.r_asc_CheckedChanged);
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
            this.r_desc.CheckedChanged += new System.EventHandler(this.r_desc_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioCategoria);
            this.groupBox1.Controls.Add(this.RadioNombre);
            this.groupBox1.Controls.Add(this.RadioStock);
            this.groupBox1.Location = new System.Drawing.Point(9, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(220, 48);
            this.groupBox1.TabIndex = 16;
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
            this.RadioCategoria.CheckedChanged += new System.EventHandler(this.RadioCategoria_CheckedChanged);
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
            this.RadioNombre.CheckedChanged += new System.EventHandler(this.RadioNombre_CheckedChanged);
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
            this.RadioStock.CheckedChanged += new System.EventHandler(this.RadioStock_CheckedChanged);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(949, 69);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(55, 25);
            this.bt_buscar.TabIndex = 15;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // tb_nombre_producto
            // 
            this.tb_nombre_producto.Location = new System.Drawing.Point(817, 74);
            this.tb_nombre_producto.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nombre_producto.Name = "tb_nombre_producto";
            this.tb_nombre_producto.Size = new System.Drawing.Size(122, 20);
            this.tb_nombre_producto.TabIndex = 14;
            this.tb_nombre_producto.TextChanged += new System.EventHandler(this.bt_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Buscar nombre de producto:";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.ContextMenuStrip = this.cms_mandar_a_inventario;
            this.dgv_productos.Location = new System.Drawing.Point(9, 102);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(1011, 364);
            this.dgv_productos.TabIndex = 18;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_cellclick);
            // 
            // bt_Salir
            // 
            this.bt_Salir.Location = new System.Drawing.Point(424, 471);
            this.bt_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Salir.Name = "bt_Salir";
            this.bt_Salir.Size = new System.Drawing.Size(106, 37);
            this.bt_Salir.TabIndex = 19;
            this.bt_Salir.Text = "Salir";
            this.bt_Salir.UseVisualStyleBackColor = true;
            this.bt_Salir.Click += new System.EventHandler(this.bt_Salir_Click);
            // 
            // cms_mandar_a_inventario
            // 
            this.cms_mandar_a_inventario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mandarAInventarioToolStripMenuItem});
            this.cms_mandar_a_inventario.Name = "cms_mandar_a_inventario";
            this.cms_mandar_a_inventario.Size = new System.Drawing.Size(181, 26);
            this.cms_mandar_a_inventario.Text = "Opciones Bodega";
            // 
            // mandarAInventarioToolStripMenuItem
            // 
            this.mandarAInventarioToolStripMenuItem.Name = "mandarAInventarioToolStripMenuItem";
            this.mandarAInventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mandarAInventarioToolStripMenuItem.Text = "Mandar a Inventario";
            this.mandarAInventarioToolStripMenuItem.Click += new System.EventHandler(this.mandarAInventarioToolStripMenuItem_Click);
            // 
            // FORM_LISTAR_BODEGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 519);
            this.Controls.Add(this.bt_Salir);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_nombre_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FORM_LISTAR_BODEGA";
            this.Text = "FORM_LISTAR_BODEGA";
            this.Load += new System.EventHandler(this.FORM_LISTAR_BODEGA_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.cms_mandar_a_inventario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton r_asc;
        private System.Windows.Forms.RadioButton r_desc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioCategoria;
        private System.Windows.Forms.RadioButton RadioNombre;
        private System.Windows.Forms.RadioButton RadioStock;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox tb_nombre_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button bt_Salir;
        private System.Windows.Forms.ContextMenuStrip cms_mandar_a_inventario;
        private System.Windows.Forms.ToolStripMenuItem mandarAInventarioToolStripMenuItem;
    }
}