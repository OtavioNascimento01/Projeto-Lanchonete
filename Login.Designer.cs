namespace log
{
    partial class Login
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
            txtUsuario = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            button1 = new Button();
            lblMenssagem = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 94);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Faça seu login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 157);
            label2.Name = "label2";
            label2.Size = new Size(48, 14);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(48, 184);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(205, 23);
            txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 249);
            label3.Name = "label3";
            label3.Size = new Size(40, 14);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(48, 276);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(205, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(180, 316);
            button1.Name = "button1";
            button1.Size = new Size(73, 23);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMenssagem
            // 
            lblMenssagem.AutoSize = true;
            lblMenssagem.Location = new Point(93, 387);
            lblMenssagem.Name = "lblMenssagem";
            lblMenssagem.Size = new Size(0, 15);
            lblMenssagem.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 486);
            Controls.Add(lblMenssagem);
            Controls.Add(button1);
            Controls.Add(txtSenha);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtSenha;
        private Button button1;
        private Label lblMenssagem;
    }
}
