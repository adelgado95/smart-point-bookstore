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
    public partial class FORM_LISTAR_PROVEEDOR : Form
    {
        public FORM_LISTAR_PROVEEDOR()
        {
            InitializeComponent();
        }

        private void recargar_Click(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void recargar_productos()
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT * FROM proveedor; ");

            dgv_proveedores.DataSource = datos;

            if (dgv_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void FORM_LISTAR_PROVEEDOR_Load(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT * FROM proveedor where nombre like '%" + tb_nombre_proveedor.Text + "%';");

            dgv_proveedores.DataSource = datos;

            if (dgv_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
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


                int salida = Datos.EjecutarOrden("delete from proveedor where ruc = '" + dgv_proveedores.CurrentRow.Cells[0].Value.ToString() + "'");

                if (salida == -1)
                {
                    MessageBox.Show("Ha ocurrido un error");
                    return;
                }
                else
                {
                    MessageBox.Show("El registro ha sido eliminado");
                    recargar_productos();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, asegurese de seleccionar el registro a eliminar");
            }
        }
    }
}
