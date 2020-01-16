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
    public partial class FSELECTORPRODUCTO : Form
    {
        public String codigo, nombre, caracteristica, precio, stock, presentacion, marca;
        public String id_producto = String.Empty;
        public Int32 existencia = 0;
        public Boolean actualizar = false;
        public DataTable t2 = null;

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { id_producto = dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString();
                existencia = Int32.Parse(dgv_productos.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch { }
            for(int i = 0; i < t2.Rows.Count; i++)
            {
                if (id_producto.Equals(t2.Rows[i][0].ToString()))
                {
                    actualizar = true;
                }
            }

        }

        private void tsmi_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsmi_mandar_bodega_click(object sender, EventArgs e)
        {
            FEDITAR nuevo_registro_bodega = new FEDITAR();
            int cantidad = 0;
            nuevo_registro_bodega.ShowDialog();
            if (nuevo_registro_bodega.editar)
            {
                cantidad = Int32.Parse(nuevo_registro_bodega.cantidad);
                if (cantidad <= existencia)
                {

                    if(actualizar)//Se actualiza si se comprueba si el producto existe ya...
                    {
                        int salida = Datos.EjecutarOrden("SET SQL_SAFE_UPDATES = 0;");
                        int salida0 = Datos.EjecutarOrden("update bodega as b, productos as p, detalle_producto as dp set b.cantidad = b.cantidad + "+cantidad+" where b.producto = p.id_producto and p.id_producto = dp.id_producto and dp.codigo_barras = '"+id_producto+"';");
                        Datos.CerrarConexion();
                        int salida1 = Datos.EjecutarOrden("UPDATE detalle_producto as dp set dp.stock_individual = dp.stock_individual - "+cantidad+" where dp.codigo_barras = '"+id_producto+"'; ");
                    }
                    else //si el producto no existe entonces se inserta en bodega
                    {
                        int salida = Datos.EjecutarOrden("SET SQL_SAFE_UPDATES = 0;");

                        int salida0 = Datos.EjecutarOrden("INSERT INTO bodega(producto,cantidad,id_detalle_producto) select p.id_producto," + cantidad + ", dp.id_detalle_producto from productos as p, detalle_producto as dp where p.id_producto=dp.id_producto and dp.codigo_barras='" + id_producto + "';");
                        Datos.CerrarConexion();
                        int salida1 = Datos.EjecutarOrden("UPDATE detalle_producto as dp set dp.stock_individual = dp.stock_individual - " + cantidad + " where dp.codigo_barras = '" + id_producto + "'; ");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad que va a enviar a bodega es mayor que la del inventario", "Aviso");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tb_buscar_productos.TextLength == 0)
            {
                //CAMBIAR LA CONSULTA PARA QUE DEVUELVA EL MISMO RESULTADO DEBIDO AL CAMBIO DE LA ESTRUCTURA DE LA TABLA PRODUCTO
                dgv_productos.Rows.Clear();
                DataTable t1 = Datos.EjecutarOrdenSelect("select dp.codigo_barras,p.nombre,p.caracteristica,p.presentacion,p.precio,dp.stock_individual,m.nombre,c.nombre as categoria from detalle_producto as dp, productos as p, marca as m, categoria as c where dp.id_producto = p.id_producto and p.marca=m.codigo and p.categoria = c.codigo and dp.stock_individual > 0;");
                for (int i = 0; i < t1.Rows.Count; i++)
                    dgv_productos.Rows.Add(t1.Rows[i][0].ToString(), t1.Rows[i][1].ToString(), t1.Rows[i][2].ToString(), t1.Rows[i][3].ToString(), t1.Rows[i][4].ToString(), t1.Rows[i][5].ToString(), t1.Rows[i][6].ToString(), t1.Rows[i][7].ToString());
                //dataGridView1.DataSource = Datos.EjecutarOrdenSelect("select p.codigo,ubicacion,p.nombre,caracteristica,precio,stock,m.nombre as marca,presentacion from productos as p , marca as m where p.marca = m.codigo;");
            }
            else {
                dgv_productos.Rows.Clear();
                DataTable t1 = Datos.EjecutarOrdenSelect("select dp.codigo_barras,p.nombre,p.caracteristica,p.presentacion,precio,dp.stock_individual,m.nombre,c.nombre as categoria from detalle_producto as dp, productos as p, marca as m, categoria as c where dp.id_producto = p.id_producto and p.marca=m.codigo and p.categoria = c.codigo and dp.stock_individual > 0 and ( dp.codigo_barras like '%" + tb_buscar_productos.Text+"%' or  p.nombre like '%" + tb_buscar_productos.Text + "%' or  m.nombre like '%" + tb_buscar_productos.Text + "%');");
                for (int i = 0; i < t1.Rows.Count; i++)
                    dgv_productos.Rows.Add(t1.Rows[i][0].ToString(), t1.Rows[i][1].ToString(), t1.Rows[i][2].ToString(), t1.Rows[i][3].ToString(), t1.Rows[i][4].ToString(), t1.Rows[i][5].ToString(), t1.Rows[i][6].ToString(), t1.Rows[i][7].ToString());
                //  dataGridView1.DataSource = Datos.EjecutarOrdenSelect("select p.codigo,ubicacion,p.nombre,caracteristica,precio,stock,m.nombre as marca,presentacion from productos as p , marca as m where p.marca = m.codigo and ( p.codigo like '%"+textBox1.Text+"%' or p.nombre like'%"+textBox1.Text+"%')");
            }
            if (dgv_productos.Rows.Count > 0)
            {
                codigo = dgv_productos.Rows[0].Cells[0].Value.ToString();
                nombre = dgv_productos.Rows[0].Cells[1].Value.ToString();
                caracteristica = dgv_productos.Rows[0].Cells[2].Value.ToString();
                presentacion = dgv_productos.Rows[0].Cells[3].Value.ToString();
                precio = dgv_productos.Rows[0].Cells[4].Value.ToString();
                stock = dgv_productos.Rows[0].Cells[5].Value.ToString();
                marca = dgv_productos.Rows[0].Cells[6].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                codigo = dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombre = dgv_productos.Rows[e.RowIndex].Cells[1].Value.ToString();
                 caracteristica = dgv_productos.Rows[e.RowIndex].Cells[2].Value.ToString();
                presentacion = dgv_productos.Rows[e.RowIndex].Cells[3].Value.ToString();
                precio = dgv_productos.Rows[e.RowIndex].Cells[4].Value.ToString();
                stock = dgv_productos.Rows[e.RowIndex].Cells[5].Value.ToString();
                marca = dgv_productos.Rows[e.RowIndex].Cells[6].Value.ToString();
                bt_aceptar.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public FSELECTORPRODUCTO()
        {
            InitializeComponent();
        }

        private void FSELECTORPRODUCTO_Load(object sender, EventArgs e)
        {
            Datos.EstablecerConexion();
            DataTable t1 = Datos.EjecutarOrdenSelect("select dp.codigo_barras,p.nombre,p.caracteristica,p.presentacion,p.precio,dp.stock_individual,m.nombre,c.nombre as categoria from detalle_producto as dp, productos as p, marca as m, categoria as c where dp.id_producto = p.id_producto and p.marca=m.codigo and p.categoria = c.codigo and dp.stock_individual > 0;");
            Datos.CerrarConexion();
            t2 = Datos.EjecutarOrdenSelect("select dp.codigo_barras from detalle_producto as dp, productos as p, bodega as b where dp.id_producto=p.id_producto and p.id_producto = b.producto;");
            for (int i=0;i<t1.Rows.Count;i++)
            dgv_productos.Rows.Add(t1.Rows[i][0].ToString(), t1.Rows[i][1].ToString(), t1.Rows[i][2].ToString(), t1.Rows[i][3].ToString(), t1.Rows[i][4].ToString(), t1.Rows[i][5].ToString(), t1.Rows[i][6].ToString(), t1.Rows[i][7].ToString());
          //  dataGridView1.DataSource = Datos.EjecutarOrdenSelect("select p.codigo,ubicacion,p.nombre,caracteristica,precio,stock,m.nombre as marca,presentacion from productos as p , marca as m where p.marca = m.codigo;");

        }
    }
}
