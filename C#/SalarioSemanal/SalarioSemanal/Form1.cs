using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalarioSemanal
{
    public partial class Form1 : Form
    {
        //A jornada de trabalho semanal de um funcionario e de 40 horas.
        //O funcionário que trabalhar mais de 40 horas receberá horas extras, cujo
        //o calculo e o valor da hora regular com um acréscimo de 50%. Escreva um programa
        //que leia o número de horas trabalhadas em um mês, o salário por hora e escreva(Calcule)
        //o salário total do funcionário, que deverá ser acrescido das horas extras caso
        //tenha sido trabalhadas, (Considere que o mês possua 4 semanas exatas).

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double horas = 0, salario = 0,total=0,horas_extra=0;

            if (txtHTM.Text.Length == 0)
            {
                MessageBox.Show("Coloque as horas trabalhadas!", "Horas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHTM.Focus();
                return;
            }
            if (txtSH.Text.Length == 0)
            {
                MessageBox.Show("Coloque o salário!", "Salário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSH.Focus();
                return;
            }

            horas = Convert.ToDouble(txtHTM.Text);
            salario = Convert.ToDouble(txtSH.Text);

            if (horas > 160)
            {
                horas_extra = (horas - 160);
                horas -= horas_extra;
            }
            total = (salario * horas)/*salario normal*/ + ((salario +(salario * 0.5)) * horas_extra)/*salario com extra*/;
            lbResultado.Text = "Total R$: " + total;
        }

        private void txtHTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtSH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHTM.Clear();
            txtSH.Clear();
            lbResultado.Text = "";
            txtHTM.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
