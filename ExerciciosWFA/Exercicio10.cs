using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosWFA
{
    public partial class Exercicio10 : Form
    {
        public Exercicio10()
        {
            InitializeComponent();
        }

        private void btApresentarI_Click(object sender, EventArgs e)
        {

            int numeroAnoDeNascimento = Convert.ToInt32(txtDataNascimento.Text);
            int idade = 2018 - numeroAnoDeNascimento;

            string mostraraousuario = String.Format(
                "Idade: {0}\r\n", idade);

            txtApresentar.Text = mostraraousuario;
            /*Console.Write("Ano de nascimento: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            double idade = 2018 - numero;

            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("");*/
        }
    }
}
