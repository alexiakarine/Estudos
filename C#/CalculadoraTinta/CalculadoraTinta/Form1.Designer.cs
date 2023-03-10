namespace AlturaLargura
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
            this.gbEnunciado = new System.Windows.Forms.GroupBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.tbLargura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.lblMetrosAltura = new System.Windows.Forms.Label();
            this.lblMetrosLargura = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.gbEnunciado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEnunciado
            // 
            this.gbEnunciado.Controls.Add(this.lblEnunciado);
            this.gbEnunciado.Location = new System.Drawing.Point(12, 12);
            this.gbEnunciado.Name = "gbEnunciado";
            this.gbEnunciado.Size = new System.Drawing.Size(260, 78);
            this.gbEnunciado.TabIndex = 0;
            this.gbEnunciado.TabStop = false;
            this.gbEnunciado.Text = "Enunciado";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(6, 16);
            this.lblEnunciado.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(244, 52);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Faça um programa que leia a altura e a largura de uma parede em metros, calcule a" +
                " sua área e a quantidade de tinta para pintá-la sabendo que cada litro de tinta," +
                " pinta uma área de 2m².";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(197, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(79, 96);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(138, 20);
            this.tbAltura.TabIndex = 2;
            this.tbAltura.TextChanged += new System.EventHandler(this.TextChangedFix);
            this.tbAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFix);
            // 
            // tbLargura
            // 
            this.tbLargura.Location = new System.Drawing.Point(79, 122);
            this.tbLargura.Name = "tbLargura";
            this.tbLargura.Size = new System.Drawing.Size(138, 20);
            this.tbLargura.TabIndex = 3;
            this.tbLargura.TextChanged += new System.EventHandler(this.TextChangedFix);
            this.tbLargura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressFix);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(12, 99);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura:";
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(12, 125);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(46, 13);
            this.lblLargura.TabIndex = 5;
            this.lblLargura.Text = "Largura:";
            // 
            // lblMetrosAltura
            // 
            this.lblMetrosAltura.AutoSize = true;
            this.lblMetrosAltura.Location = new System.Drawing.Point(223, 99);
            this.lblMetrosAltura.Name = "lblMetrosAltura";
            this.lblMetrosAltura.Size = new System.Drawing.Size(39, 13);
            this.lblMetrosAltura.TabIndex = 6;
            this.lblMetrosAltura.Text = "Metros";
            // 
            // lblMetrosLargura
            // 
            this.lblMetrosLargura.AutoSize = true;
            this.lblMetrosLargura.Location = new System.Drawing.Point(223, 125);
            this.lblMetrosLargura.Name = "lblMetrosLargura";
            this.lblMetrosLargura.Size = new System.Drawing.Size(39, 13);
            this.lblMetrosLargura.TabIndex = 7;
            this.lblMetrosLargura.Text = "Metros";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 208);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 157);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(55, 13);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Área: 0 m²";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(12, 180);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(86, 13);
            this.lblLitros.TabIndex = 10;
            this.lblLitros.Text = "Litros de Tinta: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblMetrosLargura);
            this.Controls.Add(this.lblMetrosAltura);
            this.Controls.Add(this.lblLargura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.tbLargura);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Tinta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEnunciado.ResumeLayout(false);
            this.gbEnunciado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEnunciado;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.TextBox tbLargura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblMetrosAltura;
        private System.Windows.Forms.Label lblMetrosLargura;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblLitros;
    }
}

