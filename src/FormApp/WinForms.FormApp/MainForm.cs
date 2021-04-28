using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.FormApp.Forms.Demonstracao;
using WinForms.FormApp.Forms.Mascara;
using WinForms.FormApp.Forms.Validacao;

namespace WinForms.FormApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDemonstracao_Click(object sender, EventArgs e)
        {
            DemonstracaoKeyForm f = new DemonstracaoKeyForm();
            f.ShowDialog();
        }

        private void buttonMascara_Click(object sender, EventArgs e)
        {
            MascaraForm f = new MascaraForm();
            f.ShowDialog();
        }

        private void buttonValidacao_Click(object sender, EventArgs e)
        {
            MainValidacaoForm f = new MainValidacaoForm();
            f.ShowDialog();
        }
    }
}
