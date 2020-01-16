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
    public partial class REGISTRAR_PAGO_TRABAJADOR : Form
    {
        DataTable trabajador;
        public REGISTRAR_PAGO_TRABAJADOR()
        {
            InitializeComponent();
        }

        private void REGISTRAR_PAGO_TRABAJADOR_Load(object sender, EventArgs e)
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT cedula,nombre FROM `trabajadores`");

            trabajador= datos;


            if (trabajador.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
            for(int i = 0; i < trabajador.Rows.Count; i++)
            {
                cmTrabajador.Items.Add(trabajador.Rows[i][1].ToString());
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            
            int salida = Datos.EjecutarOrden(" INSERT INTO `pagos_trabajadores` (`id`, `cantidad`, `cedula`, `fecha`) VALUES (NULL, '"+txtCantidad.Text+"', '"+trabajador.Rows[cmTrabajador.SelectedIndex][0].ToString()+"', '"+dtFecha.Text+"'); ");


            if (salida == -1)
            {
                MessageBox.Show("Asegurese de que todos los datos esten correctos");
                return;
            }
            else
            {
                MessageBox.Show("Datos Agregados");
                txtCantidad.Text = String.Empty;
            }
        }
    }
}
