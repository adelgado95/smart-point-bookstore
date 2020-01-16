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
    public partial class REGISTRAR_GASTOS : Form
    {
        public REGISTRAR_GASTOS()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
           if(txtCantidad.TextLength < 0 || txtDescripcion.TextLength < 0)
            {
                MessageBox.Show("Ingrese todos los datos");
                return;
            }

            String fecha = DateTime.Now.ToString("yyyy-MM-dd");
           
            int n = Datos.EjecutarOrden("INSERT INTO `gastos` (`id`, `cantidad`, `descripción`, `fecha`) VALUES (NULL, '"+txtCantidad.Text+"', '"+txtDescripcion.Text+"', '"+fecha+"');");

            if (n != -1)
            {
                MessageBox.Show("Gasto Registrado");
                txtCantidad.Clear();
                txtDescripcion.Clear();
            }
           

            }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
