using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InfoDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InfoDrive();
        }

        public void InfoDrive()
        {
            DriveInfo objDI = new DriveInfo(@"C:/");
            lblNomeDrive.Text = "Nome do Drive: " + objDI.Name;
            lblTipoDrive.Text = "Tipo do Drive: " + objDI.DriveType.ToString();
            lblEspacoLivre.Text = "Espaço Livre: " + objDI.AvailableFreeSpace.ToString() + " bytes";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string caminho;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminho = openFileDialog.FileName;
                if (!File.Exists(caminho)) {
                    //throw new FileNotFoundException("O arquivo não foi encontrado: " + caminho);
                    MessageBox.Show("O arquivo especificado não foi encontrado.");
                    return;
                }
                FileInfo fi = new FileInfo(caminho);
                lblNomeArquivo.Text = "Nome do Arquivo: "+fi.Name;
                lblTamanhoArquivo.Text = "Tamanho do Arquivo: "+fi.Length+" bytes";
                lblDataCriacaoArquivo.Text = "Criação do Arquivo: "+fi.CreationTime.ToLongDateString();
                lblHorarioCriacaoArquivo.Text = "Horario da Criação: "+fi.CreationTime.ToShortTimeString();
                lblDataAtualizacaoArquivo.Text = "Data da Atualização: " + fi.LastWriteTime.ToLongDateString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
