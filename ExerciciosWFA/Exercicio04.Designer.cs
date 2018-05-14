namespace ExerciciosWFA
{
    partial class Exercicio04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtNumeroo = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lbTabuada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.AutoSize = true;
            this.txtNumero.Location = new System.Drawing.Point(12, 21);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 13);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Text = "Numero";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(265, 119);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(111, 78);
            this.btCalcular.TabIndex = 1;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtNumeroo
            // 
            this.txtNumeroo.Location = new System.Drawing.Point(62, 18);
            this.txtNumeroo.Name = "txtNumeroo";
            this.txtNumeroo.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroo.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(53, 108);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 202);
            this.txtResultado.TabIndex = 3;
            // 
            // lbTabuada
            // 
            this.lbTabuada.AutoSize = true;
            this.lbTabuada.Location = new System.Drawing.Point(50, 75);
            this.lbTabuada.Name = "lbTabuada";
            this.lbTabuada.Size = new System.Drawing.Size(50, 13);
            this.lbTabuada.TabIndex = 4;
            this.lbTabuada.Text = "Tabuada";
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 322);
            this.Controls.Add(this.lbTabuada);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumeroo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtNumero);
            this.Name = "Exercicio04";
            this.Text = "Exercicio04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNumero;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.TextBox txtNumeroo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lbTabuada;
    }
}