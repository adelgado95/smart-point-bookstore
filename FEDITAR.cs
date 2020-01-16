using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaParraJr
{
    public partial class FEDITAR : Form
    {
        public string cantidad,precio,total;
        public Boolean bodega = false, editar = false;
        public FEDITAR(string cant,string prec)
        {
            InitializeComponent();
            this.cantidad = cant;
            this.precio = prec;
            tb_cantidad.Text = this.cantidad;
        }

        public FEDITAR()
        {
            InitializeComponent();
            bodega = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        private void e(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bodega)
            {
                editar = true;
                this.cantidad = tb_cantidad.Text;
                this.Close();
            }
            else
            {
                editar = true;
                float tprecio = float.Parse(this.precio);
                float fcantidad = float.Parse(tb_cantidad.Text);
                this.total = (tprecio * fcantidad).ToString();
                this.cantidad = tb_cantidad.Text;
                this.Close();
            }

        }
    }
}
