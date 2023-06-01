namespace MenuBiblioteca
{
    partial class FormMenuBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuBiblioteca));
            this.imgMenulivro = new System.Windows.Forms.PictureBox();
            this.btnCadastroAutor = new System.Windows.Forms.Button();
            this.btnCadastroEditora = new System.Windows.Forms.Button();
            this.btnCadastroLocal = new System.Windows.Forms.Button();
            this.btnCadastroSecao = new System.Windows.Forms.Button();
            this.btnCadastroItemAcervo = new System.Windows.Forms.Button();
            this.btnCadastroLeitor = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnConsultaEmprestimos = new System.Windows.Forms.Button();
            this.btnConsultarItemAcervo = new System.Windows.Forms.Button();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenulivro)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMenulivro
            // 
            this.imgMenulivro.Image = global::MenuBiblioteca.Properties.Resources.menu_removebg_preview;
            this.imgMenulivro.Location = new System.Drawing.Point(339, 40);
            this.imgMenulivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgMenulivro.Name = "imgMenulivro";
            this.imgMenulivro.Size = new System.Drawing.Size(420, 343);
            this.imgMenulivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMenulivro.TabIndex = 1;
            this.imgMenulivro.TabStop = false;
            // 
            // btnCadastroAutor
            // 
            this.btnCadastroAutor.Location = new System.Drawing.Point(14, 17);
            this.btnCadastroAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroAutor.Name = "btnCadastroAutor";
            this.btnCadastroAutor.Size = new System.Drawing.Size(292, 35);
            this.btnCadastroAutor.TabIndex = 0;
            this.btnCadastroAutor.Text = "Cadastro Autor";
            this.btnCadastroAutor.UseVisualStyleBackColor = true;
            this.btnCadastroAutor.Click += new System.EventHandler(this.btnCadastroAutor_Click);
            // 
            // btnCadastroEditora
            // 
            this.btnCadastroEditora.Location = new System.Drawing.Point(14, 62);
            this.btnCadastroEditora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroEditora.Name = "btnCadastroEditora";
            this.btnCadastroEditora.Size = new System.Drawing.Size(292, 35);
            this.btnCadastroEditora.TabIndex = 1;
            this.btnCadastroEditora.Text = "Cadastro Editora";
            this.btnCadastroEditora.UseVisualStyleBackColor = true;
            this.btnCadastroEditora.Click += new System.EventHandler(this.btnCadastroEditora_Click);
            // 
            // btnCadastroLocal
            // 
            this.btnCadastroLocal.Location = new System.Drawing.Point(14, 106);
            this.btnCadastroLocal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroLocal.Name = "btnCadastroLocal";
            this.btnCadastroLocal.Size = new System.Drawing.Size(292, 35);
            this.btnCadastroLocal.TabIndex = 2;
            this.btnCadastroLocal.Text = "Cadastro Local";
            this.btnCadastroLocal.UseVisualStyleBackColor = true;
            this.btnCadastroLocal.Click += new System.EventHandler(this.btnCadastroLocal_Click);
            // 
            // btnCadastroSecao
            // 
            this.btnCadastroSecao.Location = new System.Drawing.Point(16, 151);
            this.btnCadastroSecao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroSecao.Name = "btnCadastroSecao";
            this.btnCadastroSecao.Size = new System.Drawing.Size(292, 35);
            this.btnCadastroSecao.TabIndex = 3;
            this.btnCadastroSecao.Text = "Cadastro Seção";
            this.btnCadastroSecao.UseVisualStyleBackColor = true;
            this.btnCadastroSecao.Click += new System.EventHandler(this.btnCadastroSecao_Click);
            // 
            // btnCadastroItemAcervo
            // 
            this.btnCadastroItemAcervo.Location = new System.Drawing.Point(14, 195);
            this.btnCadastroItemAcervo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroItemAcervo.Name = "btnCadastroItemAcervo";
            this.btnCadastroItemAcervo.Size = new System.Drawing.Size(292, 35);
            this.btnCadastroItemAcervo.TabIndex = 4;
            this.btnCadastroItemAcervo.Text = "Cadastro Item Acervo";
            this.btnCadastroItemAcervo.UseVisualStyleBackColor = true;
            this.btnCadastroItemAcervo.Click += new System.EventHandler(this.btnCadastroItemAcervo_Click);
            // 
            // btnCadastroLeitor
            // 
            this.btnCadastroLeitor.Location = new System.Drawing.Point(14, 240);
            this.btnCadastroLeitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastroLeitor.Name = "btnCadastroLeitor";
            this.btnCadastroLeitor.Size = new System.Drawing.Size(292, 35);
            this.btnCadastroLeitor.TabIndex = 5;
            this.btnCadastroLeitor.Text = "Cadastro Leitor";
            this.btnCadastroLeitor.UseVisualStyleBackColor = true;
            this.btnCadastroLeitor.Click += new System.EventHandler(this.btnCadastroLeitor_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Location = new System.Drawing.Point(16, 285);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(292, 35);
            this.btnReservas.TabIndex = 6;
            this.btnReservas.Text = "Reserva de Itens";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnConsultaEmprestimos
            // 
            this.btnConsultaEmprestimos.Location = new System.Drawing.Point(16, 329);
            this.btnConsultaEmprestimos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultaEmprestimos.Name = "btnConsultaEmprestimos";
            this.btnConsultaEmprestimos.Size = new System.Drawing.Size(292, 35);
            this.btnConsultaEmprestimos.TabIndex = 7;
            this.btnConsultaEmprestimos.Text = "Consultar Empréstimos";
            this.btnConsultaEmprestimos.UseVisualStyleBackColor = true;
            this.btnConsultaEmprestimos.Click += new System.EventHandler(this.btnConsultaEmprestimos_Click);
            // 
            // btnConsultarItemAcervo
            // 
            this.btnConsultarItemAcervo.Location = new System.Drawing.Point(16, 374);
            this.btnConsultarItemAcervo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultarItemAcervo.Name = "btnConsultarItemAcervo";
            this.btnConsultarItemAcervo.Size = new System.Drawing.Size(292, 35);
            this.btnConsultarItemAcervo.TabIndex = 8;
            this.btnConsultarItemAcervo.Text = "Consultar Itens Acervo";
            this.btnConsultarItemAcervo.UseVisualStyleBackColor = true;
            this.btnConsultarItemAcervo.Click += new System.EventHandler(this.btnConsultarItemAcervo_Click);
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnConsultarItemAcervo);
            this.pnlBotoes.Controls.Add(this.btnConsultaEmprestimos);
            this.pnlBotoes.Controls.Add(this.btnReservas);
            this.pnlBotoes.Controls.Add(this.btnCadastroLeitor);
            this.pnlBotoes.Controls.Add(this.btnCadastroItemAcervo);
            this.pnlBotoes.Controls.Add(this.btnCadastroSecao);
            this.pnlBotoes.Controls.Add(this.btnCadastroLocal);
            this.pnlBotoes.Controls.Add(this.btnCadastroEditora);
            this.pnlBotoes.Controls.Add(this.btnCadastroAutor);
            this.pnlBotoes.Location = new System.Drawing.Point(4, 2);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(326, 425);
            this.pnlBotoes.TabIndex = 0;
            // 
            // FormMenuBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 432);
            this.Controls.Add(this.imgMenulivro);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormMenuBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Movtech";
            this.Load += new System.EventHandler(this.FormMenuBiblioteca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMenulivro)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgMenulivro;
        private System.Windows.Forms.Button btnCadastroAutor;
        private System.Windows.Forms.Button btnCadastroEditora;
        private System.Windows.Forms.Button btnCadastroLocal;
        private System.Windows.Forms.Button btnCadastroSecao;
        private System.Windows.Forms.Button btnCadastroItemAcervo;
        private System.Windows.Forms.Button btnCadastroLeitor;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnConsultaEmprestimos;
        private System.Windows.Forms.Button btnConsultarItemAcervo;
        private System.Windows.Forms.Panel pnlBotoes;
    }
}