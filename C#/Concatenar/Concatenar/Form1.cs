using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concatenar
{
    public partial class Contatenar : Form
    {
        public Contatenar()
        {
            InitializeComponent();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") {

                MessageBox.Show("Informe o nome","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return;
            }
            if (txtSobrenome.Text == "")
            {

                MessageBox.Show("Informe o Sobrenome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSobrenome.Focus();
                return;
            }
            lblResultado.Text = txtNome.Text + " " + txtSobrenome.Text; 
        }
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtSobrenome.Clear();
            txtNome.Clear();
            txtNome.Focus();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

// O .Text representa uma propriedade do lbl e do txt 
// O click do btnConcatenar representa um evento 
//Exemplo a porta é azul --> propriedade / e ela fecha --> Evento 
// Todo metodo tem que abrir e fechar () porque tem variações. 