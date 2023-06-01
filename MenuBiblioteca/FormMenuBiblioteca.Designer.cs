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
            this.msMenuBib = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeEditoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeSeçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeItemDoAcervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeLeitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpréstimoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarItemDoAcervoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgMenuBib = new System.Windows.Forms.PictureBox();
            this.msMenuBib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuBib)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuBib
            // 
            this.msMenuBib.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenuBib.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMenuBib.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenuBib.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movReservaToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.msMenuBib.Location = new System.Drawing.Point(0, 0);
            this.msMenuBib.Name = "msMenuBib";
            this.msMenuBib.Size = new System.Drawing.Size(692, 33);
            this.msMenuBib.TabIndex = 0;
            this.msMenuBib.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAutorToolStripMenuItem,
            this.cadastroDeEditoraToolStripMenuItem,
            this.cadastroDeLocalToolStripMenuItem,
            this.cadastroDeSeçãoToolStripMenuItem,
            this.cadastroDeItemDoAcervoToolStripMenuItem,
            this.cadastroDeLeitorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeAutorToolStripMenuItem
            // 
            this.cadastroDeAutorToolStripMenuItem.Name = "cadastroDeAutorToolStripMenuItem";
            this.cadastroDeAutorToolStripMenuItem.Size = new System.Drawing.Size(338, 34);
            this.cadastroDeAutorToolStripMenuItem.Text = "Cadastro de Autor";
            this.cadastroDeAutorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAutorToolStripMenuItem_Click);
            // 
            // cadastroDeEditoraToolStripMenuItem
            // 
            this.cadastroDeEditoraToolStripMenuItem.Name = "cadastroDeEditoraToolStripMenuItem";
            this.cadastroDeEditoraToolStripMenuItem.Size = new System.Drawing.Size(338, 34);
            this.cadastroDeEditoraToolStripMenuItem.Text = "Cadastro de Editora";
            this.cadastroDeEditoraToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeEditoraToolStripMenuItem_Click);
            // 
            // cadastroDeLocalToolStripMenuItem
            // 
            this.cadastroDeLocalToolStripMenuItem.Name = "cadastroDeLocalToolStripMenuItem";
            this.cadastroDeLocalToolStripMenuItem.Size = new System.Drawing.Size(338, 34);
            this.cadastroDeLocalToolStripMenuItem.Text = "Cadastro de Local";
            this.cadastroDeLocalToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLocalToolStripMenuItem_Click);
            // 
            // cadastroDeSeçãoToolStripMenuItem
            // 
            this.cadastroDeSeçãoToolStripMenuItem.Name = "cadastroDeSeçãoToolStripMenuItem";
            this.cadastroDeSeçãoToolStripMenuItem.Size = new System.Drawing.Size(338, 34);
            this.cadastroDeSeçãoToolStripMenuItem.Text = "Cadastro de Seção";
            this.cadastroDeSeçãoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeSeçãoToolStripMenuItem_Click);
            // 
            // cadastroDeItemDoAcervoToolStripMenuItem
            // 
            this.cadastroDeItemDoAcervoToolStripMenuItem.Name = "cadastroDeItemDoAcervoToolStripMenuItem";
            this.cadastroDeItemDoAcervoToolStripMenuItem.Size = new System.Drawing.Size(338, 34);
            this.cadastroDeItemDoAcervoToolStripMenuItem.Text = "Cadastro de Item do Acervo";
            this.cadastroDeItemDoAcervoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeItemDoAcervoToolStripMenuItem_Click);
            // 
            // cadastroDeLeitorToolStripMenuItem
            // 
            this.cadastroDeLeitorToolStripMenuItem.Name = "cadastroDeLeitorToolStripMenuItem";
            this.cadastroDeLeitorToolStripMenuItem.Size = new System.Drawing.Size(338, 34);
            this.cadastroDeLeitorToolStripMenuItem.Text = "Cadastro de Leitor";
            this.cadastroDeLeitorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeLeitorToolStripMenuItem_Click);
            // 
            // movReservaToolStripMenuItem
            // 
            this.movReservaToolStripMenuItem.Name = "movReservaToolStripMenuItem";
            this.movReservaToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.movReservaToolStripMenuItem.Text = "Mov Reserva";
            this.movReservaToolStripMenuItem.Click += new System.EventHandler(this.movReservaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarEmpréstimoToolStripMenuItem,
            this.consultarItemDoAcervoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarEmpréstimoToolStripMenuItem
            // 
            this.consultarEmpréstimoToolStripMenuItem.Name = "consultarEmpréstimoToolStripMenuItem";
            this.consultarEmpréstimoToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.consultarEmpréstimoToolStripMenuItem.Text = "Consultar Empréstimo";
            this.consultarEmpréstimoToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpréstimoToolStripMenuItem_Click);
            // 
            // consultarItemDoAcervoToolStripMenuItem
            // 
            this.consultarItemDoAcervoToolStripMenuItem.Name = "consultarItemDoAcervoToolStripMenuItem";
            this.consultarItemDoAcervoToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.consultarItemDoAcervoToolStripMenuItem.Text = "Consultar Item do Acervo";
            this.consultarItemDoAcervoToolStripMenuItem.Click += new System.EventHandler(this.consultarItemDoAcervoToolStripMenuItem_Click);
            // 
            // imgMenuBib
            // 
            this.imgMenuBib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgMenuBib.Image = global::MenuBiblioteca.Properties.Resources.movtechBib;
            this.imgMenuBib.Location = new System.Drawing.Point(45, 56);
            this.imgMenuBib.Name = "imgMenuBib";
            this.imgMenuBib.Size = new System.Drawing.Size(607, 327);
            this.imgMenuBib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMenuBib.TabIndex = 1;
            this.imgMenuBib.TabStop = false;
            // 
            // FormMenuBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 414);
            this.Controls.Add(this.imgMenuBib);
            this.Controls.Add(this.msMenuBib);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Movtech";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenuBib.ResumeLayout(false);
            this.msMenuBib.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMenuBib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuBib;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEditoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeSeçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeItemDoAcervoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeLeitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpréstimoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarItemDoAcervoToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgMenuBib;
    }
}