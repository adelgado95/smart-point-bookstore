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
    public partial class INSERTAR_EMPRESA : Form
    {
        public INSERTAR_EMPRESA()
        {
            InitializeComponent();
        }

        private void INSERTAR_EMPRESA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            if (lista_empresas.Items.Count == 0)
            {
                MessageBox.Show("No hay empresa que agregar");
                return;
            }

            if (comprobar_existencia())
            {

                return;
            }
            for (int i = 0; i < lista_empresas.Items.Count; i++)
            {
                int salida = Datos.EjecutarOrden("insert into empresa values(null,'" + lista_empresas.Items[i].ToString().ToUpper() + "');");
                if (salida == -1)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos");
                    return;
                }


            }

            MessageBox.Show("Datos agregados");
            lista_empresas.Items.Clear();
            return;
        }

        private bool comprobar_existencia()
        {
            for (int i = 0; i < lista_empresas.Items.Count; i++)
            {
                DataTable d = Datos.EjecutarOrdenSelect("SELECT nombre FROM empresa WHERE nombre = '" + lista_empresas.Items[i].ToString().ToUpper() + "'");

                if (d.Rows.Count > 0)
                {
                    MessageBox.Show("La empresa : '" + lista_empresas.Items[i].ToString().ToUpper() + "' ya existe");
                    return true;
                }

            }
            return false;
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (tb_empresa.TextLength == 0)
            {
                MessageBox.Show("Inserte la marca");
                return;

            }

            lista_empresas.Items.Add(tb_empresa.Text.ToUpper());

            tb_empresa.Text = string.Empty;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (lista_empresas.SelectedIndex == -1)
                return;
            lista_empresas.Items.RemoveAt(lista_empresas.SelectedIndex);
            if (lista_empresas.Items.Count == 0)
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
