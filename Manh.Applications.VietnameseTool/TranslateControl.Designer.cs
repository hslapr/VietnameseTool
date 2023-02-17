namespace Manh.Applications.VietnameseTool
{
    partial class TranslateControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlTranslation = new System.Windows.Forms.TabControl();
            this.tabPageGoogle = new System.Windows.Forms.TabPage();
            this.tbxGoogle = new System.Windows.Forms.TextBox();
            this.tabPageBing = new System.Windows.Forms.TabPage();
            this.tbxBing = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlTranslation.SuspendLayout();
            this.tabPageGoogle.SuspendLayout();
            this.tabPageBing.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbxInput);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlTranslation);
            this.splitContainer1.Size = new System.Drawing.Size(651, 457);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbxInput
            // 
            this.tbxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInput.Location = new System.Drawing.Point(0, 15);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(651, 202);
            this.tbxInput.TabIndex = 1;
            this.tbxInput.TextChanged += new System.EventHandler(this.tbxInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Text";
            // 
            // tabControlTranslation
            // 
            this.tabControlTranslation.Controls.Add(this.tabPageGoogle);
            this.tabControlTranslation.Controls.Add(this.tabPageBing);
            this.tabControlTranslation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTranslation.Location = new System.Drawing.Point(0, 0);
            this.tabControlTranslation.Name = "tabControlTranslation";
            this.tabControlTranslation.SelectedIndex = 0;
            this.tabControlTranslation.Size = new System.Drawing.Size(651, 236);
            this.tabControlTranslation.TabIndex = 0;
            // 
            // tabPageGoogle
            // 
            this.tabPageGoogle.Controls.Add(this.tbxGoogle);
            this.tabPageGoogle.Location = new System.Drawing.Point(4, 25);
            this.tabPageGoogle.Name = "tabPageGoogle";
            this.tabPageGoogle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoogle.Size = new System.Drawing.Size(643, 207);
            this.tabPageGoogle.TabIndex = 0;
            this.tabPageGoogle.Text = "Google";
            this.tabPageGoogle.UseVisualStyleBackColor = true;
            // 
            // tbxGoogle
            // 
            this.tbxGoogle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxGoogle.Location = new System.Drawing.Point(3, 3);
            this.tbxGoogle.Multiline = true;
            this.tbxGoogle.Name = "tbxGoogle";
            this.tbxGoogle.ReadOnly = true;
            this.tbxGoogle.Size = new System.Drawing.Size(637, 201);
            this.tbxGoogle.TabIndex = 0;
            // 
            // tabPageBing
            // 
            this.tabPageBing.Controls.Add(this.tbxBing);
            this.tabPageBing.Location = new System.Drawing.Point(4, 25);
            this.tabPageBing.Name = "tabPageBing";
            this.tabPageBing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBing.Size = new System.Drawing.Size(643, 207);
            this.tabPageBing.TabIndex = 1;
            this.tabPageBing.Text = "Bing";
            this.tabPageBing.UseVisualStyleBackColor = true;
            // 
            // tbxBing
            // 
            this.tbxBing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBing.Location = new System.Drawing.Point(3, 3);
            this.tbxBing.Multiline = true;
            this.tbxBing.Name = "tbxBing";
            this.tbxBing.ReadOnly = true;
            this.tbxBing.Size = new System.Drawing.Size(637, 201);
            this.tbxBing.TabIndex = 0;
            // 
            // TranslateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TranslateControl";
            this.Size = new System.Drawing.Size(651, 457);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlTranslation.ResumeLayout(false);
            this.tabPageGoogle.ResumeLayout(false);
            this.tabPageGoogle.PerformLayout();
            this.tabPageBing.ResumeLayout(false);
            this.tabPageBing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.TabControl tabControlTranslation;
        private System.Windows.Forms.TabPage tabPageGoogle;
        private System.Windows.Forms.TabPage tabPageBing;
        private System.Windows.Forms.TextBox tbxGoogle;
        private System.Windows.Forms.TextBox tbxBing;
    }
}
