namespace CodingGameCompactor.UI
{
    partial class CodeCompactorForm
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
            this.btnRegenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.tbMainOutput = new System.Windows.Forms.TextBox();
            this.BtnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSelectAll,
            this.btnRegenerate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Size = new System.Drawing.Size(78, 20);
            this.btnRegenerate.Text = "Regenerate";
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
            // 
            // tbMainOutput
            // 
            this.tbMainOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMainOutput.Location = new System.Drawing.Point(0, 24);
            this.tbMainOutput.Multiline = true;
            this.tbMainOutput.Name = "tbMainOutput";
            this.tbMainOutput.ReadOnly = true;
            this.tbMainOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMainOutput.Size = new System.Drawing.Size(800, 426);
            this.tbMainOutput.TabIndex = 0;
            this.tbMainOutput.WordWrap = false;
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(64, 20);
            this.BtnSelectAll.Text = "SelectAll";
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // CodeCompactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMainOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CodeCompactorForm";
            this.Text = "CodingGame Code Compactor";
            this.Load += new System.EventHandler(this.OnLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnRegenerate;
        private System.Windows.Forms.TextBox tbMainOutput;
        private System.Windows.Forms.ToolStripMenuItem BtnSelectAll;
    }
}

