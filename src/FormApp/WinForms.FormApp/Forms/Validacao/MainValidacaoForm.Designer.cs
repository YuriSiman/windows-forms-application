
namespace WinForms.FormApp.Forms.Validacao
{
    partial class MainValidacaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCPF = new System.Windows.Forms.Button();
            this.buttonSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCPF
            // 
            this.buttonCPF.Location = new System.Drawing.Point(192, 174);
            this.buttonCPF.Name = "buttonCPF";
            this.buttonCPF.Size = new System.Drawing.Size(139, 29);
            this.buttonCPF.TabIndex = 0;
            this.buttonCPF.Text = "CPF";
            this.buttonCPF.UseVisualStyleBackColor = true;
            this.buttonCPF.Click += new System.EventHandler(this.buttonCPF_Click);
            // 
            // buttonSenha
            // 
            this.buttonSenha.Location = new System.Drawing.Point(192, 225);
            this.buttonSenha.Name = "buttonSenha";
            this.buttonSenha.Size = new System.Drawing.Size(139, 29);
            this.buttonSenha.TabIndex = 1;
            this.buttonSenha.Text = "Senha";
            this.buttonSenha.UseVisualStyleBackColor = true;
            // 
            // MainValidacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 491);
            this.Controls.Add(this.buttonSenha);
            this.Controls.Add(this.buttonCPF);
            this.Name = "MainValidacaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Validações";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCPF;
        private System.Windows.Forms.Button buttonSenha;
    }
}