namespace LibreriaParraJr
{
    partial class INSERTAR_EMPRESA
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
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.lista_empresas = new System.Windows.Forms.ListBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Enabled = false;
            this.bt_eliminar.Location = new System.Drawing.Point(164, 102);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(74, 28);
            this.bt_eliminar.TabIndex = 17;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(68, 102);
            this.bt_agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(68, 28);
            this.bt_agregar.TabIndex = 16;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // lista_empresas
            // 
            this.lista_empresas.FormattingEnabled = true;
            this.lista_empresas.Location = new System.Drawing.Point(51, 145);
            this.lista_empresas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lista_empresas.Name = "lista_empresas";
            this.lista_empresas.Size = new System.Drawing.Size(209, 160);
            this.lista_empresas.TabIndex = 18;
            this.lista_empresas.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(63, 320);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(74, 29);
            this.bt_cancelar.TabIndex = 19;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(164, 320);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(74, 29);
            this.btn_aceptar.TabIndex = 20;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_marca_Click);
            // 
            // tb_empresa
            // 
            this.tb_empresa.Location = new System.Drawing.Point(48, 76);
            this.tb_empresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Size = new System.Drawing.Size(212, 20);
            this.tb_empresa.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Inserte una empresa";
            // 
            // INSERTAR_EMPRESA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 372);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.lista_empresas);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.tb_empresa);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "INSERTAR_EMPRESA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Empresa";
            this.Load += new System.EventHandler(this.INSERTAR_EMPRESA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.ListBox lista_empresas;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox tb_empresa;
        private System.Windows.Forms.Label label1;
    }
}