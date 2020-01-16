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
    public partial class FORM_CANTIDA_CAJA : Form
    {
        public FORM_CANTIDA_CAJA()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(float.Parse(txtMonto.Text) < 850 )
            {
                MessageBox.Show("No se puede dejar menos de C$ 850 en caja ");
                return;
            }
            if(txtMonto.TextLength <= 0)
            {
                MessageBox.Show("Escriba una cantidad");
            }

            Properties.Settings.Default.caja = float.Parse(txtMonto.Text);
            Properties.Settings.Default.caja_estado = false;
            Properties.Settings.Default.Save();
            this.Dispose();
            
        }

        private void FORM_CANTIDA_CAJA_Load(object sender, EventArgs e)
        {
            txtMonto.Text = Properties.Settings.Default.caja.ToString();
        }
    }
}
