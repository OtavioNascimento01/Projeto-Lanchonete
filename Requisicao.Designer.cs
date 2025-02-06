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
            btnExcluir = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnAdicionar2 = new Button();
            label6 = new Label();
            txtQuantidade2 = new TextBox();
            txtQuantidade1 = new TextBox();
            label3 = new Label();
            btnBuscar2 = new Button();
            txtBuscar = new TextBox();
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
            label1.Location = new Point(-1, 34);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 4;
            label1.Text = "Selecione o Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 118);
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
            btnAdicionar.Size = new Size(107, 30);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(114, 167);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(101, 30);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnAdicionar2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtQuantidade2);
            groupBox1.Controls.Add(txtQuantidade1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnBuscar2);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(cbSelecione2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbSelecione);
            groupBox1.Controls.Add(lvIngredientes2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 19);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(599, 568);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Requisição de Ingredientes";
            // 
            // button2
            // 
            button2.Location = new Point(114, 426);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 12;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAdicionar2
            // 
            btnAdicionar2.Location = new Point(0, 426);
            btnAdicionar2.Margin = new Padding(3, 4, 3, 4);
            btnAdicionar2.Name = "btnAdicionar2";
            btnAdicionar2.Size = new Size(107, 30);
            btnAdicionar2.TabIndex = 12;
            btnAdicionar2.Text = "Adicionar";
            btnAdicionar2.UseVisualStyleBackColor = true;
            btnAdicionar2.Click += btnAdicionar2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 18);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 12;
            label6.Text = "Buscar:";
            // 
            // txtQuantidade2
            // 
            txtQuantidade2.Location = new Point(151, 341);
            txtQuantidade2.Margin = new Padding(2, 2, 2, 2);
            txtQuantidade2.Name = "txtQuantidade2";
            txtQuantidade2.Size = new Size(63, 27);
            txtQuantidade2.TabIndex = 12;
            // 
            // txtQuantidade1
            // 
            txtQuantidade1.Location = new Point(152, 118);
            txtQuantidade1.Margin = new Padding(2, 2, 2, 2);
            txtQuantidade1.Name = "txtQuantidade1";
            txtQuantidade1.Size = new Size(63, 27);
            txtQuantidade1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-1, 341);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 12;
            label3.Text = "Digite a Quantidade:";
            // 
            // btnBuscar2
            // 
            btnBuscar2.Location = new Point(378, 51);
            btnBuscar2.Margin = new Padding(3, 4, 3, 4);
            btnBuscar2.Name = "btnBuscar2";
            btnBuscar2.Size = new Size(86, 30);
            btnBuscar2.TabIndex = 12;
            btnBuscar2.Text = "Buscar";
            btnBuscar2.UseVisualStyleBackColor = true;
            btnBuscar2.Click += btnBuscar2_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(310, 18);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(227, 27);
            txtBuscar.TabIndex = 12;
            // 
            // cbSelecione2
            // 
            cbSelecione2.FormattingEnabled = true;
            cbSelecione2.Location = new Point(0, 298);
            cbSelecione2.Margin = new Padding(2, 2, 2, 2);
            cbSelecione2.Name = "cbSelecione2";
            cbSelecione2.Size = new Size(215, 28);
            cbSelecione2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 266);
            label5.Name = "label5";
            label5.Size = new Size(169, 20);
            label5.TabIndex = 12;
            label5.Text = "Selecione o Ingrediente:";
            // 
            // cbSelecione
            // 
            cbSelecione.FormattingEnabled = true;
            cbSelecione.Location = new Point(0, 70);
            cbSelecione.Margin = new Padding(2, 2, 2, 2);
            cbSelecione.Name = "cbSelecione";
            cbSelecione.Size = new Size(215, 28);
            cbSelecione.TabIndex = 9;
            // 
            // lvIngredientes2
            // 
            lvIngredientes2.Location = new Point(258, 90);
            lvIngredientes2.Margin = new Padding(3, 4, 3, 4);
            lvIngredientes2.Name = "lvIngredientes2";
            lvIngredientes2.Size = new Size(325, 448);
            lvIngredientes2.TabIndex = 12;
            lvIngredientes2.UseCompatibleStateImageBehavior = false;
            // 
            // Requisicao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 597);
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
        private Button btnExcluir;
        private GroupBox groupBox1;
        private TextBox txtQuantidade1;
        private ComboBox cbSelecione;
        private Button button2;
        private Button btnAdicionar2;
        private Label label6;
        private TextBox txtQuantidade2;
        private Label label3;
        private Button btnBuscar2;
        private TextBox txtBuscar;
        private ComboBox cbSelecione2;
        private Label label5;
        private ListView lvIngredientes2;
    }
}