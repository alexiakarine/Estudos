using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MinhaLoja
{
    public partial class frmConsultaProd : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public frmConsultaProd()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text.Trim().Length == 0) {
                MessageBox.Show("Coloque o código do produto!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            try
            {
                con.ConnectionString = "Server=localhost;Database=bd_loja;User=root;Pwd=";
                con.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Error ==> " + Erro.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            try
            {
                cmd.CommandText = "select descrprod,prc_vend,prc_comp,qnt_estoque from tb_produtos where codprod=" + txtCodigoProduto.Text.Trim() + ";";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {

                    string descicao = leitor.GetString("descrprod");
                    string prc_venda = leitor.GetString("prc_vend");
                    string prc_comp = leitor.GetString("prc_comp");
                    string qnt_estoque = leitor.GetString("qnt_estoque");

                    txtDescricao.Text = descicao;
                    txtEstoqueAtual.Text = qnt_estoque;
                    txtPrecoCompra.Text = prc_comp;
                    txtPrecoVenda.Text = prc_venda;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCodigoProduto.Focus();
                }
                con.Close();
            }
            catch (Exception ex) { con.Close(); 
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigoProduto.Clear();
            txtDescricao.Clear();
            txtEstoqueAtual.Clear();
            txtPrecoCompra.Clear();
            txtPrecoVenda.Clear();
        }

        private void non_selectable(object sender, EventArgs e)
        {
            lblCodProduto.Focus();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarNome_Click(object sender, EventArgs e)
        {
            /*if (txtNomeProduto.Text.Trim().Length == 0)
            {
                MessageBox.Show("Coloque o nome do produto!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }*/
            try
            {
                con.ConnectionString = "Server=localhost;Database=bd_loja;User=root;Pwd=";
                con.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Error ==> " + Erro.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            try
            {
                lstbNome.Items.Clear();

                cmd.CommandText = "select codprod,descrprod from tb_produtos" + (txtNomeProduto.Text.Trim().Length > 0 ? " where descrprod like '%" + txtNomeProduto.Text.Trim() + "%';" : ";");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {

                    string nome = leitor.GetInt32("codprod") + " - " + leitor.GetString("descrprod");

                    lstbNome.Items.Add(nome);
                }
                con.Close();
            }
            catch (Exception ex) {
                con.Close();
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
