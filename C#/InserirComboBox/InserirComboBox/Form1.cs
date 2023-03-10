using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InserirComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (nome.Length == 0)
            {
                MessageBox.Show("Coloque um nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }
            if (cbNomes.Items.Contains(nome))
            {
                MessageBox.Show("Nome já adicionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }
            cbNomes.Items.Add(nome);
            txtNome.Text = "";
            lblQnt.Text = "Quantidade de Nomes: " + cbNomes.Items.Count;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbNomes.Items.Clear();
            cbNomes.Text = "";
            txtNome.Clear();
            lblQnt.Text = "Quantidade de Nomes: " + cbNomes.Items.Count;
            txtNome.Focus();
        }

        private void cbNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbNomes.Text);
        }
    }
}
