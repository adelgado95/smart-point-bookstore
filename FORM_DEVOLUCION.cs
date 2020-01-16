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
    public partial class FORM_DEVOLUCION : Form
    {
        //rellenar campos de texto
        List<String> codigo_producto = new List<String>();
        List<String> codigo_producto_proveedor = new List<String>();
        public DataTable tabla_datos_cliente = null;
        public DataTable tabla_datos_proveedor = null;

        //resultado
        int salida = 0;

        //Datos de la devolucion de clientes
        String identificacion_producto;
        String motivo_devolucion;
        String identificacion_cliente;

        //Datos de la devolucion a proveedores
        String identificacion_proveedor;
        public FORM_DEVOLUCION()
        {
            InitializeComponent();
            tb_prod.AutoCompleteCustomSource = rellenar_producto_proveedor();
            tb_producto.AutoCompleteCustomSource = rellenar_producto();
        }

        private AutoCompleteStringCollection rellenar_producto()
        {

            DataTable datos = new DataTable();

            String Consulta_productos = String.Empty;
            Consulta_productos = "select detalle_producto.codigo_barras as Producto from cliente,factura,detalle_factura,productos,detalle_producto where cliente.ruc = factura.cliente and factura.codigo = detalle_factura.codigo_factura and detalle_factura.producto = productos.id_producto and productos.id_producto=detalle_producto.id_producto;";

            var fuente = new AutoCompleteStringCollection();
            try
            {
                datos = Datos.EjecutarOrdenSelect(Consulta_productos);
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    codigo_producto.Add(datos.Rows[i][0].ToString());
                    fuente.Add(datos.Rows[i][0].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar los datos"+ex.Message,"Error");
            }
            return fuente;
        }

        private AutoCompleteStringCollection rellenar_factura_cliente()
        {

            DataTable datos = new DataTable();

            String Consulta_factura = String.Empty;
            Consulta_factura = "select factura.codigo as Factura from cliente,factura,detalle_factura,productos,detalle_producto where cliente.ruc = factura.cliente and factura.codigo = detalle_factura.codigo_factura and detalle_factura.producto = productos.id_producto and productos.id_producto=detalle_producto.id_producto and detalle_producto.codigo_barras='" + tb_producto.Text + "';";

            var fuente = new AutoCompleteStringCollection();
            try
            {
                datos = Datos.EjecutarOrdenSelect(Consulta_factura);
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    fuente.Add(datos.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los datos" + ex.Message, "Error");
            }
            return fuente;
        }

        private AutoCompleteStringCollection rellenar_factura_proveedor()
        {

            DataTable datos = new DataTable();

            String Consulta_factura = String.Empty;
            Consulta_factura = "select factura.codigo as Factura from proveedor,productos,detalle_producto,devolucion,factura where proveedor.ruc = productos.proveedor and detalle_producto.id_producto=productos.id_producto and devolucion.Identificacion_producto=detalle_producto.id_producto and factura.codigo=devolucion.id_factura and detalle_producto.codigo_barras='" + tb_prod.Text + "';";

            var fuente = new AutoCompleteStringCollection();
            try
            {
                datos = Datos.EjecutarOrdenSelect(Consulta_factura);
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    fuente.Add(datos.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los datos" + ex.Message, "Error");
            }
            return fuente;
        }

        private AutoCompleteStringCollection rellenar_producto_proveedor()
        {

            DataTable datos = new DataTable();

            String Consulta_productos = String.Empty;
            Consulta_productos = "select dp.codigo_barras from productos as p, detalle_producto as dp, devolucion as d, devolucion_clientes as dc where p.id_producto=dp.id_producto and d.idDevolucion=dc.id_devolucion and p.id_producto=d.Identificacion_producto;";

            var fuente = new AutoCompleteStringCollection();
            try
            {
                datos = Datos.EjecutarOrdenSelect(Consulta_productos);
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    codigo_producto_proveedor.Add(datos.Rows[i][0].ToString());
                    fuente.Add(datos.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los datos" + ex.Message, "Error");
            }
            return fuente;
        }


        private bool verificar_garantia()
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT categoria FROM detalle_producto as dp, productos as p where dp.id_producto=p.id_producto and codigo_barras = '" + tb_producto.Text + "';");
            DataTable categoria = Datos.EjecutarOrdenSelect("SELECT nombre FROM `categoria` where codigo = " + datos.Rows[0][0].ToString());
            if (categoria.Rows[0][0].ToString().ToUpper().Equals("TECNOLOGIA") ||
                categoria.Rows[0][0].ToString().ToUpper().Equals("TECNOLOGÍA"))
            {
                DataTable fecha = Datos.EjecutarOrdenSelect("SELECT fecha_hora from factura where codigo = " + tb_factura.Text + "; ");
                DateTime date = DateTime.Parse(fecha.Rows[0][0].ToString());
                DateTime now = DateTime.Now;
                int meses = CalcularMesesDeDiferencia(date, now);

                if (meses > 6)
                {
                    MessageBox.Show("La garantía del producto a finalizado, no se puede realizar una devolución");
                    return false;
                }
                else
                {
                    if (meses == 6)
                    { 
                        int dia_limite = 0;
                        int oldDayInMonth = System.DateTime.DaysInMonth(date.Year, date.Month); //sacamos el ultimo dia de cada mes
                        int newDayInMonth = System.DateTime.DaysInMonth(now.Year, now.Month);
                        if (oldDayInMonth > newDayInMonth) //si el mes de la factura tiene mas dia que el mes que se esta realizando la devolucion

                        {
                            if(oldDayInMonth ==date.Day) // y si el ultimo dia del mes coincide que es el mismo dia en que se produjo la facturacion
                            {
                                dia_limite = newDayInMonth; // ahora el dia limite para hacer la devolucion es el ultimo dia del mes en que se realiza la devolucion
                            
                                if(dia_limite < now.Day) // si el dia limite es mayor que el dia en que se realiza la devolucion, la devolucion expira
                                 
                                {
                                    MessageBox.Show("La garantía del producto a finalizado, no se puede realizar una devolución");
                                    return false;
                                }

                            }
                            else
                            {
                                dia_limite = date.Day;
                                if (dia_limite < now.Day)
                                //Si por ejemplo el dia limite es 16 pero al momento de facturar es 17, entonces se de la garantia como finalizada

                                {
                                    MessageBox.Show("La garantía del producto a finalizado, no se puede realizar una devolución");
                                    return false;
                                }
                            }
                        }
                        else
                        {
                            dia_limite = date.Day;
                        
                            if (dia_limite < now.Day)
                            //Si por ejemplo el dia limite es 16 pero al momento de facturar es 17, entonces se de la garantia como finalizada

                            {
                                MessageBox.Show("La garantía del producto a finalizado, no se puede realizar una devolución");
                                return false;
                            }
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Este producto no tiene garantía");
                return false;
            }
            return true;
        }

        public int CalcularMesesDeDiferencia(DateTime fechaDesde, DateTime fechaHasta)
        {
            return Math.Abs((fechaDesde.Month - fechaHasta.Month) + 12 * (fechaDesde.Year - fechaHasta.Year));
        }


        private void boton_devolver_producto_click(object sender, EventArgs e)
        {
            if (tc_devolucion.SelectedTab.Name == "tp_devolucion_clientes")
            {
                if (!verificar_campos_devolucion()) return;

                if(!verificar_garantia())return;

                //insertar datos
                try
                {
                    identificacion_cliente = tb_id_cliente.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese ingresar sus datos correctos : " + ex.Message);
                }

                try
                {
                    identificacion_producto = tb_producto.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese ingresar sus datos correctos : " + ex.Message);
                }

                try
                {
                    motivo_devolucion = tb_motivo_devolucion_cliente.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese ingresar sus datos correctos : " + ex.Message);
                }

                try
                {
                    salida = Datos.EjecutarOrden("insert into devolucion(detalle_devolucion,identificacion_producto, id_factura) select '" + motivo_devolucion + "', dp.id_producto, " + Int32.Parse(tb_factura.Text) +" from detalle_producto as dp, productos as p where dp.id_producto=p.id_producto and dp.codigo_barras='" + identificacion_producto +"';");
                    insertar_devolucion_cliente();
                    borrar_datos_factura(Int32.Parse(tb_factura.Text), identificacion_producto);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos" + ex.Message);
                }

                if (salida != -1)
                {
                    MessageBox.Show("Datos agregados");
                    this.Dispose();
                }
            }
            else
            {
                if (!verificar_campos_devolucion()) return;

                //insertar datos
                try
                {
                    identificacion_proveedor = tb_proveedor.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese ingresar sus datos correctos : " + ex.Message);
                }

                try
                {
                    identificacion_producto = tb_prod.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese ingresar sus datos correctos : " + ex.Message);
                }

                try
                {
                    motivo_devolucion = tb_motivo_prov.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asegurese ingresar sus datos correctos : " + ex.Message);
                }

                try
                {
                    String Consulta = "insert into devolucion(detalle_devolucion,identificacion_producto,id_factura) select '" + motivo_devolucion + "',dp.id_producto ," + Int32.Parse(tb_fact_prov.Text) + " from productos as p, detalle_producto as dp where p.id_producto=dp.id_producto and dp.codigo_barras = '"+ identificacion_producto + "';";
                    salida = Datos.EjecutarOrden(Consulta);
                    insertar_devolucion_proveedor();
                    //borrar_datos_factura(Int32.Parse(tb_fact_prov.Text),identificacion_producto);
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos"+ex.Message);
                }

                if (salida != -1)
                {
                    MessageBox.Show("Datos agregados");
                    this.Dispose();
                }
            }
        }

        private bool verificar_campos_devolucion()
        {
            if(tc_devolucion.SelectedTab.Name == "tp_devolucion_clientes")
            {
                for (int i = 0; i < tp_devolucion_clientes.Controls.Count; i++)
                {
                    if (tp_devolucion_clientes.Controls[i] is TextBox && tp_devolucion_clientes.Controls[i].Text == string.Empty)
                    {
                        tb_producto.Focus();
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < tp_devolucion_proveedores.Controls.Count; i++)
                {
                    if (tp_devolucion_proveedores.Controls[i] is TextBox && tp_devolucion_proveedores.Controls[i].Text == string.Empty)
                    {
                        tb_prod.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void borrar_datos_factura(int num_factura, string codigo_producto)
        {
            int salida_borrar_detalle = Datos.EjecutarOrden("delete from detalle_factura where codigo_factura="+num_factura+" and producto in (select p.id_producto from productos as p, detalle_producto as dp where p.id_producto=dp.id_producto and dp.codigo_barras='"+codigo_producto+"');");
            if(salida_borrar_detalle < 0)
            {
                MessageBox.Show("No se borro el detalle de la factura");
            }
        }

        private void insertar_devolucion_cliente()
        {
            try
            {
                salida = Datos.EjecutarOrden("insert into devolucion_clientes(id_cliente,id_devolucion) values ('" + identificacion_cliente + "',LAST_INSERT_ID());");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Asegurese de que todos los datos esten correctos"+ex.Message);
            }
        }

        private void insertar_devolucion_proveedor()
        {
            try
            {
                salida = Datos.EjecutarOrden("insert into devolucion_proveedores(id_proveedor,id_devolucion) values ('" + identificacion_proveedor + "',LAST_INSERT_ID());");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Asegurese de que todos los datos esten correctos" + ex.Message);


            }
        }

        private void bt_cancelar_transaccion_Click(object sender, EventArgs e)
        {
            if (tc_devolucion.SelectedTab.Name == "tp_devolucion_clientes")
            {
                tb_id_cliente.Text = String.Empty;
                tb_producto.Text = String.Empty;
                tb_factura.Text = String.Empty;
                tb_motivo_devolucion_cliente.Text = String.Empty;
            }
            else
            {
                tb_proveedor.Text = String.Empty;
                tb_prod.Text = String.Empty;
                tb_motivo_prov.Text = String.Empty;
                tb_fact_prov.Text = String.Empty;
            }
        }

        private void tb_producto_Leave(object sender, EventArgs e)
        {
            if (tc_devolucion.SelectedTab.Name == "tp_devolucion_clientes")
            {
                if (tb_producto.Text.Length == 0 )
                {
                    tb_producto.Focus();
                    tb_id_cliente.Text = "";
                    tb_factura.Text = "";
                    return;
                }
               
                    try
                {
                    tb_factura.AutoCompleteCustomSource = rellenar_factura_cliente();
                    tabla_datos_cliente = Datos.EjecutarOrdenSelect("select cliente.ruc as Cliente, factura.codigo as Factura from cliente,factura,detalle_factura,productos,detalle_producto where cliente.ruc = factura.cliente and factura.codigo = detalle_factura.codigo_factura and detalle_factura.producto = productos.id_producto and productos.id_producto=detalle_producto.id_producto and detalle_producto.codigo_barras='" + tb_producto.Text + "';");
                    tb_id_cliente.Text = tabla_datos_cliente.Rows[0][0].ToString();
                    tb_factura.Text = tabla_datos_cliente.Rows[0][1].ToString();
                }
                catch
                {

                    MessageBox.Show("PRODUCTO NO ENCONTRADO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tb_producto.Focus();
                    return;
                }
            }
            else
            {
                if (tb_prod.Text.Length == 0)
                {
                    tb_prod.Focus();
                    tb_fact_prov.Text = "";
                    tb_proveedor.Text = "";
                    return;
                }
                try
                {
                    tb_fact_prov.AutoCompleteCustomSource = rellenar_factura_proveedor();
                    tabla_datos_proveedor = Datos.EjecutarOrdenSelect("select proveedor.ruc as Proveedor, factura.codigo as Factura, detalle_producto.codigo_barras as Producto from proveedor,productos,detalle_producto,devolucion,factura where proveedor.ruc = productos.proveedor and detalle_producto.id_producto=productos.id_producto and devolucion.Identificacion_producto=detalle_producto.id_producto and factura.codigo=devolucion.id_factura and detalle_producto.codigo_barras='" + tb_prod.Text + "';");
                    tb_proveedor.Text = tabla_datos_proveedor.Rows[0][0].ToString();
                    tb_fact_prov.Text = tabla_datos_proveedor.Rows[0][1].ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR" + ex.Message);
                }
            }
        }
    }


    

}
