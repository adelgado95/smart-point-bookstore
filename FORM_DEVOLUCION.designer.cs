namespace LibreriaParraJr
{
    partial class FORM_DEVOLUCION
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
            this.tc_devolucion = new System.Windows.Forms.TabControl();
            this.tp_devolucion_clientes = new System.Windows.Forms.TabPage();
            this.tb_factura = new System.Windows.Forms.TextBox();
            this.tb_producto = new System.Windows.Forms.TextBox();
            this.lb_num_factura = new System.Windows.Forms.Label();
            this.tb_id_cliente = new System.Windows.Forms.TextBox();
            this.lb_id_cliente = new System.Windows.Forms.Label();
            this.lb_id_producto_cliente = new System.Windows.Forms.Label();
            this.tb_motivo_devolucion_cliente = new System.Windows.Forms.TextBox();
            this.lb_motivo_devolucion_cliente = new System.Windows.Forms.Label();
            this.lb_devolucion_clientes = new System.Windows.Forms.Label();
            this.tp_devolucion_proveedores = new System.Windows.Forms.TabPage();
            this.tb_fact_prov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_proveedor = new System.Windows.Forms.TextBox();
            this.lb_id_proveedor = new System.Windows.Forms.Label();
            this.tb_prod = new System.Windows.Forms.TextBox();
            this.lb_id_producto_proveedor = new System.Windows.Forms.Label();
            this.tb_motivo_prov = new System.Windows.Forms.TextBox();
            this.lb_motivo_devolucion_proveedor = new System.Windows.Forms.Label();
            this.lb_devolucion_proveedores = new System.Windows.Forms.Label();
            this.lb_registro_devolucion = new System.Windows.Forms.Label();
            this.bt_devolver_producto = new System.Windows.Forms.Button();
            this.bt_cancelar_transaccion = new System.Windows.Forms.Button();
            this.tc_devolucion.SuspendLayout();
            this.tp_devolucion_clientes.SuspendLayout();
            this.tp_devolucion_proveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_devolucion
            // 
            this.tc_devolucion.Controls.Add(this.tp_devolucion_clientes);
            this.tc_devolucion.Controls.Add(this.tp_devolucion_proveedores);
            this.tc_devolucion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_devolucion.Location = new System.Drawing.Point(12, 57);
            this.tc_devolucion.Name = "tc_devolucion";
            this.tc_devolucion.SelectedIndex = 0;
            this.tc_devolucion.Size = new System.Drawing.Size(775, 396);
            this.tc_devolucion.TabIndex = 0;
            // 
            // tp_devolucion_clientes
            // 
            this.tp_devolucion_clientes.Controls.Add(this.tb_factura);
            this.tp_devolucion_clientes.Controls.Add(this.tb_producto);
            this.tp_devolucion_clientes.Controls.Add(this.lb_num_factura);
            this.tp_devolucion_clientes.Controls.Add(this.tb_id_cliente);
            this.tp_devolucion_clientes.Controls.Add(this.lb_id_cliente);
            this.tp_devolucion_clientes.Controls.Add(this.lb_id_producto_cliente);
            this.tp_devolucion_clientes.Controls.Add(this.tb_motivo_devolucion_cliente);
            this.tp_devolucion_clientes.Controls.Add(this.lb_motivo_devolucion_cliente);
            this.tp_devolucion_clientes.Controls.Add(this.lb_devolucion_clientes);
            this.tp_devolucion_clientes.Location = new System.Drawing.Point(4, 28);
            this.tp_devolucion_clientes.Name = "tp_devolucion_clientes";
            this.tp_devolucion_clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tp_devolucion_clientes.Size = new System.Drawing.Size(767, 364);
            this.tp_devolucion_clientes.TabIndex = 0;
            this.tp_devolucion_clientes.Text = "Devolucion de Clientes";
            this.tp_devolucion_clientes.UseVisualStyleBackColor = true;
            // 
            // tb_factura
            // 
            this.tb_factura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_factura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_factura.Location = new System.Drawing.Point(376, 118);
            this.tb_factura.Name = "tb_factura";
            this.tb_factura.Size = new System.Drawing.Size(351, 26);
            this.tb_factura.TabIndex = 9;
            // 
            // tb_producto
            // 
            this.tb_producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_producto.Location = new System.Drawing.Point(376, 77);
            this.tb_producto.Name = "tb_producto";
            this.tb_producto.Size = new System.Drawing.Size(351, 26);
            this.tb_producto.TabIndex = 0;
            this.tb_producto.Leave += new System.EventHandler(this.tb_producto_Leave);
            // 
            // lb_num_factura
            // 
            this.lb_num_factura.AutoSize = true;
            this.lb_num_factura.Location = new System.Drawing.Point(141, 125);
            this.lb_num_factura.Name = "lb_num_factura";
            this.lb_num_factura.Size = new System.Drawing.Size(162, 19);
            this.lb_num_factura.TabIndex = 7;
            this.lb_num_factura.Text = "Numero de Factura";
            // 
            // tb_id_cliente
            // 
            this.tb_id_cliente.Location = new System.Drawing.Point(376, 176);
            this.tb_id_cliente.Name = "tb_id_cliente";
            this.tb_id_cliente.Size = new System.Drawing.Size(351, 26);
            this.tb_id_cliente.TabIndex = 6;
            // 
            // lb_id_cliente
            // 
            this.lb_id_cliente.AutoSize = true;
            this.lb_id_cliente.Location = new System.Drawing.Point(60, 183);
            this.lb_id_cliente.Name = "lb_id_cliente";
            this.lb_id_cliente.Size = new System.Drawing.Size(243, 19);
            this.lb_id_cliente.TabIndex = 5;
            this.lb_id_cliente.Text = "Identificacion del Cliente";
            // 
            // lb_id_producto_cliente
            // 
            this.lb_id_producto_cliente.AutoSize = true;
            this.lb_id_producto_cliente.Location = new System.Drawing.Point(51, 77);
            this.lb_id_producto_cliente.Name = "lb_id_producto_cliente";
            this.lb_id_producto_cliente.Size = new System.Drawing.Size(252, 19);
            this.lb_id_producto_cliente.TabIndex = 3;
            this.lb_id_producto_cliente.Text = "Identificacion del Producto";
            // 
            // tb_motivo_devolucion_cliente
            // 
            this.tb_motivo_devolucion_cliente.Location = new System.Drawing.Point(376, 230);
            this.tb_motivo_devolucion_cliente.Multiline = true;
            this.tb_motivo_devolucion_cliente.Name = "tb_motivo_devolucion_cliente";
            this.tb_motivo_devolucion_cliente.Size = new System.Drawing.Size(351, 94);
            this.tb_motivo_devolucion_cliente.TabIndex = 2;
            // 
            // lb_motivo_devolucion_cliente
            // 
            this.lb_motivo_devolucion_cliente.AutoSize = true;
            this.lb_motivo_devolucion_cliente.Location = new System.Drawing.Point(87, 237);
            this.lb_motivo_devolucion_cliente.Name = "lb_motivo_devolucion_cliente";
            this.lb_motivo_devolucion_cliente.Size = new System.Drawing.Size(216, 19);
            this.lb_motivo_devolucion_cliente.TabIndex = 1;
            this.lb_motivo_devolucion_cliente.Text = "Motivo de la devolucion";
            // 
            // lb_devolucion_clientes
            // 
            this.lb_devolucion_clientes.AutoSize = true;
            this.lb_devolucion_clientes.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_devolucion_clientes.Location = new System.Drawing.Point(241, 16);
            this.lb_devolucion_clientes.Name = "lb_devolucion_clientes";
            this.lb_devolucion_clientes.Size = new System.Drawing.Size(230, 22);
            this.lb_devolucion_clientes.TabIndex = 0;
            this.lb_devolucion_clientes.Text = "Datos de la Devolucion";
            // 
            // tp_devolucion_proveedores
            // 
            this.tp_devolucion_proveedores.Controls.Add(this.tb_fact_prov);
            this.tp_devolucion_proveedores.Controls.Add(this.label1);
            this.tp_devolucion_proveedores.Controls.Add(this.tb_proveedor);
            this.tp_devolucion_proveedores.Controls.Add(this.lb_id_proveedor);
            this.tp_devolucion_proveedores.Controls.Add(this.tb_prod);
            this.tp_devolucion_proveedores.Controls.Add(this.lb_id_producto_proveedor);
            this.tp_devolucion_proveedores.Controls.Add(this.tb_motivo_prov);
            this.tp_devolucion_proveedores.Controls.Add(this.lb_motivo_devolucion_proveedor);
            this.tp_devolucion_proveedores.Controls.Add(this.lb_devolucion_proveedores);
            this.tp_devolucion_proveedores.Location = new System.Drawing.Point(4, 28);
            this.tp_devolucion_proveedores.Name = "tp_devolucion_proveedores";
            this.tp_devolucion_proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tp_devolucion_proveedores.Size = new System.Drawing.Size(767, 364);
            this.tp_devolucion_proveedores.TabIndex = 1;
            this.tp_devolucion_proveedores.Text = "Devolucion a Proveedores";
            this.tp_devolucion_proveedores.UseVisualStyleBackColor = true;
            // 
            // tb_fact_prov
            // 
            this.tb_fact_prov.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_fact_prov.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_fact_prov.Location = new System.Drawing.Point(376, 127);
            this.tb_fact_prov.Name = "tb_fact_prov";
            this.tb_fact_prov.Size = new System.Drawing.Size(351, 26);
            this.tb_fact_prov.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero de Factura";
            // 
            // tb_proveedor
            // 
            this.tb_proveedor.Location = new System.Drawing.Point(376, 178);
            this.tb_proveedor.Name = "tb_proveedor";
            this.tb_proveedor.Size = new System.Drawing.Size(351, 26);
            this.tb_proveedor.TabIndex = 12;
            // 
            // lb_id_proveedor
            // 
            this.lb_id_proveedor.AutoSize = true;
            this.lb_id_proveedor.Location = new System.Drawing.Point(60, 185);
            this.lb_id_proveedor.Name = "lb_id_proveedor";
            this.lb_id_proveedor.Size = new System.Drawing.Size(261, 19);
            this.lb_id_proveedor.TabIndex = 11;
            this.lb_id_proveedor.Text = "Identificacion del Proveedor";
            // 
            // tb_prod
            // 
            this.tb_prod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_prod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_prod.Location = new System.Drawing.Point(376, 76);
            this.tb_prod.Name = "tb_prod";
            this.tb_prod.Size = new System.Drawing.Size(351, 26);
            this.tb_prod.TabIndex = 10;
            this.tb_prod.Leave += new System.EventHandler(this.tb_producto_Leave);
            // 
            // lb_id_producto_proveedor
            // 
            this.lb_id_producto_proveedor.AutoSize = true;
            this.lb_id_producto_proveedor.Location = new System.Drawing.Point(51, 79);
            this.lb_id_producto_proveedor.Name = "lb_id_producto_proveedor";
            this.lb_id_producto_proveedor.Size = new System.Drawing.Size(252, 19);
            this.lb_id_producto_proveedor.TabIndex = 9;
            this.lb_id_producto_proveedor.Text = "Identificacion del Producto";
            // 
            // tb_motivo_prov
            // 
            this.tb_motivo_prov.Location = new System.Drawing.Point(376, 230);
            this.tb_motivo_prov.Multiline = true;
            this.tb_motivo_prov.Name = "tb_motivo_prov";
            this.tb_motivo_prov.Size = new System.Drawing.Size(351, 94);
            this.tb_motivo_prov.TabIndex = 8;
            // 
            // lb_motivo_devolucion_proveedor
            // 
            this.lb_motivo_devolucion_proveedor.AutoSize = true;
            this.lb_motivo_devolucion_proveedor.Location = new System.Drawing.Point(87, 237);
            this.lb_motivo_devolucion_proveedor.Name = "lb_motivo_devolucion_proveedor";
            this.lb_motivo_devolucion_proveedor.Size = new System.Drawing.Size(216, 19);
            this.lb_motivo_devolucion_proveedor.TabIndex = 7;
            this.lb_motivo_devolucion_proveedor.Text = "Motivo de la devolucion";
            // 
            // lb_devolucion_proveedores
            // 
            this.lb_devolucion_proveedores.AutoSize = true;
            this.lb_devolucion_proveedores.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_devolucion_proveedores.Location = new System.Drawing.Point(240, 16);
            this.lb_devolucion_proveedores.Name = "lb_devolucion_proveedores";
            this.lb_devolucion_proveedores.Size = new System.Drawing.Size(230, 22);
            this.lb_devolucion_proveedores.TabIndex = 1;
            this.lb_devolucion_proveedores.Text = "Datos de la Devolucion";
            // 
            // lb_registro_devolucion
            // 
            this.lb_registro_devolucion.AutoSize = true;
            this.lb_registro_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registro_devolucion.Location = new System.Drawing.Point(149, 9);
            this.lb_registro_devolucion.Name = "lb_registro_devolucion";
            this.lb_registro_devolucion.Size = new System.Drawing.Size(439, 29);
            this.lb_registro_devolucion.TabIndex = 1;
            this.lb_registro_devolucion.Text = "Registro de Devoluciones de Productos";
            // 
            // bt_devolver_producto
            // 
            this.bt_devolver_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_devolver_producto.Location = new System.Drawing.Point(178, 468);
            this.bt_devolver_producto.Name = "bt_devolver_producto";
            this.bt_devolver_producto.Size = new System.Drawing.Size(141, 39);
            this.bt_devolver_producto.TabIndex = 3;
            this.bt_devolver_producto.Text = "Devolver Producto";
            this.bt_devolver_producto.UseVisualStyleBackColor = true;
            this.bt_devolver_producto.Click += new System.EventHandler(this.boton_devolver_producto_click);
            // 
            // bt_cancelar_transaccion
            // 
            this.bt_cancelar_transaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar_transaccion.Location = new System.Drawing.Point(392, 468);
            this.bt_cancelar_transaccion.Name = "bt_cancelar_transaccion";
            this.bt_cancelar_transaccion.Size = new System.Drawing.Size(151, 39);
            this.bt_cancelar_transaccion.TabIndex = 4;
            this.bt_cancelar_transaccion.Text = "Cancelar Transaccion";
            this.bt_cancelar_transaccion.UseVisualStyleBackColor = true;
            this.bt_cancelar_transaccion.Click += new System.EventHandler(this.bt_cancelar_transaccion_Click);
            // 
            // FORM_DEVOLUCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 528);
            this.Controls.Add(this.bt_cancelar_transaccion);
            this.Controls.Add(this.bt_devolver_producto);
            this.Controls.Add(this.lb_registro_devolucion);
            this.Controls.Add(this.tc_devolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FORM_DEVOLUCION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tc_devolucion.ResumeLayout(false);
            this.tp_devolucion_clientes.ResumeLayout(false);
            this.tp_devolucion_clientes.PerformLayout();
            this.tp_devolucion_proveedores.ResumeLayout(false);
            this.tp_devolucion_proveedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_devolucion;
        private System.Windows.Forms.TabPage tp_devolucion_clientes;
        private System.Windows.Forms.TabPage tp_devolucion_proveedores;
        private System.Windows.Forms.Label lb_registro_devolucion;
        private System.Windows.Forms.Button bt_devolver_producto;
        private System.Windows.Forms.Button bt_cancelar_transaccion;
        private System.Windows.Forms.TextBox tb_id_cliente;
        private System.Windows.Forms.Label lb_id_cliente;
        private System.Windows.Forms.Label lb_id_producto_cliente;
        private System.Windows.Forms.TextBox tb_motivo_devolucion_cliente;
        private System.Windows.Forms.Label lb_motivo_devolucion_cliente;
        private System.Windows.Forms.Label lb_devolucion_clientes;
        private System.Windows.Forms.TextBox tb_proveedor;
        private System.Windows.Forms.Label lb_id_proveedor;
        private System.Windows.Forms.TextBox tb_prod;
        private System.Windows.Forms.Label lb_id_producto_proveedor;
        private System.Windows.Forms.TextBox tb_motivo_prov;
        private System.Windows.Forms.Label lb_motivo_devolucion_proveedor;
        private System.Windows.Forms.Label lb_devolucion_proveedores;
        private System.Windows.Forms.TextBox tb_producto;
        private System.Windows.Forms.Label lb_num_factura;
        private System.Windows.Forms.TextBox tb_factura;
        private System.Windows.Forms.TextBox tb_fact_prov;
        private System.Windows.Forms.Label label1;
    }
}