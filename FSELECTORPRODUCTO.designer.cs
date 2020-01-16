namespace LibreriaParraJr
{
    partial class FSELECTORPRODUCTO
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
            this.tb_buscar_productos = new System.Windows.Forms.TextBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.cms_productos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_aceptar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_mandar_bodega = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.cms_productos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // tb_buscar_productos
            // 
            this.tb_buscar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_buscar_productos.Location = new System.Drawing.Point(82, 20);
            this.tb_buscar_productos.Name = "tb_buscar_productos";
            this.tb_buscar_productos.Size = new System.Drawing.Size(175, 23);
            this.tb_buscar_productos.TabIndex = 1;
            this.tb_buscar_productos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_productos.Location = new System.Drawing.Point(17, 70);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.Size = new System.Drawing.Size(950, 270);
            this.dgv_productos.TabIndex = 2;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Caracteristica";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Presentacion";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stock";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Marca";
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Categoria";
            this.Column8.Name = "Column8";
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Enabled = false;
            this.bt_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_aceptar.Location = new System.Drawing.Point(874, 20);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(92, 27);
            this.bt_aceptar.TabIndex = 3;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cms_productos
            // 
            this.cms_productos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_aceptar,
            this.tsmi_mandar_bodega,
            this.tsmi_eliminar});
            this.cms_productos.Name = "cms_productos";
            this.cms_productos.Size = new System.Drawing.Size(168, 70);
            this.cms_productos.Text = "Productos";
            // 
            // tsmi_aceptar
            // 
            this.tsmi_aceptar.Name = "tsmi_aceptar";
            this.tsmi_aceptar.Size = new System.Drawing.Size(167, 22);
            this.tsmi_aceptar.Text = "Aceptar";
            this.tsmi_aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tsmi_mandar_bodega
            // 
            this.tsmi_mandar_bodega.Name = "tsmi_mandar_bodega";
            this.tsmi_mandar_bodega.Size = new System.Drawing.Size(167, 22);
            this.tsmi_mandar_bodega.Text = "Mandar a Bodega";
            this.tsmi_mandar_bodega.Click += new System.EventHandler(this.tsmi_mandar_bodega_click);
            // 
            // tsmi_eliminar
            // 
            this.tsmi_eliminar.Name = "tsmi_eliminar";
            this.tsmi_eliminar.Size = new System.Drawing.Size(167, 22);
            this.tsmi_eliminar.Text = "Eliminar";
            this.tsmi_eliminar.Click += new System.EventHandler(this.tsmi_eliminar_Click);
            // 
            // FSELECTORPRODUCTO
            // 
            this.AcceptButton = this.bt_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 350);
            this.ContextMenuStrip = this.cms_productos;
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.tb_buscar_productos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FSELECTORPRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Producto";
            this.Load += new System.EventHandler(this.FSELECTORPRODUCTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.cms_productos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_buscar_productos;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ContextMenuStrip cms_productos;
        private System.Windows.Forms.ToolStripMenuItem tsmi_aceptar;
        private System.Windows.Forms.ToolStripMenuItem tsmi_mandar_bodega;
        private System.Windows.Forms.ToolStripMenuItem tsmi_eliminar;
    }
}