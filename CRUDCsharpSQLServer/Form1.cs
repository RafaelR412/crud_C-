namespace CRUDCsharpSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CConexion objetoConexion = new Clases.CConexion();
            objetoConexion.establecerConexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
