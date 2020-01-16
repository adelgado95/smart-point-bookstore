namespace LibreriaParraJr
{
    partial class BUSCAR_CODIGO_PRODUCTO
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
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_busqueda = new System.Windows.Forms.TextBox();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.bt_recargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(9, 86);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowTemplate.Height = 24;
            this.dgv_productos.Size = new System.Drawing.Size(885, 288);
            this.dgv_productos.TabIndex = 0;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el producto";
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Enabled = false;
            this.bt_aceptar.Location = new System.Drawing.Point(391, 388);
            this.bt_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(91, 40);
            this.bt_aceptar.TabIndex = 2;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(549, 388);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(84, 40);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar:";
            // 
            // text_busqueda
            // 
            this.text_busqueda.Location = new System.Drawing.Point(500, 58);
            this.text_busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.text_busqueda.Name = "text_busqueda";
            this.text_busqueda.Size = new System.Drawing.Size(175, 20);
            this.text_busqueda.TabIndex = 5;
            this.text_busqueda.TextChanged += new System.EventHandler(this.text_busqueda_TextChanged);
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(678, 57);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(68, 21);
            this.bt_buscar.TabIndex = 6;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_recargar
            // 
            this.bt_recargar.Location = new System.Drawing.Point(794, 48);
            this.bt_recargar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_recargar.Name = "bt_recargar";
            this.bt_recargar.Size = new System.Drawing.Size(100, 28);
            this.bt_recargar.TabIndex = 7;
            this.bt_recargar.Text = "Recargar";
            this.bt_recargar.UseVisualStyleBackColor = true;
            this.bt_recargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BUSCAR_CODIGO_PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 437);
            this.Controls.Add(this.bt_recargar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.text_busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BUSCAR_CODIGO_PRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BUSCAR_CODIGO_PRODUCTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_busqueda;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.Button bt_recargar;
    }
}