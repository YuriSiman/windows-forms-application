
namespace WinForms.FormApp.Forms.Validacao
{
    partial class SenhaForm
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
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonVerSenha = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(12, 42);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(276, 27);
            this.textBoxSenha.TabIndex = 0;
            this.textBoxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSenha_KeyDown);
            // 
            // buttonVerSenha
            // 
            this.buttonVerSenha.Location = new System.Drawing.Point(44, 98);
            this.buttonVerSenha.Name = "buttonVerSenha";
            this.buttonVerSenha.Size = new System.Drawing.Size(94, 29);
            this.buttonVerSenha.TabIndex = 1;
            this.buttonVerSenha.Text = "Ver Senha";
            this.buttonVerSenha.UseVisualStyleBackColor = true;
            this.buttonVerSenha.Click += new System.EventHandler(this.buttonVerSenha_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(158, 98);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(94, 29);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(126, 9);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(0, 20);
            this.labelSenha.TabIndex = 3;
            // 
            // SenhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 165);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonVerSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Name = "SenhaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SenhaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonVerSenha;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label labelSenha;
    }
}