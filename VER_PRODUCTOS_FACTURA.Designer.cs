namespace LibreriaParraJr
{
    partial class VER_PRODUCTOS_FACTURA
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
            this.dgv_productos_factura = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.factura = new System.Windows.Forms.Label();
            this.bt_recargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_productos_factura
            // 
            this.dgv_productos_factura.AllowUserToAddRows = false;
            this.dgv_productos_factura.AllowUserToDeleteRows = false;
            this.dgv_productos_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos_factura.Location = new System.Drawing.Point(9, 101);
            this.dgv_productos_factura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_productos_factura.Name = "dgv_productos_factura";
            this.dgv_productos_factura.ReadOnly = true;
            this.dgv_productos_factura.RowTemplate.Height = 24;
            this.dgv_productos_factura.Size = new System.Drawing.Size(467, 327);
            this.dgv_productos_factura.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Location = new System.Drawing.Point(392, 58);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(84, 38);
            this.bt_eliminar.TabIndex = 2;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalles de Factura #";
            // 
            // factura
            // 
            this.factura.AutoSize = true;
            this.factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factura.Location = new System.Drawing.Point(198, 20);
            this.factura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(0, 20);
            this.factura.TabIndex = 4;
            // 
            // bt_recargar
            // 
            this.bt_recargar.Location = new System.Drawing.Point(273, 58);
            this.bt_recargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_recargar.Name = "bt_recargar";
            this.bt_recargar.Size = new System.Drawing.Size(84, 38);
            this.bt_recargar.TabIndex = 5;
            this.bt_recargar.Text = "Recargar";
            this.bt_recargar.UseVisualStyleBackColor = true;
            this.bt_recargar.Click += new System.EventHandler(this.button3_Click);
            // 
            // VER_PRODUCTOS_FACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 512);
            this.Controls.Add(this.bt_recargar);
            this.Controls.Add(this.factura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_productos_factura);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VER_PRODUCTOS_FACTURA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VER_PRODUCTOS_FACTURA";
            this.Load += new System.EventHandler(this.VER_PRODUCTOS_FACTURA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos_factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos_factura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label factura;
        private System.Windows.Forms.Button bt_recargar;
    }
}