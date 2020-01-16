namespace LibreriaParraJr
{
    partial class FORMREPORTES
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_detallado = new System.Windows.Forms.CheckBox();
            this.cb_mes = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.bt_generar = new System.Windows.Forms.Button();
            this.rb_ventas_mes = new System.Windows.Forms.RadioButton();
            this.rb_productos_mas_vendidos = new System.Windows.Forms.RadioButton();
            this.rb_todos_productos = new System.Windows.Forms.RadioButton();
            this.rb_ventas_hoy = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_detallado);
            this.groupBox1.Controls.Add(this.cb_mes);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.bt_generar);
            this.groupBox1.Controls.Add(this.rb_ventas_mes);
            this.groupBox1.Controls.Add(this.rb_productos_mas_vendidos);
            this.groupBox1.Controls.Add(this.rb_todos_productos);
            this.groupBox1.Controls.Add(this.rb_ventas_hoy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chb_detallado
            // 
            this.chb_detallado.AutoSize = true;
            this.chb_detallado.Location = new System.Drawing.Point(406, 35);
            this.chb_detallado.Margin = new System.Windows.Forms.Padding(2);
            this.chb_detallado.Name = "chb_detallado";
            this.chb_detallado.Size = new System.Drawing.Size(87, 21);
            this.chb_detallado.TabIndex = 8;
            this.chb_detallado.Text = "Detallado";
            this.chb_detallado.UseVisualStyleBackColor = true;
            // 
            // cb_mes
            // 
            this.cb_mes.Enabled = false;
            this.cb_mes.FormattingEnabled = true;
            this.cb_mes.Location = new System.Drawing.Point(165, 112);
            this.cb_mes.Name = "cb_mes";
            this.cb_mes.Size = new System.Drawing.Size(121, 24);
            this.cb_mes.TabIndex = 7;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(134, 32);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(246, 23);
            this.dtp_fecha.TabIndex = 6;
            // 
            // bt_generar
            // 
            this.bt_generar.Location = new System.Drawing.Point(210, 184);
            this.bt_generar.Name = "bt_generar";
            this.bt_generar.Size = new System.Drawing.Size(75, 23);
            this.bt_generar.TabIndex = 4;
            this.bt_generar.Text = "Generar";
            this.bt_generar.UseVisualStyleBackColor = true;
            this.bt_generar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_ventas_mes
            // 
            this.rb_ventas_mes.AutoSize = true;
            this.rb_ventas_mes.Location = new System.Drawing.Point(35, 113);
            this.rb_ventas_mes.Name = "rb_ventas_mes";
            this.rb_ventas_mes.Size = new System.Drawing.Size(123, 21);
            this.rb_ventas_mes.TabIndex = 3;
            this.rb_ventas_mes.TabStop = true;
            this.rb_ventas_mes.Text = "Ventas del mes";
            this.rb_ventas_mes.UseVisualStyleBackColor = true;
            this.rb_ventas_mes.CheckedChanged += new System.EventHandler(this.rb_ventas_mes_CheckedChanged);
            // 
            // rb_productos_mas_vendidos
            // 
            this.rb_productos_mas_vendidos.AutoSize = true;
            this.rb_productos_mas_vendidos.Location = new System.Drawing.Point(35, 86);
            this.rb_productos_mas_vendidos.Name = "rb_productos_mas_vendidos";
            this.rb_productos_mas_vendidos.Size = new System.Drawing.Size(181, 21);
            this.rb_productos_mas_vendidos.TabIndex = 2;
            this.rb_productos_mas_vendidos.TabStop = true;
            this.rb_productos_mas_vendidos.Text = "Productos mas vendidos";
            this.rb_productos_mas_vendidos.UseVisualStyleBackColor = true;
            // 
            // rb_todos_productos
            // 
            this.rb_todos_productos.AutoSize = true;
            this.rb_todos_productos.Location = new System.Drawing.Point(35, 59);
            this.rb_todos_productos.Name = "rb_todos_productos";
            this.rb_todos_productos.Size = new System.Drawing.Size(205, 21);
            this.rb_todos_productos.TabIndex = 1;
            this.rb_todos_productos.TabStop = true;
            this.rb_todos_productos.Text = "Reporte todos los productos";
            this.rb_todos_productos.UseVisualStyleBackColor = true;
            // 
            // rb_ventas_hoy
            // 
            this.rb_ventas_hoy.AutoSize = true;
            this.rb_ventas_hoy.Location = new System.Drawing.Point(35, 32);
            this.rb_ventas_hoy.Name = "rb_ventas_hoy";
            this.rb_ventas_hoy.Size = new System.Drawing.Size(93, 21);
            this.rb_ventas_hoy.TabIndex = 0;
            this.rb_ventas_hoy.TabStop = true;
            this.rb_ventas_hoy.Text = "Ventas del";
            this.rb_ventas_hoy.UseVisualStyleBackColor = true;
            this.rb_ventas_hoy.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FORMREPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 481);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FORMREPORTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.FORMREPORTES_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_productos_mas_vendidos;
        private System.Windows.Forms.Button bt_generar;
        private System.Windows.Forms.RadioButton rb_ventas_mes;
        private System.Windows.Forms.RadioButton rb_ventas_hoy;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox cb_mes;
        private System.Windows.Forms.RadioButton rb_todos_productos;
        private System.Windows.Forms.CheckBox chb_detallado;
    }
}