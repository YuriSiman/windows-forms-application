using System;
using System.Drawing;
using System.Windows.Forms;
using WinForms.FormApp.Forms.Login;
using WinForms.FormApp.Forms.Mascara;
using WinForms.FormApp.Forms.Validacao;
using WinForms.FormApp.UserControls.AbrirArquivo;
using WinForms.FormApp.UserControls.Demonstracao;
using WinForms.FormApp.UserControls.Sobre;

namespace WinForms.FormApp
{
    public partial class MainForm : Form
    {

        int tabPagContSobre = 0, tabPagContDemonstracao = 0, tabPagContDiretorio = 0;

        public MainForm()
        {
            InitializeComponent();
            HabilitarAbas(false);
        }

        private void HabilitarAbas(bool result)
        {
            toolStripMenuItemAbrir.Enabled = result;
            toolStripMenuItemFecharAba.Enabled = result;
            toolStripMenuItemNovo.Enabled = result;
            toolStripMenuItemSobreAplicacao.Enabled = result;
            toolStripMenuItemSairUsuario.Enabled = result;
            toolStripMenuItemAlterarUsuario.Enabled = result;
        }

        private void ZerarContadorAbas()
        {
            tabPagContSobre = 0;
            tabPagContDemonstracao = 0;
            tabPagContDiretorio = 0;
        }

        private ToolStripMenuItem DesenhaItemMenu(string text)
        {
            var toolMenuItem = new ToolStripMenuItem();
            toolMenuItem.Text = text;
            return toolMenuItem;
        }

        private void ApagarAbasEsquerda(int tabSelecionada)
        {
            for (int i = tabSelecionada - 1; i >= 0; i--)
            {
                tabControlWindows.TabPages.Remove(tabControlWindows.TabPages[i]);
            }
        }

        private void ApagarAbasDireita(int tabSelecionada)
        {
            for (int i = tabControlWindows.TabCount - 1; i > tabSelecionada; i--)
            {
                tabControlWindows.TabPages.Remove(tabControlWindows.TabPages[i]);
            }
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
            if (!(tabControlWindows.SelectedTab == null)) tabControlWindows.TabPages.Remove(tabControlWindows.SelectedTab);
        }

        private void toolStripMenuItemNovoUsuario_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                HabilitarAbas(true);
                toolStripMenuItemNovoUsuario.Enabled = false;
            }
        }

        private void toolStripMenuItemAlterarUsuario_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {
                for (int i = tabControlWindows.TabPages.Count - 1; i >= 0; i--)
                {
                    tabControlWindows.TabPages.Remove(tabControlWindows.TabPages[i]);
                }

                ZerarContadorAbas();
                HabilitarAbas(true);
                toolStripMenuItemNovoUsuario.Enabled = false;
            }
        }

        private void toolStripMenuItemSairUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = tabControlWindows.TabPages.Count - 1; i >= 0; i--)
                {
                    tabControlWindows.TabPages.Remove(tabControlWindows.TabPages[i]);
                }

                ZerarContadorAbas();
                HabilitarAbas(false);
                toolStripMenuItemNovoUsuario.Enabled = true;
            }
        }

        private void toolStripMenuItemNovoArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Title = "Escolha o arquivo";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var nomeArquivo = fileDialog.FileName;


                AbrirArquivoUC uc = new AbrirArquivoUC(nomeArquivo);
                TabPage tb = new TabPage();

                tabPagContDiretorio++;

                uc.Dock = DockStyle.Fill;
                tb.Name = $"Diretório {tabPagContDiretorio}";
                tb.Text = $"Diretório {tabPagContDiretorio}";
                tb.Controls.Add(uc);
                tabControlWindows.TabPages.Add(tb);
            }
        }

        private void tabControlWindows_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var contextMenu = new ContextMenuStrip();
                var toolMenuItem1 = DesenhaItemMenu("Fechar Aba");
                var toolMenuItem2 = DesenhaItemMenu("Fechar Todas as Abas da Esquerda");
                var toolMenuItem3 = DesenhaItemMenu("Fechar Todas as Abas da Direita");
                var toolMenuItem4 = DesenhaItemMenu("Fechar Todas as Abas");
                contextMenu.Items.Add(toolMenuItem1);
                contextMenu.Items.Add(toolMenuItem2);
                contextMenu.Items.Add(toolMenuItem3);
                contextMenu.Items.Add(toolMenuItem4);
                contextMenu.Show(this, new Point(e.X, e.Y));
                toolMenuItem1.Click += new EventHandler(toolMenuItem1_Click);
                toolMenuItem2.Click += new EventHandler(toolMenuItem2_Click);
                toolMenuItem3.Click += new EventHandler(toolMenuItem3_Click);
                toolMenuItem4.Click += new EventHandler(toolMenuItem4_Click);
            }
        }

        private void toolMenuItem1_Click(object sender, EventArgs e)
        {
            tabControlWindows.TabPages.Remove(tabControlWindows.SelectedTab);
        }

        private void toolMenuItem2_Click(object sender, EventArgs e)
        {
            ApagarAbasEsquerda(tabControlWindows.SelectedIndex);
        }

        private void toolMenuItem3_Click(object sender, EventArgs e)
        {
            ApagarAbasDireita(tabControlWindows.SelectedIndex);
        }

        private void toolMenuItem4_Click(object sender, EventArgs e)
        {
            ApagarAbasEsquerda(tabControlWindows.SelectedIndex);
            ApagarAbasDireita(tabControlWindows.SelectedIndex);
            tabControlWindows.TabPages.Remove(tabControlWindows.SelectedTab);
        }

        private void toolStripMenuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
