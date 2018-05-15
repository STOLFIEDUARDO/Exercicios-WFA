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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double numero1 = 0, numero2 = 0;

            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);

            numero1 = numero1 + numero2;
            numero2 = numero1 - numero2;
            numero1 = numero1 - numero2;
            
            string mostraraousuario = String.Format(
                "Numero1: {0}\r\n" +
                "numero2: {1}\r\n", 
                numero1, numero2);

            txtApresentar.Text = mostraraousuario;
           /* Console.Write("Numero 1: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Numero 2: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            numero1 = numero2;

            Console.WriteLine("Numero 1: ");
            Console.WriteLine("Numero 2: ");*/
        }
    }
}
