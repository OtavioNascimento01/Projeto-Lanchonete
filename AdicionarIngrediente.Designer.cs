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
            btnSalvarIngrediente = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Ingrediente:";
            // 
            // txtNomeIngrediente
            // 
            txtNomeIngrediente.Location = new Point(68, 52);
            txtNomeIngrediente.Margin = new Padding(3, 4, 3, 4);
            txtNomeIngrediente.Name = "txtNomeIngrediente";
            txtNomeIngrediente.Size = new Size(225, 27);
            txtNomeIngrediente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // lvIngredientesDisponiveis
            // 
            lvIngredientesDisponiveis.Location = new Point(12, 135);
            lvIngredientesDisponiveis.Margin = new Padding(3, 4, 3, 4);
            lvIngredientesDisponiveis.Name = "lvIngredientesDisponiveis";
            lvIngredientesDisponiveis.Size = new Size(388, 490);
            lvIngredientesDisponiveis.TabIndex = 3;
            lvIngredientesDisponiveis.UseCompatibleStateImageBehavior = false;
            lvIngredientesDisponiveis.SelectedIndexChanged += lvIngredientesDisponiveis_SelectedIndexChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(67, 87);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(109, 40);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvarIngrediente
            // 
            btnSalvarIngrediente.Location = new Point(183, 87);
            btnSalvarIngrediente.Margin = new Padding(3, 4, 3, 4);
            btnSalvarIngrediente.Name = "btnSalvarIngrediente";
            btnSalvarIngrediente.Size = new Size(110, 40);
            btnSalvarIngrediente.TabIndex = 5;
            btnSalvarIngrediente.Text = "Salvar";
            btnSalvarIngrediente.UseVisualStyleBackColor = true;
            btnSalvarIngrediente.Click += button2_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(321, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(79, 34);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "<- Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // AdicionarIngrediente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 638);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvarIngrediente);
            Controls.Add(btnExcluir);
            Controls.Add(lvIngredientesDisponiveis);
            Controls.Add(label2);
            Controls.Add(txtNomeIngrediente);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnSalvarIngrediente;
        private Button btnVoltar;
    }
}