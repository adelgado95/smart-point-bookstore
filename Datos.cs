using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LibreriaParraJr
{
    class Datos
    {
        String direccion;
        private static MySqlConnection conn;
        private static MySqlCommand comm;
        private static MySqlDataAdapter adapt;

        public Datos()
        {
            direccion = String.Empty;
            conn = null;
            comm = null;
            adapt = null;
        }
        
        
        public static bool EstablecerConexion()
        {
            //int counter = 0;
            //string line;

            // Read the file and display it line by line.  
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Sistema\config.txt");
            //line = file.ReadLine();
            try
            {
                if (conn != null)
                {
                    return true;
                }
                conn = new MySqlConnection("Server=localhost;Database=libreria_parra; Uid=root;Pwd=IngenieroRoot");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static DataTable EjecutarOrdenSelect(string orden)
        {
            DataTable table = new DataTable();
            try
            {
                try
                {
                    conn.Close();
                }
                catch (Exception e)
                {

                }
                conn.Open();
                comm = new MySqlCommand(orden, conn);
                adapt = new MySqlDataAdapter();
                adapt.SelectCommand = comm;
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapt.Fill(table);
                adapt.Dispose();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            return table;
        }
        public static int EjecutarOrden(string orden)
        {
            int n = 0;
            try
            {
                try
                {
                    conn.Close();
                }
                catch (Exception e)
                {

                }
                conn.Open();
                comm = new MySqlCommand(orden, conn);
                n = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            return n;
        }
        public static void CerrarConexion()
        {
            conn.Close();
        }
    }
}
