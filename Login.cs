using System;
using System.Data;
using System.Windows.Forms;
using GerenciadorFornecedores;
using MySql.Data.MySqlClient;
using ProjetoLanchonete;

namespace log
{
    public partial class Login : Form
    {
        // String de conexão
        private readonly string conexaoString = "server=localhost;user=root;password='';database=db_lanchonete";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (VerificarLogin(usuario, senha))
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Oculta a tela de login e abre o menu principal
                this.Hide();
                Form1 novaTela = new Form1();
                novaTela.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarLogin(string usuario, string senha)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();

                    string query = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND senha = MD5(@senha)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}