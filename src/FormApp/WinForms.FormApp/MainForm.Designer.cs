
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDemonstracao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemValidacao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMascara = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemArquivo,
            this.toolStripMenuItemWindows,
            this.toolStripMenuItemSobre});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 28);
            this.menuStripMain.TabIndex = 5;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMenuItemArquivo
            // 
            this.toolStripMenuItemArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNovo,
            this.toolStripMenuItemSair});
            this.toolStripMenuItemArquivo.Name = "toolStripMenuItemArquivo";
            this.toolStripMenuItemArquivo.Size = new System.Drawing.Size(75, 24);
            this.toolStripMenuItemArquivo.Text = "Arquivo";
            // 
            // toolStripMenuItemNovo
            // 
            this.toolStripMenuItemNovo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDemonstracao,
            this.toolStripMenuItemValidacao,
            this.toolStripMenuItemMascara});
            this.toolStripMenuItemNovo.Name = "toolStripMenuItemNovo";
            this.toolStripMenuItemNovo.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItemNovo.Text = "Novo";
            // 
            // toolStripMenuItemDemonstracao
            // 
            this.toolStripMenuItemDemonstracao.Name = "toolStripMenuItemDemonstracao";
            this.toolStripMenuItemDemonstracao.Size = new System.Drawing.Size(195, 26);
            this.toolStripMenuItemDemonstracao.Text = "Demonstrações";
            this.toolStripMenuItemDemonstracao.Click += new System.EventHandler(this.toolStripMenuItemDemonstracao_Click);
            // 
            // toolStripMenuItemValidacao
            // 
            this.toolStripMenuItemValidacao.Name = "toolStripMenuItemValidacao";
            this.toolStripMenuItemValidacao.Size = new System.Drawing.Size(195, 26);
            this.toolStripMenuItemValidacao.Text = "Validações";
            this.toolStripMenuItemValidacao.Click += new System.EventHandler(this.toolStripMenuItemValidacao_Click);
            // 
            // toolStripMenuItemMascara
            // 
            this.toolStripMenuItemMascara.Name = "toolStripMenuItemMascara";
            this.toolStripMenuItemMascara.Size = new System.Drawing.Size(195, 26);
            this.toolStripMenuItemMascara.Text = "Máscaras";
            this.toolStripMenuItemMascara.Click += new System.EventHandler(this.toolStripMenuItemMascara_Click);
            // 
            // toolStripMenuItemSair
            // 
            this.toolStripMenuItemSair.Name = "toolStripMenuItemSair";
            this.toolStripMenuItemSair.Size = new System.Drawing.Size(128, 26);
            this.toolStripMenuItemSair.Text = "Sair";
            this.toolStripMenuItemSair.Click += new System.EventHandler(this.toolStripMenuItemSair_Click);
            // 
            // toolStripMenuItemWindows
            // 
            this.toolStripMenuItemWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCascata,
            this.toolStripMenuItemHorizontal,
            this.toolStripMenuItemVertical});
            this.toolStripMenuItemWindows.Name = "toolStripMenuItemWindows";
            this.toolStripMenuItemWindows.Size = new System.Drawing.Size(84, 24);
            this.toolStripMenuItemWindows.Text = "Windows";
            // 
            // toolStripMenuItemCascata
            // 
            this.toolStripMenuItemCascata.Name = "toolStripMenuItemCascata";
            this.toolStripMenuItemCascata.Size = new System.Drawing.Size(162, 26);
            this.toolStripMenuItemCascata.Text = "Cascata";
            this.toolStripMenuItemCascata.Click += new System.EventHandler(this.toolStripMenuItemCascata_Click);
            // 
            // toolStripMenuItemHorizontal
            // 
            this.toolStripMenuItemHorizontal.Name = "toolStripMenuItemHorizontal";
            this.toolStripMenuItemHorizontal.Size = new System.Drawing.Size(162, 26);
            this.toolStripMenuItemHorizontal.Text = "Horizontal";
            this.toolStripMenuItemHorizontal.Click += new System.EventHandler(this.toolStripMenuItemHorizontal_Click);
            // 
            // toolStripMenuItemSobre
            // 
            this.toolStripMenuItemSobre.Name = "toolStripMenuItemSobre";
            this.toolStripMenuItemSobre.Size = new System.Drawing.Size(62, 24);
            this.toolStripMenuItemSobre.Text = "Sobre";
            // 
            // toolStripMenuItemVertical
            // 
            this.toolStripMenuItemVertical.Name = "toolStripMenuItemVertical";
            this.toolStripMenuItemVertical.Size = new System.Drawing.Size(162, 26);
            this.toolStripMenuItemVertical.Text = "Vertical";
            this.toolStripMenuItemVertical.Click += new System.EventHandler(this.toolStripMenuItemVertical_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Application";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArquivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSobre;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNovo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDemonstracao;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemValidacao;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMascara;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWindows;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCascata;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVertical;
    }
}

