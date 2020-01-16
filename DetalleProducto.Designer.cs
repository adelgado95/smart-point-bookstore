namespace LibreriaParraJr
{
    partial class DetalleProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codigo_barra = new System.Windows.Forms.TextBox();
            this.tb_numero_serie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_estado_producto = new System.Windows.Forms.ComboBox();
            this.bt_agregar_codigo_barra = new System.Windows.Forms.Button();
            this.bt_editar_codigo_barra = new System.Windows.Forms.Button();
            this.bt_eliminar_codigo_barra = new System.Windows.Forms.Button();
            this.dg_detalle_producto = new System.Windows.Forms.DataGridView();
            this.bt_cancelar_operacion = new System.Windows.Forms.Button();
            this.bt_ingresar_codigos_barras = new System.Windows.Forms.Button();
            this.tb_caracteristica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_cantidad_individual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgtbc_codigo_barras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbc_cantidad_individual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbc_caracteristica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbc_numero_serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbc_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalle_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserciones de Codigos de Barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Barras :";
            // 
            // tb_codigo_barra
            // 
            this.tb_codigo_barra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo_barra.Location = new System.Drawing.Point(219, 71);
            this.tb_codigo_barra.Name = "tb_codigo_barra";
            this.tb_codigo_barra.Size = new System.Drawing.Size(317, 31);
            this.tb_codigo_barra.TabIndex = 3;
            // 
            // tb_numero_serie
            // 
            this.tb_numero_serie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numero_serie.Location = new System.Drawing.Point(219, 117);
            this.tb_numero_serie.Name = "tb_numero_serie";
            this.tb_numero_serie.Size = new System.Drawing.Size(317, 31);
            this.tb_numero_serie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero de Serie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado :";
            // 
            // cb_estado_producto
            // 
            this.cb_estado_producto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado_producto.FormattingEnabled = true;
            this.cb_estado_producto.Items.AddRange(new object[] {
            "DISPONIBLE",
            "VENDIDO",
            "DEVUELTO",
            "PENDIENTE",
            "ENTREGADO"});
            this.cb_estado_producto.Location = new System.Drawing.Point(158, 163);
            this.cb_estado_producto.Name = "cb_estado_producto";
            this.cb_estado_producto.Size = new System.Drawing.Size(157, 30);
            this.cb_estado_producto.TabIndex = 7;
            // 
            // bt_agregar_codigo_barra
            // 
            this.bt_agregar_codigo_barra.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_agregar_codigo_barra.FlatAppearance.BorderSize = 0;
            this.bt_agregar_codigo_barra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_agregar_codigo_barra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_agregar_codigo_barra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar_codigo_barra.ForeColor = System.Drawing.Color.White;
            this.bt_agregar_codigo_barra.Location = new System.Drawing.Point(50, 271);
            this.bt_agregar_codigo_barra.Name = "bt_agregar_codigo_barra";
            this.bt_agregar_codigo_barra.Size = new System.Drawing.Size(115, 41);
            this.bt_agregar_codigo_barra.TabIndex = 8;
            this.bt_agregar_codigo_barra.Text = "Agregar";
            this.bt_agregar_codigo_barra.UseVisualStyleBackColor = false;
            this.bt_agregar_codigo_barra.Click += new System.EventHandler(this.bt_agregar_codigo_barra_Click);
            // 
            // bt_editar_codigo_barra
            // 
            this.bt_editar_codigo_barra.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_editar_codigo_barra.FlatAppearance.BorderSize = 0;
            this.bt_editar_codigo_barra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_editar_codigo_barra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_editar_codigo_barra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar_codigo_barra.ForeColor = System.Drawing.Color.White;
            this.bt_editar_codigo_barra.Location = new System.Drawing.Point(241, 271);
            this.bt_editar_codigo_barra.Name = "bt_editar_codigo_barra";
            this.bt_editar_codigo_barra.Size = new System.Drawing.Size(115, 41);
            this.bt_editar_codigo_barra.TabIndex = 9;
            this.bt_editar_codigo_barra.Text = "Editar";
            this.bt_editar_codigo_barra.UseVisualStyleBackColor = false;
            this.bt_editar_codigo_barra.Click += new System.EventHandler(this.bt_editar_codigo_barra_Click);
            // 
            // bt_eliminar_codigo_barra
            // 
            this.bt_eliminar_codigo_barra.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_eliminar_codigo_barra.FlatAppearance.BorderSize = 0;
            this.bt_eliminar_codigo_barra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_eliminar_codigo_barra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_eliminar_codigo_barra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eliminar_codigo_barra.ForeColor = System.Drawing.Color.White;
            this.bt_eliminar_codigo_barra.Location = new System.Drawing.Point(430, 271);
            this.bt_eliminar_codigo_barra.Name = "bt_eliminar_codigo_barra";
            this.bt_eliminar_codigo_barra.Size = new System.Drawing.Size(115, 41);
            this.bt_eliminar_codigo_barra.TabIndex = 10;
            this.bt_eliminar_codigo_barra.Text = "Eliminar";
            this.bt_eliminar_codigo_barra.UseVisualStyleBackColor = false;
            this.bt_eliminar_codigo_barra.Click += new System.EventHandler(this.bt_eliminar_codigo_barra_Click);
            // 
            // dg_detalle_producto
            // 
            this.dg_detalle_producto.AllowUserToAddRows = false;
            this.dg_detalle_producto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_detalle_producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_detalle_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detalle_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtbc_codigo_barras,
            this.dgtbc_cantidad_individual,
            this.dgtbc_caracteristica,
            this.dgtbc_numero_serie,
            this.dgtbc_estado});
            this.dg_detalle_producto.Location = new System.Drawing.Point(50, 327);
            this.dg_detalle_producto.Name = "dg_detalle_producto";
            this.dg_detalle_producto.ReadOnly = true;
            this.dg_detalle_producto.Size = new System.Drawing.Size(495, 105);
            this.dg_detalle_producto.TabIndex = 11;
            this.dg_detalle_producto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionar_detalle_cellclick);
            // 
            // bt_cancelar_operacion
            // 
            this.bt_cancelar_operacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_cancelar_operacion.FlatAppearance.BorderSize = 0;
            this.bt_cancelar_operacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_cancelar_operacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_cancelar_operacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar_operacion.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar_operacion.Location = new System.Drawing.Point(349, 447);
            this.bt_cancelar_operacion.Name = "bt_cancelar_operacion";
            this.bt_cancelar_operacion.Size = new System.Drawing.Size(115, 41);
            this.bt_cancelar_operacion.TabIndex = 13;
            this.bt_cancelar_operacion.Text = "Cancelar";
            this.bt_cancelar_operacion.UseVisualStyleBackColor = false;
            this.bt_cancelar_operacion.Click += new System.EventHandler(this.bt_cancelar_operacion_Click);
            // 
            // bt_ingresar_codigos_barras
            // 
            this.bt_ingresar_codigos_barras.BackColor = System.Drawing.Color.RoyalBlue;
            this.bt_ingresar_codigos_barras.FlatAppearance.BorderSize = 0;
            this.bt_ingresar_codigos_barras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_ingresar_codigos_barras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_ingresar_codigos_barras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresar_codigos_barras.ForeColor = System.Drawing.Color.White;
            this.bt_ingresar_codigos_barras.Location = new System.Drawing.Point(158, 447);
            this.bt_ingresar_codigos_barras.Name = "bt_ingresar_codigos_barras";
            this.bt_ingresar_codigos_barras.Size = new System.Drawing.Size(115, 41);
            this.bt_ingresar_codigos_barras.TabIndex = 12;
            this.bt_ingresar_codigos_barras.Text = "Ingresar";
            this.bt_ingresar_codigos_barras.UseVisualStyleBackColor = false;
            this.bt_ingresar_codigos_barras.Click += new System.EventHandler(this.bt_ingresar_codigos_barras_Click);
            // 
            // tb_caracteristica
            // 
            this.tb_caracteristica.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_caracteristica.Location = new System.Drawing.Point(216, 207);
            this.tb_caracteristica.Name = "tb_caracteristica";
            this.tb_caracteristica.Size = new System.Drawing.Size(317, 31);
            this.tb_caracteristica.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Caracteristica Unica :";
            // 
            // tb_cantidad_individual
            // 
            this.tb_cantidad_individual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cantidad_individual.Location = new System.Drawing.Point(419, 163);
            this.tb_cantidad_individual.Name = "tb_cantidad_individual";
            this.tb_cantidad_individual.Size = new System.Drawing.Size(117, 31);
            this.tb_cantidad_individual.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cantidad :";
            // 
            // dgtbc_codigo_barras
            // 
            this.dgtbc_codigo_barras.DataPropertyName = "codigo_barras";
            this.dgtbc_codigo_barras.HeaderText = "Codigo Barras";
            this.dgtbc_codigo_barras.Name = "dgtbc_codigo_barras";
            this.dgtbc_codigo_barras.ReadOnly = true;
            this.dgtbc_codigo_barras.Width = 125;
            // 
            // dgtbc_cantidad_individual
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgtbc_cantidad_individual.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgtbc_cantidad_individual.HeaderText = "Cantidad";
            this.dgtbc_cantidad_individual.Name = "dgtbc_cantidad_individual";
            this.dgtbc_cantidad_individual.ReadOnly = true;
            this.dgtbc_cantidad_individual.Width = 75;
            // 
            // dgtbc_caracteristica
            // 
            this.dgtbc_caracteristica.HeaderText = "Caracteristica";
            this.dgtbc_caracteristica.Name = "dgtbc_caracteristica";
            this.dgtbc_caracteristica.ReadOnly = true;
            // 
            // dgtbc_numero_serie
            // 
            this.dgtbc_numero_serie.HeaderText = "Numero Serie";
            this.dgtbc_numero_serie.Name = "dgtbc_numero_serie";
            this.dgtbc_numero_serie.ReadOnly = true;
            this.dgtbc_numero_serie.Width = 118;
            // 
            // dgtbc_estado
            // 
            this.dgtbc_estado.HeaderText = "Estado";
            this.dgtbc_estado.Name = "dgtbc_estado";
            this.dgtbc_estado.ReadOnly = true;
            this.dgtbc_estado.Width = 80;
            // 
            // DetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(613, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_cantidad_individual);
            this.Controls.Add(this.tb_caracteristica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_cancelar_operacion);
            this.Controls.Add(this.bt_ingresar_codigos_barras);
            this.Controls.Add(this.dg_detalle_producto);
            this.Controls.Add(this.bt_eliminar_codigo_barra);
            this.Controls.Add(this.bt_editar_codigo_barra);
            this.Controls.Add(this.bt_agregar_codigo_barra);
            this.Controls.Add(this.cb_estado_producto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_numero_serie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_codigo_barra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DetalleProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleProducto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detalle_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_codigo_barra;
        private System.Windows.Forms.TextBox tb_numero_serie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_estado_producto;
        private System.Windows.Forms.Button bt_agregar_codigo_barra;
        private System.Windows.Forms.Button bt_editar_codigo_barra;
        private System.Windows.Forms.Button bt_eliminar_codigo_barra;
        private System.Windows.Forms.DataGridView dg_detalle_producto;
        private System.Windows.Forms.Button bt_cancelar_operacion;
        private System.Windows.Forms.Button bt_ingresar_codigos_barras;
        private System.Windows.Forms.TextBox tb_caracteristica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cantidad_individual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_codigo_barras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_cantidad_individual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_caracteristica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_numero_serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_estado;
    }
}