namespace LibreriaParraJr
{
    partial class FORM_ACTUALIZAR_STOCK
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
            this.bt_recargar = new System.Windows.Forms.Button();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.tb_busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.cms_actualizar_stock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_eliminar_stock_actual = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_resetear_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_cancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_unidades = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tecnologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.cms_actualizar_stock.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_recargar
            // 
            this.bt_recargar.Location = new System.Drawing.Point(794, 39);
            this.bt_recargar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_recargar.Name = "bt_recargar";
            this.bt_recargar.Size = new System.Drawing.Size(100, 28);
            this.bt_recargar.TabIndex = 15;
            this.bt_recargar.Text = "Recargar";
            this.bt_recargar.UseVisualStyleBackColor = true;
            this.bt_recargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(678, 48);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(68, 21);
            this.bt_buscar.TabIndex = 14;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_busqueda
            // 
            this.tb_busqueda.Location = new System.Drawing.Point(500, 50);
            this.tb_busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.tb_busqueda.Name = "tb_busqueda";
            this.tb_busqueda.Size = new System.Drawing.Size(175, 20);
            this.tb_busqueda.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar:";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(466, 455);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(84, 40);
            this.bt_cancelar.TabIndex = 11;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Enabled = false;
            this.bt_aceptar.Location = new System.Drawing.Point(334, 455);
            this.bt_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(91, 40);
            this.bt_aceptar.TabIndex = 10;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seleccione el producto";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.ContextMenuStrip = this.cms_actualizar_stock;
            this.dgv_productos.Location = new System.Drawing.Point(9, 77);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(885, 288);
            this.dgv_productos.TabIndex = 8;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cms_actualizar_stock
            // 
            this.cms_actualizar_stock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_eliminar_stock_actual,
            this.tsmi_resetear_stock,
            this.toolStripSeparator1,
            this.tsmi_cancelar});
            this.cms_actualizar_stock.Name = "cms_actualizar_stock";
            this.cms_actualizar_stock.Size = new System.Drawing.Size(223, 98);
            // 
            // tsmi_eliminar_stock_actual
            // 
            this.tsmi_eliminar_stock_actual.Name = "tsmi_eliminar_stock_actual";
            this.tsmi_eliminar_stock_actual.Size = new System.Drawing.Size(222, 22);
            this.tsmi_eliminar_stock_actual.Text = "Eliminar Stock Seleccionado";
            this.tsmi_eliminar_stock_actual.Click += new System.EventHandler(this.tsmi_eliminar_stock_actual_Click);
            // 
            // tsmi_resetear_stock
            // 
            this.tsmi_resetear_stock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tecnologiaToolStripMenuItem,
            this.escolaresToolStripMenuItem,
            this.manualidadesToolStripMenuItem,
            this.manualidadesToolStripMenuItem1,
            this.serviciosToolStripMenuItem,
            this.librosToolStripMenuItem});
            this.tsmi_resetear_stock.Name = "tsmi_resetear_stock";
            this.tsmi_resetear_stock.Size = new System.Drawing.Size(222, 22);
            this.tsmi_resetear_stock.Text = "Resetear Stock";
            this.tsmi_resetear_stock.Visible = false;
            this.tsmi_resetear_stock.Click += new System.EventHandler(this.tsmi_resetear_stock_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // tsmi_cancelar
            // 
            this.tsmi_cancelar.Name = "tsmi_cancelar";
            this.tsmi_cancelar.Size = new System.Drawing.Size(222, 22);
            this.tsmi_cancelar.Text = "Cancelar Operacion";
            this.tsmi_cancelar.Click += new System.EventHandler(this.tsmi_cancelar_Click);
            // 
            // tb_unidades
            // 
            this.tb_unidades.Location = new System.Drawing.Point(720, 389);
            this.tb_unidades.Margin = new System.Windows.Forms.Padding(2);
            this.tb_unidades.Name = "tb_unidades";
            this.tb_unidades.Size = new System.Drawing.Size(175, 20);
            this.tb_unidades.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Agregar unidades:";
            // 
            // tecnologiaToolStripMenuItem
            // 
            this.tecnologiaToolStripMenuItem.Name = "tecnologiaToolStripMenuItem";
            this.tecnologiaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tecnologiaToolStripMenuItem.Text = "Tecnologia";
            this.tecnologiaToolStripMenuItem.Click += new System.EventHandler(this.tecnologiaToolStripMenuItem_Click);
            // 
            // escolaresToolStripMenuItem
            // 
            this.escolaresToolStripMenuItem.Name = "escolaresToolStripMenuItem";
            this.escolaresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.escolaresToolStripMenuItem.Text = "Escolares";
            this.escolaresToolStripMenuItem.Click += new System.EventHandler(this.escolaresToolStripMenuItem_Click);
            // 
            // manualidadesToolStripMenuItem
            // 
            this.manualidadesToolStripMenuItem.Name = "manualidadesToolStripMenuItem";
            this.manualidadesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualidadesToolStripMenuItem.Text = "Oficina";
            this.manualidadesToolStripMenuItem.Click += new System.EventHandler(this.manualidadesToolStripMenuItem_Click);
            // 
            // manualidadesToolStripMenuItem1
            // 
            this.manualidadesToolStripMenuItem1.Name = "manualidadesToolStripMenuItem1";
            this.manualidadesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.manualidadesToolStripMenuItem1.Text = "Manualidades";
            this.manualidadesToolStripMenuItem1.Click += new System.EventHandler(this.manualidadesToolStripMenuItem1_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // FORM_ACTUALIZAR_STOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 505);
            this.Controls.Add(this.tb_unidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_recargar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_ACTUALIZAR_STOCK";
            this.Text = "Actualizar Existencias";
            this.Load += new System.EventHandler(this.FORM_ACTUALIZAR_STOCK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.cms_actualizar_stock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_recargar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox tb_busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.TextBox tb_unidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cms_actualizar_stock;
        private System.Windows.Forms.ToolStripMenuItem tsmi_eliminar_stock_actual;
        private System.Windows.Forms.ToolStripMenuItem tsmi_resetear_stock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_cancelar;
        private System.Windows.Forms.ToolStripMenuItem tecnologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
    }
}