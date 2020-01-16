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
    public partial class SELECTORCLIENTE : Form
    {
        public string ruc, nomcliente;
        public Boolean cliente_seleccionado = false; 
        public SELECTORCLIENTE()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente_seleccionado = true;
            ruc = dgv_clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            nomcliente = dgv_clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show("ruc:"+ruc+"  Cliente:"+nomcliente);
            bt_aceptar.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SELECTORCLIENTE_Load(object sender, EventArgs e)
        {
            Datos.EstablecerConexion();
            dgv_clientes.DataSource = Datos.EjecutarOrdenSelect("select * from cliente;");
            ruc = "";
            nomcliente = "";
        }
    }
}
