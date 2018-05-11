namespace ExerciciosWFA
{
    partial class Exercicio02
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtAnos = new System.Windows.Forms.TextBox();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de anos consumidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor por Litro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de litros por Dia";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(241, 61);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // txtAnos
            // 
            this.txtAnos.Location = new System.Drawing.Point(241, 35);
            this.txtAnos.Name = "txtAnos";
            this.txtAnos.Size = new System.Drawing.Size(100, 20);
            this.txtAnos.TabIndex = 4;
            // 
            // txtQnt
            // 
            this.txtQnt.Location = new System.Drawing.Point(241, 7);
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(100, 20);
            this.txtQnt.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(15, 117);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(326, 66);
            this.txtResultado.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Apresentar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(387, 276);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtQnt);
            this.Controls.Add(this.txtAnos);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtAnos;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
    }
}