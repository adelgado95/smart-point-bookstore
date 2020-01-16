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
    public partial class FORM_VER_CAJA : Form
    {
        public FORM_VER_CAJA()
        {
            InitializeComponent();
        }

        private void FORM_VER_CAJA_Load(object sender, EventArgs e)
        {

            lblMonto.Text = Properties.Settings.Default.caja.ToString();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(txtMonto.TextLength ==0) { MessageBox.Show("Escriba una cantidad"); return; }
            try { 
            Properties.Settings.Default.caja = float.Parse(lblMonto.Text) + float.Parse(txtMonto.Text);
            }
            catch (Exception )
            {
                MessageBox.Show("Solo se admiten cantidades en numeros");
                return;
            }
            MessageBox.Show("Cantidad agregada");
            this.Dispose();
        }
    }
}
