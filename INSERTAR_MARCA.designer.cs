namespace LibreriaParraJr
{
    partial class INSERTAR_MARCA
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_marca = new System.Windows.Forms.TextBox();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.lista_marcas = new System.Windows.Forms.ListBox();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.Acciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMarcasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Acciones.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserte una marca";
            // 
            // bt_marca
            // 
            this.bt_marca.Location = new System.Drawing.Point(46, 82);
            this.bt_marca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_marca.Name = "bt_marca";
            this.bt_marca.Size = new System.Drawing.Size(212, 20);
            this.bt_marca.TabIndex = 1;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(162, 326);
            this.bt_aceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(74, 29);
            this.bt_aceptar.TabIndex = 6;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.btn_marca_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(61, 326);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(74, 29);
            this.bt_cancelar.TabIndex = 5;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista_marcas
            // 
            this.lista_marcas.FormattingEnabled = true;
            this.lista_marcas.Location = new System.Drawing.Point(49, 151);
            this.lista_marcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lista_marcas.Name = "lista_marcas";
            this.lista_marcas.Size = new System.Drawing.Size(209, 160);
            this.lista_marcas.TabIndex = 4;
            this.lista_marcas.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(61, 105);
            this.bt_agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(77, 28);
            this.bt_agregar.TabIndex = 2;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Enabled = false;
            this.bt_eliminar.Location = new System.Drawing.Point(162, 105);
            this.bt_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(81, 28);
            this.bt_eliminar.TabIndex = 3;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Acciones
            // 
            this.Acciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Acciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.Acciones.Name = "Acciones";
            this.Acciones.Size = new System.Drawing.Size(123, 26);
            this.Acciones.Text = "Menú";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeMarcasToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // listadoDeMarcasToolStripMenuItem
            // 
            this.listadoDeMarcasToolStripMenuItem.Name = "listadoDeMarcasToolStripMenuItem";
            this.listadoDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listadoDeMarcasToolStripMenuItem.Text = "Listado de marcas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem1
            // 
            this.accionesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeMarcasToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.accionesToolStripMenuItem1.Name = "accionesToolStripMenuItem1";
            this.accionesToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem1.Text = "Acciones";
            // 
            // listadoDeMarcasToolStripMenuItem1
            // 
            this.listadoDeMarcasToolStripMenuItem1.Name = "listadoDeMarcasToolStripMenuItem1";
            this.listadoDeMarcasToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.listadoDeMarcasToolStripMenuItem1.Text = "Listado de Marcas";
            this.listadoDeMarcasToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeMarcasToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // INSERTAR_MARCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 372);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bt_eliminar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.lista_marcas);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.bt_marca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "INSERTAR_MARCA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Marca";
            this.Acciones.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bt_marca;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.ListBox lista_marcas;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.ContextMenuStrip Acciones;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMarcasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMarcasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}