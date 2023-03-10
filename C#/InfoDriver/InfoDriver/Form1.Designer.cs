namespace InfoDriver
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblEspacoLivre = new System.Windows.Forms.Label();
            this.lblTipoDrive = new System.Windows.Forms.Label();
            this.lblNomeDrive = new System.Windows.Forms.Label();
            this.gbInfoArquivo = new System.Windows.Forms.GroupBox();
            this.lblDataAtualizacaoArquivo = new System.Windows.Forms.Label();
            this.lblHorarioCriacaoArquivo = new System.Windows.Forms.Label();
            this.lblDataCriacaoArquivo = new System.Windows.Forms.Label();
            this.lblTamanhoArquivo = new System.Windows.Forms.Label();
            this.lblNomeArquivo = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbInfo.SuspendLayout();
            this.gbInfoArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblEspacoLivre);
            this.gbInfo.Controls.Add(this.lblTipoDrive);
            this.gbInfo.Controls.Add(this.lblNomeDrive);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(295, 64);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info do Drive";
            // 
            // lblEspacoLivre
            // 
            this.lblEspacoLivre.AutoSize = true;
            this.lblEspacoLivre.Location = new System.Drawing.Point(6, 42);
            this.lblEspacoLivre.Name = "lblEspacoLivre";
            this.lblEspacoLivre.Size = new System.Drawing.Size(72, 13);
            this.lblEspacoLivre.TabIndex = 2;
            this.lblEspacoLivre.Text = "Espaço Livre:";
            // 
            // lblTipoDrive
            // 
            this.lblTipoDrive.AutoSize = true;
            this.lblTipoDrive.Location = new System.Drawing.Point(6, 29);
            this.lblTipoDrive.Name = "lblTipoDrive";
            this.lblTipoDrive.Size = new System.Drawing.Size(59, 13);
            this.lblTipoDrive.TabIndex = 1;
            this.lblTipoDrive.Text = "Tipo Drive:";
            // 
            // lblNomeDrive
            // 
            this.lblNomeDrive.AutoSize = true;
            this.lblNomeDrive.Location = new System.Drawing.Point(6, 16);
            this.lblNomeDrive.Name = "lblNomeDrive";
            this.lblNomeDrive.Size = new System.Drawing.Size(66, 13);
            this.lblNomeDrive.TabIndex = 0;
            this.lblNomeDrive.Text = "Nome Drive:";
            // 
            // gbInfoArquivo
            // 
            this.gbInfoArquivo.Controls.Add(this.lblDataAtualizacaoArquivo);
            this.gbInfoArquivo.Controls.Add(this.lblHorarioCriacaoArquivo);
            this.gbInfoArquivo.Controls.Add(this.lblDataCriacaoArquivo);
            this.gbInfoArquivo.Controls.Add(this.lblTamanhoArquivo);
            this.gbInfoArquivo.Controls.Add(this.lblNomeArquivo);
            this.gbInfoArquivo.Controls.Add(this.btnAbrir);
            this.gbInfoArquivo.Location = new System.Drawing.Point(12, 82);
            this.gbInfoArquivo.Name = "gbInfoArquivo";
            this.gbInfoArquivo.Size = new System.Drawing.Size(295, 113);
            this.gbInfoArquivo.TabIndex = 1;
            this.gbInfoArquivo.TabStop = false;
            this.gbInfoArquivo.Text = "Info do Arquivo";
            // 
            // lblDataAtualizacaoArquivo
            // 
            this.lblDataAtualizacaoArquivo.AutoSize = true;
            this.lblDataAtualizacaoArquivo.Location = new System.Drawing.Point(6, 68);
            this.lblDataAtualizacaoArquivo.Name = "lblDataAtualizacaoArquivo";
            this.lblDataAtualizacaoArquivo.Size = new System.Drawing.Size(106, 13);
            this.lblDataAtualizacaoArquivo.TabIndex = 5;
            this.lblDataAtualizacaoArquivo.Text = "Data da Atualização:";
            // 
            // lblHorarioCriacaoArquivo
            // 
            this.lblHorarioCriacaoArquivo.AutoSize = true;
            this.lblHorarioCriacaoArquivo.Location = new System.Drawing.Point(6, 55);
            this.lblHorarioCriacaoArquivo.Name = "lblHorarioCriacaoArquivo";
            this.lblHorarioCriacaoArquivo.Size = new System.Drawing.Size(98, 13);
            this.lblHorarioCriacaoArquivo.TabIndex = 4;
            this.lblHorarioCriacaoArquivo.Text = "Horário da Criação:";
            // 
            // lblDataCriacaoArquivo
            // 
            this.lblDataCriacaoArquivo.AutoSize = true;
            this.lblDataCriacaoArquivo.Location = new System.Drawing.Point(6, 42);
            this.lblDataCriacaoArquivo.Name = "lblDataCriacaoArquivo";
            this.lblDataCriacaoArquivo.Size = new System.Drawing.Size(87, 13);
            this.lblDataCriacaoArquivo.TabIndex = 3;
            this.lblDataCriacaoArquivo.Text = "Data da Criação:";
            // 
            // lblTamanhoArquivo
            // 
            this.lblTamanhoArquivo.AutoSize = true;
            this.lblTamanhoArquivo.Location = new System.Drawing.Point(6, 29);
            this.lblTamanhoArquivo.Name = "lblTamanhoArquivo";
            this.lblTamanhoArquivo.Size = new System.Drawing.Size(109, 13);
            this.lblTamanhoArquivo.TabIndex = 2;
            this.lblTamanhoArquivo.Text = "Tamanho do Arquivo:";
            // 
            // lblNomeArquivo
            // 
            this.lblNomeArquivo.AutoSize = true;
            this.lblNomeArquivo.Location = new System.Drawing.Point(6, 16);
            this.lblNomeArquivo.Name = "lblNomeArquivo";
            this.lblNomeArquivo.Size = new System.Drawing.Size(92, 13);
            this.lblNomeArquivo.TabIndex = 1;
            this.lblNomeArquivo.Text = "Nome do Arquivo:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(214, 84);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(232, 201);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 231);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbInfoArquivo);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do Drive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbInfoArquivo.ResumeLayout(false);
            this.gbInfoArquivo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblEspacoLivre;
        private System.Windows.Forms.Label lblTipoDrive;
        private System.Windows.Forms.Label lblNomeDrive;
        private System.Windows.Forms.GroupBox gbInfoArquivo;
        private System.Windows.Forms.Label lblDataAtualizacaoArquivo;
        private System.Windows.Forms.Label lblHorarioCriacaoArquivo;
        private System.Windows.Forms.Label lblDataCriacaoArquivo;
        private System.Windows.Forms.Label lblTamanhoArquivo;
        private System.Windows.Forms.Label lblNomeArquivo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

