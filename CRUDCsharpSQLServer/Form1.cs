namespace CRUDCsharpSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CAlumnos ObjetoAlumnos = new Clases.CAlumnos();
            ObjetoAlumnos.mostraralumnos(dgvAlumnos);

            TxtID. Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos ObjetoAlumnos = new Clases.CAlumnos();
            ObjetoAlumnos.Guardarlumnos(txtDNI, txtNombres, txtApellidos, txtEdad);
            ObjetoAlumnos.mostraralumnos(dgvAlumnos);

            TxtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAlumnos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CAlumnos ObjetoAlumnos = new Clases.CAlumnos();
            ObjetoAlumnos.seleccionarAlumnos(dgvAlumnos, TxtID, txtDNI, txtNombres, txtApellidos, txtEdad);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos ObjetoAlumnos = new Clases.CAlumnos();
            ObjetoAlumnos.ModificarAlumnos(TxtID, txtDNI, txtNombres, txtApellidos, txtEdad);
            ObjetoAlumnos.mostraralumnos(dgvAlumnos);

            TxtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CAlumnos ObjetoAlumnos = new Clases.CAlumnos();
            ObjetoAlumnos.EliminarAlumnos(TxtID);
            ObjetoAlumnos.mostraralumnos(dgvAlumnos);

            TxtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEdad.Text = "";

        }
    }
}
