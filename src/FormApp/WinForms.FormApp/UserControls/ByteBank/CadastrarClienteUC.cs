using Microsoft.VisualBasic;
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
using WinForms.Library;
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
            c.CPF = maskedTextBoxCPF.Text.Replace('.', ' ').Replace('-', ' ').Replace(" ", String.Empty);
            c.Profissao = textBoxProfissao.Text;
            c.Email = textBoxEmail.Text;
            c.EmpresaAtual = textBoxAtualEmpresa.Text;
            c.UltimaEmpresa = textBoxUltimaEmpresa.Text;
            c.AtividadesDescricao = textBoxDescricao.Text;
            c.SalarioAtual = maskedTextBoxSalarioAtual.Text.Replace("R$", " ").Replace('.', ' ').Replace(',', ' ').Replace(" ", String.Empty);
            c.DataNascimento = maskedTextBoxDataNascimento.Text;
            c.EstadoCivil = textBoxEstadoCivil.Text;
            c.Celular = maskedTextBoxCelular.Text.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", String.Empty);
            c.Telefone = maskedTextBoxTelefone.Text.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", String.Empty);
            c.RendaFamiliar = maskedTextBoxRendaFamiliar.Text.Replace("R$", " ").Replace('.', ' ').Replace(',', ' ').Replace(" ", String.Empty);

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
            e.Numero = textBoxNumero.Text;

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
                string clienteJson = c.SerializedCliente(c);
                MessageBox.Show($"Cliente incluído: {clienteJson}", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void maskedTextBoxCEP_Leave(object sender, EventArgs e)
        {
            var vCep = maskedTextBoxCEP.Text;

            if (vCep.Replace('-',' ').Trim() != "")
            {
                Cep cep = new Cep();
                var json = BuscaCEP.GeraJSONCEP(maskedTextBoxCEP.Text);
                cep = cep.DesSerializedCep(json);
                textBoxBairro.Text = cep.Bairro;
                textBoxCidade.Text = cep.Localidade;
                textBoxLogradouro.Text = cep.Logradouro;

                comboBoxEstados.SelectedIndex = -1;

                for (int i = 0; i <= comboBoxEstados.Items.Count - 1; i++)
                {
                    var uf = Strings.InStr(comboBoxEstados.Items[i].ToString(), cep.UF);

                    if (uf > 0)
                    {
                        comboBoxEstados.SelectedIndex = i;
                    }
                }
            }
        }

        private void cleanToolStripButton_Click(object sender, EventArgs e)
        {
            textBoxCodigoCliente.Text = "";
            textBoxNomeCompleto.Text = "";
            maskedTextBoxCPF.Text = "";
            textBoxProfissao.Text = "";
            textBoxEmail.Text = "";
            textBoxAtualEmpresa.Text = "";
            textBoxUltimaEmpresa.Text = "";
            textBoxDescricao.Text = "";
            maskedTextBoxSalarioAtual.Text = "";
            maskedTextBoxDataNascimento.Text = "";
            textBoxEstadoCivil.Text = "";
            maskedTextBoxCelular.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxRendaFamiliar.Text = "";
            textBoxLogradouro.Text = "";
            textBoxBairro.Text = "";
            textBoxCidade.Text = "";
            maskedTextBoxCEP.Text = "";
            textBoxComplemento.Text = "";
            textBoxNumero.Text = "";
            comboBoxEstados.SelectedIndex = -1;
            checkBoxDesempregado.Checked = false;
            radioButtonMasculino.Checked = true;
        }
    }
}
