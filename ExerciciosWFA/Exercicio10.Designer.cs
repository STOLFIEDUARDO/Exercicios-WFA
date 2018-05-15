namespace ExerciciosWFA
{
    partial class Exercicio10
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
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.txtApresentar = new System.Windows.Forms.TextBox();
            this.btApresentarI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano de nascimento ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sua idade";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(119, 27);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 2;
            // 
            // txtApresentar
            // 
            this.txtApresentar.Location = new System.Drawing.Point(61, 89);
            this.txtApresentar.Multiline = true;
            this.txtApresentar.Name = "txtApresentar";
            this.txtApresentar.Size = new System.Drawing.Size(138, 50);
            this.txtApresentar.TabIndex = 3;
            // 
            // btApresentarI
            // 
            this.btApresentarI.Location = new System.Drawing.Point(82, 178);
            this.btApresentarI.Name = "btApresentarI";
            this.btApresentarI.Size = new System.Drawing.Size(99, 39);
            this.btApresentarI.TabIndex = 4;
            this.btApresentarI.Text = "Apresentar Idade";
            this.btApresentarI.UseVisualStyleBackColor = true;
            this.btApresentarI.Click += new System.EventHandler(this.btApresentarI_Click);
            // 
            // Exercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btApresentarI);
            this.Controls.Add(this.txtApresentar);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio10";
            this.Text = "Exercicio10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtApresentar;
        private System.Windows.Forms.Button btApresentarI;
    }
}