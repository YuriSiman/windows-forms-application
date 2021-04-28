using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.FormApp.Forms.Demonstracao
{
    public partial class DemonstracaoKeyForm : Form
    {
        public DemonstracaoKeyForm()
        {
            InitializeComponent();
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            var tecla = e.KeyCode;

            textBoxMsg.AppendText($"\r\nTecla: {tecla} \t Código ASCII: {(int)tecla}\r\n");
            labelUpper.Text = tecla.ToString().ToUpper();
            labelLower.Text = tecla.ToString().ToLower();
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxMsg.Text = "";
            labelUpper.Text = "";
            labelLower.Text = "";
            textBoxInput.Focus();
        }

        private void buttonNome_Click(object sender, EventArgs e)
        {
            labelNome.Text = textBoxNome.Text;
        }

        private void buttonLimparNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
