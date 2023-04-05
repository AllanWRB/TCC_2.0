namespace teste
{
    partial class EdicaoADM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarLoginESenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarCursosToolStripMenuItem,
            this.deletarCursosToolStripMenuItem,
            this.alterarCursosToolStripMenuItem,
            this.alterarLoginESenhaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarCursosToolStripMenuItem
            // 
            this.adicionarCursosToolStripMenuItem.Name = "adicionarCursosToolStripMenuItem";
            this.adicionarCursosToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.adicionarCursosToolStripMenuItem.Text = "Adicionar Cursos";
            this.adicionarCursosToolStripMenuItem.Click += new System.EventHandler(this.adicionarCursosToolStripMenuItem_Click);
            // 
            // deletarCursosToolStripMenuItem
            // 
            this.deletarCursosToolStripMenuItem.Name = "deletarCursosToolStripMenuItem";
            this.deletarCursosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.deletarCursosToolStripMenuItem.Text = "Deletar Cursos";
            // 
            // alterarCursosToolStripMenuItem
            // 
            this.alterarCursosToolStripMenuItem.Name = "alterarCursosToolStripMenuItem";
            this.alterarCursosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.alterarCursosToolStripMenuItem.Text = "Alterar Cursos";
            // 
            // alterarLoginESenhaToolStripMenuItem
            // 
            this.alterarLoginESenhaToolStripMenuItem.Name = "alterarLoginESenhaToolStripMenuItem";
            this.alterarLoginESenhaToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.alterarLoginESenhaToolStripMenuItem.Text = "Alterar Login e Senha";
            // 
            // EdicaoADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EdicaoADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdiçãoADM";
            this.Load += new System.EventHandler(this.EdicaoADM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarLoginESenhaToolStripMenuItem;
    }
}