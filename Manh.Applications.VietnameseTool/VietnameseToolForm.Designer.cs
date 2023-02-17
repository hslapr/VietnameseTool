namespace Manh.Applications.VietnameseTool
{
    partial class VietnameseToolForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VietnameseToolForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.VocabularyNotebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchReadingTextBoxModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readingTextBox = new Manh.Applications.VietnameseTool.ReadingTextBox();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VocabularyNotebookToolStripMenuItem,
            this.switchReadingTextBoxModeMenuItem,
            this.loadFromJsonToolStripMenuItem});
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // VocabularyNotebookToolStripMenuItem
            // 
            this.VocabularyNotebookToolStripMenuItem.Name = "VocabularyNotebookToolStripMenuItem";
            resources.ApplyResources(this.VocabularyNotebookToolStripMenuItem, "VocabularyNotebookToolStripMenuItem");
            this.VocabularyNotebookToolStripMenuItem.Click += new System.EventHandler(this.VocabularyNotebookToolStripMenuItem_Click);
            // 
            // switchReadingTextBoxModeMenuItem
            // 
            this.switchReadingTextBoxModeMenuItem.Name = "switchReadingTextBoxModeMenuItem";
            resources.ApplyResources(this.switchReadingTextBoxModeMenuItem, "switchReadingTextBoxModeMenuItem");
            this.switchReadingTextBoxModeMenuItem.Tag = "";
            this.switchReadingTextBoxModeMenuItem.Click += new System.EventHandler(this.switchReadingTextBoxModeMenuItem_Click);
            // 
            // loadFromJsonToolStripMenuItem
            // 
            resources.ApplyResources(this.loadFromJsonToolStripMenuItem, "loadFromJsonToolStripMenuItem");
            this.loadFromJsonToolStripMenuItem.Name = "loadFromJsonToolStripMenuItem";
            this.loadFromJsonToolStripMenuItem.Click += new System.EventHandler(this.loadFromJsonToolStripMenuItem_Click);
            // 
            // readingTextBox
            // 
            this.readingTextBox.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.readingTextBox, "readingTextBox");
            this.readingTextBox.Mode = Manh.Applications.VietnameseTool.ReadingTextBoxMode.Edit;
            this.readingTextBox.Name = "readingTextBox";
            // 
            // VietnameseToolForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.readingTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "VietnameseToolForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VietnameseToolForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem VocabularyNotebookToolStripMenuItem;
        private ReadingTextBox readingTextBox;
        private System.Windows.Forms.ToolStripMenuItem switchReadingTextBoxModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromJsonToolStripMenuItem;
    }
}

