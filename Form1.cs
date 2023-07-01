namespace Tarea4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 classTest= new Class1();
            if (classTest.Ok())
            {
                MessageBox.Show("Conectado");
            }
            else
            {
                MessageBox.Show("No se conecto");
            }

        }
    }
}