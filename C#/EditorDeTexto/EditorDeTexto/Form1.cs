using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtbTexto.SelectionColor = colorDialog.Color;
            }

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    rtbTexto.SelectionFont = fontDialog.Font;
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao trocar de fonte!\n" + ex.Message, "Fonte", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Doc Type|*.doc";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (!sfd.FileName.ToLower().EndsWith(".doc")) sfd.FileName += ".doc";
                using (StreamWriter sw = new StreamWriter(sfd.FileName,false))
                {
                    sw.WriteLine(rtbTexto.Rtf);
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Doc Type|*.doc";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.CheckFileExists)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        rtbTexto.Clear();
                        rtbTexto.Rtf = sr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
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
