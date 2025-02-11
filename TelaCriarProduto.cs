using MySql.Data.MySqlClient;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

namespace UC9_AULA_1
{
    public partial class TelaAdicionarProduto : Form
    {

        public TelaAdicionarProduto()
        {

            //inicializando todos os listviews com os dados do banco
            InitializeComponent();
            CarregarIngredientesDoBanco();
            CarregarProdutosDisponiveis();

            //configuração dos 3 list views
            lvIngredientesP.GridLines = true;
            lvIngredientesP.AllowColumnReorder = true;
            lvIngredientesP.FullRowSelect = true;

            lvIngredientesP.View = View.Details;
            lvIngredientesP.Columns.Add("ID", 40, HorizontalAlignment.Left);
            lvIngredientesP.Columns.Add("Nome", 300);

            
            lvProdutoP.GridLines = true;
            lvProdutoP.AllowColumnReorder = true;
            lvProdutoP.FullRowSelect = true;

            lvProdutoP.View = View.Details;
            lvProdutoP.Columns.Add("ID", 40, HorizontalAlignment.Left);
            lvProdutoP.Columns.Add("Nome", 150);
            lvProdutoP.Columns.Add("Quantidade", 100);

            
            lvProdutosDisponiveis.GridLines = true;
            lvProdutosDisponiveis.AllowColumnReorder = true;
            lvProdutosDisponiveis.FullRowSelect = true;

            lvProdutosDisponiveis.View = View.Details;
            lvProdutosDisponiveis.Columns.Add("ID", 40, HorizontalAlignment.Left);
            lvProdutosDisponiveis.Columns.Add("Nome", 300);
        }

        //esta funcao adiciona os ingredientes disponiveis na receita do produto
        //através de um botão
        private void btnAdicionarIngrediente_Click(object sender, EventArgs e)
        {
            if (lvIngredientesP.SelectedItems.Count > 0 && !string.IsNullOrWhiteSpace(txtQuantidadeP.Text))
            {
                //se algum item for selecionado e o espaço do nome nao está em branco
                //captura os dados necessarios do listview e do textbox
                ListViewItem itemSelecionado = lvIngredientesP.SelectedItems[0];
                string id = itemSelecionado.SubItems[0].Text;  
                string nome = itemSelecionado.SubItems[1].Text; 
                string quantidade = txtQuantidadeP.Text;

                //adiciona os ingredientes no listview da receita do produto
                ListViewItem novoItem = new ListViewItem(new[] { id, nome, quantidade });
                lvProdutoP.Items.Add(novoItem);
            }
            else
            {
                MessageBox.Show("Selecione um ingrediente e informe a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //exclui o ingrediente selecionado da receita do produto
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvProdutoP.SelectedItems.Count > 0)
            {
                lvProdutoP.Items.Remove(lvProdutoP.SelectedItems[0]);
            }
        }

        //cria o produto com a receita e salva no banco de dados
        private void btnCriarProduto_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNome.Text; 

            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("Por favor, insira um nome para o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //cria a lista de ingredientes que vai no produto com o id e a quantidade
            List<(int, int)> ingredientes = new List<(int, int)>();

            //percorre o listview pegando os ingredientes e a quantidade para jogar no banco
            foreach (ListViewItem item in lvProdutoP.Items)
            {
                int idIngrediente = Convert.ToInt32(item.SubItems[0].Text); // Pegando o ID do ingrediente
                int quantidade = Convert.ToInt32(item.SubItems[2].Text); // Pegando a quantidade

                ingredientes.Add((idIngrediente, quantidade));
            }

            if (ingredientes.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um ingrediente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //chama a função para salvar no banco e verificando se deu certo
            if (SalvarProdutoNoBanco(nomeProduto, ingredientes, out int idProduto))
            {
                //adiciona ao ListView de produtos disponíveis
                ListViewItem novoItem = new ListViewItem(idProduto.ToString()); // Adiciona o ID na primeira coluna
                novoItem.SubItems.Add(nomeProduto); // Adiciona o nome na segunda coluna
                lvProdutosDisponiveis.Items.Add(novoItem);

                //limpa os campos após salvar
                txtNome.Text = "";
                lvProdutoP.Items.Clear();
            }
        }

        //exclui o produto 
        private void btnExcluirIngrediente_Click(object sender, EventArgs e)
        {
            if (lvProdutosDisponiveis.SelectedItems.Count > 0)
            {
                //obtem o id do produto e exclui no banco
                ListViewItem itemSelecionado = lvProdutosDisponiveis.SelectedItems[0];
                int idProduto = Convert.ToInt32(itemSelecionado.SubItems[0].Text); 

                string connString = "server=localhost;user=root;password='';database=db_lanchonete";

                using (MySqlConnection conexao = new MySqlConnection(connString))
                {
                    try
                    {
                        conexao.Open();

                        //exclui os ingredientes do produto na tabela Produto_Ingredientes
                        MySqlCommand cmdDeleteIngredientes = new MySqlCommand("DELETE FROM Produto_Ingredientes WHERE id_produto = @id", conexao);
                        cmdDeleteIngredientes.Parameters.AddWithValue("@id", idProduto);
                        cmdDeleteIngredientes.ExecuteNonQuery();

                        //exclui o produto na tabela produto
                        MySqlCommand cmdDeleteProduto = new MySqlCommand("DELETE FROM produto WHERE id = @id", conexao);
                        cmdDeleteProduto.Parameters.AddWithValue("@id", idProduto);
                        cmdDeleteProduto.ExecuteNonQuery();

                        MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                CarregarProdutosDisponiveis();
            }
            else
            {
                MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void CarregarIngredientesDoBanco()
        {
            string connString = "server=127.0.0.1;user=root;password='';database=db_lanchonete";

            using (MySqlConnection conexao = new MySqlConnection(connString))
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id, nome FROM ingrediente", conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    lvIngredientesP.Items.Clear(); //limpa o listview antes de carregar para evitar duplicação

                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string nome = reader["nome"].ToString();

                        ListViewItem item = new ListViewItem(new[] { id, nome });
                        lvIngredientesP.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar ingredientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool SalvarProdutoNoBanco(string nomeProduto, List<(int, int)> ingredientes, out int idProduto)
        {
            idProduto = -1; // Inicializa com um valor inválido
            string connString = "server=localhost;user=root;password='';database=db_lanchonete";

            using (MySqlConnection conexao = new MySqlConnection(connString))
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO produto (nome) VALUES (@nome)", conexao);
                    cmd.Parameters.AddWithValue("@nome", nomeProduto);
                    cmd.ExecuteNonQuery();

                    // Pegando o ID do produto recém-criado
                    idProduto = (int)cmd.LastInsertedId;

                    // Inserindo os ingredientes na tabela Produto_Ingredientes
                    foreach (var (idIngrediente, quantidade) in ingredientes)
                    {
                        MySqlCommand cmdIngrediente = new MySqlCommand("INSERT INTO Produto_Ingredientes (id_produto, id_ingrediente, quantidade) VALUES (@id_produto, @id_ingrediente, @quantidade)", conexao);
                        cmdIngrediente.Parameters.AddWithValue("@id_produto", idProduto);
                        cmdIngrediente.Parameters.AddWithValue("@id_ingrediente", idIngrediente);
                        cmdIngrediente.Parameters.AddWithValue("@quantidade", quantidade);
                        cmdIngrediente.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true; // Retorna verdadeiro se tudo deu certo
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Retorna falso se deu erro
                }
            }
        }

        private void CarregarProdutosDisponiveis()
        {
            string connString = "server=localhost;user=root;password='';database=db_lanchonete";

            using (MySqlConnection conexao = new MySqlConnection(connString))
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id, nome FROM produto", conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    lvProdutosDisponiveis.Items.Clear(); //limpa o listview antes de carregar para evitar duplicação

                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string nome = reader["nome"].ToString();

                        ListViewItem item = new ListViewItem(new[] { id, nome });
                        lvProdutosDisponiveis.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}



