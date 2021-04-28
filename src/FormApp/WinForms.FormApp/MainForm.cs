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

        private void toolStripMenuItemDemonstracao_Click(object sender, EventArgs e)
        {
            DemonstracaoKeyForm f = new DemonstracaoKeyForm();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripMenuItemValidacao_Click(object sender, EventArgs e)
        {
            MainValidacaoForm f = new MainValidacaoForm();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripMenuItemMascara_Click(object sender, EventArgs e)
        {
            MascaraForm f = new MascaraForm();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripMenuItemCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItemHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItemVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
