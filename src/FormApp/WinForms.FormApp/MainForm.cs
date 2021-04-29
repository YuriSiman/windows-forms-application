using System;
using System.Windows.Forms;
using WinForms.FormApp.Forms.Mascara;
using WinForms.FormApp.Forms.Validacao;
using WinForms.FormApp.UserControls.Demonstracao;
using WinForms.FormApp.UserControls.Sobre;

namespace WinForms.FormApp
{
    public partial class MainForm : Form
    {

        int tabPagContSobre = 0, tabPagContDemonstracao = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemDemonstracao_Click(object sender, EventArgs e)
        {
            tabPagContDemonstracao++;

            DemonstracaoKeyUC uc = new DemonstracaoKeyUC();
            TabPage tb = new TabPage();

            uc.Dock = DockStyle.Fill;
            tb.Name = $"Demonstração {tabPagContDemonstracao}";
            tb.Text = $"Demonstração {tabPagContDemonstracao}";
            tb.Controls.Add(uc);
            tabControlWindows.TabPages.Add(tb);
        }

        private void toolStripMenuItemValidacao_Click(object sender, EventArgs e)
        {
            MainValidacaoForm f = new MainValidacaoForm();
            f.ShowDialog();
        }

        private void toolStripMenuItemMascara_Click(object sender, EventArgs e)
        {
            MascaraForm f = new MascaraForm();
            f.ShowDialog();
        }

        private void toolStripMenuItemSobreAplicacao_Click(object sender, EventArgs e)
        {
            SobreUC uc = new SobreUC();
            TabPage tb = new TabPage();

            tabPagContSobre++;

            uc.Dock = DockStyle.Fill;
            tb.Name = $"Sobre a Aplicação {tabPagContSobre}";
            tb.Text = $"Sobre a Aplicação {tabPagContSobre}";
            tb.Controls.Add(uc);
            tabControlWindows.TabPages.Add(tb);
        }

        private void toolStripMenuItemFecharAba_Click(object sender, EventArgs e)
        {
            if(!(tabControlWindows.SelectedTab == null)) tabControlWindows.TabPages.Remove(tabControlWindows.SelectedTab);
        }

        private void toolStripMenuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
