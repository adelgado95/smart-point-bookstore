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
    public partial class FCONTENEDORDETALLE : Form
    {
        String fecha_f;
        public FCONTENEDORDETALLE(String f)
        {
            InitializeComponent();
            this.fecha_f = f;
        }

        private void FCONTENEDORDETALLE_Load(object sender, EventArgs e)
        {
            Datos.EstablecerConexion();
            string dtotal = Datos.EjecutarOrdenSelect("select sum(total) from (select p.nombre,p.caracteristica,CAST(f.fecha_hora as DATE) as fecha,precio,cantidad,d.total from detalle_factura as d , productos as p,factura as f where d.producto=p.id_producto and f.codigo=d.codigo_factura) as tab where CAST(tab.fecha as DATE)=CAST('"+fecha_f+"' as DATE);").Rows[0][0].ToString();
           // MessageBox.Show(dtotal);

             // TODO: esta línea de código carga datos en la tabla 'Conjunto1.DataTable5' Puede moverla o quitarla según sea necesario.
            this.DataTable5TableAdapter.Fill(this.Conjunto1.DataTable5);
            try
            {
                ReportParameter p = new ReportParameter("ReportFecha", this.fecha_f);
                ReportParameter p2 = new ReportParameter("ParTotal", dtotal);
                this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p,p2 });
            }
            catch (LocalProcessingException re)
            {
                MessageBox.Show(re.Message.ToString());
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
