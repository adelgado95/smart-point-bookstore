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

    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            if (Properties.Settings.Default.cordobas.Length > 0)
            {
                txtcor.Text = Properties.Settings.Default.cordobas;
                lblcor.Text = Properties.Settings.Default.cordobas;

            }
            if (globales.tipo_usuario == "CAJERO") //si es un cajero se ocultan las opciones
            {
                bt_reportes.Visible = false; // boton reportes
                bt_creditos.Visible = false; //boton creditos
                txtcor.Hide();
                insertarCategoriaToolStripMenuItem1.Visible = false;
                insertarClienteToolStripMenuItem1.Visible = false;
                listaProveedorToolStripMenuItem1.Visible = false;
                listaUsuariosToolStripMenuItem1.Visible = false;
                registrarCajeroToolStripMenuItem1.Visible = false;
                
            }

            if (Properties.Settings.Default.fecha_cerrado < DateTime.Today)
            {
                Properties.Settings.Default.fecha_cerrado = DateTime.Today;
                Properties.Settings.Default.caja_estado = false;
                Properties.Settings.Default.Save();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Usuario: " + globales.usuario.ToUpper();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_ventas f1 = new form_ventas();
            if (globales.tipo_usuario == "CAJERO")
            {
                f1.nud_descuento.Maximum = 10;
            }
            else
            {
                f1.nud_descuento.Maximum = 20;
            }
            f1.Location = new Point(110, 50);
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FORMENTRADAS nueva_entrada = new FORMENTRADAS();
            nueva_entrada.Location = new Point(110, 50);
            nueva_entrada.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FORMREPORTES nuevo_reporte = new FORMREPORTES();
            nuevo_reporte.Location = new Point(110, 50);
            nuevo_reporte.ShowDialog();
        }

        private void insertarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INSERTAR_MARCA nuevo_marca = new INSERTAR_MARCA();
            nuevo_marca.Location = new Point(110, 50);
            nuevo_marca.ShowDialog();
        }

        private void insertarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INSERTAR_PROVEEDORES nuevo_proveedor = new INSERTAR_PROVEEDORES();
            nuevo_proveedor.Location = new Point(110, 50);
            nuevo_proveedor.ShowDialog();
        }

        private void insertarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INSERTAR_CLIENTE nuevo_cliente = new INSERTAR_CLIENTE();
            nuevo_cliente.Location = new Point(110, 50);
            nuevo_cliente.ShowDialog();
        }

        private void insertarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INSERTAR_CATEGORIA nuevo_categoria = new INSERTAR_CATEGORIA();
            nuevo_categoria.Location = new Point(110, 50);
            nuevo_categoria.ShowDialog();
        }

        private void insertarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INSERTAR_EMPRESA nuevo_empresa = new INSERTAR_EMPRESA();
            nuevo_empresa.Location = new Point(110, 50);
            nuevo_empresa.ShowDialog();
        }

        private void bt_devolucion_click(object sender, EventArgs e)
        {
            FORM_DEVOLUCION nueva_devolucion = new FORM_DEVOLUCION();
            nueva_devolucion.Location = new Point(110, 50);
            nueva_devolucion.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FORMCREDITO nueva_devolucion = new FORMCREDITO();
            nueva_devolucion.Location = new Point(110, 50);
            nueva_devolucion.ShowDialog();
        }

        private void actualizarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_ACTUALIZAR_STOCK stock = new FORM_ACTUALIZAR_STOCK();
            stock.Location = new Point(110, 50);
            stock.ShowDialog();
        }

        private void registrarCajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRAR_CAJERO stock = new REGISTRAR_CAJERO();
            stock.Location = new Point(110, 50);
            stock.ShowDialog();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_LISTAR_PRODUCTOS listar = new FORM_LISTAR_PRODUCTOS();
            listar.Location = new Point(110, 50);
            listar.ShowDialog();
        }

        private void listaProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_LISTAR_PROVEEDOR proveedor = new FORM_LISTAR_PROVEEDOR();
            proveedor.Location = new Point(110, 50);
            proveedor.ShowDialog();
        }

        private void listaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_LISTAR_USUARIOS usuarios = new FORM_LISTAR_USUARIOS();
            usuarios.Location = new Point(110, 50);
            usuarios.ShowDialog();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_LISTAR_CLIENTE cliente = new FORM_LISTAR_CLIENTE();
            cliente.Location = new Point(110, 50);
            cliente.ShowDialog();
        }

        private void cambiarContraseaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_CAMBIO_PASSWORD cliente = new FORM_CAMBIO_PASSWORD();
            cliente.Location = new Point(110, 50);
            cliente.ShowDialog();
        }

        private void cambiarContraseaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FORM_CAMBIO_PASSWORD cliente = new FORM_CAMBIO_PASSWORD();
            cliente.Location = new Point(110, 50);
            cliente.ShowDialog();
        }

        private void insertarCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            INSERTAR_CATEGORIA cliente = new INSERTAR_CATEGORIA();
            cliente.Location = new Point(110, 50);
            cliente.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTARFACTURAS_ cliente = new CONSULTARFACTURAS_();
            cliente.Location = new Point(110, 50);
            cliente.ShowDialog();

        }

        private void txtcor_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.cordobas = txtcor.Text;
            Properties.Settings.Default.Save();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registrarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRAR_GASTOS gastos = new REGISTRAR_GASTOS();
            gastos.Location = new Point(110, 50);
            gastos.ShowDialog();
        }

        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CERRAR_CAJA caja = new CERRAR_CAJA();
            caja.Location = new Point(110, 50);
            caja.ShowDialog();
            this.Dispose();
        }

        private void registrarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTRAR_TRABAJADOR caja = new REGISTRAR_TRABAJADOR();
            caja.Location = new Point(110, 50);
            caja.ShowDialog();
        }

        private void listarTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_LISTAR_TRABAJADORES caja = new FORM_LISTAR_TRABAJADORES();
            caja.Location = new Point(110, 50);
            caja.ShowDialog();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            REGISTRAR_PAGO_TRABAJADOR caja = new REGISTRAR_PAGO_TRABAJADOR();
            caja.Location = new Point(110, 50);
            caja.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FORM_VER_CAJA caja = new FORM_VER_CAJA();
            caja.Location = new Point(110, 50);
            caja.ShowDialog();
        }

        private void tsmi_insertar_credito(object sender, EventArgs e)
        {
            INSERTAR_CREDITO nuevo_credito = new INSERTAR_CREDITO();
            nuevo_credito.ShowDialog();
        }

        private void tsmi_listar_bodega_click(object sender, EventArgs e)
        {
            FORM_LISTAR_BODEGA nueva_vista_bodega = new FORM_LISTAR_BODEGA();
            nueva_vista_bodega.ShowDialog();
        }

        private void fotocopiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
                       
            if (controlImpresora1.Visible == false)
            {
                controlImpresora1.BringToFront();
                controlImpresora1.actualizar_servicios();
                controlImpresora1.Visible = true;
            }
            else
            {
                controlImpresora1.Visible = false;
            }
        }
    }
}
