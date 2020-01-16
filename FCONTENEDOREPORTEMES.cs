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
    public partial class FCONTENEDOREPORTEMES : Form
    {
        String mes, anyo=DateTime.Now.Year.ToString(),mesletra;
        public FCONTENEDOREPORTEMES(string pmes,string pmeslet)
        {
            InitializeComponent();
            mes = pmes;
            mesletra = pmeslet; 
        }

        private void FCONTENEDOREPORTEMES_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'Conjunto1.DataTable3' Puede moverla o quitarla según sea necesario.
            Datos.EstablecerConexion();
            string total = Datos.EjecutarOrdenSelect("select sum(total) from caja where month(fecha) = "+mes+" and year(fecha)=year(current_date()) and Estado='CERRADO';").Rows[0][0].ToString();
            if (total.ToString().Equals(""))
            {
                MessageBox.Show("SIN VENTAS");
                return;
            }
            // TODO: esta línea de código carga datos en la tabla 'Conjunto1.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable3TableAdapter.Fill(this.Conjunto1.DataTable3);
            try
            {
                ReportParameter p = new ReportParameter("Mes", mes);
                ReportParameter p2 = new ReportParameter("Anyo",anyo);
                ReportParameter p3 = new ReportParameter("Titulo","Reporte del Mes de "+ mesletra);
                ReportParameter p4 = new ReportParameter("Total", total);


                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p, p2, p3, p4 });
            }
            catch (LocalProcessingException re)
            {
                MessageBox.Show(re.Message.ToString());
            }


            this.reportViewer1.RefreshReport();
        }
    }
}
