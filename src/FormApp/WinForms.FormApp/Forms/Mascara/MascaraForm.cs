using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.FormApp.Forms.Mascara
{
    public partial class MascaraForm : Form
    {
        public MascaraForm()
        {
            InitializeComponent();
        }

        private void Formatacao(string mask, bool passwordChar)
        {
            maskedTextBoxMascara.Text = "";
            maskedTextBoxMascara.Mask = mask;
            maskedTextBoxMascara.UseSystemPasswordChar = passwordChar;
            maskedTextBoxMascara.Focus();
        }

        private void buttonHora_Click(object sender, EventArgs e)
        {
            Formatacao("00:00", false);
        }

        private void buttonCEP_Click(object sender, EventArgs e)
        {
            Formatacao("00000-000", false);
        }

        private void buttonMoeda_Click(object sender, EventArgs e)
        {
            Formatacao("$ 000.00", false);
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            Formatacao("00/00/0000", false);
        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            Formatacao("000000", true);
        }

        private void buttonCelular_Click(object sender, EventArgs e)
        {
            Formatacao("(00) 00000-0000", false);
        }

        private void buttonConteudo_Click(object sender, EventArgs e)
        {
            labelConteudo.Text = maskedTextBoxMascara.Text;
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
