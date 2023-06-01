using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuBiblioteca
{
    public partial class FormLoginBiblioteca : Form
    {
        public FormLoginBiblioteca()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    LoginDAO dao = new LoginDAO(connection);
                    FormMenuBiblioteca formMenuBiblioteca = new FormMenuBiblioteca();
                    FormLoginBiblioteca formLoginBiblioteca = new FormLoginBiblioteca();

                    bool verifica = dao.VerificaLogin(new LoginModel()
                    {
                        Usuario = txtNomeUsuário.Text,
                        Senha = txtSenhaUsuario.Text
                    });

                    if (verifica)
                    {
                        MessageBox.Show("Logado com sucesso!");
                        formMenuBiblioteca.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorreto!");
                    }
                }
            }catch(Exception ex) {
                throw ex;
            }
        }

        private void FormLoginBiblioteca_Load(object sender, EventArgs e)
        {

        }
    }
}
