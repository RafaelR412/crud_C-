namespace CRUDCSharpSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.mostrarAlumnos(dgvAlumnos);

            txtID.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.ModificarAlumnos(txtID, txtDNI, txtNombres, txtApellidos, txtEdad);
            objetoAlumnos.mostrarAlumnos(dgvAlumnos);
            txtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.GuardarAlumnos(txtDNI, txtNombres, txtApellidos, txtEdad);
            objetoAlumnos.mostrarAlumnos(dgvAlumnos);

            txtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
        }

        private void dgvAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.SeleccionarAlumnos(dgvAlumnos, txtID, txtDNI, txtNombres, txtApellidos, txtEdad);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos objetoAlumnos = new Clases.CAlumnos();
            objetoAlumnos.EliminarAlumnos(txtID);
            objetoAlumnos.mostrarAlumnos(dgvAlumnos);
            txtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
        }
    }
}
