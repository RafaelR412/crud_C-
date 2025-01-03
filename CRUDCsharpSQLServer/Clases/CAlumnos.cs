using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCsharpSQLServer.Clases
{
    internal class CAlumnos
    {

        public void mostraralumnos(DataGridView tablaAlumnos) { 
        

            CConexion objetoconexion = new CConexion();

            try{

                tablaAlumnos.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter("Select * from alumnos;", objetoconexion.establecerconexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaAlumnos.DataSource = dt;

                objetoconexion.cerrarConexion();


            }
            catch (Exception ex) { 
            
                MessageBox.Show("No se logro mostrar los registros, error: "+ ex.ToString());
            }

            }

        public void Guardarlumnos(TextBox paramDNI, TextBox paramNombres, TextBox paramApellidos, TextBox paramEdad)
        {


            CConexion objetoconexion = new CConexion();

            try
            {

                string Query = "insert into alumnos (dni,nombres,apellidos,edad)" +
                     "values(´" + paramDNI + "´,´" + paramNombres + "´,´" + paramApellidos + "´´,´" + paramEdad + "´);";

                SqlCommand mycomando = new SqlCommand(Query, objetoconexion.establecerconexion());

                objetoconexion.cerrarConexion();


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }

        }

    }
}
