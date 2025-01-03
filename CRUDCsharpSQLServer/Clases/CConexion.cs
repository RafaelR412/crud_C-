using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCsharpSQLServer.Clases
{
    internal class CConexion
    {
        SqlConnection conex = new SqlConnection();

        static String servidor = "localhost";
        static String bd = "colegiofb";
        static String usuario = "fabian";
        static String contrasenia = "fabian";
        static String puerto = "1433";

        String cadenaConexion = "Data Source=" + servidor + "," + puerto + ";Initial Catalog=" + bd + ";User ID=" + usuario + ";Password=" + contrasenia + ";Persist Security Info=True;";



        public SqlConnection establecerconexion() {
        
            try {

                conex.ConnectionString= cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente a la Base de Datos");
            }
            catch (Exception ex) {

                MessageBox.Show("No se conecto correctamente a la Base de Datos, Error: "+ ex.ToString());
            }

            return conex;
        }

        public void cerrarConexion(){
        conex.Close();
        }


    }
}
