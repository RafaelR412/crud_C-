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
                     "values('" + paramDNI.Text + "','" + paramNombres.Text + "','" + paramApellidos.Text + "','" + paramEdad.Text + "');";

                SqlCommand mycomando = new SqlCommand(Query, objetoconexion.establecerconexion());
                SqlDataReader myreader;
                myreader = mycomando.ExecuteReader();

                while (myreader.Read()) {

                }

                MessageBox.Show("Se guardo correctamente");

                objetoconexion.cerrarConexion();


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro mostrar los registros, error: " + ex.ToString());
            }

        }

        public void seleccionarAlumnos(DataGridView tablaAlumnos, TextBox paramCodigo, TextBox paramDNI, TextBox paramNombres, TextBox paramApellidos, TextBox paramEdad) {

            try { 
            
                paramCodigo.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                paramDNI.Text = tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                paramNombres.Text = tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
                paramApellidos.Text = tablaAlumnos.CurrentRow.Cells[3].Value.ToString();
                paramEdad.Text = tablaAlumnos.CurrentRow.Cells[4].Value.ToString();
            }

            catch (Exeption ex) {
                MessageBox.Show("No se logro seleccionar los registros, error: " + ex.ToString());


            }

        }

        internal void seleccionarAlumnos(DataGridView dgvAlumnos, TextBox txtID, TextBox txtDNI)
        {
            throw new NotImplementedException();
        }

        public void ModificarAlumnos(TextBox paramID, TextBox paramDNI, TextBox paramNombres, TextBox paramApellidos, TextBox paramEdad)
        {


            CConexion objetoconexion = new CConexion();

            try
            {

                string Query = "UPDATE alumnos set alumnos.dni ='" +
                     paramDNI.Text + "', alumnos.nombres='" + paramNombres.Text + "', alumnos.apellidos='" + paramApellidos.Text + "', alumnos.edad='" + paramEdad.Text + "' WHERE alumnos.codigo ='" + paramID.Text + "';";

                SqlCommand mycomando = new SqlCommand(Query, objetoconexion.establecerconexion());
                SqlDataReader myreader;
                myreader = mycomando.ExecuteReader();
                
                MessageBox.Show("Se modifico correctamente");

                while (myreader.Read())
                {

                }

                

                objetoconexion.cerrarConexion();


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro modificar los registros, error: " + ex.ToString());
            }

        }

        public void EliminarAlumnos(TextBox paramID)
        {


            CConexion objetoconexion = new CConexion();

            try
            {

                string Query = "DELETE FROM alumnos WHERE alumnos.codigo='"+paramID.Text+"';";

                SqlCommand mycomando = new SqlCommand(Query, objetoconexion.establecerconexion());
                SqlDataReader myreader;
                myreader = mycomando.ExecuteReader();

                MessageBox.Show("Se elimino correctamente");

                while (myreader.Read())
                {

                }



                objetoconexion.cerrarConexion();


            }
            catch (Exception ex)
            {

                MessageBox.Show("No se logro eliminar los registros, error: " + ex.ToString());
            }

        }

    }
}
