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

                c.Id = textBoxCodigoCliente.Text;
                c.Validate();
                MessageBox.Show("Classe iniciada sem erros", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
