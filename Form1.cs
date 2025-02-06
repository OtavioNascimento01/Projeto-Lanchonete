using ControleEstoqueHamburgueria_;
using System.Drawing.Drawing2D;
using Tela_Requisi��o;
using UC9_AULA_1;

namespace ProjetoLanchonete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarIngredientes_Click(object sender, EventArgs e)
        {
            //Form2 novaTela = new Form2();
           // novaTela.Show();

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            TelaAdicionarProduto novaTela = new TelaAdicionarProduto();
            novaTela.Show();
        }

        private void btnRequisicao_Click(object sender, EventArgs e)
        {
            Requisicao novaTela = new Requisicao();
            novaTela.Show();

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Estoque novaTela = new Estoque();
            novaTela.Show();

        }

        private void btnAdicionarIngredientes_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button; // converter o objeto para bot�o
            if (btn != null)
            {
                btn.BackColor = Color.SteelBlue; // cor ao passar o mouse
                btn.ForeColor = Color.White; // Cor texto
            }



        }

        private void btnAdicionarIngredientes_MouseLeave(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.LightGray; // Cor original
                btn.ForeColor = Color.Black; // Cor original do texto
            }

        }

        private void btnAdicionarIngredientes_Paint(object sender, PaintEventArgs e)
        { }
    }
}