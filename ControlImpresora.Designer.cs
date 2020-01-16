namespace LibreriaParraJr
{
    partial class ControlImpresora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlImpresora));
            this.label1 = new System.Windows.Forms.Label();
            this.gb_opciones = new System.Windows.Forms.GroupBox();
            this.rbMantenimiento = new System.Windows.Forms.RadioButton();
            this.rbInternet = new System.Windows.Forms.RadioButton();
            this.rbImpresora = new System.Windows.Forms.RadioButton();
            this.tb_valor_servicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_ingresar_servicio = new System.Windows.Forms.Button();
            this.lb_valor_mantenimiento = new System.Windows.Forms.Label();
            this.lb_valor_internet = new System.Windows.Forms.Label();
            this.lb_valor_impresora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_reporte_impresora = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_total_impresora = new System.Windows.Forms.Label();
            this.lb_total_internet = new System.Windows.Forms.Label();
            this.lb_total_mantenimiento = new System.Windows.Forms.Label();
            this.pb_printer = new System.Windows.Forms.PictureBox();
            this.gb_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reporte_impresora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_printer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Servicios";
            // 
            // gb_opciones
            // 
            this.gb_opciones.Controls.Add(this.rbMantenimiento);
            this.gb_opciones.Controls.Add(this.rbInternet);
            this.gb_opciones.Controls.Add(this.rbImpresora);
            this.gb_opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_opciones.Location = new System.Drawing.Point(14, 51);
            this.gb_opciones.Name = "gb_opciones";
            this.gb_opciones.Size = new System.Drawing.Size(279, 51);
            this.gb_opciones.TabIndex = 1;
            this.gb_opciones.TabStop = false;
            this.gb_opciones.Text = "Opciones";
            // 
            // rbMantenimiento
            // 
            this.rbMantenimiento.AutoSize = true;
            this.rbMantenimiento.Location = new System.Drawing.Point(162, 19);
            this.rbMantenimiento.Name = "rbMantenimiento";
            this.rbMantenimiento.Size = new System.Drawing.Size(113, 20);
            this.rbMantenimiento.TabIndex = 3;
            this.rbMantenimiento.TabStop = true;
            this.rbMantenimiento.Text = "Mantenimiento";
            this.rbMantenimiento.UseVisualStyleBackColor = true;
            // 
            // rbInternet
            // 
            this.rbInternet.AutoSize = true;
            this.rbInternet.Location = new System.Drawing.Point(92, 19);
            this.rbInternet.Name = "rbInternet";
            this.rbInternet.Size = new System.Drawing.Size(69, 20);
            this.rbInternet.TabIndex = 2;
            this.rbInternet.TabStop = true;
            this.rbInternet.Text = "Internet";
            this.rbInternet.UseVisualStyleBackColor = true;
            // 
            // rbImpresora
            // 
            this.rbImpresora.AutoSize = true;
            this.rbImpresora.Checked = true;
            this.rbImpresora.Location = new System.Drawing.Point(6, 19);
            this.rbImpresora.Name = "rbImpresora";
            this.rbImpresora.Size = new System.Drawing.Size(87, 20);
            this.rbImpresora.TabIndex = 1;
            this.rbImpresora.TabStop = true;
            this.rbImpresora.Text = "Impresora";
            this.rbImpresora.UseVisualStyleBackColor = true;
            // 
            // tb_valor_servicio
            // 
            this.tb_valor_servicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor_servicio.Location = new System.Drawing.Point(37, 142);
            this.tb_valor_servicio.Name = "tb_valor_servicio";
            this.tb_valor_servicio.Size = new System.Drawing.Size(212, 27);
            this.tb_valor_servicio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor del Servicio";
            // 
            // bt_ingresar_servicio
            // 
            this.bt_ingresar_servicio.AccessibleDescription = "CTRL + F para cancelar";
            this.bt_ingresar_servicio.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_ingresar_servicio.FlatAppearance.BorderSize = 0;
            this.bt_ingresar_servicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.bt_ingresar_servicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.bt_ingresar_servicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ingresar_servicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar_servicio.ForeColor = System.Drawing.Color.White;
            this.bt_ingresar_servicio.Location = new System.Drawing.Point(54, 189);
            this.bt_ingresar_servicio.Name = "bt_ingresar_servicio";
            this.bt_ingresar_servicio.Size = new System.Drawing.Size(170, 41);
            this.bt_ingresar_servicio.TabIndex = 5;
            this.bt_ingresar_servicio.Text = "Ingresar";
            this.bt_ingresar_servicio.UseVisualStyleBackColor = false;
            this.bt_ingresar_servicio.Click += new System.EventHandler(this.bt_ingresar_servicio_Click);
            // 
            // lb_valor_mantenimiento
            // 
            this.lb_valor_mantenimiento.AutoSize = true;
            this.lb_valor_mantenimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor_mantenimiento.Location = new System.Drawing.Point(508, 92);
            this.lb_valor_mantenimiento.Name = "lb_valor_mantenimiento";
            this.lb_valor_mantenimiento.Size = new System.Drawing.Size(21, 22);
            this.lb_valor_mantenimiento.TabIndex = 16;
            this.lb_valor_mantenimiento.Text = "0";
            // 
            // lb_valor_internet
            // 
            this.lb_valor_internet.AutoSize = true;
            this.lb_valor_internet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor_internet.Location = new System.Drawing.Point(419, 92);
            this.lb_valor_internet.Name = "lb_valor_internet";
            this.lb_valor_internet.Size = new System.Drawing.Size(21, 22);
            this.lb_valor_internet.TabIndex = 15;
            this.lb_valor_internet.Text = "0";
            // 
            // lb_valor_impresora
            // 
            this.lb_valor_impresora.AutoSize = true;
            this.lb_valor_impresora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor_impresora.Location = new System.Drawing.Point(332, 92);
            this.lb_valor_impresora.Name = "lb_valor_impresora";
            this.lb_valor_impresora.Size = new System.Drawing.Size(21, 22);
            this.lb_valor_impresora.TabIndex = 14;
            this.lb_valor_impresora.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mantenimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Internet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Impresora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Detalle del Dia";
            // 
            // pb_reporte_impresora
            // 
            this.pb_reporte_impresora.Image = ((System.Drawing.Image)(resources.GetObject("pb_reporte_impresora.Image")));
            this.pb_reporte_impresora.Location = new System.Drawing.Point(266, 214);
            this.pb_reporte_impresora.Name = "pb_reporte_impresora";
            this.pb_reporte_impresora.Size = new System.Drawing.Size(27, 31);
            this.pb_reporte_impresora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_reporte_impresora.TabIndex = 6;
            this.pb_reporte_impresora.TabStop = false;
            this.pb_reporte_impresora.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Detalles Globales";
            // 
            // lb_total_impresora
            // 
            this.lb_total_impresora.AutoSize = true;
            this.lb_total_impresora.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_impresora.Location = new System.Drawing.Point(332, 189);
            this.lb_total_impresora.Name = "lb_total_impresora";
            this.lb_total_impresora.Size = new System.Drawing.Size(21, 22);
            this.lb_total_impresora.TabIndex = 18;
            this.lb_total_impresora.Text = "0";
            // 
            // lb_total_internet
            // 
            this.lb_total_internet.AutoSize = true;
            this.lb_total_internet.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_internet.Location = new System.Drawing.Point(419, 189);
            this.lb_total_internet.Name = "lb_total_internet";
            this.lb_total_internet.Size = new System.Drawing.Size(21, 22);
            this.lb_total_internet.TabIndex = 19;
            this.lb_total_internet.Text = "0";
            // 
            // lb_total_mantenimiento
            // 
            this.lb_total_mantenimiento.AutoSize = true;
            this.lb_total_mantenimiento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_mantenimiento.Location = new System.Drawing.Point(508, 189);
            this.lb_total_mantenimiento.Name = "lb_total_mantenimiento";
            this.lb_total_mantenimiento.Size = new System.Drawing.Size(21, 22);
            this.lb_total_mantenimiento.TabIndex = 20;
            this.lb_total_mantenimiento.Text = "0";
            // 
            // pb_printer
            // 
            this.pb_printer.Image = ((System.Drawing.Image)(resources.GetObject("pb_printer.Image")));
            this.pb_printer.Location = new System.Drawing.Point(570, 214);
            this.pb_printer.Name = "pb_printer";
            this.pb_printer.Size = new System.Drawing.Size(27, 31);
            this.pb_printer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_printer.TabIndex = 21;
            this.pb_printer.TabStop = false;
            this.pb_printer.Click += new System.EventHandler(this.pb_printer_Click);
            // 
            // ControlImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pb_printer);
            this.Controls.Add(this.lb_total_mantenimiento);
            this.Controls.Add(this.lb_total_internet);
            this.Controls.Add(this.lb_total_impresora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_valor_mantenimiento);
            this.Controls.Add(this.lb_valor_internet);
            this.Controls.Add(this.lb_valor_impresora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pb_reporte_impresora);
            this.Controls.Add(this.bt_ingresar_servicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_valor_servicio);
            this.Controls.Add(this.gb_opciones);
            this.Controls.Add(this.label1);
            this.Name = "ControlImpresora";
            this.Size = new System.Drawing.Size(600, 248);
            this.gb_opciones.ResumeLayout(false);
            this.gb_opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_reporte_impresora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_printer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_opciones;
        private System.Windows.Forms.TextBox tb_valor_servicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_ingresar_servicio;
        public System.Windows.Forms.RadioButton rbMantenimiento;
        public System.Windows.Forms.RadioButton rbInternet;
        public System.Windows.Forms.RadioButton rbImpresora;
        private System.Windows.Forms.PictureBox pb_reporte_impresora;
        private System.Windows.Forms.Label lb_valor_mantenimiento;
        private System.Windows.Forms.Label lb_valor_internet;
        private System.Windows.Forms.Label lb_valor_impresora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_total_impresora;
        private System.Windows.Forms.Label lb_total_internet;
        private System.Windows.Forms.Label lb_total_mantenimiento;
        private System.Windows.Forms.PictureBox pb_printer;
    }
}
