namespace UC9_AULA_1
{
    partial class TelaAdicionarProduto
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNome = new TextBox();
            btnAdicionarIngrediente = new Button();
            txtQuantidadeP = new TextBox();
            label3 = new Label();
            lvIngredientesP = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnDExcluir = new ToolStripMenuItem();
            btnExcluirProdutoP = new Button();
            btnCriarProduto = new Button();
            lvProdutoP = new ListView();
            label2 = new Label();
            label4 = new Label();
            btnExcluirProduto = new Button();
            lvProdutosDisponiveis = new ListView();
            label5 = new Label();
            btnVoltar = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(8, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(319, 27);
            txtNome.TabIndex = 1;
            // 
            // btnAdicionarIngrediente
            // 
            btnAdicionarIngrediente.Location = new Point(161, 436);
            btnAdicionarIngrediente.Name = "btnAdicionarIngrediente";
            btnAdicionarIngrediente.Size = new Size(166, 42);
            btnAdicionarIngrediente.TabIndex = 2;
            btnAdicionarIngrediente.Text = "Adicionar ingrediente";
            btnAdicionarIngrediente.UseVisualStyleBackColor = true;
            btnAdicionarIngrediente.Click += btnAdicionarIngrediente_Click;
            // 
            // txtQuantidadeP
            // 
            txtQuantidadeP.Location = new Point(102, 437);
            txtQuantidadeP.Name = "txtQuantidadeP";
            txtQuantidadeP.Size = new Size(53, 27);
            txtQuantidadeP.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 437);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Quantidade:";
            // 
            // lvIngredientesP
            // 
            lvIngredientesP.ContextMenuStrip = contextMenuStrip1;
            lvIngredientesP.Location = new Point(8, 101);
            lvIngredientesP.Name = "lvIngredientesP";
            lvIngredientesP.Size = new Size(319, 330);
            lvIngredientesP.TabIndex = 7;
            lvIngredientesP.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { btnDExcluir });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(179, 28);
            // 
            // btnDExcluir
            // 
            btnDExcluir.Name = "btnDExcluir";
            btnDExcluir.Size = new Size(178, 24);
            btnDExcluir.Text = "Excluir Contato";
            // 
            // btnExcluirProdutoP
            // 
            btnExcluirProdutoP.Location = new Point(355, 437);
            btnExcluirProdutoP.Name = "btnExcluirProdutoP";
            btnExcluirProdutoP.Size = new Size(146, 43);
            btnExcluirProdutoP.TabIndex = 11;
            btnExcluirProdutoP.Text = "Excluir Ingrediente";
            btnExcluirProdutoP.UseVisualStyleBackColor = true;
            btnExcluirProdutoP.Click += btnExcluir_Click;
            // 
            // btnCriarProduto
            // 
            btnCriarProduto.Location = new Point(525, 437);
            btnCriarProduto.Name = "btnCriarProduto";
            btnCriarProduto.Size = new Size(147, 41);
            btnCriarProduto.TabIndex = 12;
            btnCriarProduto.Text = "Criar novo produto";
            btnCriarProduto.UseVisualStyleBackColor = true;
            btnCriarProduto.Click += btnCriarProduto_Click;
            // 
            // lvProdutoP
            // 
            lvProdutoP.ContextMenuStrip = contextMenuStrip1;
            lvProdutoP.Location = new Point(355, 101);
            lvProdutoP.Name = "lvProdutoP";
            lvProdutoP.Size = new Size(317, 330);
            lvProdutoP.TabIndex = 13;
            lvProdutoP.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 78);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 14;
            label2.Text = "Ingredientes do produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 78);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 15;
            label4.Text = "Ingredientes disponíveis:";
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.Location = new Point(702, 437);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(154, 43);
            btnExcluirProduto.TabIndex = 16;
            btnExcluirProduto.Text = "Excluir Produto";
            btnExcluirProduto.UseVisualStyleBackColor = true;
            btnExcluirProduto.Click += btnExcluirIngrediente_Click;
            // 
            // lvProdutosDisponiveis
            // 
            lvProdutosDisponiveis.ContextMenuStrip = contextMenuStrip1;
            lvProdutosDisponiveis.Location = new Point(702, 101);
            lvProdutosDisponiveis.Name = "lvProdutosDisponiveis";
            lvProdutosDisponiveis.Size = new Size(317, 330);
            lvProdutosDisponiveis.TabIndex = 17;
            lvProdutosDisponiveis.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(702, 78);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 18;
            label5.Text = "Produtos disponíveis:";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(940, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(79, 34);
            btnVoltar.TabIndex = 19;
            btnVoltar.Text = "<- Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // TelaAdicionarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 483);
            Controls.Add(btnVoltar);
            Controls.Add(label5);
            Controls.Add(lvProdutosDisponiveis);
            Controls.Add(btnExcluirProduto);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lvProdutoP);
            Controls.Add(btnCriarProduto);
            Controls.Add(btnExcluirProdutoP);
            Controls.Add(txtQuantidadeP);
            Controls.Add(label3);
            Controls.Add(btnAdicionarIngrediente);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(lvIngredientesP);
            Name = "TelaAdicionarProduto";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtQuantidadeP;
        private Label label3;
        private ListView lvIngredientesP;
        private Button btnExcluirProdutoP;
        private Button btnAdicionarIngrediente;
        private Button btnCriarProduto;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem btnDExcluir;
        private ListView lvProdutoP;
        private Label label2;
        private Label label4;
        private Button btnExcluirProduto;
        private ListView lvProdutosDisponiveis;
        private Label label5;
        private Button btnVoltar;
    }
}
