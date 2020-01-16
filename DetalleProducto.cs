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
    public partial class DetalleProducto : Form
    {
        public static DataGridView detalles_productos;
        public static bool CodigosMultiples = false;
        public static List<List<string>> detalles;
        int fila_seleccionada = 0;
        FORMENTRADAS instancia_obtenida;
        public DetalleProducto()
        {
            detalles = new List<List<string>>();
            detalles_productos = new DataGridView();
            InitializeComponent();
            cb_estado_producto.SelectedIndex = 0;
        }

        public DetalleProducto(FORMENTRADAS instancia)
        {
            detalles = new List<List<string>>();
            instancia_obtenida = instancia;
            InitializeComponent();
            cb_estado_producto.SelectedIndex = 0;
        }

        private void bt_agregar_codigo_barra_Click(object sender, EventArgs e)
        {
            if (!validar_controles()) return;
            dg_detalle_producto.Rows.Add(tb_codigo_barra.Text, tb_cantidad_individual.Text, tb_caracteristica.Text, tb_numero_serie.Text, cb_estado_producto.SelectedItem.ToString());
            resetear_controles();
        }

        private void resetear_controles()
        {
            tb_codigo_barra.Text = string.Empty;
            tb_numero_serie.Text = string.Empty;
            tb_cantidad_individual.Text = "0";
            tb_caracteristica.Text = string.Empty;
            cb_estado_producto.SelectedIndex = 0;
        }

        private bool validar_controles()
        {
            if (tb_codigo_barra.TextLength < 0)
            {
                tb_codigo_barra.Focus();
                return false;
            }
            char[] numeros = tb_cantidad_individual.Text.ToCharArray();
            for (int i = 0; i < numeros.Length; i++)
            {
                char caracter = numeros[i];
                if (!char.IsNumber(caracter))
                {
                    tb_cantidad_individual.Focus();
                    return false;
                }
            }
            if (tb_cantidad_individual.Text == string.Empty)
            {
                tb_cantidad_individual.Focus();
            }

            return true;
        }

        private void bt_editar_codigo_barra_Click(object sender, EventArgs e)
        {
            if (!validar_controles()) return;
            dg_detalle_producto.Rows.RemoveAt(fila_seleccionada);
            dg_detalle_producto.Rows.Insert(fila_seleccionada, tb_codigo_barra.Text, tb_cantidad_individual.Text, tb_caracteristica.Text, tb_numero_serie.Text, cb_estado_producto.SelectedItem.ToString());
            resetear_controles();
            encender_botones();
        }

        private void encender_botones()
        {
            bt_agregar_codigo_barra.Enabled = true;
            bt_ingresar_codigos_barras.Enabled = true;
            bt_editar_codigo_barra.Enabled = false;
            bt_eliminar_codigo_barra.Enabled = false;
            bt_cancelar_operacion.Enabled = false;
        }

        private void seleccionar_detalle_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (!validar_controles()) return;
            fila_seleccionada = e.RowIndex;
            int indice_estado = cb_estado_producto.FindString(dg_detalle_producto.CurrentRow.Cells[4].Value.ToString());
            apagar_botones();

            tb_codigo_barra.Text = dg_detalle_producto.CurrentRow.Cells[0].Value.ToString();
            tb_numero_serie.Text = dg_detalle_producto.CurrentRow.Cells[3].Value.ToString();
            tb_cantidad_individual.Text = dg_detalle_producto.CurrentRow.Cells[1].Value.ToString();
            tb_caracteristica.Text = dg_detalle_producto.CurrentRow.Cells[2].Value.ToString();
            cb_estado_producto.SelectedIndex = indice_estado;
            
        }

        private void apagar_botones()
        {
            bt_agregar_codigo_barra.Enabled = false;
            bt_ingresar_codigos_barras.Enabled = false;
            bt_editar_codigo_barra.Enabled = true;
            bt_eliminar_codigo_barra.Enabled = true;
            bt_cancelar_operacion.Enabled = true;
        }

        private void bt_eliminar_codigo_barra_Click(object sender, EventArgs e)
        {
            if (dg_detalle_producto.Rows.Count < 0) return;
            dg_detalle_producto.Rows.RemoveAt(fila_seleccionada);
            encender_botones();
            resetear_controles();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_cancelar_operacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_ingresar_codigos_barras_Click(object sender, EventArgs e)
        {
            List<string> item = new List<string>();
            if (dg_detalle_producto.Rows.Count < 1) return;
            resetear_controles();
            detalles_productos = dg_detalle_producto;
            instancia_obtenida.tb_codigo_barras.Text = "|";
            for (int i = 0; i < dg_detalle_producto.Rows.Count; i++)
            {
                item.Clear();
                instancia_obtenida.tb_codigo_barras.Text += dg_detalle_producto.Rows[i].Cells[0].Value.ToString() + "|";
                item.Add(dg_detalle_producto.Rows[i].Cells[0].Value.ToString());
                item.Add(dg_detalle_producto.Rows[i].Cells[1].Value.ToString());
                item.Add(dg_detalle_producto.Rows[i].Cells[2].Value.ToString());
                item.Add(dg_detalle_producto.Rows[i].Cells[3].Value.ToString());
                item.Add(dg_detalle_producto.Rows[i].Cells[4].Value.ToString());
                detalles.Add(new List<string>(item));
            }
            instancia_obtenida.detalles_obtenidos = detalles;
            CodigosMultiples = true;
            dg_detalle_producto.Rows.Clear();
            this.Hide();
        }
    }
}
