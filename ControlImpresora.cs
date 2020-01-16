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
    public partial class ControlImpresora : UserControl
    {
        List<List<string>> servicios, totales;
        public ControlImpresora()
        {
            InitializeComponent();
        }

        private void totales_globales()
        {
            try
            {
                string consulta = "select (select sum(total) from detalle_servicio WHERE servicio=1) as impresora, (select sum(total) from detalle_servicio WHERE servicio=2) as internet, (select sum(total) from detalle_servicio WHERE servicio=3) as mantenimiento; ";
                MySqlCommand comando_total = new MySqlCommand();
                comando_total.CommandText = consulta;
                totales = conexion.ejecutar_consulta(comando_total);

                lb_total_impresora.Text = totales[0][0];
                lb_total_internet.Text = totales[0][1];
                lb_total_mantenimiento.Text = totales[0][2];
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        public void actualizar_servicios()
        {
            try
            {
                string consulta = "select iddetalle_servicio, idServicio, NombreServicio, fecha, total from servicio, detalle_servicio where servicio.idServicio=detalle_servicio.Servicio and cast(current_timestamp() as date) = cast(fecha as date); ";
                MySqlCommand comando_servicio = new MySqlCommand();
                comando_servicio.CommandText = consulta;
                servicios = conexion.ejecutar_consulta(comando_servicio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }

        private void bt_ingresar_servicio_Click(object sender, EventArgs e)
        {
            int valor_radio = 1;
            if (rbImpresora.Checked)
            {
                valor_radio = 1;
            }
            else if (rbInternet.Checked)
            {
                valor_radio = 2;
            }
            else if (rbMantenimiento.Checked)
            {
                valor_radio = 3;
            }
            if (comprobar_update(valor_radio))
            {
                try
                {
                    string consulta = "UPDATE `libreria_parra`.`detalle_servicio` SET total = total + ?valor where servicio = ?servicio and cast(fecha as date) = cast(current_timestamp() as date);";
                    MySqlCommand comando_servicio = new MySqlCommand();
                    comando_servicio.Parameters.Add("servicio", MySqlDbType.Int32).Value = valor_radio;
                    comando_servicio.Parameters.Add("valor", MySqlDbType.Int32).Value = Convert.ToInt32(tb_valor_servicio.Text);
                    comando_servicio.CommandText = consulta;
                    conexion.ejecutar_comando(comando_servicio);
                    tb_valor_servicio.Clear();
                    actualizar_servicios();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
            }
            else
            {
                try
                {
                    string consulta = "INSERT INTO `libreria_parra`.`detalle_servicio` (`Servicio`, `fecha`, `total`) VALUES (?servicio, ?fecha, ?total);";
                    MySqlCommand comando_servicio = new MySqlCommand();
                    comando_servicio.Parameters.Add("servicio", MySqlDbType.Int32).Value = valor_radio;
                    comando_servicio.Parameters.Add("fecha", MySqlDbType.Timestamp).Value = DateTime.Now;
                    comando_servicio.Parameters.Add("total", MySqlDbType.Double).Value = Convert.ToDouble(tb_valor_servicio.Text);
                    comando_servicio.CommandText = consulta;
                    conexion.ejecutar_comando(comando_servicio);
                    tb_valor_servicio.Clear();
                    actualizar_servicios();
                    totales_globales();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
            }
        }

        private bool comprobar_update(int valor)
        {
            for (int i = 0; i < servicios.Count; i++)
            {
                if (DateTime.Parse(servicios[i][3].ToString()).ToShortDateString() == DateTime.Now.ToShortDateString() && servicios[i][1].ToString() == valor.ToString())
                {
                    return true;                                                                       
                }
            }
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            totales_globales();
            if (this.Width == 300)
            {
                actualizar_total_servicio();
                this.Width = 600;
                pb_reporte_impresora.Image = Properties.Resources.arrow_right;
            } else
            {
                this.Width = 300;
                pb_reporte_impresora.Image = Properties.Resources.arrow_left;
            }
        }

        private void pb_printer_Click(object sender, EventArgs e)
        {
            LibPrintTicket.Ticket ticket = new LibPrintTicket.Ticket();

            ticket.HeaderImage = pb_printer.Image;//Por ejemplo
            ticket.AddHeaderLine("Libreria Parra Junior");
            ticket.AddHeaderLine("EXPEDIDO EN:");
            ticket.AddHeaderLine("Paseo Real");
            ticket.AddHeaderLine("Tel. 89416603");
            ticket.AddHeaderLine("RUC: 2812005930008R");

            ticket.AddSubHeaderLine("Ticket # 1");
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            ticket.AddItem("1", "Impresora", totales[0][0]);
            ticket.AddItem("1", "Internet", totales[0][1]);
            ticket.AddItem("1", "Mantenimiento", totales[0][2]);

            ticket.AddTotal("SUBTOTAL", "12.00");
            ticket.AddTotal("IVA", "0");
            ticket.AddTotal("TOTAL", "24");
            ticket.AddTotal("", "");
            ticket.AddTotal("RECIBIDO", "0");
            ticket.AddTotal("CAMBIO", "0");
            ticket.AddTotal("", "");

            ticket.AddFooterLine("VUELVA PRONTO");
            ticket.PrintTicket("POS-80C");
        }

        private void actualizar_total_servicio()
        {
            for (int i = 0; i < servicios.Count; i++)
            {
                if (servicios[i][1].ToString().Equals("1"))
                {
                    lb_valor_impresora.Text = servicios[i][4];
                }
                else if(servicios[i][1].ToString().Equals("2")) 
                {
                    lb_valor_internet.Text = servicios[i][4];
                }
                else if(servicios[i][1].ToString().Equals("3"))
                {
                    lb_valor_mantenimiento.Text = servicios[i][4];
                }
            }
        }
    }
}
