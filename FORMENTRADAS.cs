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
    public partial class FORMENTRADAS : Form
    {
        int filaselec = -1;
        List<int> codigo_marca = new List<int>();
        List<String> codigo_proveedor = new List<String>();
        List<int> codigo_categoria = new List<int>();
        public static string cod_p = string.Empty;
        DataGridView detalles;
        public List<List<string>> detalles_obtenidos;
        DetalleProducto nuevo_detalle;
        public FORMENTRADAS()
        {
            InitializeComponent();

            detalles = new DataGridView();
            detalles_obtenidos = new List<List<string>>();
            nuevo_detalle = new DetalleProducto(this);

            if (globales.Conexion_Alm != null)
                globales.Conexion_Alm.Close();

            string connStr =
                String.Format("server=localhost;port=3306;user id=root;password=IngenieroRoot; " +
                "database=libreria_parra; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True");
            try
            {
                globales.Conexion_Alm = new MySqlConnection(connStr);
                globales.Conexion_Alm.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar al servidor de MySQL: " +
                    ex.Message, "Error al conectar" + "Revise si el script fue correctamente ejecutado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_marca.AutoCompleteCustomSource = rellenar_marca();
            tb_proveedor.AutoCompleteCustomSource = rellenar_proveedor();
            tb_categoria.AutoCompleteCustomSource = rellenar_categoria();

        }


        private AutoCompleteStringCollection rellenar_marca()
        {
            string tablatxt;
            string superior = string.Empty;
            tablatxt = "SELECT * FROM marca;";

            var source = new AutoCompleteStringCollection();
            try
            {

                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand(tablatxt, globales.Conexion_Alm);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    codigo_marca.Add(reader.GetInt32(0));
                    source.Add(reader.GetString(1));
                    

                }
                reader.Dispose();
                reader.Close();

                return source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos de la tabla de MySQL: " +
                    ex.Message, "Error ejecutar SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null; 
            }
        }

        
        private AutoCompleteStringCollection rellenar_proveedor()
        {
            string tablatxt;
            string superior = string.Empty;
            tablatxt = "SELECT * FROM proveedor;";

            var source = new AutoCompleteStringCollection();
            try
            {

                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand(tablatxt, globales.Conexion_Alm);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    codigo_proveedor.Add(reader.GetString(0)); // corregir a varchar
                    source.Add(reader.GetString(1));

                }
                reader.Dispose();
                reader.Close();

                return source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos de la tabla de MySQL: " +
                    ex.Message, "Error ejecutar SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        private AutoCompleteStringCollection rellenar_categoria()
        {
            string tablatxt;
            string superior = string.Empty;
            tablatxt = "SELECT * FROM categoria;";

            var source = new AutoCompleteStringCollection();
            try
            {

                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand(tablatxt, globales.Conexion_Alm);
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    codigo_categoria.Add(reader.GetInt32(0));
                    source.Add(reader.GetString(1));

                }
                reader.Close();

                return source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos de la tabla de MySQL: " +
                    ex.Message, "Error ejecutar SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' & e.KeyChar <= '9') | (Convert.ToInt32(e.KeyChar) == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i].Text.Length == 0 && this.datos.Controls[i] is TextBox && this.datos.Controls[i].Name != "tb_codigo_barras")
                {
                    MessageBox.Show("Por favor inserte todos los datos");
                    return;
                }
            }

            if (DetalleProducto.CodigosMultiples)
            {
                //detalles = DetalleProducto.detalles_productos;
                for (int i = 0; i < detalles_obtenidos.Count; i++)
                {
                    dgv_entrada_productos.Rows.Add(detalles_obtenidos[i][0].ToString(), tb_nombre.Text.ToString().ToUpper(), detalles_obtenidos[i][1].ToString(), tb_precio.Text,
                  tb_ubicacion.Text.ToString().ToUpper(), tb_marca.Text.ToString().ToUpper(), tb_descripcion.Text.ToString().ToUpper(), cb_presentacion.Text, tb_proveedor.Text.ToString().ToUpper(), tb_categoria.Text.ToString().ToUpper());
                }
            }
            else
            {
                    dgv_entrada_productos.Rows.Add(tb_codigo_barras.Text.ToString(), tb_nombre.Text.ToString().ToUpper(), tb_cantidad.Text, tb_precio.Text,
                  tb_ubicacion.Text.ToString().ToUpper(), tb_marca.Text.ToString().ToUpper(), tb_descripcion.Text.ToString().ToUpper(), cb_presentacion.Text, tb_proveedor.Text.ToString().ToUpper(), tb_categoria.Text.ToString().ToUpper());
            }

           
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if(this.datos.Controls[i] is TextBox)
                datos.Controls[i].Text = string.Empty;
            }


     

        }

        private void FORMENTRADAS_Load(object sender, EventArgs e)
        {
            tb_codigo_barras.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb_codigo_barras.TextLength < 10) return;
            try
            {
                DataTable producto = Datos.EjecutarOrdenSelect("SELECT dp.codigo_barras, ubicacion, p.nombre, caracteristica, precio, m.nombre as marca,  " +
                " presentacion, pv.nombre as proveedor, c.nombre as categoria FROM detalle_producto as dp, productos as p, marca as m, proveedor as pv, categoria as c where dp.id_producto=p.id_producto and " +
                " p.marca=m.codigo and p.proveedor=pv.ruc and p.categoria=c.codigo and dp.codigo_barras = '" + tb_codigo_barras.Text.ToString() + "'");
                tb_codigo_barras.Text = producto.Rows[0][0].ToString();
                tb_ubicacion.Text = producto.Rows[0][1].ToString();
                tb_nombre.Text = producto.Rows[0][2].ToString();
                tb_descripcion.Text = producto.Rows[0][3].ToString();
                tb_precio.Text = producto.Rows[0][4].ToString();
                tb_marca.Text = producto.Rows[0][5].ToString();
                cb_presentacion.Text = producto.Rows[0][6].ToString();
                tb_proveedor.Text = producto.Rows[0][7].ToString();
                tb_categoria.Text = producto.Rows[0][8].ToString();
            }
            catch
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_entrada_productos.Rows.Count < 1) return;
            tb_cancelar1.Enabled = true;
            int f = e.RowIndex;
            this.filaselec = f;
            tb_eliminar.Enabled = true;
            tb_editar.Enabled = true;
            tb_agregar.Enabled = false;


            try
            {
                tb_codigo_barras.Text = dgv_entrada_productos.CurrentRow.Cells[0].Value.ToString();
                tb_nombre.Text = dgv_entrada_productos.CurrentRow.Cells[1].Value.ToString();
                tb_cantidad.Text = dgv_entrada_productos.CurrentRow.Cells[2].Value.ToString();

                tb_ubicacion.Text = dgv_entrada_productos.CurrentRow.Cells[4].Value.ToString();
                tb_precio.Text = dgv_entrada_productos.CurrentRow.Cells[3].Value.ToString();
                tb_marca.Text = dgv_entrada_productos.CurrentRow.Cells[5].Value.ToString();
                tb_descripcion.Text = dgv_entrada_productos.CurrentRow.Cells[6].Value.ToString();
                cb_presentacion.Text = dgv_entrada_productos.CurrentRow.Cells[7].Value.ToString();
                tb_proveedor.Text = dgv_entrada_productos.CurrentRow.Cells[8].Value.ToString();
                tb_categoria.Text = dgv_entrada_productos.CurrentRow.Cells[9].Value.ToString();
            }
            catch
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgv_entrada_productos.Rows.RemoveAt(this.filaselec);
            tb_eliminar.Enabled = false;
            tb_editar.Enabled = false;
            tb_agregar.Enabled = true;
            tb_cancelar1.Enabled = false;
        }

        private void precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' & e.KeyChar <= '9' ) | (Convert.ToInt32(e.KeyChar) == 8) )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private int buscar_coincidencias(string codigo)
        {
            DataTable repetidos = Datos.EjecutarOrdenSelect("select * from productos as p,detalle_producto as dp where dp.codigo_barras = '" + codigo + "'");
            if(repetidos.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<List<string>> producto = new List<List<string>>();
            List<List<string>> cod_producto = new List<List<string>>();
            List<int> indices = new List<int>();
            for (int i = 0; i < dgv_entrada_productos.RowCount; i++)
            {
                for (int j = 0; j < dgv_entrada_productos.Rows[i].Cells.Count; j++)
                {
                    if (j == 0)
                    {
                        int valor;
                        valor = buscar_coincidencias(dgv_entrada_productos.Rows[i].Cells[j].Value.ToString());
                        if (valor == 0)
                        {
                            try
                            {
                                cod_producto.Add(new List<string>());
                                cod_producto[i].Add(dgv_entrada_productos.Rows[i].Cells[0].Value.ToString());
                                cod_producto[i].Add(dgv_entrada_productos.Rows[i].Cells[2].Value.ToString());
                                indices.Add(i);
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }
            for (int i = 0; i < indices.Count; i++)
            { try { dgv_entrada_productos.Rows.RemoveAt(indices[i]); } catch { } }

            if (dgv_entrada_productos.Rows.Count > 0)
            {

                for (int i = 0; i < dgv_entrada_productos.RowCount; i++)
                {
                    for (int j = 0; j < dgv_entrada_productos.Rows[i].Cells.Count; j++)
                    {
                        producto.Add(new List<string>());
                        producto[i].Add(dgv_entrada_productos.Rows[i].Cells[j].Value.ToString());
                    }
                }
                actualizar_stock(cod_producto);
                insertar_producto(producto);
            }
            else
            {
                actualizar_stock(cod_producto);
                MessageBox.Show("Datos actualizados");
            }

            DetalleProducto.CodigosMultiples = false;

        }

        private void actualizar_stock(List<List<string>> producto)
        {
            DataTable stock = new DataTable();
            int suma = 0;
            for(int i = 0; i < producto.Count; i++)
            {
                try
                {
                    stock = Datos.EjecutarOrdenSelect("Select stock_individual from productos as p,detalle_producto as dp where  p.id_producto=dp.id_producto and dp.codigo_barras = '" + producto[i][0].ToString() + "'");
                    suma = int.Parse(stock.Rows[0][0].ToString());
                    suma += int.Parse(producto[i][1].ToString());
                }
                catch
                {

                }
                try
                {
                    Datos.EjecutarOrden("SET SQL_SAFE_UPDATES=0;");
                    Datos.EjecutarOrden("update productos as p inner join detalle_producto as dp on p.id_producto=dp.id_producto set stock_individual = " + suma + " where dp.codigo_barras = '" + producto[i][0].ToString() + "';");
                }
                catch
                {

                }
            }

            
        }
        private int buscar_codigo_marca(string nombre)
        {

            
            for(int i=0; i<codigo_marca.Count; i++)
            {
                if (tb_marca.AutoCompleteCustomSource[i].ToString() ==  nombre.ToString().ToUpper())
                    return i;
            }

            return -1;

        }

        private int buscar_codigo_proveedor(string nombre)
        {
            for (int i = 0; i < tb_proveedor.AutoCompleteCustomSource.Count; i++)
            {
                if (tb_proveedor.AutoCompleteCustomSource[i].ToString() == nombre.ToString().ToUpper())
                    return i;
            }

            return -1;

        }

        private int buscar_codigo_categoria(string nombre)
        {


            for (int i = 0; i < tb_categoria.AutoCompleteCustomSource.Count; i++)
            {
                if (tb_categoria.AutoCompleteCustomSource[i].ToString() == nombre.ToString().ToUpper())
                    return i;
            }

            return -1;

        }
        private void insertar_producto(List<List<string>> producto)
        {
            int codigo_m = 0;
            int codigo_prov = 0;
            String codigo_p = String.Empty;
            List<string> productos_iguales = new List<string>();
            int codigo_c = 0;
            bool ingresar = true;
            for (int i = 0; i < dgv_entrada_productos.RowCount; i++)
            {
                //obtenes el indice de donde se encuentra esa marca
                codigo_m = buscar_codigo_marca(producto[i][5].ToString().ToUpper());
                codigo_prov = buscar_codigo_proveedor(producto[i][8].ToString().ToUpper());
                codigo_c = buscar_codigo_categoria(producto[i][9].ToString().ToUpper());
     
                //aqui obtenemos el id de con su indice especifico
                codigo_p = codigo_proveedor[codigo_prov];
                codigo_m = codigo_marca[codigo_m];
                codigo_c = codigo_categoria[codigo_c];

                if (i != 0)
                {
                    if (dgv_entrada_productos.Rows[i-1].Cells[1].Value.ToString().Equals(dgv_entrada_productos.Rows[i].Cells[1].Value.ToString()))
                    {
                        ingresar = false;
                    }
                    else
                    {
                        ingresar = true;
                    }
                }
                
                
                try
                {
                    if (ingresar)
                    {

                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = globales.Conexion_Alm;
                        cmd.CommandText = "INSERT INTO `libreria_parra`.`productos` (`ubicacion`, `nombre`, `caracteristica`, `precio`, `stock`, `marca`, `presentacion`, `proveedor`, `categoria`) VALUES ("
                            + "'" + producto[i][4].ToString().ToUpper() + "'," //ubicacion
                            + "'" + producto[i][1].ToString().ToUpper() + "'," //nombre
                            + "'" + producto[i][6].ToString().ToUpper() + "'," //caracteristica
                            + "" + producto[i][3] + "," //precio
                            + "" + producto[i][2] + "," //stock
                            + "" + codigo_m + "," //marca
                            + "'" + producto[i][7] + "'," //presentacion
                            + "'" + codigo_p + "'," //proveedor
                            + "" + codigo_c + ")"; //categoria


                        int resultado = conexion.EjecutarOrden(cmd);
                        int id_producto = 0;

                        if (resultado > 0)
                        {
                            id_producto = consultar_id_producto_ultimo();
                        }

                        //DataGridView detalles = DetalleProducto.detalles_productos;
                        MySqlCommand comando_detalles = new MySqlCommand();
                        if (DetalleProducto.CodigosMultiples && id_producto > 0)
                        {
                            int contador_datos = 0;
                            for (int it = 0; it < detalles_obtenidos.Count; it++)
                            {
                                string orden = "INSERT INTO `libreria_parra`.`detalle_producto` (`ns`, `estado_producto`, `codigo_barras`, `id_producto`, `stock_individual`, `CaracteristicaIndividual`) VALUES ('" + detalles_obtenidos[it][3].ToString() + "','" + detalles_obtenidos[it][4].ToString() + "','" + detalles_obtenidos[it][0].ToString() + "'," + id_producto +",'" + detalles_obtenidos[it][1].ToString() +"','"+detalles_obtenidos[it][2].ToString()+"');";
                                comando_detalles.CommandText = orden;
                                if (conexion.EjecutarOrden(comando_detalles) > 0)
                                {
                                    contador_datos++;
                                }
                            }
                            MessageBox.Show( contador_datos + " PRODUCTOS INGRESADOS");

                            detalles_obtenidos.Clear();
                        }
                        else
                        {
                            string orden = "INSERT INTO `libreria_parra`.`detalle_producto` (`ns`, `estado_producto`, `codigo_barras`, `id_producto`,`stock_individual`, `CaracteristicaIndividual`) VALUES (null,'DISPONIBLE','" + producto[i][0].ToString() + "'," + id_producto + ","+producto[i][2].ToString()+",' '"+");";
                            comando_detalles.CommandText = orden;                                                                                                                                                                                                                                                       
                            if (conexion.EjecutarOrden(comando_detalles) > 0)
                            {
                                MessageBox.Show("PRODUCTO INGRESADO");
                            }
                        }
                        dgv_entrada_productos.Rows.Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Asegurese que todos los datos esten correctos : "+ex.Message , "Error al insertar datos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
          }

            MessageBox.Show("Datos agregados");
        }

        private int consultar_id_producto_ultimo()
        {
            DataTable id_producto;
            MySqlCommand comando_id = new MySqlCommand();
            string orden_id_producto = "SELECT LAST_INSERT_ID() as id_producto;";
            comando_id.CommandText = orden_id_producto;

            id_producto = conexion.EjecutarOrdenSelect(comando_id);

            int id_obtenido = Int32.Parse(id_producto.Rows[0][0].ToString());

            return id_obtenido;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i].Text.Length == 0)
                {
                    MessageBox.Show("Por favor inserte todos los datos");
                    return;
                }
            }

            dgv_entrada_productos.Rows.RemoveAt(filaselec);
            dgv_entrada_productos.Rows.Insert(filaselec,
            tb_codigo_barras.Text, tb_nombre.Text, tb_cantidad.Text, tb_precio.Text,
                tb_ubicacion.Text, tb_marca.Text, tb_descripcion.Text, cb_presentacion.Text, tb_proveedor.Text, tb_categoria.Text);

            tb_eliminar.Enabled = false;
            tb_editar.Enabled = false;
            tb_agregar.Enabled = true;
            tb_cancelar1.Enabled = false;
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox)
                    datos.Controls[i].Text = string.Empty;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tb_eliminar.Enabled = false;
            tb_editar.Enabled = false;
            tb_agregar.Enabled = true;
            tb_cancelar1.Enabled = false;
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox)
                    datos.Controls[i].Text = string.Empty;
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (tb_codigo_barras.TextLength == 0)
            {
                new BUSCAR_CODIGO_PRODUCTO().ShowDialog();

                try
                {
                    DataTable producto = Datos.EjecutarOrdenSelect("SELECT dp.codigo_barras, ubicacion, p.nombre, caracteristica, precio, m.nombre as marca,  " +
                     " presentacion, pv.nombre as proveedor, c.nombre as categoria FROM detalle_producto as dp, productos as p, marca as m, proveedor as pv, categoria as c where dp.id_producto=p.id_producto and " +
                    " p.marca=m.codigo and p.proveedor=pv.ruc and p.categoria=c.codigo and dp.codigo_barras = '" + cod_p + "'");
                    tb_codigo_barras.Text = producto.Rows[0][0].ToString();
                    tb_ubicacion.Text = producto.Rows[0][1].ToString();
                    tb_nombre.Text = producto.Rows[0][2].ToString();
                    tb_descripcion.Text = producto.Rows[0][3].ToString();
                    tb_precio.Text = producto.Rows[0][4].ToString();
                    tb_marca.Text = producto.Rows[0][5].ToString();
                    cb_presentacion.Text = producto.Rows[0][6].ToString();
                    tb_proveedor.Text = producto.Rows[0][7].ToString();
                    tb_categoria.Text = producto.Rows[0][8].ToString();
                }
                catch
                {
                    MessageBox.Show("PRODUCTO ENCONTRADO");
                }
            } else
            {
                try
                {
                    DataTable producto = Datos.EjecutarOrdenSelect("SELECT dp.codigo_barras, ubicacion, p.nombre, caracteristica, precio, m.nombre as marca,  " +
                     " presentacion, pv.nombre as proveedor, c.nombre as categoria FROM detalle_producto as dp, productos as p, marca as m, proveedor as pv, categoria as c where dp.id_producto=p.id_producto and " +
                    " p.marca=m.codigo and p.proveedor=pv.ruc and p.categoria=c.codigo and dp.codigo_barras = '" + tb_codigo_barras.Text.ToString() + "'");
                    tb_codigo_barras.Text = producto.Rows[0][0].ToString();
                    tb_ubicacion.Text = producto.Rows[0][1].ToString();
                    tb_nombre.Text = producto.Rows[0][2].ToString();
                    tb_descripcion.Text = producto.Rows[0][3].ToString();
                    tb_precio.Text = producto.Rows[0][4].ToString();
                    tb_marca.Text = producto.Rows[0][5].ToString();
                    cb_presentacion.Text = producto.Rows[0][6].ToString();
                    tb_proveedor.Text = producto.Rows[0][7].ToString();
                    tb_categoria.Text = producto.Rows[0][8].ToString();
                }
                catch
                {
                    MessageBox.Show("PRODUCTO NUEVO");
                }
            }

        }

        private void insertar_codigos_barra_click(object sender, EventArgs e)
        {
            this.Hide();
            nuevo_detalle.ShowDialog();
            this.Show();
        }
    }


}


public static class globales
{
    public static MySqlConnection Conexion_Alm;
    public static string usuario = string.Empty;
    public static int id = 0;

    public static void buscar_id(string pass)
    {
        int id_admin = 0;
        MySqlDataReader reader = null;
        MySqlCommand cmd = new MySqlCommand("select id from usuario where nombre = '"
            + globales.usuario
            + "' and pass = '"
            + pass + "';", globales.Conexion_Alm);
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            id_admin = reader.GetInt32(0);
        }
        reader.Close();
        globales.id = id_admin;

    }
}
