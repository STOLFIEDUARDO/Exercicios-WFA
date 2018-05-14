namespace ExerciciosWFA
{
    partial class Exercicio06
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
            this.btCalcularMedia = new System.Windows.Forms.Button();
            this.lbNota1 = new System.Windows.Forms.Label();
            this.lbNota2 = new System.Windows.Forms.Label();
            this.lbNota3 = new System.Windows.Forms.Label();
            this.lbNota4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCalcularMedia
            // 
            this.btCalcularMedia.Location = new System.Drawing.Point(258, 121);
            this.btCalcularMedia.Name = "btCalcularMedia";
            this.btCalcularMedia.Size = new System.Drawing.Size(97, 51);
            this.btCalcularMedia.TabIndex = 0;
            this.btCalcularMedia.Text = "Calcular Média";
            this.btCalcularMedia.UseVisualStyleBackColor = true;
            this.btCalcularMedia.Click += new System.EventHandler(this.btCalcularMedia_Click);
            // 
            // lbNota1
            // 
            this.lbNota1.AutoSize = true;
            this.lbNota1.Location = new System.Drawing.Point(12, 36);
            this.lbNota1.Name = "lbNota1";
            this.lbNota1.Size = new System.Drawing.Size(36, 13);
            this.lbNota1.TabIndex = 1;
            this.lbNota1.Text = "Nota1";
            // 
            // lbNota2
            // 
            this.lbNota2.AutoSize = true;
            this.lbNota2.Location = new System.Drawing.Point(12, 62);
            this.lbNota2.Name = "lbNota2";
            this.lbNota2.Size = new System.Drawing.Size(36, 13);
            this.lbNota2.TabIndex = 2;
            this.lbNota2.Text = "Nota2";
            // 
            // lbNota3
            // 
            this.lbNota3.AutoSize = true;
            this.lbNota3.Location = new System.Drawing.Point(12, 95);
            this.lbNota3.Name = "lbNota3";
            this.lbNota3.Size = new System.Drawing.Size(36, 13);
            this.lbNota3.TabIndex = 3;
            this.lbNota3.Text = "Nota3";
            // 
            // lbNota4
            // 
            this.lbNota4.AutoSize = true;
            this.lbNota4.Location = new System.Drawing.Point(12, 121);
            this.lbNota4.Name = "lbNota4";
            this.lbNota4.Size = new System.Drawing.Size(36, 13);
            this.lbNota4.TabIndex = 4;
            this.lbNota4.Text = "Nota4";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(64, 29);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 20);
            this.txtNota1.TabIndex = 5;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(64, 114);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 20);
            this.txtNota4.TabIndex = 6;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(64, 88);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 20);
            this.txtNota3.TabIndex = 7;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(64, 55);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 20);
            this.txtNota2.TabIndex = 8;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(239, 29);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(133, 68);
            this.txtResultado.TabIndex = 9;
            // 
            // Exercicio06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 247);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lbNota4);
            this.Controls.Add(this.lbNota3);
            this.Controls.Add(this.lbNota2);
            this.Controls.Add(this.lbNota1);
            this.Controls.Add(this.btCalcularMedia);
            this.Name = "Exercicio06";
            this.Text = "Exercicio06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalcularMedia;
        private System.Windows.Forms.Label lbNota1;
        private System.Windows.Forms.Label lbNota2;
        private System.Windows.Forms.Label lbNota3;
        private System.Windows.Forms.Label lbNota4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtResultado;
    }
}