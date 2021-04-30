
namespace WinForms.FormApp.Forms.Login
{
    partial class LoginForm
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
            this.labelLoginTitulo = new System.Windows.Forms.Label();
            this.labelLoginSubTitulo = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonCriarConta = new System.Windows.Forms.Button();
            this.labelTermosPolitica = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoginTitulo
            // 
            this.labelLoginTitulo.AutoSize = true;
            this.labelLoginTitulo.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginTitulo.Location = new System.Drawing.Point(32, 54);
            this.labelLoginTitulo.Name = "labelLoginTitulo";
            this.labelLoginTitulo.Size = new System.Drawing.Size(304, 36);
            this.labelLoginTitulo.TabIndex = 0;
            this.labelLoginTitulo.Text = "WinForms Application";
            // 
            // labelLoginSubTitulo
            // 
            this.labelLoginSubTitulo.AutoSize = true;
            this.labelLoginSubTitulo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoginSubTitulo.Location = new System.Drawing.Point(211, 90);
            this.labelLoginSubTitulo.Name = "labelLoginSubTitulo";
            this.labelLoginSubTitulo.Size = new System.Drawing.Size(125, 20);
            this.labelLoginSubTitulo.TabIndex = 1;
            this.labelLoginSubTitulo.Text = "Communit 2021";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(527, 224);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(243, 29);
            this.buttonEntrar.TabIndex = 2;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonCriarConta
            // 
            this.buttonCriarConta.Location = new System.Drawing.Point(527, 259);
            this.buttonCriarConta.Name = "buttonCriarConta";
            this.buttonCriarConta.Size = new System.Drawing.Size(243, 29);
            this.buttonCriarConta.TabIndex = 3;
            this.buttonCriarConta.Text = "Criar Conta";
            this.buttonCriarConta.UseVisualStyleBackColor = true;
            // 
            // labelTermosPolitica
            // 
            this.labelTermosPolitica.AutoSize = true;
            this.labelTermosPolitica.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTermosPolitica.Location = new System.Drawing.Point(527, 295);
            this.labelTermosPolitica.Name = "labelTermosPolitica";
            this.labelTermosPolitica.Size = new System.Drawing.Size(249, 60);
            this.labelTermosPolitica.TabIndex = 4;
            this.labelTermosPolitica.Text = "Termos e Política\r\nAcesse para ter acesso às nossas políticas e \r\ntermos de uso!\r" +
    "\n ";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(527, 108);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(243, 27);
            this.textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(527, 169);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(243, 27);
            this.textBoxSenha.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(527, 85);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(116, 20);
            this.labelUsuario.TabIndex = 7;
            this.labelUsuario.Text = "Usuário / E-mail";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(527, 146);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(49, 20);
            this.labelSenha.TabIndex = 8;
            this.labelSenha.Text = "Senha";
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(676, 390);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(94, 29);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 446);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelTermosPolitica);
            this.Controls.Add(this.buttonCriarConta);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.labelLoginSubTitulo);
            this.Controls.Add(this.labelLoginTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginTitulo;
        private System.Windows.Forms.Label labelLoginSubTitulo;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonCriarConta;
        private System.Windows.Forms.Label labelTermosPolitica;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button buttonSair;
    }
}