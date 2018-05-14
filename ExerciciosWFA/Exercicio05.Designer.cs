namespace ExerciciosWFA
{
    partial class Exercicio05
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
            this.LBNOME = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbparcela = new System.Windows.Forms.Label();
            this.lbMeses = new System.Windows.Forms.Label();
            this.txtQuantidadeDeParcelas = new System.Windows.Forms.TextBox();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.txtValorDoCarro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtInformacoes = new System.Windows.Forms.TextBox();
            this.btApresentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBNOME
            // 
            this.LBNOME.AutoSize = true;
            this.LBNOME.Location = new System.Drawing.Point(12, 29);
            this.LBNOME.Name = "LBNOME";
            this.LBNOME.Size = new System.Drawing.Size(77, 13);
            this.LBNOME.TabIndex = 0;
            this.LBNOME.Text = "Nome do carro";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(12, 55);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(73, 13);
            this.lbValor.TabIndex = 1;
            this.lbValor.Text = "Valor do carro";
            // 
            // lbparcela
            // 
            this.lbparcela.AutoSize = true;
            this.lbparcela.Location = new System.Drawing.Point(12, 83);
            this.lbparcela.Name = "lbparcela";
            this.lbparcela.Size = new System.Drawing.Size(94, 13);
            this.lbparcela.TabIndex = 2;
            this.lbparcela.Text = "Valor das parcelas";
            // 
            // lbMeses
            // 
            this.lbMeses.AutoSize = true;
            this.lbMeses.Location = new System.Drawing.Point(12, 107);
            this.lbMeses.Name = "lbMeses";
            this.lbMeses.Size = new System.Drawing.Size(167, 13);
            this.lbMeses.TabIndex = 3;
            this.lbMeses.Text = "Quantidade de meses financiados";
            // 
            // txtQuantidadeDeParcelas
            // 
            this.txtQuantidadeDeParcelas.Location = new System.Drawing.Point(187, 104);
            this.txtQuantidadeDeParcelas.Name = "txtQuantidadeDeParcelas";
            this.txtQuantidadeDeParcelas.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeDeParcelas.TabIndex = 4;
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(187, 76);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(100, 20);
            this.txtParcelas.TabIndex = 5;
            // 
            // txtValorDoCarro
            // 
            this.txtValorDoCarro.Location = new System.Drawing.Point(187, 52);
            this.txtValorDoCarro.Name = "txtValorDoCarro";
            this.txtValorDoCarro.Size = new System.Drawing.Size(100, 20);
            this.txtValorDoCarro.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(187, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.Location = new System.Drawing.Point(15, 150);
            this.txtInformacoes.Multiline = true;
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.Size = new System.Drawing.Size(237, 162);
            this.txtInformacoes.TabIndex = 8;
            // 
            // btApresentar
            // 
            this.btApresentar.Location = new System.Drawing.Point(299, 211);
            this.btApresentar.Name = "btApresentar";
            this.btApresentar.Size = new System.Drawing.Size(96, 64);
            this.btApresentar.TabIndex = 9;
            this.btApresentar.Text = "Apresentar";
            this.btApresentar.UseVisualStyleBackColor = true;
            this.btApresentar.Click += new System.EventHandler(this.btApresentar_Click);
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 324);
            this.Controls.Add(this.btApresentar);
            this.Controls.Add(this.txtInformacoes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtValorDoCarro);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.txtQuantidadeDeParcelas);
            this.Controls.Add(this.lbMeses);
            this.Controls.Add(this.lbparcela);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.LBNOME);
            this.Name = "Exercicio05";
            this.Text = "Exercicio05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBNOME;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbparcela;
        private System.Windows.Forms.Label lbMeses;
        private System.Windows.Forms.TextBox txtQuantidadeDeParcelas;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.TextBox txtValorDoCarro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtInformacoes;
        private System.Windows.Forms.Button btApresentar;
    }
}