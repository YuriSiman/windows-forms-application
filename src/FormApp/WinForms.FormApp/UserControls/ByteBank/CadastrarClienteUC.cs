using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Domain.Entities;
using WinForms.Library.Validations;

namespace WinForms.FormApp.UserControls.ByteBank
{
    public partial class CadastrarClienteUC : UserControl
    {
        public CadastrarClienteUC()
        {
            InitializeComponent();
        }

        private void ClienteTrabalhaAtualmente(bool result)
        {
            textBoxAtualEmpresa.Enabled = result;
            textBoxUltimaEmpresa.Enabled = result;
            maskedTextBoxSalarioAtual.Enabled = result;
        }

        private Cliente LeituraFormulario()
        {
            Cliente c = new Cliente();
            c.Codigo = textBoxCodigoCliente.Text;
            c.Nome = textBoxNomeCompleto.Text;
            c.CPF = maskedTextBoxCPF.Text;
            c.Profissao = textBoxProfissao.Text;
            c.Email = maskedTextBoxEmail.Text;
            c.EmpresaAtual = textBoxAtualEmpresa.Text;
            c.UltimaEmpresa = textBoxUltimaEmpresa.Text;
            c.AtividadesDescricao = textBoxDescricao.Text;
            c.SalarioAtual = double.Parse(maskedTextBoxSalarioAtual.Text);
            c.DataNascimento = DateTime.Parse(maskedTextBoxDataNascimento.Text);
            c.EstadoCivil = textBoxEstadoCivil.Text;
            c.Celular = maskedTextBoxCelular.Text;
            c.Telefone = maskedTextBoxTelefone.Text;
            c.RendaFamiliar = double.Parse(maskedTextBoxRendaFamiliar.Text);

            if (checkBoxDesempregado.Checked)
            {
                c.Desempregado = true;
            }
            else
            {
                c.Desempregado = false;
            }

            if (radioButtonMasculino.Checked)
            {
                c.Sexo = "Masculino";
            }
            else
            {
                c.Sexo = "Feminino";
            }

            c.Endereco = LeituraEndereco();

            return c;
        }

        private Endereco LeituraEndereco()
        {
            Endereco e = new Endereco();
            e.Logradouro = textBoxLogradouro.Text;
            e.Bairro = textBoxBairro.Text;
            e.Cidade = textBoxCidade.Text;
            e.CEP = maskedTextBoxCEP.Text;
            e.Complemento = textBoxComplemento.Text;
            e.Numero = int.Parse(maskedTextBoxNumero.Text);

            if (comboBoxEstados.SelectedIndex < 0)
            {
                e.Estado = "";
            }
            else
            {
                e.Estado = comboBoxEstados.Items[comboBoxEstados.SelectedIndex].ToString();
            }
           
            return e;
        }

        

        private void checkBoxNaoTrabalho_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDesempregado.Checked)
            {
                ClienteTrabalhaAtualmente(false);
            }
            else
            {
                ClienteTrabalhaAtualmente(true);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                c = LeituraFormulario();
                c.Validate();
                c.ValidaInformacoes();
                MessageBox.Show("Classe iniciada sem erros", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


    }
}
