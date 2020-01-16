namespace LibreriaParraJr
{
    partial class form_ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.tb_codigo_producto = new System.Windows.Forms.TextBox();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_buscar_cliente = new System.Windows.Forms.Button();
            this.bt_facturar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_tipo_pago = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_buscar_producto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion_pago = new System.Windows.Forms.TextBox();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.MaskedTextBox();
            this.btn_pedido = new System.Windows.Forms.Button();
            this.lb_porc = new System.Windows.Forms.Label();
            this.nud_descuento = new System.Windows.Forms.NumericUpDown();
            this.chb_descuento = new System.Windows.Forms.CheckBox();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedido_row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_descuento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(35, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(36, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(248, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(526, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad";
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AllowUserToAddRows = false;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.pedido_row});
            this.dgv_ventas.Location = new System.Drawing.Point(40, 110);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.Size = new System.Drawing.Size(986, 383);
            this.dgv_ventas.TabIndex = 8;
            this.dgv_ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tb_codigo_producto
            // 
            this.tb_codigo_producto.Location = new System.Drawing.Point(85, 67);
            this.tb_codigo_producto.Name = "tb_codigo_producto";
            this.tb_codigo_producto.Size = new System.Drawing.Size(100, 20);
            this.tb_codigo_producto.TabIndex = 1;
            this.tb_codigo_producto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tb_codigo_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Location = new System.Drawing.Point(336, 67);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(184, 20);
            this.tb_descripcion.TabIndex = 10;
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(586, 67);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(61, 20);
            this.tb_cantidad.TabIndex = 2;
            // 
            // bt_agregar
            // 
            this.bt_agregar.Enabled = false;
            this.bt_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_agregar.Location = new System.Drawing.Point(774, 60);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(81, 28);
            this.bt_agregar.TabIndex = 12;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_buscar_cliente
            // 
            this.bt_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_buscar_cliente.Location = new System.Drawing.Point(216, 25);
            this.bt_buscar_cliente.Name = "bt_buscar_cliente";
            this.bt_buscar_cliente.Size = new System.Drawing.Size(67, 23);
            this.bt_buscar_cliente.TabIndex = 14;
            this.bt_buscar_cliente.Text = "Buscar";
            this.bt_buscar_cliente.UseVisualStyleBackColor = true;
            this.bt_buscar_cliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_facturar
            // 
            this.bt_facturar.Enabled = false;
            this.bt_facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_facturar.Location = new System.Drawing.Point(508, 554);
            this.bt_facturar.Name = "bt_facturar";
            this.bt_facturar.Size = new System.Drawing.Size(82, 28);
            this.bt_facturar.TabIndex = 15;
            this.bt_facturar.Text = "Facturar";
            this.bt_facturar.UseVisualStyleBackColor = true;
            this.bt_facturar.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_cancelar.Location = new System.Drawing.Point(406, 556);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(82, 28);
            this.bt_cancelar.TabIndex = 16;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Enabled = false;
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_eliminar.Location = new System.Drawing.Point(860, 60);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 27);
            this.bt_eliminar.TabIndex = 17;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(707, 66);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(61, 20);
            this.tb_precio.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(653, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Precio";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(745, 526);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(101, 20);
            this.tb_total.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(703, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total";
            // 
            // cb_tipo_pago
            // 
            this.cb_tipo_pago.FormattingEnabled = true;
            this.cb_tipo_pago.Location = new System.Drawing.Point(348, 26);
            this.cb_tipo_pago.Name = "cb_tipo_pago";
            this.cb_tipo_pago.Size = new System.Drawing.Size(138, 21);
            this.cb_tipo_pago.TabIndex = 24;
            this.cb_tipo_pago.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(307, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pago";
            // 
            // bt_buscar_producto
            // 
            this.bt_buscar_producto.Location = new System.Drawing.Point(191, 66);
            this.bt_buscar_producto.Name = "bt_buscar_producto";
            this.bt_buscar_producto.Size = new System.Drawing.Size(51, 23);
            this.bt_buscar_producto.TabIndex = 25;
            this.bt_buscar_producto.Text = "Buscar";
            this.bt_buscar_producto.UseVisualStyleBackColor = true;
            this.bt_buscar_producto.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(501, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "No.Cheque";
            // 
            // descripcion_pago
            // 
            this.descripcion_pago.Location = new System.Drawing.Point(582, 27);
            this.descripcion_pago.Name = "descripcion_pago";
            this.descripcion_pago.Size = new System.Drawing.Size(178, 20);
            this.descripcion_pago.TabIndex = 27;
            this.descripcion_pago.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(85, 26);
            this.tb_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(126, 20);
            this.tb_cliente.TabIndex = 28;
            // 
            // bt_editar
            // 
            this.bt_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_editar.Location = new System.Drawing.Point(950, 60);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 27);
            this.bt_editar.TabIndex = 29;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(688, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(745, 554);
            this.txtEfectivo.Margin = new System.Windows.Forms.Padding(2);
            this.txtEfectivo.Mask = "9999999999";
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(101, 20);
            this.txtEfectivo.TabIndex = 31;
            // 
            // btn_pedido
            // 
            this.btn_pedido.Enabled = false;
            this.btn_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_pedido.Location = new System.Drawing.Point(774, 22);
            this.btn_pedido.Name = "btn_pedido";
            this.btn_pedido.Size = new System.Drawing.Size(81, 28);
            this.btn_pedido.TabIndex = 32;
            this.btn_pedido.Text = "Pedido";
            this.btn_pedido.UseVisualStyleBackColor = true;
            this.btn_pedido.Click += new System.EventHandler(this.btn_pedido_Click);
            // 
            // lb_porc
            // 
            this.lb_porc.AutoSize = true;
            this.lb_porc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_porc.Location = new System.Drawing.Point(1002, 502);
            this.lb_porc.Name = "lb_porc";
            this.lb_porc.Size = new System.Drawing.Size(20, 17);
            this.lb_porc.TabIndex = 36;
            this.lb_porc.Text = "%";
            this.lb_porc.Visible = false;
            // 
            // nud_descuento
            // 
            this.nud_descuento.Location = new System.Drawing.Point(963, 501);
            this.nud_descuento.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_descuento.Name = "nud_descuento";
            this.nud_descuento.Size = new System.Drawing.Size(41, 20);
            this.nud_descuento.TabIndex = 38;
            this.nud_descuento.Visible = false;
            this.nud_descuento.ValueChanged += new System.EventHandler(this.nud_descuento_value_changed);
            // 
            // chb_descuento
            // 
            this.chb_descuento.AutoSize = true;
            this.chb_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_descuento.Location = new System.Drawing.Point(873, 501);
            this.chb_descuento.Name = "chb_descuento";
            this.chb_descuento.Size = new System.Drawing.Size(90, 20);
            this.chb_descuento.TabIndex = 37;
            this.chb_descuento.Text = "descuento";
            this.chb_descuento.UseVisualStyleBackColor = true;
            this.chb_descuento.Visible = false;
            this.chb_descuento.CheckedChanged += new System.EventHandler(this.chb_descuento_checked_changed);
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Location = new System.Drawing.Point(745, 499);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(101, 20);
            this.tb_subtotal.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(681, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Subtotal";
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Presentacion/Marca";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total";
            this.Column6.Name = "Column6";
            // 
            // pedido_row
            // 
            this.pedido_row.HeaderText = "Pedido";
            this.pedido_row.Name = "pedido_row";
            this.pedido_row.Visible = false;
            // 
            // form_ventas
            // 
            this.AcceptButton = this.bt_agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 594);
            this.Controls.Add(this.tb_subtotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nud_descuento);
            this.Controls.Add(this.chb_descuento);
            this.Controls.Add(this.lb_porc);
            this.Controls.Add(this.btn_pedido);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.descripcion_pago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_buscar_producto);
            this.Controls.Add(this.cb_tipo_pago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_facturar);
            this.Controls.Add(this.bt_buscar_cliente);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.tb_descripcion);
            this.Controls.Add(this.tb_codigo_producto);
            this.Controls.Add(this.dgv_ventas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FORMVENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_descuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.TextBox tb_codigo_producto;
        private System.Windows.Forms.TextBox tb_descripcion;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_buscar_cliente;
        private System.Windows.Forms.Button bt_facturar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_tipo_pago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_buscar_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion_pago;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtEfectivo;
        private System.Windows.Forms.Button btn_pedido;
        private System.Windows.Forms.Label lb_porc;
        private System.Windows.Forms.CheckBox chb_descuento;
        private System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedido_row;
        public System.Windows.Forms.NumericUpDown nud_descuento;
    }
}