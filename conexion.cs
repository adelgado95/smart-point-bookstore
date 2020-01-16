using MySql.Data.MySqlClient;  //se utiliza para conexion a la base de datos mysql
using System; //todo el sistema
using System.Collections.Generic; // Espacio de nombres de la lista 
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //en esta clase se utiliza para mostrar el Message Box 

namespace LibreriaParraJr
{
    class conexion //por defecto internal, puede ser accedida por cualquier clase en el ensamblado
    {
        private static MySqlCommand cmd;
        private static MySqlDataAdapter da;
        private static MySqlConnection local_connection = null;
        /*
        Metodo utilizado para realizar la conexion a la base de datos
        nivel de acceso: public                ====> puede ser accedido desde cualquier clase dentro del espacio de nombres
        tipo de metodo: static                 ====> Metodo Estático para modificar su valor desde cualquier clase sin necesidad de crear una instancia
        tipo de retorno: void                  ====> no retorna nada, solo realiza la operacion de conectar
        nombre metodo : conectar               ====> nombre con el cual se identifica
        Parametros:                            ====> no recibe
        */
        public static void conectar()
        {
            if (local_connection != null) return; //Se verifica si hay una conexion abierta a la base de datos, para evitar abrir otra
            local_connection = new MySqlConnection();   //se inicializa
            local_connection.ConnectionString = "Server=127.0.0.1; Uid=root; Pwd='IngenieroRoot'; Database=libreria_parra"; //datos de conexion
            try
            {
                local_connection.Open();  //se abre la conexion a la base de datos
            }
            //en el caso de que de error nos indique en que tenemos error, imprimiendo el mensaje de MySqlException
            catch (MySqlException ex)
            {
                //mensaje de error de conexion
                MessageBox.Show("No hemos podido conectar con la base de datos.\n Error: "
                    + ex.Message, "Error de conexion");
                local_connection = null;
            }
        }

        /*
        Metodo utilizado para ejecutar consultas de cualquier tipo
        nivel de acceso: public                ====> puede ser accedido desde cualquier clase dentro del espacio de nombres
        tipo de metodo: static                 ====> Metodo Estático para modificar su valor desde cualquier clase sin necesidad de crear una instancia
        tipo de retorno: List<List<String>>    ====> Doble Lista de String para simular una tabla
        nombre metodo : ejecutar_consulta      ====> nombre con el cual se identifica
        Parametros: MysqlCommand               ====> recibe un Comando Parametrizado para evitar inyeccion sql        
        */
        public static List<List<String>> ejecutar_consulta(MySqlCommand comando)
        {
            List<List<String>> datos = new List<List<String>>(); //doble lista de string temporal local al metodo 
            List<String> item = new List<String>(); // lista para ir agregando dentro de la doble lista
            int i;  //iterador del data_reader
            conectar();  //llamado al metodo estatico conectar()
            if (local_connection == null) return datos;  //si no hay conexion que se retorne
            MySqlCommand instrucion = comando;//se recibe el comando desde la instancia del metodo
            instrucion.Connection = local_connection;  //se le indica al comando la conexion a utilizar para realizar la consulta
            MySqlDataReader data_reader;   //lector de datos
            try
            {
                data_reader = instrucion.ExecuteReader(); //ejecucion de la consulta a la base de datos y obtencion de los datos 
                while (data_reader.Read()) //leer cada instancia del data_reader
                {
                    item.Clear();//eliminar cualquier referencia de memoria de la lista
                    for (i = 0; i < data_reader.FieldCount; i++) //ejecutar la operacion hasta completar el ultimo dato
                    {
                        item.Add(data_reader[i].ToString()); //agregamos cada dato a la lista de manera secuencial
                    }
                    datos.Add(new List<String>(item));  //agregar cada lista a la lista de listas de cadenas
                }
                data_reader.Dispose(); //eliminar la memoria de data_reader
            }
            //en el caso de error, nos indica cual es el error
            catch (MySqlException ex)
            {
                MessageBox.Show("No hemos podido hacer la consulta a la base de datos. Consulte al desarrollador sobre el siguiente error: \n\n" + ex.Message, "Error de consulta");
            }
            return datos; //nos retorna la doble lista
        }
        /*/
        Metodo utilizado para realizar operaciones de escritura en la base de datos INSERT, DELETE, UPDATE
        nivel de acceso: public                ====> puede ser accedido desde cualquier clase dentro del espacio de nombres
        tipo de metodo: static                 ====> Metodo Estático para modificar su valor desde cualquier clase sin necesidad de crear una instancia
        tipo de retorno: int                   ====> retorna un numero de filas afectadas diferentes a cero
        nombre metodo : ejecutar_comando       ====> nombre con el cual se identifica
        Parametros: MysqlCommand               ====> recibe un Comando Parametrizado para evitar inyeccion sql
        */

        public static int ejecutar_comando( MySqlCommand comando )
        {
            int filas_afectadas = 0;  //numero de filas que se insertaron, borraron o actualizaron
            conectar();  // se realiza la conexion en el caso de que no haya
            if (local_connection == null) return 0; // retornar un valor cero en el caso de que no haya conexion
            MySqlCommand instruccion = comando;  //recepcion del comando parametrizado
            instruccion.Connection = local_connection;  //indicar al MySqlCommand que conexion utilizar
            try
            {
                filas_afectadas = instruccion.ExecuteNonQuery(); //ejecucion de la operacion, donde el metodo ExecuteNonQuery retorna el numero de filas afectadas
            }
            //en el caso de error en la operacion imprimir un mensaje
            catch (MySqlException ex)
            {
                MessageBox.Show("No hemos podido actualizar la base de datos. \nError:  "
                    + ex.Message, "Error de comando");
            }
            return filas_afectadas; //se devuelve el numero de filas afectadas diferente a cero
        }

        /*/
        Metodo utilizado para cerrar la conexion a la base de datos
        nivel de acceso: public                ====> puede ser accedido desde cualquier clase dentro del espacio de nombres
        tipo de metodo: static                 ====> Metodo Estático para modificar su valor desde cualquier clase sin necesidad de crear una instancia
        tipo de retorno: void                  ====> sin valor de retorno, solo cierra la conexion a la base de datos
        nombre metodo : mysql_close            ====> nombre con el cual se identifica
        Parametros:                            ====> no recibe
        */

        public static void mysql_close()
        {
            local_connection.Close();//cerramos la conexion
            local_connection.Dispose(); //eliminamos cualquier referencia en memoria
            local_connection = null;  //apuntamos a null y no a otra referencia
        }


        public static DataTable EjecutarOrdenSelect(MySqlCommand comando)
        {
            DataTable table = new DataTable();
            try
            {
                conectar();
                if (local_connection == null) return table;
                cmd = comando;
                cmd.Connection = local_connection;
                da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                da.Fill(table);
                da.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }


        public static int EjecutarOrden(MySqlCommand comando)
        {
            int n = 0;
            conectar();
            if (local_connection == null) return 0;
            try
            {
                cmd = comando;
                cmd.Connection = local_connection;
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return n;
        }
    }
}
