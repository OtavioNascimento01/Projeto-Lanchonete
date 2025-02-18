

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
            lvEstoque.Columns.Add("Nome", 150);
            lvEstoque.Columns.Add("Quantidade", 100);

            // Inicializando a conexão com o MySQL
            string data_source = "server=localhost;user=root;password='';database=db_lanchonete";
            conexao = new MySqlConnection(data_source);


        }

        
    }
}
