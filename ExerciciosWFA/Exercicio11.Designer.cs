namespace ExerciciosWFA
{
    partial class Exercicio11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.txtMesNascimento = new System.Windows.Forms.TextBox();
            this.txtApresentar = new System.Windows.Forms.TextBox();
            this.btApresentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia Do nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano do nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes do nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(105, 31);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 3;
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(105, 84);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtAnoNascimento.TabIndex = 4;
            // 
            // txtMesNascimento
            // 
            this.txtMesNascimento.Location = new System.Drawing.Point(105, 58);
            this.txtMesNascimento.Name = "txtMesNascimento";
            this.txtMesNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtMesNascimento.TabIndex = 5;
            // 
            // txtApresentar
            // 
            this.txtApresentar.Location = new System.Drawing.Point(12, 123);
            this.txtApresentar.Multiline = true;
            this.txtApresentar.Name = "txtApresentar";
            this.txtApresentar.Size = new System.Drawing.Size(195, 92);
            this.txtApresentar.TabIndex = 6;
            // 
            // btApresentar
            // 
            this.btApresentar.Location = new System.Drawing.Point(84, 240);
            this.btApresentar.Name = "btApresentar";
            this.btApresentar.Size = new System.Drawing.Size(107, 37);
            this.btApresentar.TabIndex = 7;
            this.btApresentar.Text = "Apresentar";
            this.btApresentar.UseVisualStyleBackColor = true;
            this.btApresentar.Click += new System.EventHandler(this.btApresentar_Click);
            // 
            // Exercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 289);
            this.Controls.Add(this.btApresentar);
            this.Controls.Add(this.txtApresentar);
            this.Controls.Add(this.txtMesNascimento);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio11";
            this.Text = "Exercicio11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.TextBox txtMesNascimento;
        private System.Windows.Forms.TextBox txtApresentar;
        private System.Windows.Forms.Button btApresentar;
    }
}