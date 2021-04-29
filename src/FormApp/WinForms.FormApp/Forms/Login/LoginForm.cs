using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Library.Validations;

namespace WinForms.FormApp.Forms.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            ValidacaoSenha validacao = new ValidacaoSenha();

            var usuario = textBoxUsuario.Text;
            var senha = textBoxSenha.Text;

            if(!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(senha))
            {
                if (validacao.ValidaSenhaLogin(usuario, senha))
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gentileza informar Usuário e Senha!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}
