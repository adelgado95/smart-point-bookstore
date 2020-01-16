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
    public partial class FORMREPORTES : Form
    {
        public List<String> ultimo_dia = new List<string>();
        public FORMREPORTES()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rb_ventas_hoy.Checked)
            {
                if (chb_detallado.Checked==false)
                {
                    CONTENEDORREPORTEHOY d = new CONTENEDORREPORTEHOY();
                    d.fechat = dtp_fecha.Value.ToString("yyyy-MM-dd");
                    d.fechan = dtp_fecha.Value.ToString("dd/MM/yyyy");
                    string fechar = dtp_fecha.Value.ToString("yyyy-MM-dd");
                    if (Datos.EjecutarOrdenSelect("select * from factura where CAST(fecha_hora as DATE)='" + fechar + "';").Rows.Count > 0)
                        d.ShowDialog();
                    else
                        MessageBox.Show("Lo siento no hay ningun registro");
                }
                else {
                    String fechaamd = dtp_fecha.Value.ToString("yyyy-MM-dd");
                    if (Datos.EjecutarOrdenSelect("select sum(total) from (select p.nombre,p.caracteristica,CAST(f.fecha_hora as DATE) as fecha,precio,cantidad,d.total from detalle_factura as d , productos as p,factura as f where d.producto=p.id_producto and f.codigo=d.codigo_factura) as tab where CAST(tab.fecha as DATE)=CAST('"+fechaamd+"' as DATE)").Rows.Count > 0)
                    { 
                    FCONTENEDORDETALLE f = new FCONTENEDORDETALLE(fechaamd);
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos no hay ningun registro");
                    }
                }

               
            }
            if (rb_todos_productos.Checked)
            {
                CONTENEDORREPORTETODOS f = new CONTENEDORREPORTETODOS();
                f.ShowDialog();
            }
            if (rb_productos_mas_vendidos.Checked)
            {
                FCONTENEDORMASVENDIDOS f = new FCONTENEDORMASVENDIDOS();
                f.ShowDialog();
            }
            if (rb_ventas_mes.Checked)
            {
                String cadena = (cb_mes.SelectedIndex + 1).ToString();
                FCONTENEDOREPORTEMES f = new FCONTENEDOREPORTEMES(cadena,cb_mes.Text);
                f.ShowDialog();
            }

        }
        public int ObtenerMes()
        {
            int mes = cb_mes.SelectedIndex + 1;
            return mes;
        }

        private void FORMREPORTES_Load(object sender, EventArgs e)
        {
            Datos.EstablecerConexion();
            LlenarCombobox();
            cb_mes.SelectedIndex = DateTime.Now.Month-1;
            
        }
        public void LlenarCombobox()
        {
            cb_mes.Items.Add("Enero");
            cb_mes.Items.Add("Febrero");
            cb_mes.Items.Add("Marzo");
            cb_mes.Items.Add("Abril");
            cb_mes.Items.Add("Mayo");
            cb_mes.Items.Add("Junio");
            cb_mes.Items.Add("Julio");
            cb_mes.Items.Add("Agosto");
            cb_mes.Items.Add("Septiembre");
            cb_mes.Items.Add("Octubre");
            cb_mes.Items.Add("Noviembre");
            cb_mes.Items.Add("Diciembre");
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_ventas_mes_CheckedChanged(object sender, EventArgs e)
        {
            cb_mes.SelectedIndex = DateTime.Now.Month-1;
        }
    }
}
