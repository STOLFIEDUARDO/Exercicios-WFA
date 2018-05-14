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
    public partial class Exercicio06 : Form
    {
        public Exercicio06()
        {
            InitializeComponent();
        }

        private void btCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota01 = 0;
            double nota02 = 0;
            double nota03 = 0;
            double nota04 = 0;

            nota01 = Convert.ToDouble(txtNota1.Text);
            nota02 = Convert.ToDouble(txtNota2.Text);
            nota03 = Convert.ToDouble(txtNota3.Text);
            nota04 = Convert.ToDouble(txtNota4.Text);

            double media = (nota01 + nota02 + nota03 + nota04) / 4;
            string textoMedia = String.Format("{0:n}", media);

            txtResultado.Text = textoMedia;
        }
    }
}
