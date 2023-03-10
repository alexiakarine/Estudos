using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PesoIdeal_Mi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text == "")
            {

                MessageBox.Show("Informe a altura!", "Altura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAltura.Focus();
                return;
            }
            double altura = 0, PesoIdeal = 0;
            try{ // Tente fazer 
                altura = double.Parse(txtAltura.Text.Replace(".", ",")); //Para aceitar . e ,
            }
            catch { //Caso não consiga
                MessageBox.Show("Use apenas números na altura!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rbMasc.Checked) PesoIdeal = (72.7 * altura) - 58;
            else PesoIdeal = (62.1 * altura) - 44.7;
            lblResultado.Text = "Peso Ideal: " + PesoIdeal.ToString("N2"); // Formatação

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            lblResultado.Text = "Peso Ideal: 0";
            rbMasc.Checked = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("confirmar a saida?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                //char 8 = backspace
                //char 44 = virgula
                e.Handled = true;
            }
        }
        
    }
}
