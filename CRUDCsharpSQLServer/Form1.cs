namespace CRUDCsharpSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CAlumnosV objetoAlumnos = new Clases.CAlumnosV();
            objetoAlumnos.mostrarAlumnos(RegistroD);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnosV objetoAlumnos = new Clases.CAlumnosV();
            objetoAlumnos.guardarAlumnos(txtDNI, txtNombres, txtApellidos, txtEdad);
            objetoAlumnos.mostrarAlumnos(RegistroD);
        }

        private void RegistroD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CAlumnosV objetoAlumnos = new Clases.CAlumnosV();
            objetoAlumnos.SeleccionarAlumnos(RegistroD, txtID, txtDNI, txtNombres, txtApellidos, txtEdad);
        }
    }
}
