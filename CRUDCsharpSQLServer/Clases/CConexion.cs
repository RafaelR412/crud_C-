using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCsharpSQLServer.Clases
{
    internal class CConexion
    {
        SqlConnection conex = new SqlConnection();

        static String servidor = "localhost";
        static String bd = "colegioFB";
        static String usuario = "fabi";
        static String contrasenia = "fabi";
        static String puerto = "1433";

        String cadenaConexion = "Data Source=" + servidor + "," + puerto + ";user id=" + usuario + ";password=" + contrasenia + ";Initial Catalog=" + bd + "Persist Security Info=True";



            public SqlConnection establecerconexion() {
        
            try {

                conex.ConnectionString= cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente a la Base de Datos");
            }
            catch (Exeption ex) {

                MessageBox.Show("No se conecto correctamente a la Base de Datos, Error: "+ ex.ToString());
            }

            return conex;
        }

        public void cerrarConexion(){
        conex.Close();
        }


    }
}
