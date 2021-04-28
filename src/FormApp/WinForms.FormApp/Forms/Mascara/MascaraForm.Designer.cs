
namespace WinForms.FormApp.Forms.Mascara
{
    partial class MascaraForm
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
            this.maskedTextBoxMascara = new System.Windows.Forms.MaskedTextBox();
            this.buttonHora = new System.Windows.Forms.Button();
            this.buttonCEP = new System.Windows.Forms.Button();
            this.buttonMoeda = new System.Windows.Forms.Button();
            this.buttonCelular = new System.Windows.Forms.Button();
            this.buttonSenha = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonConteudo = new System.Windows.Forms.Button();
            this.labelConteudo = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxMascara
            // 
            this.maskedTextBoxMascara.Location = new System.Drawing.Point(53, 87);
            this.maskedTextBoxMascara.Name = "maskedTextBoxMascara";
            this.maskedTextBoxMascara.Size = new System.Drawing.Size(419, 27);
            this.maskedTextBoxMascara.TabIndex = 0;
            // 
            // buttonHora
            // 
            this.buttonHora.Location = new System.Drawing.Point(53, 169);
            this.buttonHora.Name = "buttonHora";
            this.buttonHora.Size = new System.Drawing.Size(123, 60);
            this.buttonHora.TabIndex = 1;
            this.buttonHora.Text = "Hora";
            this.buttonHora.UseVisualStyleBackColor = true;
            this.buttonHora.Click += new System.EventHandler(this.buttonHora_Click);
            // 
            // buttonCEP
            // 
            this.buttonCEP.Location = new System.Drawing.Point(201, 169);
            this.buttonCEP.Name = "buttonCEP";
            this.buttonCEP.Size = new System.Drawing.Size(123, 60);
            this.buttonCEP.TabIndex = 2;
            this.buttonCEP.Text = "CEP";
            this.buttonCEP.UseVisualStyleBackColor = true;
            this.buttonCEP.Click += new System.EventHandler(this.buttonCEP_Click);
            // 
            // buttonMoeda
            // 
            this.buttonMoeda.Location = new System.Drawing.Point(349, 169);
            this.buttonMoeda.Name = "buttonMoeda";
            this.buttonMoeda.Size = new System.Drawing.Size(123, 60);
            this.buttonMoeda.TabIndex = 3;
            this.buttonMoeda.Text = "Moeda";
            this.buttonMoeda.UseVisualStyleBackColor = true;
            this.buttonMoeda.Click += new System.EventHandler(this.buttonMoeda_Click);
            // 
            // buttonCelular
            // 
            this.buttonCelular.Location = new System.Drawing.Point(349, 250);
            this.buttonCelular.Name = "buttonCelular";
            this.buttonCelular.Size = new System.Drawing.Size(123, 60);
            this.buttonCelular.TabIndex = 6;
            this.buttonCelular.Text = "Celular";
            this.buttonCelular.UseVisualStyleBackColor = true;
            this.buttonCelular.Click += new System.EventHandler(this.buttonCelular_Click);
            // 
            // buttonSenha
            // 
            this.buttonSenha.Location = new System.Drawing.Point(201, 250);
            this.buttonSenha.Name = "buttonSenha";
            this.buttonSenha.Size = new System.Drawing.Size(123, 60);
            this.buttonSenha.TabIndex = 5;
            this.buttonSenha.Text = "Senha";
            this.buttonSenha.UseVisualStyleBackColor = true;
            this.buttonSenha.Click += new System.EventHandler(this.buttonSenha_Click);
            // 
            // buttonData
            // 
            this.buttonData.Location = new System.Drawing.Point(53, 250);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(123, 60);
            this.buttonData.TabIndex = 4;
            this.buttonData.Text = "Data";
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // buttonConteudo
            // 
            this.buttonConteudo.Location = new System.Drawing.Point(53, 338);
            this.buttonConteudo.Name = "buttonConteudo";
            this.buttonConteudo.Size = new System.Drawing.Size(419, 60);
            this.buttonConteudo.TabIndex = 7;
            this.buttonConteudo.Text = "Ver Conteúdo";
            this.buttonConteudo.UseVisualStyleBackColor = true;
            this.buttonConteudo.Click += new System.EventHandler(this.buttonConteudo_Click);
            // 
            // labelConteudo
            // 
            this.labelConteudo.AutoSize = true;
            this.labelConteudo.Location = new System.Drawing.Point(53, 424);
            this.labelConteudo.Name = "labelConteudo";
            this.labelConteudo.Size = new System.Drawing.Size(0, 20);
            this.labelConteudo.TabIndex = 8;
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(429, 450);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(94, 29);
            this.buttonSair.TabIndex = 9;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // MascaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 491);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelConteudo);
            this.Controls.Add(this.buttonConteudo);
            this.Controls.Add(this.buttonCelular);
            this.Controls.Add(this.buttonSenha);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.buttonMoeda);
            this.Controls.Add(this.buttonCEP);
            this.Controls.Add(this.buttonHora);
            this.Controls.Add(this.maskedTextBoxMascara);
            this.Name = "MascaraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MascaraForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxMascara;
        private System.Windows.Forms.Button buttonHora;
        private System.Windows.Forms.Button buttonCEP;
        private System.Windows.Forms.Button buttonMoeda;
        private System.Windows.Forms.Button buttonCelular;
        private System.Windows.Forms.Button buttonSenha;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Button buttonConteudo;
        private System.Windows.Forms.Label labelConteudo;
        private System.Windows.Forms.Button buttonSair;
    }
}