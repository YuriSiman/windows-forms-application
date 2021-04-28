using System;
using System.Windows.Forms;

namespace WinForms.FormApp.Forms.Validacao
{
    public partial class MainValidacaoForm : Form
    {
        public MainValidacaoForm()
        {
            InitializeComponent();
        }

        private void buttonCPF_Click(object sender, EventArgs e)
        {
            CpfForm f = new CpfForm();
            f.ShowDialog();
        }

        private void buttonSenha_Click(object sender, EventArgs e)
        {
            SenhaForm f = new SenhaForm();
            f.ShowDialog();
        }
    }
}
