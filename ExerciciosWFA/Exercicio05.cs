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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
        }
        string carro = "";
        double valor = 0;
        double parcelas = 0;
        int QuantidadeParcelas = 0;

        double ValorTotalDoFinanciamento = 0;
        double DiferencaDeFinanciamento = 0;

        private void MostrarInformacoes()
        {
            string informacoes = String.Format(
                    "Nome do carro: {0}\r\n" + "Valor do carro: {1:n}\r\n" + "Valor de cada parcela: {2:n}\r\n" + "Quantidade de parcelas: {3}\r\n" + "Valor total do financiamento: {4:n}\r\n" + "Diferença entre o valor total do financiamento e valor do carro: {5:n}", carro, valor, parcelas, QuantidadeParcelas, ValorTotalDoFinanciamento, DiferencaDeFinanciamento);

            txtInformacoes.Text = informacoes;
        }
        private void btApresentar_Click(object sender, EventArgs e)
        {

            carro = txtNome.Text;

            try
            {
                if (carro.Length <= 4)
                {
                    MessageBox.Show("Nome do carro precisa conter pelo menos 4 caracters");
                    txtNome.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Preencha novamente");
            }


            if (txtValorDoCarro.Text.Replace(".", "") == "")
            {
                MessageBox.Show("Preencher valor do carro");
                txtValorDoCarro.Focus();
                return;
            }
            try
            {
                valor = Convert.ToDouble(txtValorDoCarro.Text);
            }
            catch
            {
                MessageBox.Show("Preencher valor do carro");
                txtValorDoCarro.Focus();
                return;
            }

            if (txtParcelas.Text.Replace(".", "") == "")
            {
                MessageBox.Show("Preencher o valor das parcelas");
                txtParcelas.Focus();
                return;
            }
            try
            {
                parcelas = Convert.ToDouble(txtParcelas.Text);
            }
            catch
            {
                MessageBox.Show("Preencher o valor das parcelas");
                txtParcelas.Focus();
                return;
            }

            QuantidadeParcelas = Convert.ToInt32(txtQuantidadeDeParcelas.Text);
            if (QuantidadeParcelas == 0)
            {
                MessageBox.Show("Deve conter pelo menos uma parcela");
                txtQuantidadeDeParcelas.Focus();
                return;
            }

            ValorTotalDoFinanciamento = parcelas * QuantidadeParcelas;
            DiferencaDeFinanciamento = ValorTotalDoFinanciamento - valor;

            MostrarInformacoes();
        }
    }
}
