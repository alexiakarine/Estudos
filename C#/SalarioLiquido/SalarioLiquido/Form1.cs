﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioLiquido
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
            if (tbValorHoras.Text.Length == 0)
            {
                MessageBox.Show("Digite o valor das horas trabalhadas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbValorHoras.Focus();
                return;
            }
            if (tbQuantidadeHoras.Text.Length == 0)
            {
                MessageBox.Show("Digite a quantidade de horas trabalhadas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbQuantidadeHoras.Focus();
                return;
            }
            if (tbPercentualDesconto.Text.Length == 0)
            {
                MessageBox.Show("Digite o percentual de desconto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPercentualDesconto.Focus();
                return;
            }

            double valorHoras, quantidadeHoras, percentualDesconto, total;
            valorHoras = double.Parse(tbValorHoras.Text);
            quantidadeHoras = double.Parse(tbQuantidadeHoras.Text);
            percentualDesconto = double.Parse(tbPercentualDesconto.Text);

            total = valorHoras * quantidadeHoras;
            total -= ((total * percentualDesconto) / 100);

            lblPreco.Text = "Salário Líquido: R$ " + total.ToString("N2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblPreco.Text = "Salário Líquido: R$ 0";
            tbValorHoras.Clear();
            tbPercentualDesconto.Clear();
            tbQuantidadeHoras.Clear();
            tbValorHoras.Focus();
        }

    }
}
