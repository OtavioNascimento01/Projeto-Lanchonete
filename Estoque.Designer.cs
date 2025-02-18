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
            SuspendLayout();
            // 
            // lvEstoque
            // 
            lvEstoque.Location = new Point(12, 76);
            lvEstoque.Name = "lvEstoque";
            lvEstoque.Size = new Size(359, 431);
            lvEstoque.TabIndex = 0;
            lvEstoque.UseCompatibleStateImageBehavior = false;
            // 
            // cbLanchonetesEstoque
            // 
            cbLanchonetesEstoque.FormattingEnabled = true;
            cbLanchonetesEstoque.Location = new Point(12, 42);
            cbLanchonetesEstoque.Name = "cbLanchonetesEstoque";
            cbLanchonetesEstoque.Size = new Size(359, 28);
            cbLanchonetesEstoque.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 2;
            label1.Text = "Selecione a lanchonete:";
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(519, 519);
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
    }
}
