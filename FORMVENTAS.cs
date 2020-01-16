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
    public partial class form_ventas : Form
    {
        decimal efectivo;
        string edtprecio, edtcantidad;
        string univcliente, univruc;
        List<String> ruc = new List<string>();
        List<String> nclientes = new List<string>();
        String codigo, nombre, caracteristica, precio, stock, presentacion,marca;
        int indexeliminar = -1;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable productos = null;
            if (tb_codigo_producto.TextLength == 0)
            {
                tb_descripcion.Text = "";
                tb_cantidad.Text = "1";
                tb_precio.Text = "";
                this.codigo = "";
                this.nombre = "";
                this.caracteristica = "";
                this.precio = "";
                this.stock = "";
                this.presentacion = "";
                return;
            }
            if (tb_codigo_producto.TextLength > 0)
            {
              productos = Datos.EjecutarOrdenSelect("select dp.codigo_barras,p.nombre,caracteristica,precio,stock_individual,presentacion, m.nombre as marca from detalle_producto as dp, productos as p , marca as m where dp.id_producto = p.id_producto and p.marca = m.codigo and dp.codigo_barras = '" + tb_codigo_producto.Text + "';");
            }
            if (productos.Rows.Count > 0)
            {
                
                this.codigo = productos.Rows[0][0].ToString();
                this.nombre = productos.Rows[0][1].ToString();
                this.caracteristica = productos.Rows[0][2].ToString();
                this.precio = productos.Rows[0][3].ToString();
                this.stock = productos.Rows[0][4].ToString();
                if (Int32.Parse(this.stock) == 0)
                {
                    bt_agregar.Enabled = false;
                    tb_cantidad.Text = "0";
                }
                    this.presentacion = productos.Rows[0][5].ToString();
                this.marca = productos.Rows[0][6].ToString();
                tb_codigo_producto.Text = this.codigo;
                tb_descripcion.Text = this.nombre;
                tb_precio.Text = this.precio;
                bt_agregar.Enabled = true;
                btn_pedido.Enabled = true;
                //bt_agregar.PerformClick();
                CalcularTotal();
            }
            else {
                //DialogResult resultado = MessageBox.Show("NO SE ENCONTRO EL PRODUCTO. ¿DESEA AGREGARLO?","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                //if (resultado == DialogResult.Yes)
                //{
                //    this.button2_Click(sender,e);
                //}
                tb_descripcion.Text = "";
                tb_cantidad.Text = "1";
                tb_precio.Text = "";
                this.codigo = "";
                this.nombre = "";
                this.caracteristica = "";
                this.precio = "";
                this.stock = "";
                this.presentacion = "";
            }

            }
        public void CalcularTotal()
        {
            
            float total = 0;
            if (dgv_ventas.Rows.Count > 0)
            {
                for (int i = 0; i < dgv_ventas.Rows.Count; i++)
                {
                    float descuento = 0;
                    total += (float.Parse(dgv_ventas.Rows[i].Cells[3].Value.ToString())* float.Parse(dgv_ventas.Rows[i].Cells[4].Value.ToString()))-descuento;
                }

            }
            tb_subtotal.Text = total.ToString();
            tb_total.Text = Convert.ToInt32(total).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FSELECTORPRODUCTO f = new FSELECTORPRODUCTO();
            f.ShowDialog();
            this.codigo = f.codigo;
            tb_codigo_producto.Text = this.codigo;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(dgv_ventas.Rows.Count < 1)
            {
                return;
            } 
            indexeliminar = int.Parse(e.RowIndex.ToString());
            bt_buscar_producto.Enabled = true;
            edtprecio = dgv_ventas.Rows[e.RowIndex].Cells[3].Value.ToString();
            edtcantidad = dgv_ventas.Rows[e.RowIndex].Cells[4].Value.ToString();
            bt_eliminar.Enabled = true;
            bt_editar.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (indexeliminar == -1)
            {
                dgv_ventas.Rows.RemoveAt(dgv_ventas.Rows.Count - 1);
            }
            else
            {
                dgv_ventas.Rows.RemoveAt(indexeliminar);
                indexeliminar = -1;    
            }
            if (dgv_ventas.Rows.Count == 0)
            {
                bt_eliminar.Enabled = false;
                bt_editar.Enabled = false;
            }
            CalcularTotal();
            if (dgv_ventas.RowCount < 1)
            {
                bt_facturar.Enabled = false;
            }
            tb_codigo_producto.Focus();
            if (dgv_ventas.RowCount < 1)
            {
                chb_descuento.Checked = false;
                nud_descuento.Value = 0;
                chb_descuento.Visible = false;
                nud_descuento.Visible = false;
                lb_porc.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            descripcion_pago.Text = "";
            //comboBox2.Items.AddRange(new String []  {"CONTADO","TARJETA","PAYPHONE","CHEQUE","CREDITO"});
            if (cb_tipo_pago.SelectedIndex == 0)
            {
                label1.Text = "CONTADO";
                descripcion_pago.Text = "CONTADO";
            }
            if (cb_tipo_pago.SelectedIndex == 1)
            {
                
                label1.Text = "TRANS. NO.";
                descripcion_pago.Enabled = true;
                descripcion_pago.Focus();
            }
            if (cb_tipo_pago.SelectedIndex == 2)
            {
                label1.Text = "TRANS. NO.";
                descripcion_pago.Enabled = true;
                descripcion_pago.Focus();
            }
            if (cb_tipo_pago.SelectedIndex == 3)
            {
                label1.Text = "CHEQUE NO.";
                descripcion_pago.Enabled = true;
                descripcion_pago.Focus();
            }
            if (cb_tipo_pago.SelectedIndex == 4)
            {
                if (tb_cliente.Text == "CONTADO")
                {
                    MessageBox.Show("POR FAVOR SELECCIONA UN CLIENTE DIFERENTE DE CONTADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cb_tipo_pago.SelectedIndex = cb_tipo_pago.FindStringExact("CONTADO");
                    return;
                }
                label1.Text = "CRED. CLIENTE";
                descripcion_pago.Text = tb_cliente.Text;
                descripcion_pago.Enabled = false;
                descripcion_pago.Focus();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public form_ventas()
        {
            InitializeComponent();
            tb_codigo_producto.Focus();
            Datos.EstablecerConexion();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FEDITAR f = new FEDITAR(edtcantidad, edtprecio);
            f.ShowDialog();
            dgv_ventas.Rows[indexeliminar].Cells[4].Value =f.cantidad;
            dgv_ventas.Rows[indexeliminar].Cells[5].Value = f.total;
            CalcularTotal();
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text == "" )
            if (VerificarIguales())
            {
                int cantoriginal = int.Parse(dgv_ventas.Rows[dgv_ventas.RowCount - 1].Cells[4].Value.ToString());
                int canrt = int.Parse(tb_cantidad.Text);
                int ctotal = cantoriginal + canrt;
                float prexio = float.Parse(dgv_ventas.Rows[dgv_ventas.RowCount - 1].Cells[3].Value.ToString());
                dgv_ventas.Rows[dgv_ventas.RowCount - 1].Cells[4].Value = ctotal.ToString();
                dgv_ventas.Rows[dgv_ventas.RowCount - 1].Cells[5].Value = prexio * ctotal;

            }
            else
            {
                float total = (int.Parse(this.precio)) * (int.Parse(tb_cantidad.Text));
                dgv_ventas.Rows.Add(this.codigo, this.nombre, this.presentacion + this.marca, this.precio, tb_cantidad.Text, total, "true");
                for (int i = 0; i < 6; i++)
                {
                    dgv_ventas.Rows[dgv_ventas.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                    dgv_ventas.Rows[dgv_ventas.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Black;
                }
            }
            tb_codigo_producto.Text = "";
            tb_descripcion.Text = "";
            tb_cantidad.Text = "1";
            CalcularTotal();
            bt_facturar.Enabled = true;
            bt_agregar.Enabled = false;
            btn_pedido.Enabled = false;

            //Meter en el datagrid
        }

        private void chb_descuento_checked_changed(object sender, EventArgs e)
        {
            if (chb_descuento.Checked == true)
            {
                nud_descuento.Visible = true;
                lb_porc.Visible = true;
            }
            else
            {
                nud_descuento.Visible = false;
                lb_porc.Visible = false;
                nud_descuento.Value = 0;
                tb_total.Text = tb_subtotal.Text;
            }
        }

        private void nud_descuento_value_changed(object sender, EventArgs e)
        {
            tb_total.Text = (Convert.ToInt32(Convert.ToDouble(tb_subtotal.Text)-(Convert.ToDouble(tb_subtotal.Text) * Convert.ToDouble(nud_descuento.Value/100)))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SELECTORCLIENTE f = new SELECTORCLIENTE();     
            f.ShowDialog();
            if(f.cliente_seleccionado)
            {
                univruc = f.ruc;
                univcliente = f.nomcliente;
                tb_cliente.Text = univcliente;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String ObtenerCadenaDescripcion()
        {
            //comboBox2.Items.AddRange(new String []  {"CONTADO","TARJETA","PAYPHONE","CHEQUE","CREDITO"});
            if (cb_tipo_pago.Text == "CONTADO")
            {
                return "CONTADO";
            }
            else { 
                    if (cb_tipo_pago.Text == "TARJETA")
                    {
                        return ("Tarjeta Tran. No. "+descripcion_pago.Text);
                    }
                    if (cb_tipo_pago.Text == "PAYPHONE")
                    {
                        return ("Payphone Trans. No."+descripcion_pago.Text);
                    }
                    if (cb_tipo_pago.Text == "CHEQUE")
                    {
                        return ("Cheque No. " + descripcion_pago.Text);
                    }
                if (cb_tipo_pago.Text == "CREDITO")
                {
                    return ("CREDITO:" + tb_cliente.Text);
                }
                else
                    return "";
            }
            
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            String fecha = string.Empty;
            String hora = string.Empty;

            //tipo_pago

            try {

                efectivo = decimal.Parse(txtEfectivo.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Asegurase de que la cantidad en efectivo este correcta");
                return;
            }
            if (efectivo < decimal.Parse(tb_total.Text))
            {
                MessageBox.Show("La cantidad en efectivo no puede ser menor que el total");
                return;
            }


            if (Properties.Settings.Default.caja_estado == false)
            {
                fecha = DateTime.Now.ToString("yyyy-MM-dd");
                hora = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                DateTime mañana = DateTime.Now;
                mañana = mañana.AddDays(1);
                hora = "00:00:00";

            }
            float total = float.Parse(tb_total.Text);
            int total_real = Convert.ToInt32(total);
            string descripcion_pago = ObtenerCadenaDescripcion();
            Datos.EjecutarOrden("insert into factura(fecha_hora, empresa, cliente, total, tipo_pago, descripcion_pago) values('" + fecha + " " + hora + "', 1, '" + univruc + "'," + total_real + ",'" + cb_tipo_pago.Text +"','"+descripcion_pago+"');");
            String factura_insertada = Datos.EjecutarOrdenSelect("SELECT LAST_INSERT_ID();").Rows[0][0].ToString();
            String factura = Datos.EjecutarOrdenSelect("select codigo from factura order by codigo desc;").Rows[0][0].ToString();
            float total_producto = 0;
            for (int i = 0; i < dgv_ventas.Rows.Count; i++)
            {
                /*total_producto = float.Parse(dgv_ventas.Rows[i].Cells[3].Value.ToString()) * Int32.Parse(dgv_ventas.Rows[i].Cells[4].Value.ToString());
                Datos.EjecutarOrden("insert into detalle_factura(codigo_factura, producto, cantidad, descuento, total) values("+factura+",'"+ dgv_ventas.Rows[i].Cells[0].Value.ToString()+"',"
                    + dgv_ventas.Rows[i].Cells[4].Value.ToString()+" ,"+ dgv_ventas.Rows[i].Cells[5].Value.ToString() + ","+total_producto+");"); // acordate que modifque esta mierda alfonso jalam
                Datos.EjecutarOrden("update productos set stock = stock - " + dgv_ventas.Rows[i].Cells[4].Value.ToString() + " where codigo =" + dgv_ventas.Rows[i].Cells[0].Value.ToString());
                */
                total_producto = float.Parse(dgv_ventas.Rows[i].Cells[3].Value.ToString()) * Int32.Parse(dgv_ventas.Rows[i].Cells[4].Value.ToString());
                
                if (dgv_ventas.Rows[i].Cells[6].Value.ToString().Equals("false"))
                {

                    try
                    {
                        Datos.EjecutarOrden("insert into detalle_factura(codigo_factura, producto, cantidad, descuento, total) select " + factura + ",p.id_producto, "
                        + dgv_ventas.Rows[i].Cells[4].Value.ToString() + " ," + nud_descuento.Value + "," + total_producto + " from productos as p, detalle_producto as dp where p.id_producto=dp.id_producto and dp.codigo_barras = '" + dgv_ventas.Rows[i].Cells[0].Value.ToString() + "';"); // acordate que modifque esta mierda alfonso jalam
                    }
                    catch
                    {

                    }
                    try
                    {
                        Datos.EjecutarOrden("SET SQL_SAFE_UPDATES=0;");
                        Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto set dp.stock_individual = dp.stock_individual - " + Int32.Parse(dgv_ventas.Rows[i].Cells[4].Value.ToString()) + " where dp.codigo_barras = '" + dgv_ventas.Rows[i].Cells[0].Value.ToString() + "';");
                    }
                    catch
                    {

                    }


                }
                else
                {
                    Datos.EjecutarOrden("insert into detalle_pedido(codigo_factura, producto, cantidad, descuento, total) select " + factura + ", id_producto ,"
                    + dgv_ventas.Rows[i].Cells[4].Value.ToString() + " ," + dgv_ventas.Rows[i].Cells[5].Value.ToString() + "," + total_producto + " from productos as p, detalle_productos as dp where p.id_producto=dp.id_producto and dp.codigo_barras = '"+dgv_ventas.Rows[i].Cells[0].Value.ToString()+"';"); // acordate que modifque esta mierda alfonso jalam
                   

                }

            }
            if(this.descripcion_pago.Text == "CREDITO")
            {
                //primero quiero decir que me la suda el codigo de Henry y aqui va el codigo de creditos
            }

            /*********************************************************************************************/
            /*POSDATA HENRY ES BIEN GAY*/
            /*********************************************************************************************/
            //aqui va el codigo de imprimir para machos


            LibPrintTicket.Ticket ticket = new LibPrintTicket.Ticket();

            ticket.HeaderImage = Properties.Resources.logo_ancho;//Por ejemplo
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("Libreria Parra Junior");
            ticket.AddHeaderLine("Sucursal Paseo Real");
            ticket.AddHeaderLine("Tel. 89416603");
            ticket.AddHeaderLine("RUC: 2812005930008R");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("Cliente: " + tb_cliente.Text);

            ticket.AddSubHeaderLine("Ticket # " + factura_insertada);
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());


            decimal suma = 0;
            //decimal iva = 0; //iva se podria modificar
            decimal desc = 0;
            for (int i = 0; i < dgv_ventas.Rows.Count; i++)
            {
                ticket.AddItem(dgv_ventas.Rows[i].Cells[4].Value.ToString(), dgv_ventas.Rows[i].Cells[1].Value.ToString(), "C$ " + dgv_ventas.Rows[i].Cells[5].Value.ToString());
                try { suma += decimal.Parse(dgv_ventas.Rows[i].Cells[3].Value.ToString()) * decimal.Parse(dgv_ventas.Rows[i].Cells[4].Value.ToString()); }
                catch { }
            }

            if (chb_descuento.Checked == true)
            {
                desc = suma * (nud_descuento.Value / 100);
            }
            else
            {
                desc = 0;
            }

            ticket.AddTotal("SUBTOTAL", "C$ " +suma.ToString());
            ticket.AddTotal("DESC", "C$ " + desc.ToString());
            ticket.AddTotal("TOTAL", "C$ " + (suma - desc).ToString());
            ticket.AddTotal("", "");
            ticket.AddTotal("RECIBIDO", "C$ " + efectivo.ToString());
            ticket.AddTotal("CAMBIO", "C$ " + (efectivo - (suma - desc)).ToString());
            ticket.AddTotal("", "");

            ticket.AddFooterLine("!GRACIAS POR SU COMPRA!");
            ticket.AddFooterLine("ATENCION : 10 AM - 9 PM");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("ATENDIO : " + globales.usuario);
            await Task.Run(() => ticket.PrintTicket("POS-80C"));
            this.Show();
            

            dgv_ventas.Rows.Clear();
            univcliente = "CONTADO";
            univruc = "1234";
            cb_tipo_pago.SelectedIndex = 0;
            tb_cliente.Text = "CONTADO";
            tb_cantidad.Text = "1";
            tb_codigo_producto.Focus();
            this.descripcion_pago.Text = "CONTADO";

            this.descripcion_pago.Enabled = false;
            CargarClientes();
            bt_facturar.Enabled = false;
            this.univruc = "1234";
            tb_total.Text ="0";
            tb_subtotal.Text = "0";
            txtEfectivo.Clear();

            nud_descuento.Visible = false;
            chb_descuento.Checked = false;
            nud_descuento.Value = 0;
            lb_porc.Visible = false;
            chb_descuento.Visible = false;
            
        }

        private void FORMVENTAS_Load(object sender, EventArgs e)
        {
            cb_tipo_pago.Items.AddRange(new String []  {"CONTADO","TARJETA","PAYPHONE","CHEQUE","CREDITO"});
            cb_tipo_pago.SelectedIndex = 0;
            tb_cliente.Text = "CONTADO";
            tb_cantidad.Text = "1";
            tb_codigo_producto.Focus();
            descripcion_pago.Text = "CONTADO";
       
            descripcion_pago.Enabled = false;
            CargarClientes();
            bt_facturar.Enabled = false;
            this.univruc = "1234";
            bt_editar.Enabled = false;
            efectivo = 0;

           // this.reportViewer1.RefreshReport();
        }
        public void CargarClientes()
        {/*
            DataTable clientes = Datos.EjecutarOrdenSelect("select ruc,nombre from cliente");
            for (int i = 0; i < clientes.Rows.Count; i++)
            {
                comboBox1.Items.Add(clientes.Rows[i][1].ToString());
                ruc.Add(clientes.Rows[i][0].ToString());
                nclientes.Add(clientes.Rows[i][1].ToString());
            }
            comboBox1.SelectedIndex = comboBox1.FindStringExact("CONTADO");*/
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            chb_descuento.Visible = true;
            //if(textBox1.Text == "" )
            if (VerificarIguales())
            {
                int cantoriginal = int.Parse(dgv_ventas.Rows[dgv_ventas.RowCount - 1].Cells[4].Value.ToString());
                int canrt = int.Parse(tb_cantidad.Text);
                int ctotal = cantoriginal + canrt;
                float prexio = float.Parse(dgv_ventas.Rows[dgv_ventas.RowCount - 1].Cells[3].Value.ToString());
                dgv_ventas.Rows[dgv_ventas.RowCount - 1].Cells[4].Value = ctotal.ToString();
                dgv_ventas.Rows[dgv_ventas.RowCount - 1].Cells[5].Value = prexio*ctotal;

            }
            else { 
            float total = (int.Parse(this.precio))*(int.Parse(tb_cantidad.Text));
            dgv_ventas.Rows.Add(this.codigo,this.nombre,this.presentacion+this.marca,this.precio,tb_cantidad.Text,total,"false");
            }
            tb_codigo_producto.Text = "";
            tb_descripcion.Text = "";
            tb_cantidad.Text = "1";
            CalcularTotal();
            bt_facturar.Enabled = true;
            bt_agregar.Enabled = false;
            btn_pedido.Enabled = false;          
            //Meter en el datagrid
        }
        public bool VerificarIguales()
        {
            if (dgv_ventas.Rows.Count < 1)
            {
                return false;
            }
            else {

                if (dgv_ventas.Rows[dgv_ventas.Rows.Count-1].Cells[0].Value.ToString() == tb_codigo_producto.Text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
    }
}
