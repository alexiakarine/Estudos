using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorTextPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void TrocarDeCor(bool form=false)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (form) this.BackColor = colorDialog.Color;
                else lblMeuTexto.ForeColor = colorDialog.Color;
            }
        }

        private void btnCorTexto_Click(object sender, EventArgs e)
        {
            TrocarDeCor();
        }

        private void corDaLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrocarDeCor();
        }
        private void corDoFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrocarDeCor(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show((Control)sender, e.Location);
            }
        }

    }
}
