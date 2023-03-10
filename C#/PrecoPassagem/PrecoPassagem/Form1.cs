using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrecoPassagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckButton();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você deseja sair?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void KeyPressFix(object sender, KeyPressEventArgs e)
        {
            e.Handled = OnlyNumber(e.KeyChar);
        }

        private void TextChangedFix(object sender, EventArgs e)
        {
            CheckV((TextBox)sender);
            CheckButton();
        }

        public bool OnlyNumber(char c)
        {
            if (!char.IsDigit(c) && c != 8 && c != 45 && c != 44 && c != 46)
            {
                return true;
            }
            return false;
        }

        public void CheckV(TextBox txt)
        {
            if (txt.Text.Contains(",") || txt.Text.Contains("."))
            {
                int index = txt.SelectionStart;
                string text = txt.Text.Replace(".", ",");
                if (text == "," || text.StartsWith(","))
                {
                    text = "0" + text;
                    index++;
                }
                string[] test = text.Split(',');
                string final = "";
                foreach (string s in test)
                {
                    if (final.Length == 0) final += s + ",";
                    else final += s;
                }
                txt.Text = final;
                txt.SelectionStart = index;
            }
        }

        public void CheckButton()
        {
            //btnCalcular.Enabled = (tbDistancia.Text.Length > 0 && tbLDistancia.Text.Length > 0 && tbCDistancia.Text.Length > 0);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (tbDistancia.Text.Length == 0)
            {
                MessageBox.Show("Digite o valor da distância!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbDistancia.Focus();
                return;
            }
            if (tbCDistancia.Text.Length == 0)
            {
                MessageBox.Show("Digite o valor do preço da curta distância!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCDistancia.Focus();
                return;
            }
            if (tbLDistancia.Text.Length == 0)
            {
                MessageBox.Show("Digite o valor do preço da longa distância!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLDistancia.Focus();
                return;
            }

            double distancia, preco_cdistancia, preco_ldistancia, total;
            distancia = double.Parse(tbDistancia.Text);
            preco_cdistancia = double.Parse(tbCDistancia.Text);
            preco_ldistancia = double.Parse(tbLDistancia.Text);

            if (distancia <= 200) total = distancia * preco_cdistancia;
            else total = distancia * preco_ldistancia;

            lblPreco.Text = "Preço da Passagem: R$ " + total.ToString("N2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblPreco.Text = "Preço da Passagem: R$ 0";
            tbDistancia.Clear();
            tbLDistancia.Clear();
            tbCDistancia.Clear();
            tbDistancia.Focus();
        }
    }
}
