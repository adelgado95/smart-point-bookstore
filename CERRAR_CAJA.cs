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
    public partial class CERRAR_CAJA : Form
    {
        float ventas;
        float pagos;
        float gastos;
        float total;
        DataTable cajas;
        bool cerrado = false;
        
        public CERRAR_CAJA()
        {
            InitializeComponent();

            DataTable d = Datos.EjecutarOrdenSelect("SELECT sum(`cantidad`) FROM `gastos` WHERE `fecha` = CURDATE()");

            if (d.Rows[0][0].ToString().Length > 0)
            {
                lblGastos.Text = d.Rows[0][0].ToString();
            }
            d = Datos.EjecutarOrdenSelect("SELECT sum(`total`) FROM `factura` WHERE DATE(`fecha_hora`) = CURDATE()");
            if (d.Rows[0][0].ToString().Length > 0) lblVentas.Text = d.Rows[0][0].ToString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
            d = Datos.EjecutarOrdenSelect("SELECT sum(`cantidad`) FROM `pagos_trabajadores` WHERE `fecha` = CURRENT_DATE()");
            if (d.Rows[0][0].ToString().Length > 0) lblPagos.Text = d.Rows[0][0].ToString();
            ventas = float.Parse(lblVentas.Text);
            gastos = float.Parse(lblGastos.Text);
            pagos = float.Parse(lblPagos.Text);

            total = (pagos + gastos) - ventas;
            //if(total < 1 )
            total = total * -1;
            label8.Text = total.ToString();

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            FORM_CANTIDA_CAJA caja = new FORM_CANTIDA_CAJA();
            caja.Location = new Point(110, 50);
            int usuario = globales.id;
            caja.ShowDialog();
            if(cerrado == false)
            {
                try
                {
                    string consulta = "INSERT INTO `libreria_parra`.`caja` (`gastos`, `ventas`, `pagos`, `total`,`usuario`) VALUES (" + gastos+","+ventas+", "+pagos+", "+total+ ","+usuario+"); ";
                    resultado = Datos.EjecutarOrden(consulta);                    
                }
                catch
                {


                }
                if (resultado > 0)
                {
                    LibPrintTicket.Ticket ticket = new LibPrintTicket.Ticket();

                    //ticket.HeaderImage = Cursors.Arrow.Handle;//Por ejemplo
                    ticket.AddHeaderLine("Libreria Parra Junior");
                    ticket.AddHeaderLine("SUCURSAL: Paseo Real");
                    ticket.AddHeaderLine("Tel. 89416603");
                    ticket.AddHeaderLine("RUC: 2812005930008R");

                    ticket.AddSubHeaderLine("CIERRE DE CAJA");
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

                    ticket.AddItem("", "Pagos", pagos.ToString());
                    ticket.AddItem("", "Gastos", gastos.ToString());
                    ticket.AddItem("", "Ventas", ventas.ToString());

                    ticket.AddTotal("CIERRE TOTAL", (ventas - gastos - pagos).ToString());
                    ticket.AddTotal("", "");

                    ticket.AddFooterLine("!NUNCA TE RINDAS!");
                    ticket.PrintTicket("POS-80C");



                   //aqui sigue el codigo para mariconas
                    MessageBox.Show("Cierre de caja completado");
                    btnAceptar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Cierre de caja cancelado");
                return;
            }
        }

        private void CERRAR_CAJA_Load(object sender, EventArgs e)
        {

            if (globales.tipo_usuario != "CAJERO")
            {
                pb_operaciones_caja.Visible = true;
            }
            try
            {
                string consulta = "SELECT * FROM caja;";
                cajas = Datos.EjecutarOrdenSelect(consulta);
            }
            catch
            {


            }

            for (int i = 0; i < cajas.Rows.Count; i++)
            {
                if (DateTime.Parse(cajas.Rows[i][5].ToString()).ToShortDateString() == DateTime.Now.ToShortDateString() && cajas.Rows[i][6].ToString().Equals("CERRADO"))
                {
                    MessageBox.Show("La caja ya se ha cerrado por hoy");
                    btnAceptar.Enabled = false;
                    cerrado = true;
                    return;
                }
            }
            btnAceptar.Enabled = true;
            cerrado = false;
        }

        private void pb_imprimir_reporte_Click(object sender, EventArgs e)
        {
            LibPrintTicket.Ticket ticket = new LibPrintTicket.Ticket();

            //ticket.HeaderImage = Cursors.Arrow.Handle;//Por ejemplo
            ticket.AddHeaderLine("Libreria Parra Junior");
            ticket.AddHeaderLine("SUCURSAL: Paseo Real");
            ticket.AddHeaderLine("Tel. 89416603");
            ticket.AddHeaderLine("RUC: 2812005930008R");

            ticket.AddSubHeaderLine("REPORTE");
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            ticket.AddItem("", "Pagos", pagos.ToString());
            ticket.AddItem("", "Gastos", gastos.ToString());
            ticket.AddItem("", "Ventas", ventas.ToString());

            ticket.AddTotal("TOTAL", (ventas - gastos - pagos).ToString());
            ticket.AddTotal("", "");

            ticket.AddFooterLine("!NUNCA TE RINDAS!");
            ticket.PrintTicket("POS-80C");

        }

        private void pb_cambiar_cajero_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int usuario = globales.id;
            
            if (cerrado == false)
            {
                try
                {
                    string consulta = "INSERT INTO `libreria_parra`.`caja` (`gastos`, `ventas`, `pagos`, `total`, `Estado`, `usuario`) VALUES (" + gastos + "," + ventas + ", " + pagos + ", " + total + ",'ABIERTO'," + usuario + "); ";
                    resultado = Datos.EjecutarOrden(consulta);
                }
                catch
                {


                }
                if (resultado > 0)
                {
                    LibPrintTicket.Ticket ticket = new LibPrintTicket.Ticket();

                    //ticket.HeaderImage = Cursors.Arrow.Handle;//Por ejemplo
                    ticket.AddHeaderLine("Libreria Parra Junior");
                    ticket.AddHeaderLine("SUCURSAL: Paseo Real");
                    ticket.AddHeaderLine("Tel. 89416603");
                    ticket.AddHeaderLine("RUC: 2812005930008R");

                    ticket.AddSubHeaderLine("CIERRE TEMPORAL DE : " + globales.usuario);
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

                    ticket.AddItem("", "Pagos", pagos.ToString());
                    ticket.AddItem("", "Gastos", gastos.ToString());
                    ticket.AddItem("", "Ventas", ventas.ToString());

                    ticket.AddTotal("TOTAL", (ventas - gastos - pagos).ToString());
                    ticket.AddTotal("", "");

                    ticket.AddFooterLine("!NUNCA TE RINDAS!");
                    ticket.PrintTicket("POS-80C");



                    //aqui sigue el codigo para mariconas
                    MessageBox.Show("Cierre completado");
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Cierre temporal cancelado");
                return;
            }
        }

        private void pb_operaciones_caja_Click(object sender, EventArgs e)
        {
            if (controlReporteCaja1.Visible)
            {
                controlReporteCaja1.Visible = false;
            }
            else
            {
                controlReporteCaja1.ControlReporteCaja_Load(sender,e);
                controlReporteCaja1.Visible = true;
            }
        }
    }
}
