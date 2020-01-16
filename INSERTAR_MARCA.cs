using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibreriaParraJr
{
    public partial class INSERTAR_MARCA : Form
    {
        public INSERTAR_MARCA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            if (lista_marcas.Items.Count == 0)
            {
                MessageBox.Show("No hay marcas que agregar");
                return;
            }

            if (comprobar_existencia())
            {

                return;
            }

            for (int i = 0; i < lista_marcas.Items.Count; i++)
            {
                int salida = Datos.EjecutarOrden("insert into marca values(null,'" + lista_marcas.Items[i].ToString().ToUpper() + "');");
                if (salida == -1)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos");
                    return;
                }


            }
            MessageBox.Show("Datos agregados");
            lista_marcas.Items.Clear();
            return;

        }

        private bool comprobar_existencia()
        {
            for (int i = 0; i < lista_marcas.Items.Count; i++)
            {
                DataTable d = Datos.EjecutarOrdenSelect("SELECT nombre FROM marca WHERE nombre = '" + lista_marcas.Items[i].ToString().ToUpper() + "'");

                if (d.Rows.Count > 0)
                {
                    MessageBox.Show("La marca : '" + lista_marcas.Items[i].ToString().ToUpper() + "' ya existe");
                    return true;
                }

            }
            return false;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (bt_marca.TextLength == 0)
            {
                MessageBox.Show("Inserte la marca");
                return;

            }

            lista_marcas.Items.Add(bt_marca.Text.ToUpper());

            bt_marca.Text = string.Empty;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (lista_marcas.SelectedIndex == -1)
                return;
            lista_marcas.Items.RemoveAt(lista_marcas.SelectedIndex);
            if(lista_marcas.Items.Count == 0)
            {
                bt_eliminar.Enabled = false;
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_eliminar.Enabled = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listadoDeMarcasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new LISTADOMARCAS().ShowDialog();
        }
    }
}
