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
    public partial class BUSCAR_CODIGO_PRODUCTO : Form
    {
        public BUSCAR_CODIGO_PRODUCTO()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            FORMENTRADAS.cod_p = string.Empty;
            this.Dispose();
        }

        private void BUSCAR_CODIGO_PRODUCTO_Load(object sender, EventArgs e)
        {
            FORMENTRADAS.cod_p = string.Empty;
            DataTable productos = Datos.EjecutarOrdenSelect(
                           "select dp.codigo_barras,concat(p.nombre,' ',dp.CaracteristicaIndividual) AS nombre,caracteristica,precio,stock_individual,presentacion from detalle_producto as dp, productos as p where dp.id_producto = p.id_producto;");
            dgv_productos.DataSource = productos;
            
            if(dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado productos");
                this.Dispose();
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            FORMENTRADAS.cod_p = dgv_productos.CurrentRow.Cells[0].Value.ToString();
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_aceptar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(text_busqueda.TextLength == 0 )
            {
                return;
            }

            DataTable productos = Datos.EjecutarOrdenSelect("select dp.codigo_barras,concat(p.nombre,' ',dp.CaracteristicaIndividual) AS nombre,caracteristica,precio,stock_individual,presentacion from detalle_producto as dp, productos as p where dp.id_producto = p.id_producto and (dp.codigo_barras = '" + text_busqueda.Text + "' or nombre like '%" + text_busqueda.Text.ToUpper() + "%');");
            dgv_productos.DataSource = productos;

            if (dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado productos");
     
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable productos = Datos.EjecutarOrdenSelect("select dp.codigo_barras,concat(p.nombre,' ',dp.CaracteristicaIndividual) AS nombre,caracteristica,precio,stock_individual,presentacion from detalle_producto as dp, productos as p where dp.id_producto = p.id_producto;");
            dgv_productos.DataSource = productos;

            if (dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado productos");

            }
        }

        private void text_busqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
