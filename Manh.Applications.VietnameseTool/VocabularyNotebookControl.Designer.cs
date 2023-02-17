namespace Manh.Applications.VietnameseTool
{
    partial class VocabularyNotebookControl
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
            this.lbxWords = new System.Windows.Forms.ListBox();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.lblWord = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnNewExample = new System.Windows.Forms.Button();
            this.lbxExamples = new System.Windows.Forms.ListBox();
            this.tbxExampleNote = new System.Windows.Forms.TextBox();
            this.tbxExample = new System.Windows.Forms.TextBox();
            this.tabControlDictionary = new System.Windows.Forms.TabControl();
            this.tabPageVndic = new System.Windows.Forms.TabPage();
            this.wbVndic = new System.Windows.Forms.WebBrowser();
            this.tabPageTratuViVi = new System.Windows.Forms.TabPage();
            this.wbTratu = new System.Windows.Forms.WebBrowser();
            this.tabPageTratuViJa = new System.Windows.Forms.TabPage();
            this.wbTratuViJa = new System.Windows.Forms.WebBrowser();
            this.tabPageTratuViEn = new System.Windows.Forms.TabPage();
            this.wbTratuViEn = new System.Windows.Forms.WebBrowser();
            this.tabPageWiktionary = new System.Windows.Forms.TabPage();
            this.wbWiktionary = new System.Windows.Forms.WebBrowser();
            this.tabPageGlosbe = new System.Windows.Forms.TabPage();
            this.wbGlosbe = new System.Windows.Forms.WebBrowser();
            this.tabPageTranslate = new System.Windows.Forms.TabPage();
            this.translateControl = new Manh.Applications.VietnameseTool.TranslateControl();
            this.wbTranslate = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControlDictionary.SuspendLayout();
            this.tabPageVndic.SuspendLayout();
            this.tabPageTratuViVi.SuspendLayout();
            this.tabPageTratuViJa.SuspendLayout();
            this.tabPageTratuViEn.SuspendLayout();
            this.tabPageWiktionary.SuspendLayout();
            this.tabPageGlosbe.SuspendLayout();
            this.tabPageTranslate.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbxWords);
            this.splitContainer1.Panel1.Controls.Add(this.tbxWord);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1200, 800);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // lbxWords
            // 
            this.lbxWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxWords.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxWords.FormattingEnabled = true;
            this.lbxWords.ItemHeight = 23;
            this.lbxWords.Location = new System.Drawing.Point(0, 30);
            this.lbxWords.Margin = new System.Windows.Forms.Padding(4);
            this.lbxWords.Name = "lbxWords";
            this.lbxWords.Size = new System.Drawing.Size(150, 770);
            this.lbxWords.TabIndex = 1;
            this.lbxWords.TabStop = false;
            this.lbxWords.Click += new System.EventHandler(this.lbxWords_Click);
            // 
            // tbxWord
            // 
            this.tbxWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxWord.Location = new System.Drawing.Point(0, 0);
            this.tbxWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(150, 30);
            this.tbxWord.TabIndex = 0;
            this.tbxWord.TextChanged += new System.EventHandler(this.tbxWord_TextChanged);
            this.tbxWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxWord_KeyDown);
            this.tbxWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWord_KeyPress);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControlDictionary);
            this.splitContainer2.Size = new System.Drawing.Size(1047, 800);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tbxNote);
            this.splitContainer3.Panel1.Controls.Add(this.lblWord);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(300, 800);
            this.splitContainer3.SplitterDistance = 100;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.TabStop = false;
            // 
            // tbxNote
            // 
            this.tbxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNote.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxNote.Location = new System.Drawing.Point(0, 30);
            this.tbxNote.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Size = new System.Drawing.Size(300, 70);
            this.tbxNote.TabIndex = 1;
            this.tbxNote.TextChanged += new System.EventHandler(this.tbxNote_TextChanged);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWord.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblWord.Location = new System.Drawing.Point(0, 0);
            this.lblWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.lblWord.Size = new System.Drawing.Size(4, 30);
            this.lblWord.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(300, 695);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examples";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(4, 31);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnNewExample);
            this.splitContainer4.Panel1.Controls.Add(this.lbxExamples);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tbxExampleNote);
            this.splitContainer4.Panel2.Controls.Add(this.tbxExample);
            this.splitContainer4.Size = new System.Drawing.Size(292, 660);
            this.splitContainer4.SplitterDistance = 473;
            this.splitContainer4.TabIndex = 0;
            this.splitContainer4.TabStop = false;
            // 
            // btnNewExample
            // 
            this.btnNewExample.AutoSize = true;
            this.btnNewExample.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewExample.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExample.Location = new System.Drawing.Point(0, 435);
            this.btnNewExample.Name = "btnNewExample";
            this.btnNewExample.Size = new System.Drawing.Size(292, 38);
            this.btnNewExample.TabIndex = 1;
            this.btnNewExample.TabStop = false;
            this.btnNewExample.Text = "New Example";
            this.btnNewExample.UseVisualStyleBackColor = true;
            this.btnNewExample.Click += new System.EventHandler(this.btnNewExample_Click);
            // 
            // lbxExamples
            // 
            this.lbxExamples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxExamples.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxExamples.FormattingEnabled = true;
            this.lbxExamples.ItemHeight = 23;
            this.lbxExamples.Location = new System.Drawing.Point(0, 0);
            this.lbxExamples.Name = "lbxExamples";
            this.lbxExamples.Size = new System.Drawing.Size(292, 473);
            this.lbxExamples.TabIndex = 0;
            this.lbxExamples.TabStop = false;
            this.lbxExamples.SelectedValueChanged += new System.EventHandler(this.lbxExamples_SelectedValueChanged);
            // 
            // tbxExampleNote
            // 
            this.tbxExampleNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxExampleNote.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxExampleNote.Location = new System.Drawing.Point(0, 34);
            this.tbxExampleNote.Multiline = true;
            this.tbxExampleNote.Name = "tbxExampleNote";
            this.tbxExampleNote.Size = new System.Drawing.Size(292, 149);
            this.tbxExampleNote.TabIndex = 3;
            this.tbxExampleNote.TextChanged += new System.EventHandler(this.tbxExampleNote_TextChanged);
            // 
            // tbxExample
            // 
            this.tbxExample.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxExample.Location = new System.Drawing.Point(0, 0);
            this.tbxExample.Name = "tbxExample";
            this.tbxExample.Size = new System.Drawing.Size(292, 34);
            this.tbxExample.TabIndex = 2;
            this.tbxExample.TextChanged += new System.EventHandler(this.tbxExample_TextChanged);
            this.tbxExample.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxExample_KeyPress);
            // 
            // tabControlDictionary
            // 
            this.tabControlDictionary.Controls.Add(this.tabPageVndic);
            this.tabControlDictionary.Controls.Add(this.tabPageTratuViVi);
            this.tabControlDictionary.Controls.Add(this.tabPageTratuViJa);
            this.tabControlDictionary.Controls.Add(this.tabPageTratuViEn);
            this.tabControlDictionary.Controls.Add(this.tabPageWiktionary);
            this.tabControlDictionary.Controls.Add(this.tabPageGlosbe);
            this.tabControlDictionary.Controls.Add(this.tabPageTranslate);
            this.tabControlDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDictionary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDictionary.Location = new System.Drawing.Point(0, 0);
            this.tabControlDictionary.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlDictionary.Name = "tabControlDictionary";
            this.tabControlDictionary.SelectedIndex = 0;
            this.tabControlDictionary.Size = new System.Drawing.Size(741, 800);
            this.tabControlDictionary.TabIndex = 0;
            this.tabControlDictionary.SelectedIndexChanged += new System.EventHandler(this.tabControlDictionary_TabIndexChanged);
            this.tabControlDictionary.TabIndexChanged += new System.EventHandler(this.tabControlDictionary_TabIndexChanged);
            // 
            // tabPageVndic
            // 
            this.tabPageVndic.Controls.Add(this.wbVndic);
            this.tabPageVndic.Location = new System.Drawing.Point(4, 37);
            this.tabPageVndic.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageVndic.Name = "tabPageVndic";
            this.tabPageVndic.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageVndic.Size = new System.Drawing.Size(733, 759);
            this.tabPageVndic.TabIndex = 0;
            this.tabPageVndic.Text = "VNDIC";
            this.tabPageVndic.UseVisualStyleBackColor = true;
            // 
            // wbVndic
            // 
            this.wbVndic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbVndic.Location = new System.Drawing.Point(4, 4);
            this.wbVndic.Margin = new System.Windows.Forms.Padding(4);
            this.wbVndic.MinimumSize = new System.Drawing.Size(28, 27);
            this.wbVndic.Name = "wbVndic";
            this.wbVndic.ScriptErrorsSuppressed = true;
            this.wbVndic.Size = new System.Drawing.Size(725, 751);
            this.wbVndic.TabIndex = 0;
            this.wbVndic.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // tabPageTratuViVi
            // 
            this.tabPageTratuViVi.Controls.Add(this.wbTratu);
            this.tabPageTratuViVi.Location = new System.Drawing.Point(4, 37);
            this.tabPageTratuViVi.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTratuViVi.Name = "tabPageTratuViVi";
            this.tabPageTratuViVi.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTratuViVi.Size = new System.Drawing.Size(733, 759);
            this.tabPageTratuViVi.TabIndex = 1;
            this.tabPageTratuViVi.Text = "Tratu(vi-vi)";
            this.tabPageTratuViVi.UseVisualStyleBackColor = true;
            // 
            // wbTratu
            // 
            this.wbTratu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTratu.Location = new System.Drawing.Point(4, 4);
            this.wbTratu.Margin = new System.Windows.Forms.Padding(4);
            this.wbTratu.MinimumSize = new System.Drawing.Size(28, 27);
            this.wbTratu.Name = "wbTratu";
            this.wbTratu.ScriptErrorsSuppressed = true;
            this.wbTratu.Size = new System.Drawing.Size(725, 751);
            this.wbTratu.TabIndex = 0;
            this.wbTratu.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // tabPageTratuViJa
            // 
            this.tabPageTratuViJa.Controls.Add(this.wbTratuViJa);
            this.tabPageTratuViJa.Location = new System.Drawing.Point(4, 37);
            this.tabPageTratuViJa.Name = "tabPageTratuViJa";
            this.tabPageTratuViJa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTratuViJa.Size = new System.Drawing.Size(733, 759);
            this.tabPageTratuViJa.TabIndex = 5;
            this.tabPageTratuViJa.Text = "Tratu(vi-ja)";
            this.tabPageTratuViJa.UseVisualStyleBackColor = true;
            // 
            // wbTratuViJa
            // 
            this.wbTratuViJa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTratuViJa.Location = new System.Drawing.Point(3, 3);
            this.wbTratuViJa.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTratuViJa.Name = "wbTratuViJa";
            this.wbTratuViJa.Size = new System.Drawing.Size(727, 753);
            this.wbTratuViJa.TabIndex = 0;
            this.wbTratuViJa.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // tabPageTratuViEn
            // 
            this.tabPageTratuViEn.Controls.Add(this.wbTratuViEn);
            this.tabPageTratuViEn.Location = new System.Drawing.Point(4, 37);
            this.tabPageTratuViEn.Name = "tabPageTratuViEn";
            this.tabPageTratuViEn.Size = new System.Drawing.Size(733, 759);
            this.tabPageTratuViEn.TabIndex = 6;
            this.tabPageTratuViEn.Text = "Tratu(vi-en)";
            this.tabPageTratuViEn.UseVisualStyleBackColor = true;
            // 
            // wbTratuViEn
            // 
            this.wbTratuViEn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTratuViEn.Location = new System.Drawing.Point(0, 0);
            this.wbTratuViEn.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTratuViEn.Name = "wbTratuViEn";
            this.wbTratuViEn.Size = new System.Drawing.Size(733, 759);
            this.wbTratuViEn.TabIndex = 0;
            this.wbTratuViEn.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // tabPageWiktionary
            // 
            this.tabPageWiktionary.Controls.Add(this.wbWiktionary);
            this.tabPageWiktionary.Location = new System.Drawing.Point(4, 37);
            this.tabPageWiktionary.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageWiktionary.Name = "tabPageWiktionary";
            this.tabPageWiktionary.Size = new System.Drawing.Size(733, 759);
            this.tabPageWiktionary.TabIndex = 2;
            this.tabPageWiktionary.Text = "Wiktionary";
            this.tabPageWiktionary.UseVisualStyleBackColor = true;
            // 
            // wbWiktionary
            // 
            this.wbWiktionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbWiktionary.Location = new System.Drawing.Point(0, 0);
            this.wbWiktionary.Margin = new System.Windows.Forms.Padding(4);
            this.wbWiktionary.MinimumSize = new System.Drawing.Size(28, 27);
            this.wbWiktionary.Name = "wbWiktionary";
            this.wbWiktionary.ScriptErrorsSuppressed = true;
            this.wbWiktionary.Size = new System.Drawing.Size(733, 759);
            this.wbWiktionary.TabIndex = 0;
            this.wbWiktionary.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // tabPageGlosbe
            // 
            this.tabPageGlosbe.Controls.Add(this.wbGlosbe);
            this.tabPageGlosbe.Location = new System.Drawing.Point(4, 37);
            this.tabPageGlosbe.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGlosbe.Name = "tabPageGlosbe";
            this.tabPageGlosbe.Size = new System.Drawing.Size(733, 759);
            this.tabPageGlosbe.TabIndex = 3;
            this.tabPageGlosbe.Text = "Glosbe";
            this.tabPageGlosbe.UseVisualStyleBackColor = true;
            // 
            // wbGlosbe
            // 
            this.wbGlosbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbGlosbe.Location = new System.Drawing.Point(0, 0);
            this.wbGlosbe.Margin = new System.Windows.Forms.Padding(4);
            this.wbGlosbe.MinimumSize = new System.Drawing.Size(28, 27);
            this.wbGlosbe.Name = "wbGlosbe";
            this.wbGlosbe.ScriptErrorsSuppressed = true;
            this.wbGlosbe.Size = new System.Drawing.Size(733, 759);
            this.wbGlosbe.TabIndex = 0;
            this.wbGlosbe.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // tabPageTranslate
            // 
            this.tabPageTranslate.Controls.Add(this.translateControl);
            this.tabPageTranslate.Controls.Add(this.wbTranslate);
            this.tabPageTranslate.Location = new System.Drawing.Point(4, 37);
            this.tabPageTranslate.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTranslate.Name = "tabPageTranslate";
            this.tabPageTranslate.Size = new System.Drawing.Size(733, 759);
            this.tabPageTranslate.TabIndex = 4;
            this.tabPageTranslate.Text = "Translate";
            this.tabPageTranslate.UseVisualStyleBackColor = true;
            // 
            // translateControl
            // 
            this.translateControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translateControl.InputText = null;
            this.translateControl.Location = new System.Drawing.Point(0, 0);
            this.translateControl.Margin = new System.Windows.Forms.Padding(4);
            this.translateControl.Name = "translateControl";
            this.translateControl.Size = new System.Drawing.Size(733, 759);
            this.translateControl.TabIndex = 1;
            // 
            // wbTranslate
            // 
            this.wbTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTranslate.Location = new System.Drawing.Point(0, 0);
            this.wbTranslate.Margin = new System.Windows.Forms.Padding(4);
            this.wbTranslate.MinimumSize = new System.Drawing.Size(28, 27);
            this.wbTranslate.Name = "wbTranslate";
            this.wbTranslate.ScriptErrorsSuppressed = true;
            this.wbTranslate.Size = new System.Drawing.Size(733, 759);
            this.wbTranslate.TabIndex = 0;
            this.wbTranslate.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // VocabularyNotebookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VocabularyNotebookControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControlDictionary.ResumeLayout(false);
            this.tabPageVndic.ResumeLayout(false);
            this.tabPageTratuViVi.ResumeLayout(false);
            this.tabPageTratuViJa.ResumeLayout(false);
            this.tabPageTratuViEn.ResumeLayout(false);
            this.tabPageWiktionary.ResumeLayout(false);
            this.tabPageGlosbe.ResumeLayout(false);
            this.tabPageTranslate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbxWords;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControlDictionary;
        private System.Windows.Forms.TabPage tabPageVndic;
        private System.Windows.Forms.TabPage tabPageTratuViVi;
        private System.Windows.Forms.TabPage tabPageWiktionary;
        private System.Windows.Forms.TabPage tabPageGlosbe;
        private System.Windows.Forms.TabPage tabPageTranslate;
        private System.Windows.Forms.WebBrowser wbVndic;
        private System.Windows.Forms.WebBrowser wbTratu;
        private System.Windows.Forms.WebBrowser wbWiktionary;
        private System.Windows.Forms.WebBrowser wbGlosbe;
        private System.Windows.Forms.WebBrowser wbTranslate;
        private TranslateControl translateControl;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox lbxExamples;
        private System.Windows.Forms.TextBox tbxExampleNote;
        private System.Windows.Forms.TextBox tbxExample;
        private System.Windows.Forms.Button btnNewExample;
        private System.Windows.Forms.TabPage tabPageTratuViJa;
        private System.Windows.Forms.WebBrowser wbTratuViJa;
        private System.Windows.Forms.TabPage tabPageTratuViEn;
        private System.Windows.Forms.WebBrowser wbTratuViEn;
    }
}
