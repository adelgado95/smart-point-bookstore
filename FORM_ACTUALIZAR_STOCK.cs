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
    public partial class FORM_ACTUALIZAR_STOCK : Form
    {
        int fila_seleccionado = 0;
        public FORM_ACTUALIZAR_STOCK()
        {
            InitializeComponent();

            if (globales.tipo_usuario == "CAJERO")
            {
                tsmi_resetear_stock.Visible = false;
            }
            else
            {
                tsmi_resetear_stock.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void recargar()
        {
            DataTable productos = Datos.EjecutarOrdenSelect("select codigo_barras, concat(p.nombre,' ',dp.CaracteristicaIndividual) AS nombre, caracteristica, precio, stock_individual, presentacion from  detalle_producto as dp,productos as p where dp.id_producto=p.id_producto; ");
            dgv_productos.DataSource = productos;

            if (dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado productos");

            }
            bt_aceptar.Enabled = false;
        }

        private void FORM_ACTUALIZAR_STOCK_Load(object sender, EventArgs e)
        {
            recargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_busqueda.TextLength == 0)
            {
                return;
            }

            DataTable productos = Datos.EjecutarOrdenSelect("select codigo_barras, concat(p.nombre,' ',dp.CaracteristicaIndividual) AS nombre, caracteristica, precio, stock_individual, presentacion from  detalle_producto as dp, productos as p where dp.id_producto=p.id_producto and nombre like '%" + tb_busqueda.Text.ToUpper() + "%';");
            dgv_productos.DataSource = productos;

            if (dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No se han encontrado productos");

            }
            bt_aceptar.Enabled = false;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if(tb_unidades.Text.Length == 0)
            {
                MessageBox.Show("Escriba las unidades entrantes");
                return;
            }
            int unidades = int.Parse(dgv_productos.CurrentRow.Cells[4].Value.ToString());
            unidades += int.Parse( tb_unidades.Text);
            int n = Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto  set dp.stock_individual = " + unidades + " where dp.codigo_barras = '" + dgv_productos.CurrentRow.Cells[0].Value.ToString() + "';");
            if(n != -1)
            {
                MessageBox.Show("Datos actualizados");
                recargar();
                tb_unidades.Text = string.Empty;
                bt_aceptar.Enabled = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_aceptar.Enabled = true;

            fila_seleccionado = e.RowIndex;

            
        }

        private void tsmi_eliminar_stock_actual_Click(object sender, EventArgs e)
        {
            if (fila_seleccionado >= 0)
            {
                int n = Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto  set dp.stock_individual = 0 where dp.codigo_barras = '" + dgv_productos.CurrentRow.Cells[0].Value.ToString() + "';");
                if (n != -1)
                {
                    MessageBox.Show("Datos actualizados");
                    recargar();
                    bt_aceptar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("SELECCIONE UN PRODUCTO A ELIMINAR STOCK","INFORMACION",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmi_resetear_stock_Click(object sender, EventArgs e)
        {
            return;
        }

        private void tecnologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto  set dp.stock_individual = 0 where categoria=1;");
            if (n != -1)
            {
                MessageBox.Show("Datos actualizados");
                recargar();
                bt_aceptar.Enabled = false;
            }
        }

        private void escolaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto  set dp.stock_individual = 0 where categoria=2;");
            if (n != -1)
            {
                MessageBox.Show("Datos actualizados");
                recargar();
                bt_aceptar.Enabled = false;
            }
        }

        private void manualidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto  set dp.stock_individual = 0 where categoria=3;");
            if (n != -1)
            {
                MessageBox.Show("Datos actualizados");
                recargar();
                bt_aceptar.Enabled = false;
            }
        }

        private void manualidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int n = Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto  set dp.stock_individual = 0 where categoria=4;");
            if (n != -1)
            {
                MessageBox.Show("Datos actualizados");
                recargar();
                bt_aceptar.Enabled = false;
            }
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto  set dp.stock_individual = 0 where categoria=5;");
            if (n != -1)
            {
                MessageBox.Show("Datos actualizados");
                recargar();
                bt_aceptar.Enabled = false;
            }
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto  set dp.stock_individual = 0 where categoria=6;");
            if (n != -1)
            {
                MessageBox.Show("Datos actualizados");
                recargar();
                bt_aceptar.Enabled = false;
            }
        }

        private void tsmi_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
