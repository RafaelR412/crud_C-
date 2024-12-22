using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCsharpSQLServer.Clases
{
    internal class CAlumnosV
    {
        public void mostrarAlumnos(DataGridView tablaAlumnosV) {

            CConexion objetoConexion = new CConexion(); 

            try{
                tablaAlumnosV.DataSource = null;

                SqlDataAdapter adapter = new SqlDataAdapter("Select*from alumnos",objetoConexion.establecerConexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                tablaAlumnosV.DataSource =dt;
                objetoConexion.cerrarConexion();

            }

            catch (Exception ex) {

                MessageBox.Show("NO se logra mostrar los registros, error: "+ ex.ToString());
            
            } 
       }   


        public void guardarAlumnos(TextBox paramDNI, TextBox paramNombres, TextBox paramApellidos, TextBox paramEdad)
        {

            CConexion objetoConexion = new CConexion();

            try
            {
                String Query = "insert into alumnos (dni,nombres,apellidos,edad)" +
                "values('"+ paramDNI.Text + "','" + paramNombres.Text + "','" + paramApellidos.Text + "','" + paramEdad.Text +"')";

                SqlCommand myComando = new SqlCommand(Query, objetoConexion.establecerConexion());
                SqlDataReader myReader;
                myReader = myComando.ExecuteReader();

                while(myReader.Read()) {
                }

                MessageBox.Show("Se guardo correctamente");


                objetoConexion.cerrarConexion();

            }

            catch (Exception ex)
            {

                MessageBox.Show("NO se logro GUARDAR los registros, error: " + ex.ToString());

            }
        }

        public void SeleccionarAlumnos(DataGridView TablaAlumnos, TextBox paramCodigo, TextBox paramDNI, TextBox paramNombres, TextBox paramApellidos, TextBox paramEdad)
        {

            try{
                paramCodigo.Text = TablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                paramDNI.Text = TablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                paramNombres.Text = TablaAlumnos.CurrentRow.Cells[2].Value.ToString();
                paramApellidos.Text = TablaAlumnos.CurrentRow.Cells[3].Value.ToString();
                paramEdad.Text = TablaAlumnos.CurrentRow.Cells[4].Value.ToString();

            }

            catch (Exception ex){
                MessageBox.Show("NO se logro seleccionar el registro, error: "+ ex.ToString());
            }
        }

    }
}