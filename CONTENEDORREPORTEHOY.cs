using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace LibreriaParraJr
{
    public partial class CONTENEDORREPORTEHOY : Form
    {
       public  String fechan, fechat;
        public CONTENEDORREPORTEHOY()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CONTENEDORREPORTEHOY_Load(object sender, EventArgs e)
        {
            Datos.EstablecerConexion();
            string total = Datos.EjecutarOrdenSelect("SELECT sum(total) FROM `factura` WHERE CAST(fecha_hora as date) = CAST('"+fechat+"' as DATE)").Rows[0][0].ToString();
            // TODO: esta línea de código carga datos en la tabla 'Conjunto1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.Conjunto1.DataTable1);
            try
            {
                ReportParameter p = new ReportParameter("ParFecha", fechan + " 0:00:00");
                ReportParameter p2 = new ReportParameter("ParFecha2", fechan + " 23:59:59");
                ReportParameter p3 = new ReportParameter("ParTotal", total);

                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p, p2, p3 });
            }
            catch (LocalProcessingException re)
            {
                MessageBox.Show(re.Message.ToString());
            }
            

            this.reportViewer1.RefreshReport();
        }
    }
}
