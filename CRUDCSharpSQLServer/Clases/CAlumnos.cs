using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCSharpSQLServer.Clases
{
    internal class CAlumnos
    {

        public void mostrarAlumnos(DataGridView tablaAlumnos)
        {


            CConexion objetoConexion = new CConexion();

            try
            {

                tablaAlumnos.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter("select * from alumnos;", objetoConexion.establecerConexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaAlumnos.DataSource = dt;
                objetoConexion.CerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }

        }

        public void GuardarAlumnos(TextBox paramDNI, TextBox paramNombres, TextBox paramApellidos, TextBox paramEdad)
        {


            CConexion objetoConexion = new CConexion();

            try
            {

                String Query = "insert into alumnos (dni,nombres,apellidos,edad)" +
                    "values('" + paramDNI.Text + "','" + paramNombres.Text + "','" + paramApellidos.Text + "','" + paramEdad.Text + "');";

                SqlCommand myComando = new SqlCommand(Query, objetoConexion.establecerConexion());
                SqlDataReader myReader;
                myReader = myComando.ExecuteReader();

                while (myReader.Read())
                {

                }

                MessageBox.Show("Se guardo correctamente");

                objetoConexion.CerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }

        }

        public void SeleccionarAlumnos(DataGridView tablaAlumnos, TextBox paramCodigo, TextBox paramDNI, TextBox paramNombres, TextBox paramApellidos, TextBox paramEdad)
        {

            try
            {

                paramCodigo.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                paramDNI.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                paramNombres.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
                paramApellidos.Text = tablaAlumnos.CurrentRow.Cells[3].Value.ToString();
                paramEdad.Text = tablaAlumnos.CurrentRow.Cells[4].Value.ToString();

            }

            catch (Exception ex)
            {
                MessageBox.Show("No se logró Seleccionar los registros, error: " + ex.ToString());

            }
        }

        public void ModificarAlumnos(TextBox paramID, TextBox paramDNI, TextBox paramNombres, TextBox paramApellidos, TextBox paramEdad)
        {


            CConexion objetoConexion = new CConexion();

            try
            {

                String Query = "UPDATE alumnos set  alumnos.dni ='" +
                    paramDNI.Text + "', alumnos.nombres ='" + paramNombres.Text + "', alumnos.apellidos ='" + paramApellidos.Text + "', alumnos.Edad ='" + paramEdad.Text + "' WHERE alumnos.codigo ='" + paramID.Text + "';";

                SqlCommand myComando = new SqlCommand(Query, objetoConexion.establecerConexion());
                SqlDataReader myReader;
                myReader = myComando.ExecuteReader();

                MessageBox.Show("Se modifico correctamente");

                while (myReader.Read())
                {

                }



                objetoConexion.CerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro modificar los registros, error: " + ex.ToString());
            }

        }
        public void EliminarAlumnos(TextBox paramID)
        {


            CConexion objetoConexion = new CConexion();

            try
            {

                String Query = "DELETE FROM alumnos WHERE alumnos.codigo='" + paramID.Text + "';";

                SqlCommand myComando = new SqlCommand(Query, objetoConexion.establecerConexion());
                SqlDataReader myReader;
                myReader = myComando.ExecuteReader();

                MessageBox.Show("Se elimino correctamente");

                while (myReader.Read())
                {

                }



                objetoConexion.CerrarConexion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro eliminar los registros, error: " + ex.ToString());
            }


        }
    }
}
