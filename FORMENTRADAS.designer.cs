namespace LibreriaParraJr
{
    partial class FORMENTRADAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORMENTRADAS));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_entrada_productos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.tb_agregar = new System.Windows.Forms.Button();
            this.tb_eliminar = new System.Windows.Forms.Button();
            this.tb_codigo_barras = new System.Windows.Forms.TextBox();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.tb_ubicacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_proveedor = new System.Windows.Forms.TextBox();
            this.tb_categoria = new System.Windows.Forms.TextBox();
            this.datos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_buscar_codigo = new System.Windows.Forms.Button();
            this.tb_cancelar1 = new System.Windows.Forms.Button();
            this.tb_editar = new System.Windows.Forms.Button();
            this.cb_presentacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entrada_productos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(570, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad:";
            // 
            // dgv_entrada_productos
            // 
            this.dgv_entrada_productos.AllowUserToAddRows = false;
            this.dgv_entrada_productos.AllowUserToDeleteRows = false;
            this.dgv_entrada_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_entrada_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_entrada_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_entrada_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column3,
            this.Column1,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgv_entrada_productos.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_entrada_productos.Location = new System.Drawing.Point(22, 197);
            this.dgv_entrada_productos.Name = "dgv_entrada_productos";
            this.dgv_entrada_productos.ReadOnly = true;
            this.dgv_entrada_productos.Size = new System.Drawing.Size(832, 259);
            this.dgv_entrada_productos.TabIndex = 13;
            this.dgv_entrada_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_entrada_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 69;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 74;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 62;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ubicación";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Marca";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 62;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Descripción";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 88;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Presentación";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 94;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Proveedor";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 81;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Categoría";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 79;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_cancelar.Location = new System.Drawing.Point(325, 478);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 40);
            this.bt_cancelar.TabIndex = 14;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_registrar
            // 
            this.bt_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_registrar.Location = new System.Drawing.Point(436, 478);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(79, 40);
            this.bt_registrar.TabIndex = 15;
            this.bt_registrar.Text = "Registrar";
            this.bt_registrar.UseVisualStyleBackColor = true;
            this.bt_registrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_agregar
            // 
            this.tb_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_agregar.Location = new System.Drawing.Point(352, 132);
            this.tb_agregar.Name = "tb_agregar";
            this.tb_agregar.Size = new System.Drawing.Size(82, 24);
            this.tb_agregar.TabIndex = 11;
            this.tb_agregar.Text = "Agregar";
            this.tb_agregar.UseVisualStyleBackColor = true;
            this.tb_agregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_eliminar
            // 
            this.tb_eliminar.Enabled = false;
            this.tb_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_eliminar.Location = new System.Drawing.Point(459, 134);
            this.tb_eliminar.Name = "tb_eliminar";
            this.tb_eliminar.Size = new System.Drawing.Size(76, 24);
            this.tb_eliminar.TabIndex = 12;
            this.tb_eliminar.Text = "Eliminar";
            this.tb_eliminar.UseVisualStyleBackColor = true;
            this.tb_eliminar.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_codigo_barras
            // 
            this.tb_codigo_barras.Location = new System.Drawing.Point(122, 22);
            this.tb_codigo_barras.Name = "tb_codigo_barras";
            this.tb_codigo_barras.Size = new System.Drawing.Size(126, 20);
            this.tb_codigo_barras.TabIndex = 0;
            this.tb_codigo_barras.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Location = new System.Drawing.Point(122, 93);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(178, 20);
            this.tb_descripcion.TabIndex = 7;
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(641, 22);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(153, 20);
            this.tb_cantidad.TabIndex = 2;
            this.tb_cantidad.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.tb_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // tb_ubicacion
            // 
            this.tb_ubicacion.Location = new System.Drawing.Point(122, 59);
            this.tb_ubicacion.Name = "tb_ubicacion";
            this.tb_ubicacion.Size = new System.Drawing.Size(178, 20);
            this.tb_ubicacion.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ubicación:";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(395, 22);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(170, 20);
            this.tb_nombre.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(321, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre:";
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(418, 60);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(78, 20);
            this.tb_precio.TabIndex = 5;
            this.tb_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(321, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio:";
            // 
            // tb_marca
            // 
            this.tb_marca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_marca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_marca.Location = new System.Drawing.Point(641, 60);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(153, 20);
            this.tb_marca.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(584, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(321, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Presentación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(562, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Proveedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(22, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Categoría:";
            // 
            // tb_proveedor
            // 
            this.tb_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_proveedor.Location = new System.Drawing.Point(641, 91);
            this.tb_proveedor.Name = "tb_proveedor";
            this.tb_proveedor.Size = new System.Drawing.Size(153, 20);
            this.tb_proveedor.TabIndex = 9;
            // 
            // tb_categoria
            // 
            this.tb_categoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_categoria.Location = new System.Drawing.Point(122, 131);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(178, 20);
            this.tb_categoria.TabIndex = 10;
            // 
            // datos
            // 
            this.datos.Controls.Add(this.pictureBox1);
            this.datos.Controls.Add(this.bt_buscar_codigo);
            this.datos.Controls.Add(this.tb_cancelar1);
            this.datos.Controls.Add(this.tb_editar);
            this.datos.Controls.Add(this.cb_presentacion);
            this.datos.Controls.Add(this.tb_ubicacion);
            this.datos.Controls.Add(this.label2);
            this.datos.Controls.Add(this.tb_eliminar);
            this.datos.Controls.Add(this.tb_categoria);
            this.datos.Controls.Add(this.label3);
            this.datos.Controls.Add(this.tb_proveedor);
            this.datos.Controls.Add(this.label4);
            this.datos.Controls.Add(this.label11);
            this.datos.Controls.Add(this.tb_agregar);
            this.datos.Controls.Add(this.label10);
            this.datos.Controls.Add(this.label9);
            this.datos.Controls.Add(this.tb_codigo_barras);
            this.datos.Controls.Add(this.tb_descripcion);
            this.datos.Controls.Add(this.tb_marca);
            this.datos.Controls.Add(this.tb_cantidad);
            this.datos.Controls.Add(this.label8);
            this.datos.Controls.Add(this.label7);
            this.datos.Controls.Add(this.tb_precio);
            this.datos.Controls.Add(this.label5);
            this.datos.Controls.Add(this.tb_nombre);
            this.datos.Controls.Add(this.label6);
            this.datos.Location = new System.Drawing.Point(22, 11);
            this.datos.Margin = new System.Windows.Forms.Padding(2);
            this.datos.Name = "datos";
            this.datos.Padding = new System.Windows.Forms.Padding(2);
            this.datos.Size = new System.Drawing.Size(832, 180);
            this.datos.TabIndex = 28;
            this.datos.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.insertar_codigos_barra_click);
            // 
            // bt_buscar_codigo
            // 
            this.bt_buscar_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_buscar_codigo.Location = new System.Drawing.Point(254, 20);
            this.bt_buscar_codigo.Name = "bt_buscar_codigo";
            this.bt_buscar_codigo.Size = new System.Drawing.Size(62, 23);
            this.bt_buscar_codigo.TabIndex = 28;
            this.bt_buscar_codigo.Text = "Buscar";
            this.bt_buscar_codigo.UseVisualStyleBackColor = true;
            this.bt_buscar_codigo.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // tb_cancelar1
            // 
            this.tb_cancelar1.Enabled = false;
            this.tb_cancelar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_cancelar1.Location = new System.Drawing.Point(655, 134);
            this.tb_cancelar1.Name = "tb_cancelar1";
            this.tb_cancelar1.Size = new System.Drawing.Size(76, 24);
            this.tb_cancelar1.TabIndex = 27;
            this.tb_cancelar1.Text = "Cancelar";
            this.tb_cancelar1.UseVisualStyleBackColor = true;
            this.tb_cancelar1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_editar
            // 
            this.tb_editar.Enabled = false;
            this.tb_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_editar.Location = new System.Drawing.Point(548, 134);
            this.tb_editar.Name = "tb_editar";
            this.tb_editar.Size = new System.Drawing.Size(82, 24);
            this.tb_editar.TabIndex = 26;
            this.tb_editar.Text = "Editar";
            this.tb_editar.UseVisualStyleBackColor = true;
            this.tb_editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // cb_presentacion
            // 
            this.cb_presentacion.FormattingEnabled = true;
            this.cb_presentacion.Items.AddRange(new object[] {
            "UNIDAD",
            "DOCENA",
            "RESMA",
            "CAJA",
            "PAQUETE",
            "OTROS"});
            this.cb_presentacion.Location = new System.Drawing.Point(418, 93);
            this.cb_presentacion.Margin = new System.Windows.Forms.Padding(2);
            this.cb_presentacion.Name = "cb_presentacion";
            this.cb_presentacion.Size = new System.Drawing.Size(78, 21);
            this.cb_presentacion.TabIndex = 8;
            // 
            // FORMENTRADAS
            // 
            this.AcceptButton = this.bt_buscar_codigo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 528);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.dgv_entrada_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FORMENTRADAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENTRADA DE PRODUCTO";
            this.Load += new System.EventHandler(this.FORMENTRADAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entrada_productos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_entrada_productos;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Button tb_agregar;
        private System.Windows.Forms.Button tb_eliminar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.TextBox tb_ubicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_proveedor;
        private System.Windows.Forms.TextBox tb_categoria;
        private System.Windows.Forms.GroupBox datos;
        private System.Windows.Forms.ComboBox cb_presentacion;
        private System.Windows.Forms.Button tb_editar;
        private System.Windows.Forms.Button tb_cancelar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button bt_buscar_codigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox tb_codigo_barras;
    }
}