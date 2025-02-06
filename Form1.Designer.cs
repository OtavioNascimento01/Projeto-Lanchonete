namespace ProjetoLanchonete
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdicionarIngredientes = new Button();
            btnProduto = new Button();
            btnRequisicao = new Button();
            btnEstoque = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdicionarIngredientes
            // 
            btnAdicionarIngredientes.BackColor = Color.LightGray;
            btnAdicionarIngredientes.FlatStyle = FlatStyle.Flat;
            btnAdicionarIngredientes.Font = new Font("Segoe UI", 16F);
            btnAdicionarIngredientes.Location = new Point(209, 117);
            btnAdicionarIngredientes.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarIngredientes.Name = "btnAdicionarIngredientes";
            btnAdicionarIngredientes.Size = new Size(301, 83);
            btnAdicionarIngredientes.TabIndex = 0;
            btnAdicionarIngredientes.Text = "Adicionar Ingredientes";
            btnAdicionarIngredientes.UseVisualStyleBackColor = false;
            btnAdicionarIngredientes.Click += btnAdicionarIngredientes_Click;
            btnAdicionarIngredientes.Paint += btnAdicionarIngredientes_Paint;
            btnAdicionarIngredientes.MouseEnter += btnAdicionarIngredientes_MouseEnter;
            btnAdicionarIngredientes.MouseLeave += btnAdicionarIngredientes_MouseLeave;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.LightGray;
            btnProduto.FlatStyle = FlatStyle.Flat;
            btnProduto.Font = new Font("Segoe UI", 20F);
            btnProduto.Location = new Point(209, 224);
            btnProduto.Margin = new Padding(3, 4, 3, 4);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(301, 81);
            btnProduto.TabIndex = 1;
            btnProduto.Text = "Criar Produto";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += btnProduto_Click;
            btnProduto.Paint += btnAdicionarIngredientes_Paint;
            btnProduto.MouseEnter += btnAdicionarIngredientes_MouseEnter;
            btnProduto.MouseLeave += btnAdicionarIngredientes_MouseLeave;
            // 
            // btnRequisicao
            // 
            btnRequisicao.BackColor = Color.LightGray;
            btnRequisicao.FlatStyle = FlatStyle.Flat;
            btnRequisicao.Font = new Font("Segoe UI", 24F);
            btnRequisicao.Location = new Point(209, 325);
            btnRequisicao.Margin = new Padding(3, 4, 3, 4);
            btnRequisicao.Name = "btnRequisicao";
            btnRequisicao.Size = new Size(301, 90);
            btnRequisicao.TabIndex = 2;
            btnRequisicao.Text = "Requisição";
            btnRequisicao.UseVisualStyleBackColor = false;
            btnRequisicao.Click += btnRequisicao_Click;
            btnRequisicao.Paint += btnAdicionarIngredientes_Paint;
            btnRequisicao.MouseEnter += btnAdicionarIngredientes_MouseEnter;
            btnRequisicao.MouseLeave += btnAdicionarIngredientes_MouseLeave;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.LightGray;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 24F);
            btnEstoque.Location = new Point(209, 444);
            btnEstoque.Margin = new Padding(3, 4, 3, 4);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(301, 88);
            btnEstoque.TabIndex = 3;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnRelatorio_Click;
            btnEstoque.Paint += btnAdicionarIngredientes_Paint;
            btnEstoque.MouseEnter += btnAdicionarIngredientes_MouseEnter;
            btnEstoque.MouseLeave += btnAdicionarIngredientes_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEstoque);
            panel1.Controls.Add(btnAdicionarIngredientes);
            panel1.Controls.Add(btnRequisicao);
            panel1.Controls.Add(btnProduto);
            panel1.Location = new Point(-6, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 643);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F);
            label1.Location = new Point(114, 12);
            label1.Name = "label1";
            label1.Size = new Size(510, 81);
            label1.TabIndex = 4;
            label1.Text = "Menu Lanchonete";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdicionarIngredientes;
        private Button btnProduto;
        private Button btnRequisicao;
        private Button btnEstoque;
        private Panel panel1;
        private Label label1;
    }
}