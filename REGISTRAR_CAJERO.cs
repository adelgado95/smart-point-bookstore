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
    public partial class REGISTRAR_CAJERO : Form
    {
        public REGISTRAR_CAJERO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_nombre_cajero.Text.Length == 0 || tb_pass1.Text.Length == 0 || tb_pass2.Text.Length == 0)
            {
                MessageBox.Show("Rellene todos los campos");
                return;
            }
            if(tb_pass1.Text != tb_pass2.Text )
            {
                MessageBox.Show("Las contraseñas no coinciden");
                tb_pass1.Text = string.Empty;
                tb_pass2.Text = string.Empty;
                return;
               
            }
           int n =  Datos.EjecutarOrden("INSERT INTO `usuarios` (`usuario`, `pass`, `tipo_usuario`) VALUES('"+tb_nombre_cajero.Text+"', '"+tb_pass1.Text+"', '1');");

           if(n != -1)
            {
                MessageBox.Show("Usuario Registrado");
                tb_nombre_cajero.Text = string.Empty;
                tb_pass1.Text = string.Empty;
                tb_pass2.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
