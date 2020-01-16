namespace LibreriaParraJr
{
    partial class FORMABONAR
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datos = new System.Windows.Forms.GroupBox();
            this.cb_minutos = new System.Windows.Forms.ComboBox();
            this.cb_horas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_registrar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // datos
            // 
            this.datos.Controls.Add(this.cb_minutos);
            this.datos.Controls.Add(this.cb_horas);
            this.datos.Controls.Add(this.label4);
            this.datos.Controls.Add(this.dtp_fecha);
            this.datos.Controls.Add(this.tb_monto);
            this.datos.Controls.Add(this.label3);
            this.datos.Controls.Add(this.label2);
            this.datos.Controls.Add(this.label1);
            this.datos.Location = new System.Drawing.Point(9, 11);
            this.datos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datos.Name = "datos";
            this.datos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datos.Size = new System.Drawing.Size(363, 90);
            this.datos.TabIndex = 43;
            this.datos.TabStop = false;
            // 
            // cb_minutos
            // 
            this.cb_minutos.FormattingEnabled = true;
            this.cb_minutos.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cb_minutos.Location = new System.Drawing.Point(296, 20);
            this.cb_minutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_minutos.Name = "cb_minutos";
            this.cb_minutos.Size = new System.Drawing.Size(38, 21);
            this.cb_minutos.TabIndex = 10;
            this.cb_minutos.Text = "00";
            // 
            // cb_horas
            // 
            this.cb_horas.FormattingEnabled = true;
            this.cb_horas.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            ""});
            this.cb_horas.Location = new System.Drawing.Point(238, 20);
            this.cb_horas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_horas.Name = "cb_horas";
            this.cb_horas.Size = new System.Drawing.Size(38, 21);
            this.cb_horas.TabIndex = 9;
            this.cb_horas.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(44, 20);
            this.dtp_fecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(134, 20);
            this.dtp_fecha.TabIndex = 6;
            this.dtp_fecha.Value = new System.DateTime(2017, 1, 2, 22, 35, 0, 0);
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(122, 53);
            this.tb_monto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(128, 20);
            this.tb_monto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // bt_registrar
            // 
            this.bt_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_registrar.Location = new System.Drawing.Point(206, 120);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(79, 40);
            this.bt_registrar.TabIndex = 42;
            this.bt_registrar.Text = "Registrar";
            this.bt_registrar.UseVisualStyleBackColor = true;
            this.bt_registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_cancelar.Location = new System.Drawing.Point(94, 120);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 40);
            this.bt_cancelar.TabIndex = 41;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // FORMABONAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 171);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.bt_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FORMABONAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonar Pago";
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_registrar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.ComboBox cb_minutos;
        private System.Windows.Forms.ComboBox cb_horas;
    }
}