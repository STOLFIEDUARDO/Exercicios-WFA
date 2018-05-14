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
    public partial class Exercicio03 : Form
    {

        public Exercicio03()
        {
            InitializeComponent();
        }

        private void btApresentar_Click(object sender, EventArgs e)
        {
                         
            double numero01 = Convert.ToDouble(txtNumero1.Text);
            double numero02 = Convert.ToDouble(txtNumero2.Text);
 
            double Soma = numero01 + numero02;
            double Subtracao = numero01 - numero02;
            double Multiplicacao = numero01 * numero02;
            double Divisao = (numero01 / numero02);
            double Produtos = Soma + Subtracao + Multiplicacao + Divisao;
 
             string resultado = String.Format(
                 "Soma: {0}\r\n" + "Subtração: {1}\r\n" + "Multiplicação: {2}\r\n" + "Divisão: {3:n}\r\n" + "Produto dos valores: {4}", Soma, Subtracao, Multiplicacao, Divisao, Produtos);
 
             txtResultado.Text = resultado;
        }
     
    }
}
