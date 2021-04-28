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
using WinForms.Library.Validations.Enums;

namespace WinForms.FormApp.Forms.Validacao
{
    public partial class SenhaForm : Form
    {
        public SenhaForm()
        {
            InitializeComponent();
        }

        private void buttonVerSenha_Click(object sender, EventArgs e)
        {
            if (textBoxSenha.PasswordChar != '\0')
            {
                textBoxSenha.PasswordChar = '\0';
                buttonVerSenha.Text = "Esconder Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                buttonVerSenha.Text = "Ver Senha";
            }
            
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            ValidacaoForcaSenha validarSenha = new ValidacaoForcaSenha();

            ForcaSenha forca = validarSenha.GetForcaDaSenha(textBoxSenha.Text);
            labelSenha.Text = forca.ToString();

            if (labelSenha.Text == "Inaceitavel" || labelSenha.Text == "Fraca")
            {
                labelSenha.ForeColor = Color.Red;
            }
            else if (labelSenha.Text == "Aceitavel")
            {
                labelSenha.ForeColor = Color.Blue;
            }
            else
            {
                labelSenha.ForeColor = Color.Green;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxSenha.Text = "";
            labelSenha.Text = "";
            textBoxSenha.Focus();
        }
    }
}
