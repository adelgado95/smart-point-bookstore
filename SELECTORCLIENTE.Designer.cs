namespace LibreriaParraJr
{
    partial class SELECTORCLIENTE
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
            this.tb_buscar_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.bt_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_buscar_cliente
            // 
            this.tb_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_buscar_cliente.Location = new System.Drawing.Point(87, 14);
            this.tb_buscar_cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_buscar_cliente.Name = "tb_buscar_cliente";
            this.tb_buscar_cliente.Size = new System.Drawing.Size(154, 26);
            this.tb_buscar_cliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(18, 54);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowTemplate.Height = 24;
            this.dgv_clientes.Size = new System.Drawing.Size(599, 230);
            this.dgv_clientes.TabIndex = 2;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Enabled = false;
            this.bt_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_aceptar.Location = new System.Drawing.Point(510, 11);
            this.bt_aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(107, 28);
            this.bt_aceptar.TabIndex = 3;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // SELECTORCLIENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 310);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_buscar_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SELECTORCLIENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Cliente";
            this.Load += new System.EventHandler(this.SELECTORCLIENTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_buscar_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Button bt_aceptar;
    }
}