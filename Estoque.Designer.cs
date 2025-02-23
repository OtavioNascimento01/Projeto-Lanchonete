namespace ControleEstoqueHamburgueria_
{
    partial class Estoque
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lvEstoque = new ListView();
            cbLanchonetesEstoque = new ComboBox();
            label1 = new Label();
            btnVoltar = new Button();
            btnExibirEstoque = new Button();
            btnExcluirItem = new Button();
            SuspendLayout();
            // 
            // lvEstoque
            // 
            lvEstoque.Location = new Point(12, 106);
            lvEstoque.Name = "lvEstoque";
            lvEstoque.Size = new Size(413, 475);
            lvEstoque.TabIndex = 0;
            lvEstoque.UseCompatibleStateImageBehavior = false;
            // 
            // cbLanchonetesEstoque
            // 
            cbLanchonetesEstoque.FormattingEnabled = true;
            cbLanchonetesEstoque.Location = new Point(12, 32);
            cbLanchonetesEstoque.Name = "cbLanchonetesEstoque";
            cbLanchonetesEstoque.Size = new Size(328, 28);
            cbLanchonetesEstoque.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 2;
            label1.Text = "Selecione a lanchonete:";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(346, 9);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(79, 34);
            btnVoltar.TabIndex = 3;
            btnVoltar.Text = "<- Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button1_Click;
            // 
            // btnExibirEstoque
            // 
            btnExibirEstoque.Location = new Point(291, 66);
            btnExibirEstoque.Name = "btnExibirEstoque";
            btnExibirEstoque.Size = new Size(134, 34);
            btnExibirEstoque.TabIndex = 4;
            btnExibirEstoque.Text = "Exibir Estoque";
            btnExibirEstoque.UseVisualStyleBackColor = true;
            btnExibirEstoque.Click += btnExibirEstoque_Click;
            // 
            // btnExcluirItem
            // 
            btnExcluirItem.Location = new Point(12, 66);
            btnExcluirItem.Name = "btnExcluirItem";
            btnExcluirItem.Size = new Size(126, 34);
            btnExcluirItem.TabIndex = 5;
            btnExcluirItem.Text = "Excluir Item";
            btnExcluirItem.UseVisualStyleBackColor = true;
            btnExcluirItem.Click += btnExcluirItem_Click;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(440, 591);
            Controls.Add(btnExcluirItem);
            Controls.Add(btnExibirEstoque);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(cbLanchonetesEstoque);
            Controls.Add(lvEstoque);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Estoque";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView lvEstoque;
        private ComboBox cbLanchonetesEstoque;
        private Label label1;
        private Button btnVoltar;
        private Button btnExibirEstoque;
        private Button btnExcluirItem;
    }
}
