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
    public partial class frmLogin : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Testando a conexão com o banco de dados
            try
            {
                //Quem é o host(hospedeiro)
                //Qual banco de dados
                //Qual o usuário
                //Qual a senha
                con.ConnectionString = "Server=localhost;Database=bd_loja;User=root;Pwd=";
                con.Open();
                //MessageBox.Show("Acesso OK");
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Error ==> " + Erro.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                Application.Exit();
            }
            cmd.CommandText = "select password from tb_login where user_id='" + txtUsuario.Text.Trim() + "';";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string resultado = (string)cmd.ExecuteScalar();
            con.Close();

            if (resultado!=null&& resultado == txtSenha.Text)
            {
                MessageBox.Show("Senha Válida!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmPrincipal form = new frmPrincipal();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário/Senha Inválido!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
