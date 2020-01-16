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
    public partial class INSERTAR_CLIENTE : Form
    {
        int filaselec = -1;
        public INSERTAR_CLIENTE()
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

            dgv_clientes.Rows.Add(tb_ruc.Text.ToUpper(), tb_nombre.Text.ToUpper(), tb_direccion.Text.ToUpper(),
                mtb_telefono.Text.ToUpper(), tb_email.Text.ToUpper());

            for (int i = 0; i < this.datos.Controls.Count; i++)
            {
                if (this.datos.Controls[i] is TextBox || this.datos.Controls[i] is MaskedTextBox)
                    datos.Controls[i].Text = string.Empty;
            }


        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            dgv_clientes.Rows.RemoveAt(this.filaselec);
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

            dgv_clientes.Rows.RemoveAt(filaselec);
            dgv_clientes.Rows.Insert(filaselec,
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

            tb_ruc.Text = dgv_clientes.CurrentRow.Cells[0].Value.ToString();
            tb_nombre.Text = dgv_clientes.CurrentRow.Cells[1].Value.ToString();
            tb_direccion.Text = dgv_clientes.CurrentRow.Cells[2].Value.ToString();
            mtb_telefono.Text = dgv_clientes.CurrentRow.Cells[3].Value.ToString();
            tb_email.Text = dgv_clientes.CurrentRow.Cells[4].Value.ToString();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (dgv_clientes.Rows.Count == 0)
            {
                MessageBox.Show("No hay marcas que agregar");
                return;
            }
            for (int i = 0; i < dgv_clientes.Rows.Count; i++)
            {

                int salida = Datos.EjecutarOrden("insert into cliente values('" + dgv_clientes.Rows[i].Cells[0].Value.ToString() + "',"
                   + "'" + dgv_clientes.Rows[i].Cells[1].Value.ToString() + "', "
                   + "'" + dgv_clientes.Rows[i].Cells[2].Value.ToString() + "', "
                   + "'" + dgv_clientes.Rows[i].Cells[3].Value.ToString() + "', "
                   + "'" + dgv_clientes.Rows[i].Cells[4].Value.ToString() + "' "
                   + " );");


                if (salida == -1)
                {
                    MessageBox.Show("Asegurese de que todos los datos esten correctos");
                    return;
                }
                else
                {
                    MessageBox.Show("Datos agregados");
                    dgv_clientes.Rows.Clear();
                    return;
                }


            }
        }
    }
}
