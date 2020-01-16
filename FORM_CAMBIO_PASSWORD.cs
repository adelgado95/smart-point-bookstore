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
    public partial class FORM_CAMBIO_PASSWORD : Form
    {
        public FORM_CAMBIO_PASSWORD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( tb_pass1.Text.Length == 0 || tb_pass2.Text.Length == 0)
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            if (tb_pass1.Text != tb_pass2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                tb_pass1.Text = string.Empty;
                tb_pass2.Text = string.Empty;
                return;

            }
            int n = Datos.EjecutarOrden("update usuarios set pass = '"+tb_pass1.Text+"' where id = '"+ globales.id+"';");

            if (n != -1)
            {
                MessageBox.Show("Contraseña actualizada");
           
                tb_pass1.Text = string.Empty;
                tb_pass2.Text = string.Empty;
                this.Dispose();
            }
        }
    }
}
