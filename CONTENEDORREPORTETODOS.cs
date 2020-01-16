using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Drawing.Printing.PrinterSettings;

namespace LibreriaParraJr
{
    public partial class CONTENEDORREPORTETODOS : Form
    {
        public CONTENEDORREPORTETODOS()
        {
            InitializeComponent();
        }

        private void CONTENEDORREPORTETODOS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Conjunto1.DataTable4' Puede moverla o quitarla según sea necesario.
            this.DataTable4TableAdapter.Fill(this.Conjunto1.DataTable4);

            this.reportViewer1.RefreshReport();
        }
    }
}
