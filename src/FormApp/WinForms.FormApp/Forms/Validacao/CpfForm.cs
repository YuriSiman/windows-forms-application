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

namespace WinForms.FormApp.Forms.Validacao
{
    public partial class CpfForm : Form
    {
        public CpfForm()
        {
            InitializeComponent();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            var cpf = maskedTextBoxCPF.Text.Replace(".", "").Replace("-", "").Trim();
            ValidacaoCpfForm(cpf);
        }

        private void ValidacaoCpfForm(string cpf)
        {
            ValidacaoCPF validaCpf = new ValidacaoCPF();

            if (cpf == "")
            {
                MessageBox.Show("CPF não informado!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cpf.Length != 11)
                {
                    MessageBox.Show("O CPF deve conter 11 dígitos!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (validaCpf.ValidarCPF(cpf))
                        {
                            MessageBox.Show("CPF Válido!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido!", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCPF.Text = "";
            maskedTextBoxCPF.Focus();
        }
    }
}
