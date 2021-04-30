using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
