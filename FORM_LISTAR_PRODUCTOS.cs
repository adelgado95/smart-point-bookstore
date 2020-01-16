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
    public partial class FORM_LISTAR_PRODUCTOS : Form
    {
        public String id_producto = String.Empty;
        public Int32 stock = 0;
        public Boolean actualizar = false;
        public DataTable t2 = null;
        public FORM_LISTAR_PRODUCTOS()
        {
            InitializeComponent();
        }

        private void recargar_Click(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void recargar_productos()
        {
            DataTable datos = null;
            if (RadioNombre.Checked == true)
            { 
                if(r_asc.Checked == true)
                { 
                 datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                " stock_individual, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  "+
                " categoria.nombre as categoria  FROM productos, detalle_producto, marca, proveedor, categoria where "+
                " productos.id_producto=detalle_producto.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and "+
                " productos.categoria = categoria.codigo order by productos.nombre asc;");
                }
                else
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " stock_individual, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM productos, detalle_producto, marca, proveedor, categoria where " +
                   " productos.id_producto=detalle_producto.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo order by productos.nombre desc;");
                }
            }

            if (RadioStock.Checked == true)
            {
                if (r_asc.Checked == true)
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " stock_individual, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM productos, detalle_producto, marca, proveedor, categoria where " +
                   " productos.id_producto=detalle_producto.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo order by detalle_producto.stock_individual asc;");
                }
                else
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " stock_individual, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM productos, detalle_producto, marca, proveedor, categoria where " +
                   " productos.id_producto=detalle_producto.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo order by detalle_producto.stock_individual desc;");
                }
            }

            if (RadioCategoria.Checked == true)
            {
                if (r_asc.Checked == true)
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " stock_individual, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM productos, detalle_producto, marca, proveedor, categoria where " +
                   " productos.id_producto=detalle_producto.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo order by productos.categoria asc;");
                }
                else
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " stock_individual, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM productos, detalle_producto, marca, proveedor, categoria where " +
                   " productos.id_producto=detalle_producto.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo order by productos.categoria desc;");
                }
            }

            dgv_productos.DataSource = datos;

            if(dgv_productos.Rows.Count == 0 )
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void FORM_LISTAR_PRODUCTOS_Load(object sender, EventArgs e)
        {
            recargar_productos();
            t2 = Datos.EjecutarOrdenSelect("select dp.codigo_barras from detalle_producto as dp, productos as p, bodega as b where dp.id_producto=p.id_producto and p.id_producto = b.producto;");
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " stock_individual, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM productos, detalle_producto, marca, proveedor, categoria where " +
                   " productos.id_producto=detalle_producto.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo and productos.nombre like '%" + tb_nombre_producto.Text+"%';");

            dgv_productos.DataSource = datos;

            if (dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void reportes_Click(object sender, EventArgs e)
        {
            CONTENEDORREPORTETODOS f = new CONTENEDORREPORTETODOS();
            f.ShowDialog();
        }

        private void tsmi_mandar_bodega_click(object sender, EventArgs e)
        {
            int cantidad = 0;
            FEDITAR cantidad_bodega = new FEDITAR();
            cantidad_bodega.ShowDialog();
            if(cantidad_bodega.editar)
            {
                cantidad = Int32.Parse(cantidad_bodega.cantidad);
                if(cantidad <= stock)
                {
                    if(actualizar)//Se actualiza si se comprueba si el producto existe ya...
                    {
                        int salida = Datos.EjecutarOrden("SET SQL_SAFE_UPDATES = 0;");
                        int salida0 = Datos.EjecutarOrden("update bodega as b, productos as p, detalle_producto as dp set b.cantidad = b.cantidad +"+cantidad+" where b.producto = p.id_producto and p.id_producto = dp.id_producto and dp.codigo_barras = '"+id_producto+"';");
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
                    MessageBox.Show("La cantidad que va a enviar a bodega es mayor que la del inventario","Aviso");
                }
            }

        }

        private void dgv_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { id_producto = dgv_productos.Rows[e.RowIndex].Cells[0].Value.ToString();
                stock = Int32.Parse(dgv_productos.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            catch { }
            for (int i = 0; i < t2.Rows.Count; i++)
            {
                if (id_producto.Equals(t2.Rows[i][0].ToString()))
                {
                    actualizar = true;
                }
            }
        }
    }
}
