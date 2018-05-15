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
    public partial class Exercicio08 : Form
    {
        public Exercicio08()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
        
           double ContaLuz = 0, ContaAgua = 0, ContaNET = 0, ContaVivo = 0, ContaOI = 0, ContaIPTU = 0, ContaIPVA = 0, ContaSeguroCarro = 0;


           ContaLuz = Convert.ToDouble(txtContaLuz.Text);

           ContaAgua = Convert.ToDouble(txtContaAgua.Text);

           ContaNET = Convert.ToDouble(txtContaNet.Text);

           ContaVivo = Convert.ToDouble(txtContaVivo.Text);

           ContaOI = Convert.ToDouble(txtContaOi.Text);

           ContaIPTU = Convert.ToDouble(txtContaIPTU.Text);

           ContaIPVA = Convert.ToDouble(txtIPVA.Text);

           ContaSeguroCarro = Convert.ToDouble(txtSeguroCarro.Text);


               double totalTelefonia = ContaOI + ContaVivo + ContaNET, TotalDeImpostos = ContaIPTU + ContaIPVA, TotalRestaurante = ContaLuz + ContaAgua + ContaSeguroCarro;
               double totalContas = TotalDeImpostos + TotalRestaurante + totalTelefonia;

           string mostraraousuario = String.Format(
               "Valor das contas de Telefone: {0}\r\n" +
               "Valor dos impostos: {1}\r\n" +
               "Valor do restante das contas: {2}\r\n" +
               "Valor Total de todas as contas: {3}",
               totalTelefonia, TotalDeImpostos, TotalRestaurante, totalContas);

           txtApresentar.Text = mostraraousuario;
       }
     
        }
    }

