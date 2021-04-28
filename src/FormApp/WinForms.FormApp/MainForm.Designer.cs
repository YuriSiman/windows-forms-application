
namespace WinForms.FormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDemonstracao = new System.Windows.Forms.Button();
            this.buttonValidacao = new System.Windows.Forms.Button();
            this.buttonMascara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDemonstracao
            // 
            this.buttonDemonstracao.Location = new System.Drawing.Point(249, 180);
            this.buttonDemonstracao.Name = "buttonDemonstracao";
            this.buttonDemonstracao.Size = new System.Drawing.Size(296, 29);
            this.buttonDemonstracao.TabIndex = 0;
            this.buttonDemonstracao.Text = "Demonstrações";
            this.buttonDemonstracao.UseVisualStyleBackColor = true;
            this.buttonDemonstracao.Click += new System.EventHandler(this.buttonDemonstracao_Click);
            // 
            // buttonValidacao
            // 
            this.buttonValidacao.Location = new System.Drawing.Point(249, 231);
            this.buttonValidacao.Name = "buttonValidacao";
            this.buttonValidacao.Size = new System.Drawing.Size(296, 29);
            this.buttonValidacao.TabIndex = 3;
            this.buttonValidacao.Text = "Validações";
            this.buttonValidacao.UseVisualStyleBackColor = true;
            this.buttonValidacao.Click += new System.EventHandler(this.buttonValidacao_Click);
            // 
            // buttonMascara
            // 
            this.buttonMascara.Location = new System.Drawing.Point(249, 281);
            this.buttonMascara.Name = "buttonMascara";
            this.buttonMascara.Size = new System.Drawing.Size(296, 29);
            this.buttonMascara.TabIndex = 4;
            this.buttonMascara.Text = "Máscaras";
            this.buttonMascara.UseVisualStyleBackColor = true;
            this.buttonMascara.Click += new System.EventHandler(this.buttonMascara_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMascara);
            this.Controls.Add(this.buttonValidacao);
            this.Controls.Add(this.buttonDemonstracao);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDemonstracao;
        private System.Windows.Forms.Button buttonValidacao;
        private System.Windows.Forms.Button buttonMascara;
    }
}

