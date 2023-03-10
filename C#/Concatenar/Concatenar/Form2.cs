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
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToLower() == "heloisa")
            {
                lblResultado.Text = "";

            }
        }
       

       
    }
}
