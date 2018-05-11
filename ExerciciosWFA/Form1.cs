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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double antecessor = 0, sucessor = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double numero = 0; 
            numero = Convert.ToDouble(txtNumero.Text);
            antecessor = numero + 1;
           // MessageBox.Show("Antecessor: " + antecessor);
            sucessor = numero - 1;
           // MessageBox.Show("Sucessor: " + sucessor);
            string textao = string.Format("Antecessor: {0}\r\nSucessor: {1}\r\n",
                                           sucessor, antecessor);
           txtResultado.Text = textao;
        }
    }
}
