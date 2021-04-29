
namespace WinForms.FormApp.UserControls.AbrirArquivo
{
    partial class AbrirArquivoUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAbrirArquivo = new System.Windows.Forms.Label();
            this.buttonCor = new System.Windows.Forms.Button();
            this.buttonFonte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAbrirArquivo
            // 
            this.labelAbrirArquivo.AutoSize = true;
            this.labelAbrirArquivo.Location = new System.Drawing.Point(62, 93);
            this.labelAbrirArquivo.Name = "labelAbrirArquivo";
            this.labelAbrirArquivo.Size = new System.Drawing.Size(76, 20);
            this.labelAbrirArquivo.TabIndex = 0;
            this.labelAbrirArquivo.Text = "Diretório: ";
            // 
            // buttonCor
            // 
            this.buttonCor.Location = new System.Drawing.Point(62, 37);
            this.buttonCor.Name = "buttonCor";
            this.buttonCor.Size = new System.Drawing.Size(94, 29);
            this.buttonCor.TabIndex = 1;
            this.buttonCor.Text = "Cor";
            this.buttonCor.UseVisualStyleBackColor = true;
            this.buttonCor.Click += new System.EventHandler(this.buttonCor_Click);
            // 
            // buttonFonte
            // 
            this.buttonFonte.Location = new System.Drawing.Point(162, 37);
            this.buttonFonte.Name = "buttonFonte";
            this.buttonFonte.Size = new System.Drawing.Size(94, 29);
            this.buttonFonte.TabIndex = 2;
            this.buttonFonte.Text = "Fonte";
            this.buttonFonte.UseVisualStyleBackColor = true;
            this.buttonFonte.Click += new System.EventHandler(this.buttonFonte_Click);
            // 
            // AbrirArquivoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFonte);
            this.Controls.Add(this.buttonCor);
            this.Controls.Add(this.labelAbrirArquivo);
            this.Name = "AbrirArquivoUC";
            this.Size = new System.Drawing.Size(609, 495);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbrirArquivo;
        private System.Windows.Forms.Button buttonCor;
        private System.Windows.Forms.Button buttonFonte;
    }
}
