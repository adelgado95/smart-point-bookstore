using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibreriaParraJr
{
    public partial class ControlReporteCaja : UserControl
    {
        DataTable reporte_caja;
        public ControlReporteCaja()
        {
            InitializeComponent();
        }

        public void ControlReporteCaja_Load(object sender, EventArgs e)
        {
            try
            {
                dg_reporte_caja.Rows.Clear();
                reporte_caja = new DataTable();
                string consulta = "select u.usuario, total from usuarios as u, caja as c where u.id=c.usuario and CAST(fecha as date)=CAST(current_date() as date);";
                MySqlCommand comando_caja = new MySqlCommand();
                comando_caja.CommandText = consulta;
                reporte_caja = conexion.EjecutarOrdenSelect(comando_caja);
                float suma = 0;
                for (int i = 0; i < reporte_caja.Rows.Count; i++)
                {
                    dg_reporte_caja.Rows.Add(reporte_caja.Rows[i][0].ToString(),(float.Parse(reporte_caja.Rows[i][1].ToString())-suma).ToString());
                    suma = float.Parse(reporte_caja.Rows[i][1].ToString());
                }
                lb_total.Text = suma.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
