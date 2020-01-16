namespace LibreriaParraJr
{
    partial class FORM_CAMBIO_PASSWORD
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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.tb_pass2 = new System.Windows.Forms.TextBox();
            this.tb_pass1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(177, 197);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(68, 25);
            this.bt_cancelar.TabIndex = 17;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(74, 197);
            this.bt_aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(68, 25);
            this.bt_aceptar.TabIndex = 16;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_pass2
            // 
            this.tb_pass2.Location = new System.Drawing.Point(172, 145);
            this.tb_pass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_pass2.Name = "tb_pass2";
            this.tb_pass2.PasswordChar = '*';
            this.tb_pass2.Size = new System.Drawing.Size(158, 20);
            this.tb_pass2.TabIndex = 15;
            // 
            // tb_pass1
            // 
            this.tb_pass1.Location = new System.Drawing.Point(172, 84);
            this.tb_pass1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_pass1.Name = "tb_pass1";
            this.tb_pass1.PasswordChar = '*';
            this.tb_pass1.Size = new System.Drawing.Size(158, 20);
            this.tb_pass1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirmar Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese la nueva contraseña";
            // 
            // FORM_CAMBIO_PASSWORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 232);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.tb_pass2);
            this.Controls.Add(this.tb_pass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FORM_CAMBIO_PASSWORD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.TextBox tb_pass2;
        private System.Windows.Forms.TextBox tb_pass1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}