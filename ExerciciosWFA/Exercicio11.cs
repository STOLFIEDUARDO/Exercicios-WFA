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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void btApresentar_Click(object sender, EventArgs e)
        {

            int dianascimeto = Convert.ToInt32(txtDataNascimento.Text);
            int mesdenascimento = Convert.ToInt32(txtMesNascimento.Text);
            int anodenascimento = Convert.ToInt32(txtAnoNascimento.Text);

            double diasvivo = (2018 - anodenascimento) * 365;
            double anosvivo = 2018 - anodenascimento;
            double mesesvivo = (2018 - anodenascimento) * 12;
            double minutos = (24 * 365) * anosvivo;
            double segundos = (3600 * 365) * anosvivo;

            string mostraraousuario = String.Format(
               "Quantidade de dias Vivo: {0}\r\n" +
               "Quantidade de anos Vivo: {1}\r\n" +
               "Quantidade de meses Vivo: {2}\r\n" +
               "Quantidade de horas Vivo: {3}\r\n" +
               "Quantidade de segundos Vivo {4}",
               diasvivo, anosvivo, mesesvivo, minutos, segundos);

            txtApresentar.Text = mostraraousuario;

            /*

            double diasvivo = (2018 - anodenascimento) * 365;
            Console.WriteLine("Quantidade de dias Vivo: " + diasvivo);
            Console.WriteLine("");

            double anosvivo = 2018 - anodenascimento;
            Console.WriteLine("Quantidade de anos Vivo: " + anosvivo);
            Console.WriteLine("");

            double mesesvivo = (2018 - anodenascimento) * 12;
            Console.WriteLine("Quantidade de meses Vivo: " + mesesvivo);
            Console.WriteLine("");

            double minutos = (24 * 365) * anosvivo;
            Console.WriteLine("Quantidade de horas Vivo: " + minutos);
            Console.WriteLine("");

            double segundos = (3600 * 365) * anosvivo;
            Console.WriteLine("Quantidade de segundos Vivo: " + segundos);
            Console.WriteLine("");*/
        }
    }
}
