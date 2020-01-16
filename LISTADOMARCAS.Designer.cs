namespace LibreriaParraJr
{
    partial class LISTADOMARCAS
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
            this.dgv_marcas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_buscar = new System.Windows.Forms.Button();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.Bt_Recargar = new System.Windows.Forms.Button();
            this.bt_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_marcas
            // 
            this.dgv_marcas.AllowUserToAddRows = false;
            this.dgv_marcas.AllowUserToDeleteRows = false;
            this.dgv_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marcas.Location = new System.Drawing.Point(9, 111);
            this.dgv_marcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_marcas.Name = "dgv_marcas";
            this.dgv_marcas.ReadOnly = true;
            this.dgv_marcas.RowTemplate.Height = 24;
            this.dgv_marcas.Size = new System.Drawing.Size(291, 306);
            this.dgv_marcas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Marcas";
            // 
            // bt_buscar
            // 
            this.bt_buscar.Location = new System.Drawing.Point(238, 78);
            this.bt_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.Size = new System.Drawing.Size(62, 28);
            this.bt_buscar.TabIndex = 2;
            this.bt_buscar.Text = "Buscar";
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Location = new System.Drawing.Point(103, 83);
            this.tb_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(132, 20);
            this.tb_Buscar.TabIndex = 3;
            // 
            // Bt_Recargar
            // 
            this.Bt_Recargar.Location = new System.Drawing.Point(9, 78);
            this.Bt_Recargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bt_Recargar.Name = "Bt_Recargar";
            this.Bt_Recargar.Size = new System.Drawing.Size(62, 28);
            this.Bt_Recargar.TabIndex = 4;
            this.Bt_Recargar.Text = "Recargar";
            this.Bt_Recargar.UseVisualStyleBackColor = true;
            this.Bt_Recargar.Click += new System.EventHandler(this.BtnRecarga_Click);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(108, 422);
            this.bt_aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(98, 40);
            this.bt_aceptar.TabIndex = 5;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // LISTADOMARCAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 471);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.Bt_Recargar);
            this.Controls.Add(this.tb_Buscar);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_marcas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LISTADOMARCAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTADOMARCAS";
            this.Load += new System.EventHandler(this.LISTADOMARCAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_marcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_buscar;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.Button Bt_Recargar;
        private System.Windows.Forms.Button bt_aceptar;
    }
}