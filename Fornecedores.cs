using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // Importa a biblioteca do MySQL

namespace GerenciadorFornecedores
{
    public partial class Fornecedores : Form
    {
        private MySqlConnection conexao;  // Declaração da conexão com o banco
        public Fornecedores()
        {
            InitializeComponent();

            // Configuração do ListView
            lvFornecedores.View = View.Details; // Define exibição detalhada
            lvFornecedores.FullRowSelect = true; // Permite selecionar a linha inteira
            lvFornecedores.GridLines = true; // Mostra as linhas de grade
            lvFornecedores.Columns.Clear(); // Limpa colunas antigas

            // Adicionando colunas ao ListView
            lvFornecedores.Columns.Add("ID", 50);
            lvFornecedores.Columns.Add("Nome", 150);
            lvFornecedores.Columns.Add("Contato", 150);
            lvFornecedores.Columns.Add("Ingredientes", 200);
            lvFornecedores.Columns.Add("Frequência", 100);

            // Configuração da conexão com MySQL
            string data_source = "server=localhost;user=root;password='';database=db_lanchonete";
            conexao = new MySqlConnection(data_source);

            // Carregar fornecedores ao abrir a tela
            CarregarFornecedores();
        }

        // 🔹 MÉTODO PARA CARREGAR FORNECEDORES DO BANCO NO LISTVIEW
        private void CarregarFornecedores(string filtro = "")
        {
            lvFornecedores.Items.Clear(); // Limpa a lista antes de carregar

            try
            {
                conexao.Open(); // Abre conexão com o banco
                string sql = "SELECT * FROM fornecedores1";

                if (!string.IsNullOrEmpty(filtro))
                {
                    sql += " WHERE LOWER(nome) LIKE LOWER(@nome)";
                }

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        comando.Parameters.AddWithValue("@nome", "%" + filtro + "%");
                    }

                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        // Percorre os registros do banco e adiciona ao ListView
                        while (leitor.Read())
                        {
                            ListViewItem item = new ListViewItem(leitor["id"].ToString());
                            item.SubItems.Add(leitor["nome"].ToString());
                            item.SubItems.Add(leitor["contato"].ToString());
                            item.SubItems.Add(leitor["ingredientes"].ToString());
                            item.SubItems.Add(leitor["frequencia"].ToString());

                            lvFornecedores.Items.Add(item); // Adiciona à lista
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
            finally
            {
                conexao.Close(); // Fecha a conexão com o banco
            }
        }

        // 🔹 MÉTODO PARA ADICIONAR UM NOVO FORNECEDOR
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open(); // Abre a conexão para a inserção

                string sql = "INSERT INTO fornecedores1 (nome, contato, ingredientes, frequencia) " +
                             "VALUES (@nome, @contato, @ingredientes, @frequencia)";

                using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@contato", txtContato.Text);
                    comando.Parameters.AddWithValue("@ingredientes", txtIngredientes.Text);
                    comando.Parameters.AddWithValue("@frequencia", txtFrequencia.Text);

                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Fornecedor adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar fornecedor: " + ex.Message);
            }
            finally
            {
                conexao.Close(); // Fecha a conexão após a inserção
            }

            // Recarrega a lista após adicionar um novo fornecedor
            CarregarFornecedores(); // Aqui, a conexão será aberta novamente no método CarregarFornecedores

            
        }
       
        // 🔹 MÉTODO PARA BUSCAR FORNECEDORES POR NOME
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomeFornecedor = txtNome.Text.Trim();

            if (!string.IsNullOrEmpty(nomeFornecedor))
            {
                CarregarFornecedores(nomeFornecedor);
            }
            else
            {
                CarregarFornecedores();
            }
        }

        // 🔹 MÉTODO PARA EXCLUIR FORNECEDORES
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvFornecedores.SelectedItems.Count > 0)
            {
                DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir o fornecedor selecionado?",
                                                        "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        int idFornecedor = Convert.ToInt32(lvFornecedores.SelectedItems[0].Text);
                        conexao.Open(); // Abre a conexão apenas para a exclusão

                        string sql = "DELETE FROM fornecedores1 WHERE id = @id";
                        using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                        {
                            comando.Parameters.AddWithValue("@id", idFornecedor);
                            comando.ExecuteNonQuery();
                        }

                        MessageBox.Show("Fornecedor excluído com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
                    }
                    finally
                    {
                        conexao.Close(); // Fecha a conexão antes de recarregar os fornecedores
                    }

                    // Agora a conexão está fechada e podemos chamar o método sem problemas
                    CarregarFornecedores();
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor para excluir.");
            }
        }
    }
}
