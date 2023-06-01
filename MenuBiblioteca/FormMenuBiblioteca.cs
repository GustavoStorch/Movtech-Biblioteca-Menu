using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuBiblioteca
{
    public partial class FormMenuBiblioteca : Form
    {
        public FormMenuBiblioteca()
        {
            InitializeComponent();
        }

        private void movReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservaItemAcervo.FormReservaItemAcervo form = new ReservaItemAcervo.FormReservaItemAcervo();
            form.ShowDialog();
        }

        private void cadastroDeAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAutor.FormCadAutor formCadastroAutor = new CadastroAutor.FormCadAutor();
            formCadastroAutor.ShowDialog();
        }

        private void cadastroDeEditoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEditora.FormCadEditora formCadEditora = new CadastroEditora.FormCadEditora();
            formCadEditora.ShowDialog();
        }

        private void cadastroDeLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLocal.FormCadLocal formCadLocal = new CadastroLocal.FormCadLocal();
            formCadLocal.ShowDialog();
        }

        private void cadastroDeSeçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroSecao.FormCadSecao formCadSecao = new CadastroSecao.FormCadSecao();
            formCadSecao.ShowDialog();
        }

        private void cadastroDeItemDoAcervoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroItemDoAcervo.FormCadItemAcervo formCadItemAcervo = new CadastroItemDoAcervo.FormCadItemAcervo();
            formCadItemAcervo.ShowDialog();
        }

        private void cadastroDeLeitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroLeitor.FormCadLeitor formCadLeitor = new CadastroLeitor.FormCadLeitor();
            formCadLeitor.ShowDialog();
        }

        private void consultarEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEmprestimo.FormConsultaEmprestimo formConsultaEmprestimo = new ConsultaEmprestimo.FormConsultaEmprestimo();
            formConsultaEmprestimo.ShowDialog();
        }

        private void consultarItemDoAcervoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaItemAcervo.FormConsultaItem formConsultaItem = new ConsultaItemAcervo.FormConsultaItem();
            formConsultaItem.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
