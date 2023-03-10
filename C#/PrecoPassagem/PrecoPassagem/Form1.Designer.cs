namespace PrecoPassagem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPreco = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblCDistancia = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.tbCDistancia = new System.Windows.Forms.TextBox();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbEnunciado = new System.Windows.Forms.GroupBox();
            this.lblLDistancia = new System.Windows.Forms.Label();
            this.tbLDistancia = new System.Windows.Forms.TextBox();
            this.gbEnunciado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(12, 226);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(131, 13);
            this.lblPreco.TabIndex = 20;
            this.lblPreco.Text = "Preço da Passagem: R$ 0";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 254);
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
            this.lblEnunciado.Size = new System.Drawing.Size(248, 65);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = resources.GetString("lblEnunciado.Text");
            // 
            // lblCDistancia
            // 
            this.lblCDistancia.AutoSize = true;
            this.lblCDistancia.Location = new System.Drawing.Point(12, 140);
            this.lblCDistancia.Name = "lblCDistancia";
            this.lblCDistancia.Size = new System.Drawing.Size(119, 13);
            this.lblCDistancia.TabIndex = 16;
            this.lblCDistancia.Text = "Preço Curta Dinstância:";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(12, 114);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(54, 13);
            this.lblDistancia.TabIndex = 15;
            this.lblDistancia.Text = "Distância:";
            // 
            // tbCDistancia
            // 
            this.tbCDistancia.Location = new System.Drawing.Point(137, 137);
            this.tbCDistancia.Name = "tbCDistancia";
            this.tbCDistancia.Size = new System.Drawing.Size(80, 20);
            this.tbCDistancia.TabIndex = 1;
            this.tbCDistancia.TextChanged += new System.EventHandler(this.TextChangedFix);
            this.tbCDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFix);
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(79, 111);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(138, 20);
            this.tbDistancia.TabIndex = 0;
            this.tbDistancia.TextChanged += new System.EventHandler(this.TextChangedFix);
            this.tbDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFix);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(197, 254);
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
            this.gbEnunciado.Size = new System.Drawing.Size(260, 93);
            this.gbEnunciado.TabIndex = 11;
            this.gbEnunciado.TabStop = false;
            this.gbEnunciado.Text = "Enunciado";
            // 
            // lblLDistancia
            // 
            this.lblLDistancia.AutoSize = true;
            this.lblLDistancia.Location = new System.Drawing.Point(12, 166);
            this.lblLDistancia.Name = "lblLDistancia";
            this.lblLDistancia.Size = new System.Drawing.Size(124, 13);
            this.lblLDistancia.TabIndex = 23;
            this.lblLDistancia.Text = "Preço Longa Dinstância:";
            // 
            // tbLDistancia
            // 
            this.tbLDistancia.Location = new System.Drawing.Point(137, 163);
            this.tbLDistancia.Name = "tbLDistancia";
            this.tbLDistancia.Size = new System.Drawing.Size(80, 20);
            this.tbLDistancia.TabIndex = 2;
            this.tbLDistancia.TextChanged += new System.EventHandler(this.TextChangedFix);
            this.tbLDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFix);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.lblLDistancia);
            this.Controls.Add(this.tbLDistancia);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblCDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.tbCDistancia);
            this.Controls.Add(this.tbDistancia);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preço da Passagem";
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
        private System.Windows.Forms.Label lblCDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox tbCDistancia;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbEnunciado;
        private System.Windows.Forms.Label lblLDistancia;
        private System.Windows.Forms.TextBox tbLDistancia;
    }
}

