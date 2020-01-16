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
    public partial class INSERTAR_CREDITO : Form
    {
        int filaselec = -1;
        DataTable empresas = null;
        DataTable entidad = null;
        public INSERTAR_CREDITO()
        {
            InitializeComponent();
        }

        private void INSERTAR_CREDITO_Load(object sender, EventArgs e)
        {

            empresas = Datos.EjecutarOrdenSelect("select ruc, nombre from proveedor;");

            for (int i = 0; i < empresas.Rows.Count; i++)
            {
                cb_proveedor.Items.Add(empresas.Rows[i][1].ToString());
            }

            entidad = Datos.EjecutarOrdenSelect("select codigo, nombre from empresa;");

            for (int i = 0; i < entidad.Rows.Count; i++)
            {
                cb_empresas.Items.Add(entidad.Rows[i][1].ToString());
            }
        }


        private void agregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i].Text.Length == 0)
                {
                    MessageBox.Show("Por favor inserte todos los datos");
                    return;
                }
            }

            dgv_creditos.Rows.Add(cb_proveedor.SelectedItem.ToString().ToUpper(), cb_empresas.SelectedItem.ToString().ToUpper(), mtb_fecha.Text.ToUpper(), tb_total.Text.ToUpper());

            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }


        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_creditos.RowCount == 0)
            {
                return;
            }
            dgv_creditos.Rows.RemoveAt(this.filaselec);
            bt_eliminar.Enabled = false;
            bt_editar.Enabled = false;
            bt_agregar.Enabled = true;
            bt_cancelar1.Enabled = false;

            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }
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

            dgv_creditos.Rows.RemoveAt(filaselec);
            dgv_creditos.Rows.Insert(filaselec,
              cb_proveedor.SelectedItem.ToString().ToUpper(), cb_empresas.SelectedItem.ToString().ToUpper(),
                mtb_fecha.Text.ToUpper(), tb_total.Text.ToUpper());

            bt_eliminar.Enabled = false;
            bt_editar.Enabled = false;
            bt_agregar.Enabled = true;
            bt_cancelar1.Enabled = false;
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }
        }

        private void cancelar1_Click(object sender, EventArgs e)
        {
            bt_eliminar.Enabled = false;
            bt_editar.Enabled = false;
            bt_agregar.Enabled = true;
            bt_cancelar1.Enabled = false;
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }
        }

        private void dgv_creditos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_cancelar1.Enabled = true;
            int f = e.RowIndex;
            this.filaselec = f;
            bt_eliminar.Enabled = true;
            bt_editar.Enabled = true;
            bt_agregar.Enabled = false;

            cb_proveedor.SelectedItem = dgv_creditos.CurrentRow.Cells[0].Value.ToString();
            cb_empresas.SelectedItem = dgv_creditos.CurrentRow.Cells[1].Value.ToString();
            mtb_fecha.Text = dgv_creditos.CurrentRow.Cells[2].Value.ToString();
            tb_total.Text = dgv_creditos.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            int codigo_proveedor = 0, codigo_empresa = 0;

            if (dgv_creditos.Rows.Count == 0)
            {
                MessageBox.Show("No hay marcas que agregar");
                return;
            }

            for (int i = 0; i < dgv_creditos.Rows.Count; i++)
            {
                codigo_proveedor = obtener_codigo_proveedor(dgv_creditos.Rows[i].Cells[0].Value.ToString());
                codigo_empresa = obtener_codigo_empresa(dgv_creditos.Rows[i].Cells[1].Value.ToString());

                int salida = Datos.EjecutarOrden("insert into credito(fecha_final,empresa,total,estado,proveedor) values('" + dgv_creditos.Rows[i].Cells[2].Value.ToString() + "',"
                   + "'" + codigo_empresa + "', "
                   + "'" + dgv_creditos.Rows[i].Cells[3].Value.ToString() + "', "
                   + "'PENDIENTE',"
                   + "'" + codigo_proveedor + "' "
                   + " );");


                if (salida == -1)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos");
                    return;
                }

            }

            MessageBox.Show("Datos agregados");
            dgv_creditos.Rows.Clear();
            cb_empresas.SelectedIndex = 0;
            cb_proveedor.SelectedIndex = 0;
            mtb_fecha.Text = String.Empty;
            tb_total.Text = String.Empty;
            return;
        }

        private int obtener_codigo_proveedor(String proveedor)
        {
            for (int i = 0; i < empresas.Rows.Count; i++)
            {
                if(empresas.Rows[i][1].ToString().Equals(proveedor))
                {
                    return Int32.Parse(empresas.Rows[i][0].ToString());
                }
            }
            return 0;
        }

        private int obtener_codigo_empresa(String empresa)
        {
            for (int i = 0; i < entidad.Rows.Count; i++)
            {
                if (entidad.Rows[i][1].ToString().Equals(empresa))
                {
                    return Int32.Parse(entidad.Rows[i][0].ToString());
                }
            }
            return 0;
        }
    }
}
