using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCsharpSQLServer.Clases
{
    internal class CConexion
    {
        SqlConnection conex = new SqlConnection ();

        // Creacion de Credenciales
        static String servidor = "localhost";
        static String bd = "colegioDBtina";
        static String usuario = "tina";
        static String contrasenia = "tina";
        static String puerto = "1433";

        //Cadena de Conexion
        String cadenaConexion = "Data Source =" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + contrasenia + ";" + "Initial Catalog=" + bd + ";" + "Persist Security info= true";

        //Metodo de Conexion
        public SqlConnection establecerConexion() { 
        
        try{
                conex.ConnectionString = cadenaConexion;
                conex.Open ();
                MessageBox.Show("Se conecto correctamente a la Base de Datos");
            }

        catch (Exception ex){
                MessageBox.Show("NO se conecto correctamente a la Base de Datos, error: "+ ex.ToString());
            }
                return conex;
} 
            public void cerrarConexion() {
               conex.Close();
        }

    }
}