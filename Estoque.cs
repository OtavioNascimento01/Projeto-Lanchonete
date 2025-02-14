

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

        
    }
}
