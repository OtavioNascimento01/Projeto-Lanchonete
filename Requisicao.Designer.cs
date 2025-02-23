namespace Tela_Requisição
{
    partial class Requisicao
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
            label1 = new Label();
            label2 = new Label();
            btnAdicionar = new Button();
            groupBox1 = new GroupBox();
            btnVoltar = new Button();
            cbLanchonete = new ComboBox();
            label6 = new Label();
            btnFazerRequisicao = new Button();
            label4 = new Label();
            button2 = new Button();
            btnAdicionar2 = new Button();
            txtQuantidade2 = new TextBox();
            txtQuantidade1 = new TextBox();
            label3 = new Label();
            cbSelecione2 = new ComboBox();
            label5 = new Label();
            cbSelecione = new ComboBox();
            lvIngredientes2 = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 4;
            label1.Text = "Selecione o Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 117);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 5;
            label2.Text = "Digite a Quantidade:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(0, 167);
            btnAdicionar.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(214, 40);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnVoltar);
            groupBox1.Controls.Add(cbLanchonete);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnFazerRequisicao);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnAdicionar2);
            groupBox1.Controls.Add(txtQuantidade2);
            groupBox1.Controls.Add(txtQuantidade1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbSelecione2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbSelecione);
            groupBox1.Controls.Add(lvIngredientes2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(617, 584);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Requisição de Ingredientes";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(526, 17);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(79, 34);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "<- Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // cbLanchonete
            // 
            cbLanchonete.FormattingEnabled = true;
            cbLanchonete.Location = new Point(11, 535);
            cbLanchonete.Margin = new Padding(2, 3, 2, 3);
            cbLanchonete.Name = "cbLanchonete";
            cbLanchonete.Size = new Size(408, 28);
            cbLanchonete.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 512);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 15;
            label6.Text = "Selecione a lanchonete:";
            // 
            // btnFazerRequisicao
            // 
            btnFazerRequisicao.Font = new Font("Segoe UI", 10F);
            btnFazerRequisicao.Location = new Point(468, 512);
            btnFazerRequisicao.Margin = new Padding(3, 4, 3, 4);
            btnFazerRequisicao.Name = "btnFazerRequisicao";
            btnFazerRequisicao.Size = new Size(137, 60);
            btnFazerRequisicao.TabIndex = 9;
            btnFazerRequisicao.Text = "Fazer Requisição";
            btnFazerRequisicao.UseVisualStyleBackColor = true;
            btnFazerRequisicao.Click += btnFazerRequisicao_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 24);
            label4.Name = "label4";
            label4.Size = new Size(245, 20);
            label4.TabIndex = 13;
            label4.Text = "Total de ingredientes da requisição:";
            // 
            // button2
            // 
            button2.Location = new Point(118, 401);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 51);
            button2.TabIndex = 7;
            button2.Text = "Excluir Ingrediente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAdicionar2
            // 
            btnAdicionar2.Location = new Point(11, 401);
            btnAdicionar2.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar2.Name = "btnAdicionar2";
            btnAdicionar2.Size = new Size(101, 51);
            btnAdicionar2.TabIndex = 6;
            btnAdicionar2.Text = "Adicionar Ingrediente";
            btnAdicionar2.UseVisualStyleBackColor = true;
            btnAdicionar2.Click += btnAdicionar2_Click;
            // 
            // txtQuantidade2
            // 
            txtQuantidade2.Location = new Point(156, 354);
            txtQuantidade2.Margin = new Padding(2, 3, 2, 3);
            txtQuantidade2.Name = "txtQuantidade2";
            txtQuantidade2.Size = new Size(63, 27);
            txtQuantidade2.TabIndex = 5;
            // 
            // txtQuantidade1
            // 
            txtQuantidade1.Location = new Point(152, 117);
            txtQuantidade1.Margin = new Padding(2, 3, 2, 3);
            txtQuantidade1.Name = "txtQuantidade1";
            txtQuantidade1.Size = new Size(63, 27);
            txtQuantidade1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 354);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 12;
            label3.Text = "Digite a Quantidade:";
            // 
            // cbSelecione2
            // 
            cbSelecione2.FormattingEnabled = true;
            cbSelecione2.Location = new Point(10, 309);
            cbSelecione2.Margin = new Padding(2, 3, 2, 3);
            cbSelecione2.Name = "cbSelecione2";
            cbSelecione2.Size = new Size(215, 28);
            cbSelecione2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 286);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 12;
            label5.Text = "Selecione o Ingrediente:";
            // 
            // cbSelecione
            // 
            cbSelecione.FormattingEnabled = true;
            cbSelecione.Location = new Point(5, 69);
            cbSelecione.Margin = new Padding(2, 3, 2, 3);
            cbSelecione.Name = "cbSelecione";
            cbSelecione.Size = new Size(215, 28);
            cbSelecione.TabIndex = 1;
            // 
            // lvIngredientes2
            // 
            lvIngredientes2.Location = new Point(267, 56);
            lvIngredientes2.Margin = new Padding(3, 4, 3, 4);
            lvIngredientes2.Name = "lvIngredientes2";
            lvIngredientes2.Size = new Size(338, 448);
            lvIngredientes2.TabIndex = 12;
            lvIngredientes2.UseCompatibleStateImageBehavior = false;
            // 
            // Requisicao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 582);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Requisicao";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnAdicionar;
        private GroupBox groupBox1;
        private TextBox txtQuantidade1;
        private ComboBox cbSelecione;
        private Button button2;
        private Button btnAdicionar2;
        private TextBox txtQuantidade2;
        private Label label3;
        private ComboBox cbSelecione2;
        private Label label5;
        private ListView lvIngredientes2;
        private Label label4;
        private ComboBox cbLanchonete;
        private Label label6;
        private Button btnFazerRequisicao;
        private Button btnVoltar;
    }
}