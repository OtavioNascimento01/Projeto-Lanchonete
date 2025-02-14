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
            txtBuscarProduto = new TextBox();
            btnBuscar = new Button();
            btnPrestesAVencer = new Button();
            btnVencido = new Button();
            label1 = new Label();
            lvEstoque = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnMostrarEstoqueCompleto = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnRelatorio = new Button();
            SuspendLayout();
            // 
            // txtBuscarProduto
            // 
            txtBuscarProduto.Location = new Point(46, 132);
            txtBuscarProduto.Margin = new Padding(3, 4, 3, 4);
            txtBuscarProduto.Name = "txtBuscarProduto";
            txtBuscarProduto.Size = new Size(114, 27);
            txtBuscarProduto.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.MintCream;
            btnBuscar.Location = new Point(167, 132);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnPrestesAVencer
            // 
            btnPrestesAVencer.BackColor = Color.LemonChiffon;
            btnPrestesAVencer.Location = new Point(306, 131);
            btnPrestesAVencer.Margin = new Padding(3, 4, 3, 4);
            btnPrestesAVencer.Name = "btnPrestesAVencer";
            btnPrestesAVencer.Size = new Size(83, 31);
            btnPrestesAVencer.TabIndex = 2;
            btnPrestesAVencer.Text = "Estagnado";
            btnPrestesAVencer.UseVisualStyleBackColor = false;
            // 
            // btnVencido
            // 
            btnVencido.BackColor = Color.LightCoral;
            btnVencido.Location = new Point(397, 131);
            btnVencido.Margin = new Padding(3, 4, 3, 4);
            btnVencido.Name = "btnVencido";
            btnVencido.Size = new Size(122, 31);
            btnVencido.TabIndex = 3;
            btnVencido.Text = "prester a vencer";
            btnVencido.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 108);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 5;
            label1.Text = "nome do produto";
            // 
            // lvEstoque
            // 
            lvEstoque.BackColor = Color.MintCream;
            lvEstoque.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvEstoque.FullRowSelect = true;
            lvEstoque.Location = new Point(45, 188);
            lvEstoque.Margin = new Padding(3, 4, 3, 4);
            lvEstoque.Name = "lvEstoque";
            lvEstoque.Size = new Size(474, 244);
            lvEstoque.TabIndex = 6;
            lvEstoque.UseCompatibleStateImageBehavior = false;
            lvEstoque.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOME";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ENTRADA";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "VALIDADE";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "VENCIMENTO";
            columnHeader5.Width = 90;
            // 
            // btnMostrarEstoqueCompleto
            // 
            btnMostrarEstoqueCompleto.Location = new Point(45, 60);
            btnMostrarEstoqueCompleto.Margin = new Padding(3, 4, 3, 4);
            btnMostrarEstoqueCompleto.Name = "btnMostrarEstoqueCompleto";
            btnMostrarEstoqueCompleto.Size = new Size(153, 31);
            btnMostrarEstoqueCompleto.TabIndex = 7;
            btnMostrarEstoqueCompleto.Text = "estoque completo";
            btnMostrarEstoqueCompleto.UseVisualStyleBackColor = true;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(433, 461);
            btnRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(86, 31);
            btnRelatorio.TabIndex = 9;
            btnRelatorio.Text = "Relatório";
            btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(603, 600);
            Controls.Add(btnRelatorio);
            Controls.Add(btnMostrarEstoqueCompleto);
            Controls.Add(lvEstoque);
            Controls.Add(label1);
            Controls.Add(btnVencido);
            Controls.Add(btnPrestesAVencer);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarProduto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarProduto;
        private Button btnBuscar;
        private Button btnPrestesAVencer;
        private Button btnVencido;
        private Label label1;
        private ListView lvEstoque;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnMostrarEstoqueCompleto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnRelatorio;
    }
}
