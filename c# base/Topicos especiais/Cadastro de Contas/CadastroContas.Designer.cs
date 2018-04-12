namespace MinhasContas
{
    partial class CadastroContas
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.tbTitular = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btTelaPrincipal = new System.Windows.Forms.Button();
            this.tbSaldoInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(167, 196);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(154, 23);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // tbTitular
            // 
            this.tbTitular.Location = new System.Drawing.Point(51, 34);
            this.tbTitular.Name = "tbTitular";
            this.tbTitular.Size = new System.Drawing.Size(270, 20);
            this.tbTitular.TabIndex = 1;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(51, 91);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(270, 20);
            this.tbNumero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titular da Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero da Conta";
            // 
            // btTelaPrincipal
            // 
            this.btTelaPrincipal.Location = new System.Drawing.Point(51, 196);
            this.btTelaPrincipal.Name = "btTelaPrincipal";
            this.btTelaPrincipal.Size = new System.Drawing.Size(115, 23);
            this.btTelaPrincipal.TabIndex = 5;
            this.btTelaPrincipal.Text = "Tela principal";
            this.btTelaPrincipal.UseVisualStyleBackColor = true;
            this.btTelaPrincipal.Click += new System.EventHandler(this.btTelaPrincipal_Click);
            // 
            // tbSaldoInicial
            // 
            this.tbSaldoInicial.Location = new System.Drawing.Point(51, 148);
            this.tbSaldoInicial.Name = "tbSaldoInicial";
            this.tbSaldoInicial.Size = new System.Drawing.Size(270, 20);
            this.tbSaldoInicial.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saldo Inicial";
            // 
            // CadastroContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSaldoInicial);
            this.Controls.Add(this.btTelaPrincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbTitular);
            this.Controls.Add(this.btCadastrar);
            this.Name = "CadastroContas";
            this.Text = "CadastroContas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox tbTitular;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTelaPrincipal;
        private System.Windows.Forms.TextBox tbSaldoInicial;
        private System.Windows.Forms.Label label3;
    }
}