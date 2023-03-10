using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CincoPorcentoDesconto
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

        public bool OnlyNumber(char c, bool isDecimal = true)
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
            if (tbValorProduto.Text.Length == 0)
            {
                MessageBox.Show("Digite o valor das horas trabalhadas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbValorProduto.Focus();
                return;
            }

            double valorProduto, valorDesconto = 5, valorComDesconto;
            valorProduto = double.Parse(tbValorProduto.Text);
            valorComDesconto = valorProduto - ((valorProduto * valorDesconto) / 100);

            lblValorProduto.Text = "Valor do Produto: R$" + valorProduto.ToString("N2");
            lblValorDesconto.Text = "Valor do Desconto: " + valorDesconto + "%";
            lblValorComDesconto.Text = "Valor com Desconto: R$" + valorComDesconto.ToString("N2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblValorProduto.Text = "Valor do Produto: R$0";
            lblValorDesconto.Text = "Valor do Desconto: 0%";
            lblValorComDesconto.Text = "Valor com Desconto: R$0";
            tbValorProduto.Clear();
            tbValorProduto.Focus();
        }
    }
}
