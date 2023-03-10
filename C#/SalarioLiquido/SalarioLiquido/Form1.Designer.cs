namespace SalarioLiquido
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblQuantidadeHoras = new System.Windows.Forms.Label();
            this.lblValorHoras = new System.Windows.Forms.Label();
            this.tbQuantidadeHoras = new System.Windows.Forms.TextBox();
            this.tbValorHoras = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbEnunciado = new System.Windows.Forms.GroupBox();
            this.lblPercentualDesconto = new System.Windows.Forms.Label();
            this.tbPercentualDesconto = new System.Windows.Forms.TextBox();
            this.gbEnunciado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 233);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(107, 13);
            this.lblPreco.TabIndex = 20;
            this.lblPreco.Text = "Salário Líquido: R$ 0";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(11, 261);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(6, 16);
            this.lblEnunciado.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(250, 78);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = resources.GetString("lblEnunciado.Text");
            // 
            // lblQuantidadeHoras
            // 
            this.lblQuantidadeHoras.AutoSize = true;
            this.lblQuantidadeHoras.Location = new System.Drawing.Point(12, 147);
            this.lblQuantidadeHoras.Name = "lblQuantidadeHoras";
            this.lblQuantidadeHoras.Size = new System.Drawing.Size(167, 13);
            this.lblQuantidadeHoras.TabIndex = 16;
            this.lblQuantidadeHoras.Text = "Quantidade de horas trabalhadas:";
            // 
            // lblValorHoras
            // 
            this.lblValorHoras.AutoSize = true;
            this.lblValorHoras.Location = new System.Drawing.Point(12, 121);
            this.lblValorHoras.Name = "lblValorHoras";
            this.lblValorHoras.Size = new System.Drawing.Size(129, 13);
            this.lblValorHoras.TabIndex = 15;
            this.lblValorHoras.Text = "Valor por hora trabalhada:";
            // 
            // tbQuantidadeHoras
            // 
            this.tbQuantidadeHoras.Location = new System.Drawing.Point(185, 144);
            this.tbQuantidadeHoras.Name = "tbQuantidadeHoras";
            this.tbQuantidadeHoras.Size = new System.Drawing.Size(83, 20);
            this.tbQuantidadeHoras.TabIndex = 1;
            this.tbQuantidadeHoras.TextChanged += new System.EventHandler(this.TextChangedFix);
            this.tbQuantidadeHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFix);
            // 
            // tbValorHoras
            // 
            this.tbValorHoras.Location = new System.Drawing.Point(185, 118);
            this.tbValorHoras.Name = "tbValorHoras";
            this.tbValorHoras.Size = new System.Drawing.Size(83, 20);
            this.tbValorHoras.TabIndex = 0;
            this.tbValorHoras.TextChanged += new System.EventHandler(this.TextChangedFix);
            this.tbValorHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFix);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(196, 261);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbEnunciado
            // 
            this.gbEnunciado.Controls.Add(this.lblEnunciado);
            this.gbEnunciado.Location = new System.Drawing.Point(12, 12);
            this.gbEnunciado.Name = "gbEnunciado";
            this.gbEnunciado.Size = new System.Drawing.Size(260, 100);
            this.gbEnunciado.TabIndex = 11;
            this.gbEnunciado.TabStop = false;
            this.gbEnunciado.Text = "Enunciado";
            // 
            // lblPercentualDesconto
            // 
            this.lblPercentualDesconto.AutoSize = true;
            this.lblPercentualDesconto.Location = new System.Drawing.Point(12, 173);
            this.lblPercentualDesconto.Name = "lblPercentualDesconto";
            this.lblPercentualDesconto.Size = new System.Drawing.Size(123, 13);
            this.lblPercentualDesconto.TabIndex = 23;
            this.lblPercentualDesconto.Text = "Percentual de desconto:";
            // 
            // tbPercentualDesconto
            // 
            this.tbPercentualDesconto.Location = new System.Drawing.Point(185, 170);
            this.tbPercentualDesconto.Name = "tbPercentualDesconto";
            this.tbPercentualDesconto.Size = new System.Drawing.Size(83, 20);
            this.tbPercentualDesconto.TabIndex = 2;
            this.tbPercentualDesconto.TextChanged += new System.EventHandler(this.TextChangedFix);
            this.tbPercentualDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFix);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(this.lblPercentualDesconto);
            this.Controls.Add(this.tbPercentualDesconto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblQuantidadeHoras);
            this.Controls.Add(this.lblValorHoras);
            this.Controls.Add(this.tbQuantidadeHoras);
            this.Controls.Add(this.tbValorHoras);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salário Líquido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEnunciado.ResumeLayout(false);
            this.gbEnunciado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblQuantidadeHoras;
        private System.Windows.Forms.Label lblValorHoras;
        private System.Windows.Forms.TextBox tbQuantidadeHoras;
        private System.Windows.Forms.TextBox tbValorHoras;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbEnunciado;
        private System.Windows.Forms.Label lblPercentualDesconto;
        private System.Windows.Forms.TextBox tbPercentualDesconto;
    }
}

