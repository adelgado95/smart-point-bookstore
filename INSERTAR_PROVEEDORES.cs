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
    public partial class INSERTAR_PROVEEDORES : Form
    {
        int filaselec = -1;
        public INSERTAR_PROVEEDORES()
        {
            InitializeComponent();
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

            dgv_proveedores.Rows.Add(tb_ruc.Text.ToUpper(),tb_nombre.Text.ToUpper(),tb_direccion.Text.ToUpper(),
                mtb_telefono.Text.ToUpper(), tb_email.Text.ToUpper());

            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }


        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if(dgv_proveedores.RowCount == 0)
            {
                return;
            }
            dgv_proveedores.Rows.RemoveAt(this.filaselec);
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

            dgv_proveedores.Rows.RemoveAt(filaselec);
            dgv_proveedores.Rows.Insert(filaselec,
                tb_ruc.Text.ToUpper(), tb_nombre.Text.ToUpper(), tb_direccion.Text.ToUpper(),
                mtb_telefono.Text.ToUpper(), tb_email.Text.ToUpper());

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bt_cancelar1.Enabled = true;
            int f = e.RowIndex;
            this.filaselec = f;
            bt_eliminar.Enabled = true;
            bt_editar.Enabled = true;
            bt_agregar.Enabled = false;

            tb_ruc.Text = dgv_proveedores.CurrentRow.Cells[0].Value.ToString();
            tb_nombre.Text = dgv_proveedores.CurrentRow.Cells[1].Value.ToString();
            tb_direccion.Text = dgv_proveedores.CurrentRow.Cells[2].Value.ToString();
            mtb_telefono.Text = dgv_proveedores.CurrentRow.Cells[3].Value.ToString();
            tb_email.Text = dgv_proveedores.CurrentRow.Cells[4].Value.ToString();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (dgv_proveedores.Rows.Count == 0)
            {
                MessageBox.Show("No hay proveedor que agregar");
                return;
            }
            if (comprobar_ruc())
            {
                return;
            }

            if (comprobar_existencia())
            {
                return;
            }

            for (int i = 0; i < dgv_proveedores.Rows.Count; i++)
            {

                int salida = Datos.EjecutarOrden("insert into proveedor values('" + dgv_proveedores.Rows[i].Cells[0].Value.ToString() + "',"
                   + "'" + dgv_proveedores.Rows[i].Cells[1].Value.ToString() + "', "
                   + "'" + dgv_proveedores.Rows[i].Cells[2].Value.ToString() + "', "
                   + "'" + dgv_proveedores.Rows[i].Cells[3].Value.ToString() + "', "
                   + "'" + dgv_proveedores.Rows[i].Cells[4].Value.ToString() + "' "
                   + " );");


                if (salida == -1)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos");
                    return;
                }
                if (i == dgv_proveedores.Rows.Count - 1 && salida != -1)
                {
                    MessageBox.Show("Datos agregados");
                    dgv_proveedores.Rows.Clear();
                }


            }
        }

        private bool comprobar_ruc()
        {
            for (int i = 0; i < dgv_proveedores.Rows.Count; i++)
            {
                DataTable d = Datos.EjecutarOrdenSelect("SELECT nombre FROM proveedor WHERE " + "ruc = '" + dgv_proveedores.Rows[i].Cells[0].Value.ToString() + "'"
                   + " ;");
                if (d.Rows.Count > 0)
                {
                    MessageBox.Show("El ruc : '" + dgv_proveedores.Rows[i].Cells[0].Value.ToString().ToUpper() + "' ya existe");
                    return true;
                }

            }
            return false;
        }
        private bool comprobar_existencia()
        {
            for (int i = 0; i < dgv_proveedores.Rows.Count; i++)
            {
                DataTable d = Datos.EjecutarOrdenSelect("SELECT nombre FROM proveedor WHERE " + "nombre = '" + dgv_proveedores.Rows[i].Cells[1].Value.ToString() + "' and "
                   + "direccion = '" + dgv_proveedores.Rows[i].Cells[2].Value.ToString() + "' and "
                   + "telefono = '" + dgv_proveedores.Rows[i].Cells[3].Value.ToString() + "' and "
                   + "email = '" + dgv_proveedores.Rows[i].Cells[4].Value.ToString() + "' "
                   + " ;");
                if (d.Rows.Count > 0)
                {
                    MessageBox.Show("El proveedor : '" + dgv_proveedores.Rows[i].Cells[1].Value.ToString().ToUpper() + "' ya existe");
                    return true;
                }

            }
            return false;
        }
    }
}
