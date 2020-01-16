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
    public partial class FORM_LISTAR_TRABAJADORES : Form
    {
        public FORM_LISTAR_TRABAJADORES()
        {
            InitializeComponent();
            recargar_trabajadores();
        }

        private void bt_recargar_Click(object sender, EventArgs e)
        {
            recargar_trabajadores();
        }
        private void recargar_trabajadores()
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT * FROM trabajadores; ");

            dgv_usuarios.DataSource = datos;

            if (dgv_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT * FROM trabajadores where nombre like '%" + bt_nombre_usuario.Text + "%';");

            dgv_usuarios.DataSource = datos;

            if (dgv_usuarios.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string message = "¿Esta seguro que desea borrar este registro?";
            string caption = "Aviso";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.No)
            {

                return;

            }

            try
            {


                int salida = Datos.EjecutarOrden("delete from trabajadores where cedula = '" + dgv_usuarios.CurrentRow.Cells[0].Value.ToString() + "'");

                if (salida == -1)
                {
                    MessageBox.Show("Ha ocurrido un error");
                    return;
                }
                else
                {
                    MessageBox.Show("El registro ha sido eliminado");
                    recargar_trabajadores();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, asegurese de seleccionar el registro a eliminar");
            }

        }
    }
}
