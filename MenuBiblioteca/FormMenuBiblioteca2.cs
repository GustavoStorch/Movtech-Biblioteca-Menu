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
    public partial class FormMenuBiblioteca2 : Form
    {
        public FormMenuBiblioteca2()
        {
            InitializeComponent();
        }

        private void btnCadastroAutor_Click(object sender, EventArgs e)
        {
            CadastroAutor.FormCadAutor formCadastroAutor = new CadastroAutor.FormCadAutor();
            formCadastroAutor.ShowDialog();
        }

        private void btnCadastroEditora_Click(object sender, EventArgs e)
        {
            CadastroEditora.FormCadEditora formCadEditora = new CadastroEditora.FormCadEditora();
            formCadEditora.ShowDialog();
        }

        private void btnCadastroLocal_Click(object sender, EventArgs e)
        {
            CadastroLocal.FormCadLocal formCadLocal = new CadastroLocal.FormCadLocal();
            formCadLocal.ShowDialog();
        }

        private void btnCadastroSecao_Click(object sender, EventArgs e)
        {
            CadastroSecao.FormCadSecao formCadSecao = new CadastroSecao.FormCadSecao();
            formCadSecao.ShowDialog();
        }

        private void btnCadastroItemAcervo_Click(object sender, EventArgs e)
        {
            CadastroItemDoAcervo.FormCadItemAcervo formCadItemAcervo = new CadastroItemDoAcervo.FormCadItemAcervo();
            formCadItemAcervo.ShowDialog();
        }

        private void btnCadastroLeitor_Click(object sender, EventArgs e)
        {
            CadastroLeitor.FormCadLeitor formCadLeitor = new CadastroLeitor.FormCadLeitor();
            formCadLeitor.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ReservaItemAcervo.FormReservaItemAcervo formReservaItemAcervo = new ReservaItemAcervo.FormReservaItemAcervo();
            formReservaItemAcervo.ShowDialog();
        }

        private void btnConsultaEmprestimos_Click(object sender, EventArgs e)
        {
            ConsultaEmprestimo.FormConsultaEmprestimo formConsultaEmprestimo = new ConsultaEmprestimo.FormConsultaEmprestimo();
            formConsultaEmprestimo.ShowDialog();
        }

        private void btnConsultarItemAcervo_Click(object sender, EventArgs e)
        {
            ConsultaItemAcervo.FormConsultaItem formConsultaItem = new ConsultaItemAcervo.FormConsultaItem();
            formConsultaItem.ShowDialog();
        }

        private void FormMenuBiblioteca_Load(object sender, EventArgs e)
        {

        }
    }
}
