
namespace WinForms.FormApp.Forms.Demonstracao
{
    partial class DemonstracaoKeyForm
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.buttonLimparCampos = new System.Windows.Forms.Button();
            this.labelMinus = new System.Windows.Forms.Label();
            this.labelMaius = new System.Windows.Forms.Label();
            this.labelUpper = new System.Windows.Forms.Label();
            this.labelLower = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonNome = new System.Windows.Forms.Button();
            this.buttonLimparNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(125, 27);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMsg.Location = new System.Drawing.Point(12, 62);
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMsg.Size = new System.Drawing.Size(335, 269);
            this.textBoxMsg.TabIndex = 1;
            this.textBoxMsg.TabStop = false;
            // 
            // buttonLimparCampos
            // 
            this.buttonLimparCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimparCampos.Location = new System.Drawing.Point(429, 12);
            this.buttonLimparCampos.Name = "buttonLimparCampos";
            this.buttonLimparCampos.Size = new System.Drawing.Size(94, 29);
            this.buttonLimparCampos.TabIndex = 2;
            this.buttonLimparCampos.Text = "Limpar";
            this.buttonLimparCampos.UseVisualStyleBackColor = true;
            this.buttonLimparCampos.Click += new System.EventHandler(this.buttonLimparCampos_Click);
            // 
            // labelMinus
            // 
            this.labelMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinus.AutoSize = true;
            this.labelMinus.Location = new System.Drawing.Point(353, 104);
            this.labelMinus.Name = "labelMinus";
            this.labelMinus.Size = new System.Drawing.Size(51, 20);
            this.labelMinus.TabIndex = 3;
            this.labelMinus.Text = "Minus.";
            // 
            // labelMaius
            // 
            this.labelMaius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaius.AutoSize = true;
            this.labelMaius.Location = new System.Drawing.Point(353, 156);
            this.labelMaius.Name = "labelMaius";
            this.labelMaius.Size = new System.Drawing.Size(51, 20);
            this.labelMaius.TabIndex = 4;
            this.labelMaius.Text = "Maius.";
            // 
            // labelUpper
            // 
            this.labelUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUpper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUpper.Location = new System.Drawing.Point(410, 91);
            this.labelUpper.Name = "labelUpper";
            this.labelUpper.Size = new System.Drawing.Size(113, 33);
            this.labelUpper.TabIndex = 5;
            // 
            // labelLower
            // 
            this.labelLower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLower.Location = new System.Drawing.Point(410, 143);
            this.labelLower.Name = "labelLower";
            this.labelLower.Size = new System.Drawing.Size(113, 33);
            this.labelLower.TabIndex = 6;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.Location = new System.Drawing.Point(429, 450);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(94, 29);
            this.buttonSair.TabIndex = 7;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 362);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(78, 20);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Seu Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNome.Location = new System.Drawing.Point(12, 400);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(335, 27);
            this.textBoxNome.TabIndex = 9;
            // 
            // buttonNome
            // 
            this.buttonNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNome.Location = new System.Drawing.Point(12, 450);
            this.buttonNome.Name = "buttonNome";
            this.buttonNome.Size = new System.Drawing.Size(94, 29);
            this.buttonNome.TabIndex = 10;
            this.buttonNome.Text = "Assinar";
            this.buttonNome.UseVisualStyleBackColor = true;
            this.buttonNome.Click += new System.EventHandler(this.buttonNome_Click);
            // 
            // buttonLimparNome
            // 
            this.buttonLimparNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLimparNome.Location = new System.Drawing.Point(112, 450);
            this.buttonLimparNome.Name = "buttonLimparNome";
            this.buttonLimparNome.Size = new System.Drawing.Size(112, 29);
            this.buttonLimparNome.TabIndex = 11;
            this.buttonLimparNome.Text = "Limpar Nome";
            this.buttonLimparNome.UseVisualStyleBackColor = true;
            this.buttonLimparNome.Click += new System.EventHandler(this.buttonLimparNome_Click);
            // 
            // DemonstracaoKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 491);
            this.Controls.Add(this.buttonLimparNome);
            this.Controls.Add(this.buttonNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelLower);
            this.Controls.Add(this.labelUpper);
            this.Controls.Add(this.labelMaius);
            this.Controls.Add(this.labelMinus);
            this.Controls.Add(this.buttonLimparCampos);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.textBoxInput);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(553, 538);
            this.Name = "DemonstracaoKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DemonstracaoKeyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Button buttonLimparCampos;
        private System.Windows.Forms.Label labelMinus;
        private System.Windows.Forms.Label labelMaius;
        private System.Windows.Forms.Label labelUpper;
        private System.Windows.Forms.Label labelLower;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonNome;
        private System.Windows.Forms.Button buttonLimparNome;
    }
}