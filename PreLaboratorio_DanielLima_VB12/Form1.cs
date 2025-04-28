using System.DirectoryServices.ActiveDirectory;

namespace PreLaboratorio_DanielLima_VB12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "MessiRonaldo2025")
            {
                CRUD v1 = new CRUD();
                v1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("La contraseña es incorrecta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Credito v1 = new Credito();
            v1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
