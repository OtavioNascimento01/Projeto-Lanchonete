namespace UC9_AULA_1
{
    partial class AdicionarIngrediente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNomeIngrediente = new TextBox();
            label2 = new Label();
            lvIngredientesDisponiveis = new ListView();
            btnExcluir = new Button();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Ingrediente:";
            // 
            // txtNomeIngrediente
            // 
            txtNomeIngrediente.Location = new Point(52, 32);
            txtNomeIngrediente.Name = "txtNomeIngrediente";
            txtNomeIngrediente.Size = new Size(197, 23);
            txtNomeIngrediente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // lvIngredientesDisponiveis
            // 
            lvIngredientesDisponiveis.Location = new Point(3, 97);
            lvIngredientesDisponiveis.Name = "lvIngredientesDisponiveis";
            lvIngredientesDisponiveis.Size = new Size(294, 341);
            lvIngredientesDisponiveis.TabIndex = 3;
            lvIngredientesDisponiveis.UseCompatibleStateImageBehavior = false;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(52, 61);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(95, 30);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(153, 61);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 30);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button2_Click;
            // 
            // AdicionarIngrediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 450);
            Controls.Add(btnAdicionar);
            Controls.Add(btnExcluir);
            Controls.Add(lvIngredientesDisponiveis);
            Controls.Add(label2);
            Controls.Add(txtNomeIngrediente);
            Controls.Add(label1);
            Name = "AdicionarIngrediente";
            Text = "AdicionarIngrediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeIngrediente;
        private Label label2;
        private ListView lvIngredientesDisponiveis;
        private Button btnExcluir;
        private Button btnAdicionar;
    }
}