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
    public partial class LISTADOMARCAS : Form
    {
        public LISTADOMARCAS()
        {
            InitializeComponent();
        }

        private void LISTADOMARCAS_Load(object sender, EventArgs e)
        {

        }

        private void recargar()
        {
            DataTable datos = Datos.EjecutarOrdenSelect("select nombre from marca");



            dgv_marcas.DataSource = datos;

            if (dgv_marcas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnRecarga_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void buscar_Click(object sender, EventArgs e)
        {

            if (tb_Buscar.TextLength == 0)
                return;

            DataTable datos = Datos.EjecutarOrdenSelect("select nombre from marca where nombre like '%"+tb_Buscar.Text+"%'");



            dgv_marcas.DataSource = datos;

            if (dgv_marcas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }
    }
}
