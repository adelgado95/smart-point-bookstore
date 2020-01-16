namespace LibreriaParraJr
{
    partial class INSERTAR_CLIENTE
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
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.bt_cancelar1 = new System.Windows.Forms.Button();
            this.mtb_telefono = new System.Windows.Forms.MaskedTextBox();
            this.bt_editar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ruc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // datos
            // 
            this.datos.Controls.Add(this.bt_eliminar);
            this.datos.Controls.Add(this.bt_agregar);
            this.datos.Controls.Add(this.tb_email);
            this.datos.Controls.Add(this.label5);
            this.datos.Controls.Add(this.tb_nombre);
            this.datos.Controls.Add(this.bt_cancelar1);
            this.datos.Controls.Add(this.mtb_telefono);
            this.datos.Controls.Add(this.bt_editar);
            this.datos.Controls.Add(this.label4);
            this.datos.Controls.Add(this.tb_direccion);
            this.datos.Controls.Add(this.label3);
            this.datos.Controls.Add(this.label2);
            this.datos.Controls.Add(this.tb_ruc);
            this.datos.Controls.Add(this.label1);
            this.datos.Location = new System.Drawing.Point(9, 10);
            this.datos.Margin = new System.Windows.Forms.Padding(2);
            this.datos.Name = "datos";
            this.datos.Padding = new System.Windows.Forms.Padding(2);
            this.datos.Size = new System.Drawing.Size(524, 155);
            this.datos.TabIndex = 39;
            this.datos.TabStop = false;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Enabled = false;
            this.bt_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_eliminar.Location = new System.Drawing.Point(434, 92);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(76, 24);
            this.bt_eliminar.TabIndex = 29;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_agregar.Location = new System.Drawing.Point(344, 92);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(82, 24);
            this.bt_agregar.TabIndex = 28;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(58, 89);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(175, 20);
            this.tb_email.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(299, 20);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(211, 20);
            this.tb_nombre.TabIndex = 3;
            // 
            // bt_cancelar1
            // 
            this.bt_cancelar1.Enabled = false;
            this.bt_cancelar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_cancelar1.Location = new System.Drawing.Point(434, 123);
            this.bt_cancelar1.Name = "bt_cancelar1";
            this.bt_cancelar1.Size = new System.Drawing.Size(76, 24);
            this.bt_cancelar1.TabIndex = 31;
            this.bt_cancelar1.Text = "Cancelar";
            this.bt_cancelar1.UseVisualStyleBackColor = true;
            this.bt_cancelar1.Click += new System.EventHandler(this.cancelar1_Click);
            // 
            // mtb_telefono
            // 
            this.mtb_telefono.Location = new System.Drawing.Point(304, 54);
            this.mtb_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_telefono.Mask = "0000-0000";
            this.mtb_telefono.Name = "mtb_telefono";
            this.mtb_telefono.Size = new System.Drawing.Size(134, 20);
            this.mtb_telefono.TabIndex = 7;
            // 
            // bt_editar
            // 
            this.bt_editar.Enabled = false;
            this.bt_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_editar.Location = new System.Drawing.Point(344, 123);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(82, 24);
            this.bt_editar.TabIndex = 30;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(58, 54);
            this.tb_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(175, 20);
            this.tb_direccion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // tb_ruc
            // 
            this.tb_ruc.Location = new System.Drawing.Point(58, 20);
            this.tb_ruc.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ruc.Name = "tb_ruc";
            this.tb_ruc.Size = new System.Drawing.Size(175, 20);
            this.tb_ruc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUC:";
            // 
            // bt_registrar
            // 
            this.bt_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_registrar.Location = new System.Drawing.Point(308, 351);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(79, 40);
            this.bt_registrar.TabIndex = 38;
            this.bt_registrar.Text = "Registrar";
            this.bt_registrar.UseVisualStyleBackColor = true;
            this.bt_registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_cancelar.Location = new System.Drawing.Point(197, 351);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 40);
            this.bt_cancelar.TabIndex = 37;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_clientes.Location = new System.Drawing.Point(9, 170);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowTemplate.Height = 24;
            this.dgv_clientes.Size = new System.Drawing.Size(524, 154);
            this.dgv_clientes.TabIndex = 36;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ruc";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dirección";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teléfono";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // INSERTAR_CLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 401);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.dgv_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "INSERTAR_CLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datos;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Button bt_cancelar1;
        private System.Windows.Forms.MaskedTextBox mtb_telefono;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ruc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}