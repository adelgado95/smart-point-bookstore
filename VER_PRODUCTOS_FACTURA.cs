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
    public partial class VER_PRODUCTOS_FACTURA : Form
    {
        string factura_codigo = string.Empty;

        public VER_PRODUCTOS_FACTURA(string f)
        {
            InitializeComponent();

            factura_codigo = f;
        }

        private void VER_PRODUCTOS_FACTURA_Load(object sender, EventArgs e)
        {
            recargar_productos();
            factura.Text = factura_codigo.ToString();
            if (globales.tipo_usuario == "CAJERO")
            {
                bt_eliminar.Enabled = false;
            }
        }

        private void recargar_productos()
        {
            DataTable datos = null;

            datos = Datos.EjecutarOrdenSelect("SELECT factura.codigo, productos.nombre, sum(cantidad) as cantidad, factura.total FROM detalle_factura, "
          + "  productos, factura where productos.codigo = detalle_factura.producto and detalle_factura.codigo_factura = factura.codigo "
          + "  and factura.codigo = " + factura_codigo + " group by productos.nombre");


            dgv_productos_factura.DataSource = datos;

            if (dgv_productos_factura.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta factura?", "Eliminar factura", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Datos.EjecutarOrden("Delete from factura where codigo = '" + factura_codigo + "'");
                this.Dispose();
            }
            else
            {
               
            }
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
