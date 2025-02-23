namespace GerenciadorFornecedores
{
    partial class Fornecedores
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.txtFrequencia = new System.Windows.Forms.TextBox();
            this.lvFornecedores = new System.Windows.Forms.ListView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "contato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ingredientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "frequencia";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(89, 90);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(100, 20);
            this.txtContato.TabIndex = 5;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(89, 135);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(100, 20);
            this.txtIngredientes.TabIndex = 6;
            // 
            // txtFrequencia
            // 
            this.txtFrequencia.Location = new System.Drawing.Point(89, 184);
            this.txtFrequencia.Name = "txtFrequencia";
            this.txtFrequencia.Size = new System.Drawing.Size(100, 20);
            this.txtFrequencia.TabIndex = 7;
            // 
            // lvFornecedores
            // 
            this.lvFornecedores.FullRowSelect = true;
            this.lvFornecedores.GridLines = true;
            this.lvFornecedores.HideSelection = false;
            this.lvFornecedores.Location = new System.Drawing.Point(209, 45);
            this.lvFornecedores.Name = "lvFornecedores";
            this.lvFornecedores.Size = new System.Drawing.Size(593, 316);
            this.lvFornecedores.TabIndex = 11;
            this.lvFornecedores.UseCompatibleStateImageBehavior = false;
            this.lvFornecedores.View = System.Windows.Forms.View.Details;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnExcluir.Image = global::GerenciadorFornecedores.Properties.Resources.icons8_trash_24;
            this.btnExcluir.Location = new System.Drawing.Point(162, 220);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(27, 34);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //this.btnBuscar.Image = global::GerenciadorFornecedores.Properties.Resources.icons8_search_241;
            this.btnBuscar.Location = new System.Drawing.Point(24, 224);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 28);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           // this.btnAdicionar.Image = global::GerenciadorFornecedores.Properties.Resources.icons8_plus_24;
            this.btnAdicionar.Location = new System.Drawing.Point(125, 223);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(31, 29);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.lvFornecedores);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtFrequencia);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.TextBox txtFrequencia;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lvFornecedores;
        private System.Windows.Forms.Button btnExcluir;
    }
}

