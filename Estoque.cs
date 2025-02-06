

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ControleEstoqueHamburgueria_
{
    public partial class Estoque : Form
    {
        private MySqlConnection conexao;

        public Estoque()
        {
            InitializeComponent();

            // Configuração do ListView
            lvEstoque.GridLines = true;
            lvEstoque.AllowColumnReorder = true;
            lvEstoque.FullRowSelect = true;
            lvEstoque.View = View.Details;

            // Adicionando colunas ao ListView
            lvEstoque.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lvEstoque.Columns.Add("Nome", 150);
            lvEstoque.Columns.Add("Data Entrada", 100);
            lvEstoque.Columns.Add("Validade (dias)", 120);
            lvEstoque.Columns.Add("Data de Vencimento", 150);

            // Inicializando a conexão com o MySQL
            string data_source = "server=localhost;database=db_laura_trabalhadora;uid=root;pwd=;";
            conexao = new MySqlConnection(data_source);


        }

        // Método para carregar o estoque no ListView
        private void CarregarEstoque(string filtro = "")
        {
            try
            {
                conexao.Open(); // Abre a conexão com o banco

                // Consulta SQL básica para pegar todos os produtos
                string sql = "SELECT id, nome, data_entrada, validade_dias FROM produto";

                // Se houver um filtro, adiciona a condição WHERE
                if (!string.IsNullOrEmpty(filtro))
                {
                    sql += " WHERE " + filtro;
                }

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                MySqlDataReader leitor = comando.ExecuteReader();

                lvEstoque.Items.Clear(); // Limpa os itens antes de adicionar os novos

                // Obtém a data atual
                DateTime dataAtual = DateTime.Today;

                // Preenche o ListView com os dados encontrados
                while (leitor.Read())
                {
                    int id = leitor.GetInt32("id");
                    string nome = leitor.GetString("nome");
                    DateTime dataEntrada = leitor.GetDateTime("data_entrada");
                    int validade = leitor.GetInt32("validade_dias");
                    DateTime dataValidade = dataEntrada.AddDays(validade); // Calcula a data de vencimento

                    // Cria um novo item para o ListView
                    ListViewItem item = new ListViewItem(id.ToString());
                    item.SubItems.Add(nome);
                    item.SubItems.Add(dataEntrada.ToShortDateString()); // Adiciona a data de entrada
                    item.SubItems.Add(validade.ToString()); // Adiciona a validade em dias
                    item.SubItems.Add(dataValidade.ToShortDateString()); // Adiciona a data de vencimento

                    // Define a cor do item baseado na validade
                    if ((dataAtual - dataEntrada).TotalDays >= 10)
                    {
                        item.BackColor = System.Drawing.Color.LightCoral; // Produto vencido (>10 dias)
                    }
                    else if ((dataAtual - dataEntrada).TotalDays >= 5)
                    {
                        item.BackColor = System.Drawing.Color.LemonChiffon; // Produto perto do vencimento (5 dias)
                    }

                    lvEstoque.Items.Add(item);
                }

                leitor.Close(); // Fecha o leitor de dados
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close(); // Garante que a conexão seja fechada
            }
        }

        // Método para buscar um produto no banco de dados
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtBuscarProduto.Text.Trim(); // Obtém o nome digitado

            if (!string.IsNullOrEmpty(nomeProduto))
            {
                // Filtra os produtos que contêm o nome digitado
                string filtro = $"LOWER(nome) LIKE LOWER('%{nomeProduto}%')";
                CarregarEstoque(filtro);
            }
            else
            {
                // Se o campo estiver vazio, carrega todos os produtos
                CarregarEstoque();
            }
        }

        // Botão para listar produtos prestes a vencer (entre 5 e 10 dias no estoque)
        private void btnPrestesAVencer_Click(object sender, EventArgs e)
        {
            string filtro = "DATEDIFF(NOW(), data_entrada) >= 5 AND DATEDIFF(NOW(), data_entrada) < 10";
            CarregarEstoque(filtro);
        }

        // Botão para listar produtos vencidos (10 dias ou mais no estoque)
        private void btnVencido_Click(object sender, EventArgs e)
        {
            string filtro = "DATEDIFF(NOW(), data_entrada) >= 10";
            CarregarEstoque(filtro);
        }

        private void btnMostrarEstoqueCompleto_Click(object sender, EventArgs e)
        {
            CarregarEstoque();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //FormRelatorio formRelatorio = new FormRelatorio();
            //formRelatorio.Show();
        }
    }
}
