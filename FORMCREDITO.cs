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
    public partial class FORMCREDITO : Form
    {
        DataTable codigo_credito=null;
        DataTable credito = null;
        public FORMCREDITO()
        {
            InitializeComponent();
        }

        private void FORMCREDITO_Load(object sender, EventArgs e)
        {
            DataTable empresas = null;

            empresas = Datos.EjecutarOrdenSelect("select ruc, nombre from proveedor;");

            for(int i=0; i< empresas.Rows.Count; i++)
            {
                cb_proveedor.Items.Add(empresas.Rows[i][1].ToString());
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {

            string orden_text = string.Empty;
            string orden2_text = string.Empty;
            for (int i = 0; i < orden.Controls.Count; i++)
            {
                if (orden.Controls[i] is RadioButton)
                {
                    RadioButton r = (RadioButton)orden.Controls[i];
                    if (r.Checked == true)
                    {
                        orden_text = r.Name;
                    }
                }
            }
            for (int i = 0; i < orden2.Controls.Count; i++)
            {
                if (orden2.Controls[i] is RadioButton)
                {
                    RadioButton r = (RadioButton)orden2.Controls[i];
                    if (r.Checked == true)
                    {
                        orden2_text = r.Name;
                    }
                }
            }

            if (cb_proveedor.Text.Length == 0)
            {
                credito = Datos.EjecutarOrdenSelect("select fecha_final as Fecha_Final, nombre as Proveedor, total as Total, " +
                " estado as Estado from credito,proveedor where credito.proveedor = proveedor.ruc " +
                " order by " + orden_text + " " + orden2_text + ";");
                dgv_creditos.DataSource = credito;



                codigo_credito = Datos.EjecutarOrdenSelect("select credito.codigo from credito, proveedor where credito.proveedor = proveedor.ruc " +
                    " order by " + orden_text + " " + orden2_text + ";");

                if (credito.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros");
                    dgv_creditos.DataSource = null;
                }

                return;

            }

   

          
            credito = Datos.EjecutarOrdenSelect("select fecha_final as Fecha_Final, nombre as Proveedor, total as Total, " +
                " estado as Estado from credito,proveedor where credito.proveedor = proveedor.ruc and nombre = '"+ cb_proveedor.SelectedItem.ToString() + "'"+
                " order by "+ orden_text +" "+orden2_text+";");
            dgv_creditos.DataSource = credito;
            


            codigo_credito = Datos.EjecutarOrdenSelect("select credito.codigo from credito, proveedor where credito.proveedor = proveedor.ruc and nombre = '" + cb_proveedor.SelectedItem.ToString() + "'" +
                " order by " + orden_text + " " + orden2_text + ";");

            if (credito.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros");
                dgv_creditos.DataSource = null;
            }
        }

        private void combo_empresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(btn_ver.Enabled != true)
                btn_ver.Enabled = true;
        }

        private void btn_ver_pagos_Click(object sender, EventArgs e)
        {
            new FORMVERPAGOS(codigo_credito,credito,dgv_creditos.CurrentRow.Index).ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ver_pagos.Enabled = true;
        }
    }
}
