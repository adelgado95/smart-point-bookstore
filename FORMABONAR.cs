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
    public partial class FORMABONAR : Form
    {
        string codigo_credito = String.Empty;
        float monto_debido = 0;
        public FORMABONAR(string c, float m)
        {
            InitializeComponent();
            monto_debido = m;
            codigo_credito = c;
        }

        private void minutos_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            float monto_num;
            try
            {
                monto_num = float.Parse(tb_monto.Text);
                if(monto_debido < monto_num)
                {
                    MessageBox.Show("Usted va a pagar mas de lo que debe...");
                    return;
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Asegurese de que la cantidad solo sean números : " + ex.Message);
            }
            
            int salida = Datos.EjecutarOrden("insert into pagos values (null,'" +dtp_fecha.Text+ "',"
                 + "'" +cb_horas.Text +":"+cb_minutos.Text + "', "
                 + "" + tb_monto.Text + ", "
                 + "" + codigo_credito + ""
                 + " );");

            if (salida == -1)
            {
                MessageBox.Show("Asegurese de que todos los datos esten correctos");
                return;
            }
            else
            {
                MessageBox.Show("Datos agregados");
                this.Dispose();
                
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
