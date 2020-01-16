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
    public partial class FORMVERPAGOS : Form
    {
        DataTable codigo_credito;
        DataTable credito;
        int index;
        float monto_debido = 0; // variable para validar en el form_abonar que no pague mas de lo que debe
        public FORMVERPAGOS(DataTable c, DataTable c2,int i)
        {
            InitializeComponent();
            codigo_credito = c;
            credito = c2;
            index = i;
        }

        private void FORMVERPAGOS_Load(object sender, EventArgs e)
        {

            verpagos();
        }

        private void verpagos()
        {
            DataTable pagos = null;
            pagos = Datos.EjecutarOrdenSelect("select fecha,hora,monto from pagos,credito where codigo_credito = " + codigo_credito.Rows[index][0].ToString() + " and credito.codigo=codigo_credito;");
            dgv_pagos.DataSource = pagos;
            float suma = 0;
            for (int i = 0; i < pagos.Rows.Count; i++)
            {
                suma += float.Parse(pagos.Rows[i][2].ToString());
            }
            label2.Text = "Monto pagado: " + suma;
            float total = float.Parse(credito.Rows[index][2].ToString());
            total = total - suma;
            if (total < 0)
                total = 0;
            label3.Text = "Monto debido: " + total;
            monto_debido = total;

            if (monto_debido == 0)
            {
                int salida0 = Datos.EjecutarOrden("UPDATE credito set estado='PAGADO' where codigo='" + codigo_credito.Rows[index][0].ToString() + "';");
            }

            if (total == 0)
                bt_abonar.Enabled = false;

        }

        private void abonar_Click(object sender, EventArgs e)
        {
            new FORMABONAR(codigo_credito.Rows[index][0].ToString(),monto_debido).ShowDialog();
            verpagos();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
