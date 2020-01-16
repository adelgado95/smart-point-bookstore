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
    public partial class CONSULTARFACTURAS_ : Form
    {
        public CONSULTARFACTURAS_()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CONSULTARFACTURAS__Load(object sender, EventArgs e)
        {
            recargar_productos();
            if (globales.tipo_usuario == "CAJERO")
            {
                bt_eliminar.Enabled = false;
            }
        }

        private void recargar_Click(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void recargar_productos()
        {
            DataTable datos = null;
            if (RadioFecha.Checked == true)
            {
                if (r_asc.Checked == true)
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT factura.codigo,fecha_hora, empresa.nombre, cliente.nombre, total, tipo_pago, descripcion_pago "+
                          "  FROM factura, empresa, cliente where empresa.codigo = factura.empresa "
                           +" and cliente.ruc = factura.cliente order by fecha_hora asc; ");
                }
                else
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT factura.codigo,fecha_hora, empresa.nombre, cliente.nombre, total, tipo_pago, descripcion_pago " +
                        "  FROM factura, empresa, cliente where empresa.codigo = factura.empresa "
                         + " and cliente.ruc = factura.cliente order by fecha_hora desc; ");
                }
            }

         

            dataGridView1.DataSource = datos;

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT factura.codigo,fecha_hora, empresa.nombre, cliente.nombre, total, tipo_pago, descripcion_pago "+
                          "  FROM factura, empresa, cliente where empresa.codigo = factura.empresa "
                           +" and cliente.ruc = factura.cliente  and factura.codigo like '%" + tb_buscar_factura.Text + "%'");

            dataGridView1.DataSource = datos;

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void reportes_Click(object sender, EventArgs e)
        {
            CONTENEDORREPORTETODOS f = new CONTENEDORREPORTETODOS();
            f.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            new VER_PRODUCTOS_FACTURA(dataGridView1.CurrentRow.Cells[0].Value.ToString()).ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar esta factura?", "Eliminar factura", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Datos.EjecutarOrden("Delete from factura where codigo = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'");
                recargar_productos();
            }
            else
            {

            }
        }
    }
}
