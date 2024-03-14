using System.Windows.Forms.Design;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Button de calcular
        {
            float soma, media, valor;
            soma = 0;
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                }
                media = soma / 4;
                this.Controls["label7"].Text = media.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)//Limpar de calcular
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            { if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
                this.Controls["label7"].Text = "...";
                
            }
        }
    }
}
