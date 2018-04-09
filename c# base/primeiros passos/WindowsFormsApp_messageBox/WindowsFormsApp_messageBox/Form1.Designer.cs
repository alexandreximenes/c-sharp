namespace WindowsFormsApp_messageBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_messageBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_messageBox
            // 
            this.btn_messageBox.Location = new System.Drawing.Point(108, 173);
            this.btn_messageBox.Name = "btn_messageBox";
            this.btn_messageBox.Size = new System.Drawing.Size(172, 23);
            this.btn_messageBox.TabIndex = 0;
            this.btn_messageBox.Text = "Abrir MessageBox";
            this.btn_messageBox.UseVisualStyleBackColor = true;
            this.btn_messageBox.Click += new System.EventHandler(this.btn_messageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 208);
            this.Controls.Add(this.btn_messageBox);
            this.Name = "Form1";
            this.Text = "MessageBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_messageBox;
    }
}

