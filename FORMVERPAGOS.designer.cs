namespace LibreriaParraJr
{
    partial class FORMVERPAGOS
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
            this.bt_abonar = new System.Windows.Forms.Button();
            this.dgv_pagos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagos)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_abonar
            // 
            this.bt_abonar.Location = new System.Drawing.Point(139, 367);
            this.bt_abonar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_abonar.Name = "bt_abonar";
            this.bt_abonar.Size = new System.Drawing.Size(80, 30);
            this.bt_abonar.TabIndex = 13;
            this.bt_abonar.Text = "Abonar";
            this.bt_abonar.UseVisualStyleBackColor = true;
            this.bt_abonar.Click += new System.EventHandler(this.abonar_Click);
            // 
            // dgv_pagos
            // 
            this.dgv_pagos.AllowUserToAddRows = false;
            this.dgv_pagos.AllowUserToDeleteRows = false;
            this.dgv_pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_pagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pagos.Location = new System.Drawing.Point(9, 52);
            this.dgv_pagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_pagos.Name = "dgv_pagos";
            this.dgv_pagos.ReadOnly = true;
            this.dgv_pagos.RowHeadersWidth = 42;
            this.dgv_pagos.RowTemplate.Height = 24;
            this.dgv_pagos.Size = new System.Drawing.Size(246, 261);
            this.dgv_pagos.TabIndex = 7;
            this.dgv_pagos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Abonos Realizados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "aaaa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "bbbbb";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(42, 367);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(80, 30);
            this.bt_cancelar.TabIndex = 17;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // FORMVERPAGOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 407);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_abonar);
            this.Controls.Add(this.dgv_pagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FORMVERPAGOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORMVERPAGOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_abonar;
        private System.Windows.Forms.DataGridView dgv_pagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_cancelar;
    }
}