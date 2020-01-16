namespace LibreriaParraJr
{
    partial class INSERTAR_CREDITO
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
            this.datos = new System.Windows.Forms.GroupBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_fecha = new System.Windows.Forms.MaskedTextBox();
            this.cb_empresas = new System.Windows.Forms.ComboBox();
            this.cb_proveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_cancelar1 = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_creditos = new System.Windows.Forms.DataGridView();
            this.dgtbc_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbc_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbc_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtbc_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_creditos)).BeginInit();
            this.SuspendLayout();
            // 
            // datos
            // 
            this.datos.Controls.Add(this.tb_total);
            this.datos.Controls.Add(this.label5);
            this.datos.Controls.Add(this.mtb_fecha);
            this.datos.Controls.Add(this.cb_empresas);
            this.datos.Controls.Add(this.cb_proveedor);
            this.datos.Controls.Add(this.label4);
            this.datos.Controls.Add(this.label2);
            this.datos.Controls.Add(this.label1);
            this.datos.Controls.Add(this.bt_eliminar);
            this.datos.Controls.Add(this.bt_agregar);
            this.datos.Controls.Add(this.bt_cancelar1);
            this.datos.Controls.Add(this.bt_editar);
            this.datos.Location = new System.Drawing.Point(11, 46);
            this.datos.Margin = new System.Windows.Forms.Padding(2);
            this.datos.Name = "datos";
            this.datos.Padding = new System.Windows.Forms.Padding(2);
            this.datos.Size = new System.Drawing.Size(524, 155);
            this.datos.TabIndex = 40;
            this.datos.TabStop = false;
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(84, 118);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(165, 20);
            this.tb_total.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Total";
            // 
            // mtb_fecha
            // 
            this.mtb_fecha.Location = new System.Drawing.Point(84, 79);
            this.mtb_fecha.Mask = "0000/00/00";
            this.mtb_fecha.Name = "mtb_fecha";
            this.mtb_fecha.Size = new System.Drawing.Size(165, 20);
            this.mtb_fecha.TabIndex = 38;
            this.mtb_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // cb_empresas
            // 
            this.cb_empresas.FormattingEnabled = true;
            this.cb_empresas.Location = new System.Drawing.Point(84, 42);
            this.cb_empresas.Name = "cb_empresas";
            this.cb_empresas.Size = new System.Drawing.Size(165, 21);
            this.cb_empresas.TabIndex = 37;
            // 
            // cb_proveedor
            // 
            this.cb_proveedor.FormattingEnabled = true;
            this.cb_proveedor.Location = new System.Drawing.Point(84, 9);
            this.cb_proveedor.Name = "cb_proveedor";
            this.cb_proveedor.Size = new System.Drawing.Size(165, 21);
            this.cb_proveedor.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Proveedor";
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Enabled = false;
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_eliminar.Location = new System.Drawing.Point(409, 18);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(76, 45);
            this.bt_eliminar.TabIndex = 29;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_agregar.Location = new System.Drawing.Point(286, 18);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(82, 45);
            this.bt_agregar.TabIndex = 28;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // bt_cancelar1
            // 
            this.bt_cancelar1.Enabled = false;
            this.bt_cancelar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_cancelar1.Location = new System.Drawing.Point(409, 80);
            this.bt_cancelar1.Name = "bt_cancelar1";
            this.bt_cancelar1.Size = new System.Drawing.Size(76, 47);
            this.bt_cancelar1.TabIndex = 31;
            this.bt_cancelar1.Text = "Cancelar";
            this.bt_cancelar1.UseVisualStyleBackColor = true;
            // 
            // bt_editar
            // 
            this.bt_editar.Enabled = false;
            this.bt_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_editar.Location = new System.Drawing.Point(286, 80);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(82, 47);
            this.bt_editar.TabIndex = 30;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 22);
            this.label6.TabIndex = 41;
            this.label6.Text = "INSERTAR CREDITOS DE PROVEEDORES";
            // 
            // dgv_creditos
            // 
            this.dgv_creditos.AllowUserToAddRows = false;
            this.dgv_creditos.AllowUserToDeleteRows = false;
            this.dgv_creditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_creditos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgtbc_proveedor,
            this.dgtbc_empresa,
            this.dgtbc_fecha,
            this.dgtbc_total});
            this.dgv_creditos.Location = new System.Drawing.Point(15, 215);
            this.dgv_creditos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_creditos.Name = "dgv_creditos";
            this.dgv_creditos.ReadOnly = true;
            this.dgv_creditos.RowTemplate.Height = 24;
            this.dgv_creditos.Size = new System.Drawing.Size(524, 154);
            this.dgv_creditos.TabIndex = 42;
            this.dgv_creditos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_creditos_CellContentClick);
            // 
            // dgtbc_proveedor
            // 
            this.dgtbc_proveedor.HeaderText = "Proveedor";
            this.dgtbc_proveedor.Name = "dgtbc_proveedor";
            this.dgtbc_proveedor.ReadOnly = true;
            this.dgtbc_proveedor.Width = 140;
            // 
            // dgtbc_empresa
            // 
            this.dgtbc_empresa.HeaderText = "Empresa";
            this.dgtbc_empresa.Name = "dgtbc_empresa";
            this.dgtbc_empresa.ReadOnly = true;
            this.dgtbc_empresa.Width = 140;
            // 
            // dgtbc_fecha
            // 
            this.dgtbc_fecha.HeaderText = "Fecha";
            this.dgtbc_fecha.Name = "dgtbc_fecha";
            this.dgtbc_fecha.ReadOnly = true;
            // 
            // dgtbc_total
            // 
            this.dgtbc_total.HeaderText = "Total";
            this.dgtbc_total.Name = "dgtbc_total";
            this.dgtbc_total.ReadOnly = true;
            // 
            // bt_registrar
            // 
            this.bt_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_registrar.Location = new System.Drawing.Point(280, 383);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(79, 40);
            this.bt_registrar.TabIndex = 44;
            this.bt_registrar.Text = "Registrar";
            this.bt_registrar.UseVisualStyleBackColor = true;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_cancelar.Location = new System.Drawing.Point(169, 383);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 40);
            this.bt_cancelar.TabIndex = 43;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // INSERTAR_CREDITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 453);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.dgv_creditos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datos);
            this.Name = "INSERTAR_CREDITO";
            this.Text = "INSERTAR_CREDITO";
            this.Load += new System.EventHandler(this.INSERTAR_CREDITO_Load);
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_creditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox datos;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_cancelar1;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_creditos;
        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_fecha;
        private System.Windows.Forms.ComboBox cb_empresas;
        private System.Windows.Forms.ComboBox cb_proveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtbc_total;
    }
}