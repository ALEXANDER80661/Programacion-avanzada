//Alumno: Alexander Rodriguez Santos 
//Activivda 11 - Ejercicio1: Eventos de boton
namespace ActividadFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         string nombre = "Alexander Rodríguez Santos";
         MessageBox.Show("Bienvenido " + nombre, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
