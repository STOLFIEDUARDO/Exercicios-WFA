namespace ExerciciosWFA
{
    partial class Exercicio07
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
            this.btGerar = new System.Windows.Forms.Button();
            this.txtGerar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGerar
            // 
            this.btGerar.Location = new System.Drawing.Point(63, 235);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(166, 75);
            this.btGerar.TabIndex = 0;
            this.btGerar.Text = "Gerar";
            this.btGerar.UseVisualStyleBackColor = true;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // txtGerar
            // 
            this.txtGerar.Location = new System.Drawing.Point(63, 39);
            this.txtGerar.Multiline = true;
            this.txtGerar.Name = "txtGerar";
            this.txtGerar.Size = new System.Drawing.Size(202, 159);
            this.txtGerar.TabIndex = 1;
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 328);
            this.Controls.Add(this.txtGerar);
            this.Controls.Add(this.btGerar);
            this.Name = "Exercicio07";
            this.Text = "Exercicio07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.TextBox txtGerar;
    }
}