

using MySql.Data.MySqlClient;
using ProjetoLanchonete;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleEstoqueHamburgueria_
{
    public partial class Estoque : Form
    {
        private string connectionString = "server=localhost;user=root;password='';database=db_lanchonete";

        public Estoque()
        {
            InitializeComponent();
            CarregarLanchonetes();

            // Configuração do ListView
            lvEstoque.GridLines = true;
            lvEstoque.AllowColumnReorder = true;
            lvEstoque.FullRowSelect = true;
            lvEstoque.View = View.Details;

            // Adicionando colunas ao ListView
            lvEstoque.Columns.Add("Nome", 300);
            lvEstoque.Columns.Add("Quantidade", 100);
        }

        private void CarregarLanchonetes()
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id_lanchonete, nome FROM lanchonetes", conexao);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cbLanchonetesEstoque.Items.Clear();

                    while (reader.Read())
                    {
                        string id = reader["id_lanchonete"].ToString();
                        string nome = reader["nome"].ToString();

                        cbLanchonetesEstoque.Items.Add(new { Text = nome, Value = id });
                    }
                    cbLanchonetesEstoque.DisplayMember = "Text";
                    cbLanchonetesEstoque.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar lanchonetes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CarregarEstoque(int idLanchonete)
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    string query = @"SELECT i.nome AS ingrediente, e.quantidade 
                             FROM estoque e 
                             JOIN ingrediente i ON e.id_ingrediente = i.id
                             WHERE e.id_lanchonete = @idLanchonete";
                    MySqlCommand cmd = new MySqlCommand(query, conexao);
                    cmd.Parameters.AddWithValue("@idLanchonete", idLanchonete);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    lvEstoque.Items.Clear();
                    int count = 0;

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ingrediente"].ToString());
                        item.SubItems.Add(reader["quantidade"].ToString());
                        lvEstoque.Items.Add(item);
                        count++;
                    }

                    if (count == 0)
                    {
                        MessageBox.Show("Nenhum item encontrado no estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 telaPrincipal = new Form1();
            telaPrincipal.Show();
            this.Close();
        }

        private void btnExibirEstoque_Click(object sender, EventArgs e)
        {
            if (cbLanchonetesEstoque.SelectedItem != null)
            {
                var selectedItem = cbLanchonetesEstoque.SelectedItem as dynamic;
                int idLanchonete = Convert.ToInt32(selectedItem.Value);
                CarregarEstoque(idLanchonete);
            }
            else
            {
                MessageBox.Show("Selecione uma lanchonete antes de exibir o estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (lvEstoque.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeIngrediente = lvEstoque.SelectedItems[0].Text;
            var selectedItem = cbLanchonetesEstoque.SelectedItem;

            if (selectedItem == null)
            {
                MessageBox.Show("Selecione uma lanchonete!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idLanchonete = Convert.ToInt32(((dynamic)selectedItem).Value);

            DialogResult confirm = MessageBox.Show($"Deseja excluir '{nomeIngrediente}' do estoque?",
                                                   "Confirmar Exclusão",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conexao.Open();
                        string query = @"DELETE FROM estoque 
                                 WHERE id_lanchonete = @idLanchonete 
                                 AND id_ingrediente = (SELECT id FROM ingrediente WHERE nome = @nomeIngrediente)";

                        MySqlCommand cmd = new MySqlCommand(query, conexao);
                        cmd.Parameters.AddWithValue("@idLanchonete", idLanchonete);
                        cmd.Parameters.AddWithValue("@nomeIngrediente", nomeIngrediente);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregarEstoque(idLanchonete); 
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir item!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir do banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }


}
