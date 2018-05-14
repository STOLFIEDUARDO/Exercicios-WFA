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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
         
            int numero = Convert.ToInt32(txtNumeroo.Text);

            int x0 = numero * 0;
            int x1 = numero * 1;
            int x2 = numero * 2;
            int x3 = numero * 3;
            int x4 = numero * 4;
            int x5 = numero * 5;
            int x6 = numero * 6;
            int x7 = numero * 7;
            int x8 = numero * 8;
            int x9 = numero * 9;
            int x10 = numero * 10;

            string tabuada = String.Format(
                "{0} x 0 = {1}\r\n" +
                "{0} x 1 = {2}\r\n" +
                "{0} x 2 = {3}\r\n" +
                "{0} x 3 = {4}\r\n" +
                "{0} x 4 = {5}\r\n" +
                "{0} x 5 = {6}\r\n" +
                "{0} x 6 = {7}\r\n" +
                "{0} x 7 = {8}\r\n" +
                "{0} x 8 = {9}\r\n" +
                "{0} x 9 = {10}\r\n" +
                "{0} x 10 = {11}\r\n", numero, x0, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10
                );

            txtResultado.Text = tabuada;
        }
        }

      
    }

