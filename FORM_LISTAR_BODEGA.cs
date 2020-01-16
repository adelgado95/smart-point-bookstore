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
    public partial class FORM_LISTAR_BODEGA : Form
    {
        string id_producto = string.Empty;
        int fila_seleccionada = -1;
        public FORM_LISTAR_BODEGA()
        {
            InitializeComponent();
        }

        private void recargar_productos()
        {
            DataTable datos = null;
            if (RadioNombre.Checked == true)
            {
                if (r_asc.Checked == true)
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " bodega.cantidad, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM bodega, productos, detalle_producto, marca, proveedor, categoria where " +
                   " detalle_producto.id_producto=productos.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo and bodega.id_detalle_producto=detalle_producto.id_detalle_producto group by id_registro order by productos.nombre asc;");
                }
                else
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " bodega.cantidad, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM bodega, productos, detalle_producto, marca, proveedor, categoria where " +
                   " bodega.producto = productos.id_producto and detalle_producto.id_producto=productos.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo and bodega.id_detalle_producto=detalle_producto.id_detalle_producto group by id_registro order by productos.nombre desc;");
                }
            }

            if (RadioStock.Checked == true)
            {
                if (r_asc.Checked == true)
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " bodega.cantidad, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM bodega, productos, detalle_producto, marca, proveedor, categoria where " +
                   " bodega.producto = productos.id_producto and detalle_producto.id_producto=productos.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo and bodega.id_detalle_producto=detalle_producto.id_detalle_producto group by id_registro order by detalle_producto.stock_individual asc;");
                }
                else
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " bodega.cantidad, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM bodega, productos, detalle_producto, marca, proveedor, categoria where " +
                   " bodega.producto = productos.id_producto and detalle_producto.id_producto=productos.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo and bodega.id_detalle_producto=detalle_producto.id_detalle_producto group by id_registro order by detalle_producto.stock_individual desc;");
                }
            }

            if (RadioCategoria.Checked == true)
            {
                if (r_asc.Checked == true)
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " bodega.cantidad, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM bodega, productos, detalle_producto, marca, proveedor, categoria where " +
                   " bodega.producto = productos.id_producto and detalle_producto.id_producto=productos.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo and bodega.id_detalle_producto=detalle_producto.id_detalle_producto group by id_registro order by productos.categoria asc;");
                }
                else
                {
                    datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " bodega.cantidad, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM bodega, productos, detalle_producto, marca, proveedor, categoria where " +
                   " bodega.producto = productos.id_producto and detalle_producto.id_producto=productos.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo and bodega.id_detalle_producto=detalle_producto.id_detalle_producto group by id_registro order by productos.categoria desc;");
                }
            }

            dgv_productos.DataSource = datos;

            if (dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void FORM_LISTAR_BODEGA_Load(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void bt_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            DataTable datos = Datos.EjecutarOrdenSelect("SELECT detalle_producto.codigo_barras, ubicacion, productos.nombre, caracteristica, precio, " +
                   " bodega.cantidad, marca.nombre as marca, presentacion, proveedor.nombre as proveedor,  " +
                   " categoria.nombre as categoria  FROM bodega, productos, detalle_producto, marca, proveedor, categoria where " +
                   " bodega.producto = productos.id_producto and detalle_producto.id_producto=productos.id_producto and marca.codigo = productos.marca and productos.proveedor = proveedor.ruc and " +
                   " productos.categoria = categoria.codigo and bodega.id_detalle_producto=detalle_producto.id_detalle_producto and productos.nombre like '%" + tb_nombre_producto.Text + "%' group by id_registro order by productos.nombre asc;");

            dgv_productos.DataSource = datos;

            if (dgv_productos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron datos");
                return;
            }
        }

        private void RadioNombre_CheckedChanged(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void RadioStock_CheckedChanged(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void RadioCategoria_CheckedChanged(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void r_asc_CheckedChanged(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void r_desc_CheckedChanged(object sender, EventArgs e)
        {
            recargar_productos();
        }

        private void mandarAInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fila_seleccionada < 0) { MessageBox.Show("SELECCIONE UN PRODUCTO"); return; }
            FEDITAR nuevo_registro_a_inventario = new FEDITAR();
            int cantidad = 0;
            nuevo_registro_a_inventario.ShowDialog();
            if (nuevo_registro_a_inventario.editar)
            {
                cantidad = Int32.Parse(nuevo_registro_a_inventario.cantidad);

                int salida = Datos.EjecutarOrden("SET SQL_SAFE_UPDATES = 0;");
                int salida0 = Datos.EjecutarOrden("update bodega as b, productos as p, detalle_producto as dp set b.cantidad = b.cantidad - " + cantidad + " where b.id_detalle_producto = dp.id_detalle_producto and p.id_producto = dp.id_producto and dp.codigo_barras = '" + id_producto + "';");
                Datos.CerrarConexion();
                int salida1 = Datos.EjecutarOrden("UPDATE detalle_producto as dp set dp.stock_individual = dp.stock_individual + " + cantidad + " where dp.codigo_barras = '" + id_producto + "'; ");
            }
        }

        private void dgv_productos_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            id_producto = dgv_productos.CurrentRow.Cells[0].Value.ToString();
            fila_seleccionada = e.RowIndex; 
        }
    }
}
