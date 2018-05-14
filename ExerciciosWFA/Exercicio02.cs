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
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidadeDeLitrosPorDia = 0, quantidadeDeLitrosPorAno = 0;
            double valorlitro = 0;

            quantidadeDeLitrosPorDia = Convert.ToInt32(txtQnt.Text);
            quantidadeDeLitrosPorAno = Convert.ToInt32(txtAnos.Text);
            valorlitro = Convert.ToDouble(txtValor.Text);
            double quantidadelitros = (quantidadeDeLitrosPorDia * 365 * quantidadeDeLitrosPorAno);
            double valortotalpago = (valorlitro * quantidadelitros);


            string textao = string.Format("Quantidade de Litros consumido: {0}\r\nValor total Pago: {1}\r\n",
                                           quantidadelitros, valortotalpago);
            txtResultado.Text = textao;


            /*double quantidadelitros = (quantidadepordia * 365) * (quantidadeporano);
            Console.WriteLine("Quantidade de Litros consumido: " + quantidadelitros);

            double valortotalpago = (valorlitro * quantidadelitros);
            Console.WriteLine("Valor total Pago: " + valortotalpago);
             * 
             * 
           /* double numero = 0;
            numero = Convert.ToDouble(//txtNumero.Text);
            
            
            string //textao = string.Format("Antecessor: {0}\r\nSucessor: {1}\r\n",
                                           //sucessor, antecessor);
            txtResultado.Text = //textao;*/
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
