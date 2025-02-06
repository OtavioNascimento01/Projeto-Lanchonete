using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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

            lvIngredientes2.GridLines = true;
            lvIngredientes2.AllowColumnReorder = true;
            lvIngredientes2.FullRowSelect = true;

            lvIngredientes2.View = View.Details;
            lvIngredientes2.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lvIngredientes2.Columns.Add("Ingrediente", 150);
            lvIngredientes2.Columns.Add("Quantidade", 150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password='';database=db_lanchonete";
                conexao = new MySqlConnection(data_source);

                for (int i = 0; i < cbSelecione.Items.Count; i++)
                {
                    
                    if (i < cbSelecione2.Items.Count)
                    {
                        string ingredienteSelecionado = cbSelecione.Items[i].ToString();
                        string ingredienteAdicional = cbSelecione2.Items[i].ToString();

                        string sql = "INSERT INTO produto (ingredientes, quantidade) " +
                                     "VALUES(@ingredientes, @quantidade)";

                        MySqlCommand comando = new MySqlCommand(sql, conexao);
                        comando.Parameters.AddWithValue("@ingredientes", ingredienteAdicional);
                        comando.Parameters.AddWithValue("@quantidade", txtQuantidade1.Text);

                        conexao.Open();
                        comando.ExecuteNonQuery();
                        conexao.Close();
                    }
                }

                MessageBox.Show("Produtos adicionados com sucesso!");
                AtualizarListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void AtualizarListView()
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password='';database=db_lanchonete";
                conexao = new MySqlConnection(data_source);

                string sql1 = "SELECT id, ingredientes, quantidade FROM produto";
                string sql2 = "SELECT id, ingrediente, quantidade FROM ingredientes_separados";

                MySqlCommand comando1 = new MySqlCommand(sql1, conexao);
                MySqlCommand comando2 = new MySqlCommand(sql2, conexao);

                conexao.Open();

                lvIngredientes2.Items.Clear();

                MySqlDataReader reader1 = comando1.ExecuteReader();
                while (reader1.Read())
                {
                    ListViewItem item = new ListViewItem(reader1["id"].ToString());
                    item.SubItems.Add(reader1["ingredientes"].ToString());
                    item.SubItems.Add(reader1["quantidade"].ToString());
                    lvIngredientes2.Items.Add(item);
                }
                reader1.Close();

                MySqlDataReader reader2 = comando2.ExecuteReader();
                while (reader2.Read())
                {
                    ListViewItem item = new ListViewItem(reader2["id"].ToString());
                    item.SubItems.Add(reader2["ingrediente"].ToString());
                    item.SubItems.Add(reader2["quantidade"].ToString());
                    lvIngredientes2.Items.Add(item);
                }
                reader2.Close();

                if (lvIngredientes2.Items.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvIngredientes2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            try
            {
                string data_source = "datasource=localhost;username=root;password='';database=db_lanchonete";
                conexao = new MySqlConnection(data_source);

                string idproduto = lvIngredientes2.SelectedItems[0].SubItems[0].Text;

                string sql = "DELETE FROM produto WHERE id = @id";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", idproduto);

                conexao.Open();
                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Produto excluído com sucesso.");
                    lvIngredientes2.SelectedItems[0].Remove();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o produto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            AtualizarListView();
        }


        private void btnAdicionar2_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password='';database=db_lanchonete";
                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO ingredientes_separados (ingrediente, quantidade) " +
                             "VALUES(@ingrediente, @quantidade)";

                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@ingrediente", cbSelecione2.Text);
                comando.Parameters.AddWithValue("@quantidade", txtQuantidade2.Text);

                conexao.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Produto adicionado com sucesso!");

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
                AtualizarListView();
        }


        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password='';database=db_lanchonete";
                conexao = new MySqlConnection(data_source);

                string sql1 = "SELECT id, ingredientes, quantidade FROM produto WHERE ingredientes LIKE @ingrediente";
                string sql2 = "SELECT id, ingrediente, quantidade FROM ingredientes_separados WHERE ingrediente LIKE @ingrediente";

                MySqlCommand comando1 = new MySqlCommand(sql1, conexao);
                comando1.Parameters.AddWithValue("@ingrediente", "%" + txtBuscar.Text + "%");

                MySqlCommand comando2 = new MySqlCommand(sql2, conexao);
                comando2.Parameters.AddWithValue("@ingrediente", "%" + txtBuscar.Text + "%");

                conexao.Open();

                MySqlDataReader reader1 = comando1.ExecuteReader();
                lvIngredientes2.Items.Clear();

                while (reader1.Read())
                {
                    ListViewItem item = new ListViewItem(reader1["id"].ToString());
                    item.SubItems.Add(reader1["ingredientes"].ToString());
                    item.SubItems.Add(reader1["quantidade"].ToString());
                    lvIngredientes2.Items.Add(item);
                }

                reader1.Close();

                MySqlDataReader reader2 = comando2.ExecuteReader();
                while (reader2.Read())
                {
                    ListViewItem item = new ListViewItem(reader2["id"].ToString());
                    item.SubItems.Add(reader2["ingrediente"].ToString());
                    item.SubItems.Add(reader2["quantidade"].ToString());
                    lvIngredientes2.Items.Add(item);
                }

                if (lvIngredientes2.Items.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (lvIngredientes2.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Selecione um produto para excluir.");
                    return;
                }

                try
                {
                    string data_source = "datasource=localhost;username=root;password='';database=db_lanchonete";
                    conexao = new MySqlConnection(data_source);

                    string idIngredientes_separados = lvIngredientes2.SelectedItems[0].SubItems[0].Text;

                    string sql = "DELETE FROM ingredientes_separados WHERE id = @id";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@id", idIngredientes_separados);

                    conexao.Open();
                    int rowsAffected = comando.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produto excluído com sucesso.");
                        lvIngredientes2.SelectedItems[0].Remove();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o produto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexao.Close();
                }
                AtualizarListView();
            }
        }

        private void CarregarProdutos()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();
                    string query = "SELECT nome FROM produto";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cbSelecione.Items.Add(reader["Nome"].ToString());
                        }
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
                    string query = "SELECT Nome FROM Ingrediente";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cbSelecione2.Items.Add(reader["Nome"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar ingredientes: " + ex.Message);
            }
        }
    }
}
