using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tela_Requisição
{
    public partial class Requisicao : Form
    {
        MySqlConnection conexao;
        private string conexaoString = "server=localhost;user=root;password='';database=db_lanchonete";

        public Requisicao()
        {
            InitializeComponent();
            CarregarIngredientes();
            CarregarProdutos();
            CarregarLanchonetes();

            lvIngredientes2.GridLines = true;
            lvIngredientes2.AllowColumnReorder = true;
            lvIngredientes2.FullRowSelect = true;

            lvIngredientes2.View = View.Details;
            lvIngredientes2.Columns.Add("Ingrediente", 150);
            lvIngredientes2.Columns.Add("Quantidade", 150);
        }

        //este botão adiciona os ingredientes no listview através da seleção do produto
        //multiplicando a receita do produto pela quantidade inserida
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //conexão padrão com o banco
                string data_source = "server=localhost;user=root;password='';database=db_lanchonete";
                conexao = new MySqlConnection(data_source);

                //verificações
                if (cbSelecione.SelectedItem == null || string.IsNullOrWhiteSpace(txtQuantidade1.Text))
                {
                    MessageBox.Show("Selecione um produto e insira uma quantidade válida.");
                    return;
                }

                int idProduto = Convert.ToInt32(cbSelecione.SelectedValue);
                int quantidadeInserida = Convert.ToInt32(txtQuantidade1.Text);

                // query para buscar os ingredientes do produto e seus nomes
                string sql = @"
                    SELECT i.id, i.nome, pi.quantidade
                    FROM Produto_Ingredientes pi
                    JOIN ingrediente i ON pi.id_ingrediente = i.id
                    WHERE pi.id_produto = @id_produto";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id_produto", idProduto);

                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int idIngrediente = Convert.ToInt32(reader["id"]); // Obtendo o ID do ingrediente
                    string nomeIngrediente = reader["nome"].ToString();
                    int quantidadeOriginal = Convert.ToInt32(reader["quantidade"]);
                    int quantidadeFinal = quantidadeOriginal * quantidadeInserida;

                    ListViewItem item = new ListViewItem(nomeIngrediente);
                    item.SubItems.Add(quantidadeFinal.ToString());
                    item.Tag = idIngrediente; // 

                    lvIngredientes2.Items.Add(item);
                }

                reader.Close();
                conexao.Close();

                MessageBox.Show("Produtos adicionados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        //este botão adiciona os ingredientes ao listview diretamente
        private void btnAdicionar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSelecione2.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um ingrediente antes de continuar.");
                    return;
                }

                //obtém o nome do ingrediente
                string ingredienteSelecionado = cbSelecione2.SelectedItem.ToString();

                //valida o textbox de quantidade
                int quantidade = 1;
                if (!int.TryParse(txtQuantidade2.Text, out quantidade) || quantidade <= 0)
                {
                    MessageBox.Show("Insira uma quantidade válida.");
                    return;
                }

                //aqui é verificado se ja existe o ingrediente no listview, se sim, soma, se não insere um novo
                bool encontrado = false;
                foreach (ListViewItem item in lvIngredientes2.Items)
                {
                    //compara através do nome
                    if (item.SubItems[0].Text.Equals(ingredienteSelecionado, StringComparison.OrdinalIgnoreCase))
                    {
                        //atualiza a quantidade total, somando a quantidade atual no listview + o que foi inserido no textbox
                        int quantidadeAtual = int.Parse(item.SubItems[1].Text);
                        item.SubItems[1].Text = (quantidadeAtual + quantidade).ToString();
                        encontrado = true;
                        break;
                    }
                }

                //se o ingrediente não foi encontrado, adiciona como novo item
                if (!encontrado)
                {
                    ListViewItem novoItem = new ListViewItem(ingredienteSelecionado);
                    novoItem.SubItems.Add(quantidade.ToString());
                    lvIngredientes2.Items.Add(novoItem);
                }

                MessageBox.Show("Ingrediente adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvIngredientes2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um ingrediente para excluir.");
                return;
            }

            //remove o item selecionado no ListView
            lvIngredientes2.SelectedItems[0].Remove();

            MessageBox.Show("Ingrediente excluído com sucesso.");
        }

        private void CarregarProdutos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();
                    string query = "SELECT id, nome FROM produto";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cbSelecione.DataSource = dt;
                        cbSelecione.DisplayMember = "nome";
                        cbSelecione.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void CarregarIngredientes()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();
                    string query = "SELECT nome FROM ingrediente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cbSelecione2.Items.Clear();

                        while (reader.Read())
                        {
                            cbSelecione2.Items.Add(reader["nome"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void CarregarLanchonetes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password='';database=db_lanchonete"))
                {
                    conn.Open();
                    string query = "SELECT id_lanchonete, nome FROM lanchonetes"; // Ajuste conforme o nome correto da tabela no seu banco

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            cbLanchonete.DataSource = dt; // Define os dados no ComboBox
                            cbLanchonete.DisplayMember = "nome"; // Mostra os nomes no dropdown
                            cbLanchonete.ValueMember = "id_lanchonete"; // Mantém o ID associado
                            cbLanchonete.SelectedIndex = -1; // Deixa sem seleção inicial
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar lanchonetes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFazerRequisicao_Click(object sender, EventArgs e)
        {
            // Tratamento de erros
            if (lvIngredientes2.Items.Count == 0)
            {
                MessageBox.Show("A lista de ingredientes está vazia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbLanchonete.SelectedItem == null || cbLanchonete.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma lanchonete!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o ID e nome da lanchonete selecionada
            int idLanchonete = Convert.ToInt32(cbLanchonete.SelectedValue);
            string lanchonete = cbLanchonete.Text; // Obtém o nome exibido

            string dataHoraRequisicao = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Monta a mensagem de confirmação
            string mensagem = $"Confirma a requisição para a lanchonete: {lanchonete}?\n\n";
            mensagem += $"Data/Hora da Requisição: {dataHoraRequisicao}\n\n";
            mensagem += "Ingredientes:\n";

            foreach (ListViewItem item in lvIngredientes2.Items)
            {
                string ingrediente = item.SubItems[0].Text;
                string quantidade = item.SubItems[1].Text;
                mensagem += $"{ingrediente}: {quantidade}\n";
            }

            // Exibe a mensagem
            DialogResult resposta = MessageBox.Show(mensagem, "Confirmação de Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Se resposta for OK, salva no banco
            if (resposta == DialogResult.OK)
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;password='';database=db_lanchonete"))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO estoque (id_lanchonete, id_ingrediente, quantidade, data_requisicao)
                        VALUES (@idLanchonete, @idIngrediente, @quantidade, NOW())
                        ON DUPLICATE KEY UPDATE quantidade = quantidade + VALUES(quantidade);";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        foreach (ListViewItem item in lvIngredientes2.Items)
                        {
                            int idIngrediente = Convert.ToInt32(item.Tag); // Pegando o ID do ingrediente
                            //MessageBox.Show("Tag do Item: " + item.Tag?.ToString());
                            int quantidade = Convert.ToInt32(item.SubItems[1].Text);

                            cmd.Parameters.Clear(); // Limpa os parâmetros para cada iteração
                            cmd.Parameters.AddWithValue("@idLanchonete", idLanchonete);
                            cmd.Parameters.AddWithValue("@idIngrediente", idIngrediente);
                            cmd.Parameters.AddWithValue("@quantidade", quantidade);

                            //MessageBox.Show("ID Ingrediente: " + idIngrediente);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Pedido realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
