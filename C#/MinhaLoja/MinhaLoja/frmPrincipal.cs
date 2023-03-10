using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MinhaLoja
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaProd consulta = new frmConsultaProd();
            consulta.TopLevel = false;
            consulta.AutoScroll = true;
            consulta.FormBorderStyle = FormBorderStyle.None;
            FecharTelas();
            panelChild.Controls.Add(consulta);
            consulta.Dock = DockStyle.Fill;
            consulta.Show();
        }

        public void FecharTelas()
        {
            foreach (var c in panelChild.Controls)
            {
                if (c.GetType() == typeof(Form))
                {
                    ((Form)c).Close();
                }
            }
            panelChild.Controls.Clear();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
