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
            this.imgMenulivro.Location = new System.Drawing.Point(226, 26);
            this.imgMenulivro.Name = "imgMenulivro";
            this.imgMenulivro.Size = new System.Drawing.Size(280, 223);
            this.imgMenulivro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMenulivro.TabIndex = 1;
            this.imgMenulivro.TabStop = false;
            // 
            // btnCadastroAutor
            // 
            this.btnCadastroAutor.Location = new System.Drawing.Point(9, 11);
            this.btnCadastroAutor.Name = "btnCadastroAutor";
            this.btnCadastroAutor.Size = new System.Drawing.Size(195, 23);
            this.btnCadastroAutor.TabIndex = 0;
            this.btnCadastroAutor.Text = "Cadastro Autor";
            this.btnCadastroAutor.UseVisualStyleBackColor = true;
            this.btnCadastroAutor.Click += new System.EventHandler(this.btnCadastroAutor_Click);
            // 
            // btnCadastroEditora
            // 
            this.btnCadastroEditora.Location = new System.Drawing.Point(9, 40);
            this.btnCadastroEditora.Name = "btnCadastroEditora";
            this.btnCadastroEditora.Size = new System.Drawing.Size(195, 23);
            this.btnCadastroEditora.TabIndex = 1;
            this.btnCadastroEditora.Text = "Cadastro Editora";
            this.btnCadastroEditora.UseVisualStyleBackColor = true;
            this.btnCadastroEditora.Click += new System.EventHandler(this.btnCadastroEditora_Click);
            // 
            // btnCadastroLocal
            // 
            this.btnCadastroLocal.Location = new System.Drawing.Point(9, 69);
            this.btnCadastroLocal.Name = "btnCadastroLocal";
            this.btnCadastroLocal.Size = new System.Drawing.Size(195, 23);
            this.btnCadastroLocal.TabIndex = 2;
            this.btnCadastroLocal.Text = "Cadastro Local";
            this.btnCadastroLocal.UseVisualStyleBackColor = true;
            this.btnCadastroLocal.Click += new System.EventHandler(this.btnCadastroLocal_Click);
            // 
            // btnCadastroSecao
            // 
            this.btnCadastroSecao.Location = new System.Drawing.Point(11, 98);
            this.btnCadastroSecao.Name = "btnCadastroSecao";
            this.btnCadastroSecao.Size = new System.Drawing.Size(195, 23);
            this.btnCadastroSecao.TabIndex = 3;
            this.btnCadastroSecao.Text = "Cadastro Seção";
            this.btnCadastroSecao.UseVisualStyleBackColor = true;
            this.btnCadastroSecao.Click += new System.EventHandler(this.btnCadastroSecao_Click);
            // 
            // btnCadastroItemAcervo
            // 
            this.btnCadastroItemAcervo.Location = new System.Drawing.Point(9, 127);
            this.btnCadastroItemAcervo.Name = "btnCadastroItemAcervo";
            this.btnCadastroItemAcervo.Size = new System.Drawing.Size(195, 23);
            this.btnCadastroItemAcervo.TabIndex = 4;
            this.btnCadastroItemAcervo.Text = "Cadastro Item Acervo";
            this.btnCadastroItemAcervo.UseVisualStyleBackColor = true;
            this.btnCadastroItemAcervo.Click += new System.EventHandler(this.btnCadastroItemAcervo_Click);
            // 
            // btnCadastroLeitor
            // 
            this.btnCadastroLeitor.Location = new System.Drawing.Point(9, 156);
            this.btnCadastroLeitor.Name = "btnCadastroLeitor";
            this.btnCadastroLeitor.Size = new System.Drawing.Size(195, 23);
            this.btnCadastroLeitor.TabIndex = 5;
            this.btnCadastroLeitor.Text = "Cadastro Leitor";
            this.btnCadastroLeitor.UseVisualStyleBackColor = true;
            this.btnCadastroLeitor.Click += new System.EventHandler(this.btnCadastroLeitor_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Location = new System.Drawing.Point(11, 185);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(195, 23);
            this.btnReservas.TabIndex = 6;
            this.btnReservas.Text = "Reserva de Itens";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnConsultaEmprestimos
            // 
            this.btnConsultaEmprestimos.Location = new System.Drawing.Point(11, 214);
            this.btnConsultaEmprestimos.Name = "btnConsultaEmprestimos";
            this.btnConsultaEmprestimos.Size = new System.Drawing.Size(195, 23);
            this.btnConsultaEmprestimos.TabIndex = 7;
            this.btnConsultaEmprestimos.Text = "Consultar Empréstimos";
            this.btnConsultaEmprestimos.UseVisualStyleBackColor = true;
            this.btnConsultaEmprestimos.Click += new System.EventHandler(this.btnConsultaEmprestimos_Click);
            // 
            // btnConsultarItemAcervo
            // 
            this.btnConsultarItemAcervo.Location = new System.Drawing.Point(11, 243);
            this.btnConsultarItemAcervo.Name = "btnConsultarItemAcervo";
            this.btnConsultarItemAcervo.Size = new System.Drawing.Size(195, 23);
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
            this.pnlBotoes.Location = new System.Drawing.Point(3, 1);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(217, 276);
            this.pnlBotoes.TabIndex = 0;
            // 
            // FormMenuBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 282);
            this.Controls.Add(this.imgMenulivro);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "FormMenuBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Movtech";
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