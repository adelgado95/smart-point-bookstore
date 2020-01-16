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
    public partial class REGISTRAR_TRABAJADOR : Form
    {
        int filaselec = -1;
        public REGISTRAR_TRABAJADOR()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (dtTrabajadores.Rows.Count == 0)
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

            for (int i = 0; i < dtTrabajadores.Rows.Count; i++)
            {

                int salida = Datos.EjecutarOrden("insert into trabajadores values('" + dtTrabajadores.Rows[i].Cells[0].Value.ToString() + "',"
                   + "'" + dtTrabajadores.Rows[i].Cells[1].Value.ToString() + "', "
                   + "'" + dtTrabajadores.Rows[i].Cells[2].Value.ToString() + "', "
                   + "'" + dtTrabajadores.Rows[i].Cells[3].Value.ToString() + "', "
                   + "'" + dtTrabajadores.Rows[i].Cells[4].Value.ToString() + "', "
                   + "'" + dtTrabajadores.Rows[i].Cells[5].Value.ToString() + "' "
                   + " );");


                if (salida == -1)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos");
                    return;
                }
                if(i ==  dtTrabajadores.Rows.Count -1 && salida  != -1 )
                {
                    MessageBox.Show("Datos agregados");
                    dtTrabajadores.Rows.Clear();
                }             


            }
        }
        private bool comprobar_ruc()
        {
            for (int i = 0; i < dtTrabajadores.Rows.Count; i++)
            {
                DataTable d = Datos.EjecutarOrdenSelect("SELECT nombre FROM trabajadores WHERE " + "cedula = '" + dtTrabajadores.Rows[i].Cells[0].Value.ToString() + "'"
                   + " ;");
                if (d.Rows.Count > 0)
                {
                    MessageBox.Show("La cédula : '" + dtTrabajadores.Rows[i].Cells[0].Value.ToString().ToUpper() + "' ya existe");
                    return true;
                }

            }
            return false;
        }
        private bool comprobar_existencia()
        {
            for (int i = 0; i < dtTrabajadores.Rows.Count; i++)
            {
                DataTable d = Datos.EjecutarOrdenSelect("SELECT nombre FROM trabajadores WHERE " + "nombre = '" + dtTrabajadores.Rows[i].Cells[1].Value.ToString() + "' and "
                   + "apellido = '" + dtTrabajadores.Rows[i].Cells[2].Value.ToString() + "' and "
                   + "telefono = '" + dtTrabajadores.Rows[i].Cells[3].Value.ToString() + "'"
                   + " ;");
                if (d.Rows.Count > 0)
                {
                    MessageBox.Show("El trabajador : '" + dtTrabajadores.Rows[i].Cells[1].Value.ToString().ToUpper() + "' ya existe");
                    return true;
                }

            }
            return false;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i].Text.Length == 0)
                {
                    MessageBox.Show("Por favor inserte todos los datos");
                    return;
                }
            }

            dtTrabajadores.Rows.Add(txtCedula.Text.ToUpper(),txtNombre.Text.ToUpper(),txtApellido.Text.ToUpper(),txtTelefono.Text.ToUpper(),
                txtSalario.Text.ToUpper(), txtFecha.Text.ToUpper());

            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }
        }

        private void dtTrabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dtTrabajadores.RowCount == 0)
            {
                return;
            }
            dtTrabajadores.Rows.RemoveAt(this.filaselec);
            btEliminar.Enabled = false;
            btEditar.Enabled = false;
            btAgregar.Enabled = true;
            btCancelar1.Enabled = false;

            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }
        }

        private void dtTrabajadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btCancelar1.Enabled = true;
            int f = e.RowIndex;
            this.filaselec = f;
            btEliminar.Enabled = true;
            btEditar.Enabled = true;
            btAgregar.Enabled = false;

             txtCedula.Text = dtTrabajadores.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtTrabajadores.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dtTrabajadores.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dtTrabajadores.CurrentRow.Cells[3].Value.ToString();
            txtSalario.Text = dtTrabajadores.CurrentRow.Cells[4].Value.ToString();
            txtFecha.Text = dtTrabajadores.CurrentRow.Cells[5].Value.ToString();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i].Text.Length == 0)
                {
                    MessageBox.Show("Por favor inserte todos los datos");
                    return;
                }
            }

            dtTrabajadores.Rows.RemoveAt(filaselec);
            dtTrabajadores.Rows.Insert(filaselec,
                txtCedula.Text.ToUpper(), txtNombre.Text.ToUpper(), txtApellido.Text.ToUpper(), txtTelefono.Text.ToUpper(),
                txtSalario.Text.ToUpper(), txtFecha.Text.ToUpper());

            btEliminar.Enabled = false;
            btEditar.Enabled = false;
            btAgregar.Enabled = true;
            btCancelar1.Enabled = false;
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }
        }

        private void btCancelar1_Click(object sender, EventArgs e)
        {
            btEliminar.Enabled = false;
            btEditar.Enabled = false;
            btAgregar.Enabled = true;
            btCancelar1.Enabled = false;
            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }
        }
    }
}
