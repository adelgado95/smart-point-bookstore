namespace LibreriaParraJr
{
    partial class FORM_LISTAR_PROVEEDOR
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
            this.tb_nombre_proveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_salir = new System.Windows.Forms.Button();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_recargar
            // 
            this.bt_recargar.Location = new System.Drawing.Point(689, 66);
            this.bt_recargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_recargar.Name = "bt_recargar";
            this.bt_recargar.Size = new System.Drawing.Size(87, 49);
            this.bt_recargar.TabIndex = 14;
            this.bt_recargar.Text = "Recargar";
            this.bt_recargar.UseVisualStyleBackColor = true;
            this.bt_recargar.Click += new System.EventHandler(this.recargar_Click);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(579, 76);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(75, 31);
            this.bt_buscar.TabIndex = 13;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // tb_nombre_proveedor
            // 
            this.tb_nombre_proveedor.Location = new System.Drawing.Point(325, 82);
            this.tb_nombre_proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nombre_proveedor.Name = "tb_nombre_proveedor";
            this.tb_nombre_proveedor.Size = new System.Drawing.Size(239, 22);
            this.tb_nombre_proveedor.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buscar nombre de proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Listado de proveedor";
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(312, 574);
            this.bt_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(125, 46);
            this.bt_salir.TabIndex = 9;
            this.bt_salir.Text = "Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_proveedores.Location = new System.Drawing.Point(13, 119);
            this.dgv_proveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            this.dgv_proveedores.RowTemplate.Height = 24;
            this.dgv_proveedores.Size = new System.Drawing.Size(763, 448);
            this.dgv_proveedores.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 56);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // FORM_LISTAR_PROVEEDOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 639);
            this.Controls.Add(this.bt_recargar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.tb_nombre_proveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.dgv_proveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FORM_LISTAR_PROVEEDOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_LISTAR_PROVEEDOR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_recargar;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox tb_nombre_proveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}