
namespace Projeto_Exemplo_WF
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cálculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comBotõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadora1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraExemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visorÚnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cálculosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cálculosToolStripMenuItem
            // 
            this.cálculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comBotõesToolStripMenuItem,
            this.visorÚnicoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cálculosToolStripMenuItem.Name = "cálculosToolStripMenuItem";
            this.cálculosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cálculosToolStripMenuItem.Text = "Cálculos";
            // 
            // comBotõesToolStripMenuItem
            // 
            this.comBotõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadora1ToolStripMenuItem,
            this.calculadoraExemploToolStripMenuItem});
            this.comBotõesToolStripMenuItem.Name = "comBotõesToolStripMenuItem";
            this.comBotõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comBotõesToolStripMenuItem.Text = "Com Botões";
            // 
            // calculadora1ToolStripMenuItem
            // 
            this.calculadora1ToolStripMenuItem.Name = "calculadora1ToolStripMenuItem";
            this.calculadora1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.calculadora1ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.calculadora1ToolStripMenuItem.Text = "Calculadora";
            this.calculadora1ToolStripMenuItem.Click += new System.EventHandler(this.calculadora1ToolStripMenuItem_Click);
            // 
            // calculadoraExemploToolStripMenuItem
            // 
            this.calculadoraExemploToolStripMenuItem.Name = "calculadoraExemploToolStripMenuItem";
            this.calculadoraExemploToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.calculadoraExemploToolStripMenuItem.Text = "Calculadora Exemplo";
            // 
            // visorÚnicoToolStripMenuItem
            // 
            this.visorÚnicoToolStripMenuItem.Name = "visorÚnicoToolStripMenuItem";
            this.visorÚnicoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.visorÚnicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visorÚnicoToolStripMenuItem.Text = "Visor Único";
            this.visorÚnicoToolStripMenuItem.Click += new System.EventHandler(this.visorÚnicoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cálculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comBotõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visorÚnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadora1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem calculadoraExemploToolStripMenuItem;
    }
}