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
    public partial class INSERTAR_CATEGORIA : Form
    {
        public INSERTAR_CATEGORIA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            if (lista.Items.Count == 0)
            {
                MessageBox.Show("No hay categorías que agregar");
                return;
            }
            if (comprobar_existencia())
            {

                return;
            }
            for (int i = 0; i < lista.Items.Count; i++)
            {
                int salida = Datos.EjecutarOrden("insert into categoria values(null,'" + lista.Items[i].ToString().ToUpper() + "');");
                if (salida == -1)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos");
                    return;
                }


            }

            MessageBox.Show("Datos agregados");
            lista.Items.Clear();
            return;
        }

        private bool comprobar_existencia()
        {
            for (int i = 0; i < lista.Items.Count; i++)
            {
                DataTable d = Datos.EjecutarOrdenSelect("SELECT nombre FROM categoria WHERE nombre ='" + lista.Items[i].ToString().ToUpper() + "'");

                if (d.Rows.Count > 0)
                {
                    MessageBox.Show("La categoría : '" + lista.Items[i].ToString().ToUpper() + "' ya existe");
                    return true;
                }

            }
            return false;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (tb_categoria.TextLength == 0)
            {
                MessageBox.Show("Inserte la categoria");
                return;

            }

            lista.Items.Add(tb_categoria.Text.ToUpper());

            tb_categoria.Text = string.Empty;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex == -1)
                return;
            lista.Items.RemoveAt(lista.SelectedIndex);
            if (lista.Items.Count == 0)
            {
                bt_eliminar.Enabled = false;
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_eliminar.Enabled = true;
        }
    }
}
