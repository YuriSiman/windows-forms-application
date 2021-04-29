using System.Windows.Forms;

namespace WinForms.FormApp.UserControls.AbrirArquivo
{
    public partial class AbrirArquivoUC : UserControl
    {
        public AbrirArquivoUC(string nomeArquivo)
        {
            InitializeComponent();
            labelAbrirArquivo.Text = nomeArquivo;
        }

        private void buttonCor_Click(object sender, System.EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK) labelAbrirArquivo.ForeColor = color.Color;
        }

        private void buttonFonte_Click(object sender, System.EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK) labelAbrirArquivo.Font = font.Font;
        }
    }
}
