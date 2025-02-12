using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC9_AULA_1
{
    public partial class AdicionarIngrediente : Form
    {
        public AdicionarIngrediente()
        {
            InitializeComponent();
            CarregarIngredientesDoBanco();

            lvIngredientesDisponiveis.GridLines = true;
            lvIngredientesDisponiveis.AllowColumnReorder = true;
            lvIngredientesDisponiveis.FullRowSelect = true;

            lvIngredientesDisponiveis.View = View.Details;
            lvIngredientesDisponiveis.Columns.Add("ID", 40, HorizontalAlignment.Left);
            lvIngredientesDisponiveis.Columns.Add("Nome", 250);
        }

        private void button2_Click(object sender, EventArgs e) // Botão Salvar
        {
            string nomeIngrediente = txtNomeIngrediente.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeIngrediente))
            {
                MessageBox.Show("Por favor, insira um nome para o ingrediente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = "server=localhost;user=root;password='';database=db_lanchonete";

            using (MySqlConnection conexao = new MySqlConnection(connString))
            {
                try
                {
                    conexao.Open();
                    MySqlCommand cmd;

                    //se for selecionado algo no lv ele altera, se não, adiciona
                    if (lvIngredientesDisponiveis.SelectedItems.Count > 0)
                    {                       
                        ListViewItem itemSelecionado = lvIngredientesDisponiveis.SelectedItems[0];
                        int idIngrediente = Convert.ToInt32(itemSelecionado.SubItems[0].Text);

                        cmd = new MySqlCommand("UPDATE ingrediente SET nome = @nome WHERE id = @id", conexao);
                        cmd.Parameters.AddWithValue("@id", idIngrediente);
                        MessageBox.Show("Ingrediente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Inserir novo ingrediente
                        cmd = new MySqlCommand("INSERT INTO ingrediente (nome) VALUES (@nome)", conexao);
                        MessageBox.Show("Ingrediente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    cmd.Parameters.AddWithValue("@nome", nomeIngrediente);
                    cmd.ExecuteNonQuery();
                    CarregarIngredientesDoBanco(); 
                    txtNomeIngrediente.Clear(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar o ingrediente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvIngredientesDisponiveis.SelectedItems.Count > 0)
            {
                //obtem o id do produto e exclui no banco
                ListViewItem itemSelecionado = lvIngredientesDisponiveis.SelectedItems[0];
                int idIngrediente = Convert.ToInt32(itemSelecionado.SubItems[0].Text);

                string connString = "server=localhost;user=root;password='';database=db_lanchonete";

                using (MySqlConnection conexao = new MySqlConnection(connString))
                {
                    try
                    {
                        conexao.Open();

                        //exclui os ingredientes do produto na tabela Produto_Ingredientes
                        MySqlCommand cmdDeleteIngredientes = new MySqlCommand("DELETE FROM ingrediente WHERE id = @id", conexao);
                        cmdDeleteIngredientes.Parameters.AddWithValue("@id", idIngrediente);
                        cmdDeleteIngredientes.ExecuteNonQuery();

                        //remove do listview
                        lvIngredientesDisponiveis.Items.Remove(itemSelecionado);

                        MessageBox.Show("Ingrediente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o ingrediente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um ingrediente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    lvIngredientesDisponiveis.Items.Clear(); //limpa o listview antes de carregar para evitar duplicação

                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string nome = reader["nome"].ToString();

                        ListViewItem item = new ListViewItem(new[] { id, nome });
                        lvIngredientesDisponiveis.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar ingredientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lvIngredientesDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvIngredientesDisponiveis.SelectedItems.Count > 0)
            {
                ListViewItem itemSelecionado = lvIngredientesDisponiveis.SelectedItems[0];
                txtNomeIngrediente.Text = itemSelecionado.SubItems[1].Text; // Exibe o nome no TextBox
            }
        }
    }
}
