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
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Datos.EstablecerConexion();
        }
        public bool ValidarVacios()
        {
            if (tb_usuario.TextLength == 0 || tb_clave.TextLength == 0)
            {
                MessageBox.Show("Por favor llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool ValidarUsuario()
        {
            DataTable tabla = Datos.EjecutarOrdenSelect("select * from Usuarios;");
            bool a = false, b = false;

            int id = 0;
            string usuario = string.Empty;
            string tipo = string.Empty;

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tb_usuario.Text.ToString() == tabla.Rows[i][1].ToString())
                {
                    id = int.Parse(tabla.Rows[i][0].ToString());
                    usuario = tabla.Rows[i][1].ToString();
                    tipo = tabla.Rows[i][3].ToString(); //aqui se extrae el faking tipo de usuario
                    a = true;
                }
                if (tb_clave.Text.ToString() == tabla.Rows[i][2].ToString())
                {
                    b = true;
                }
                if (a == true && b == true)
                {
                    break;
                }
            }
            if (a != true || b != true)
            {
                MessageBox.Show("Datos Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                globales.usuario = usuario; //aqui se guardan las faking variables
                globales.id = id;
                globales.tipo_usuario = tipo;
                return true;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarVacios())
                return;
            if (!ValidarUsuario())
                return;
            tb_usuario.Text = String.Empty;
            tb_clave.Text = String.Empty;
            tb_usuario.Focus();
            MenuPrincipal f = new MenuPrincipal();
            this.Hide();
            f.ShowDialog();
            try
            {
                this.Show();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }



    public static class globales //Variables globales
    {
        public static MySqlConnection Conexion_Alm;
        public static string usuario = string.Empty;
        public static int id = 0;
        public static string tipo_usuario = string.Empty;

    }


}
