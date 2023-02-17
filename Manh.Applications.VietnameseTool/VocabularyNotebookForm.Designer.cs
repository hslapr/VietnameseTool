namespace Manh.Applications.VietnameseTool
{
    partial class VocabularyNotebookForm
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
            this.vocabularyNotebookControl = new Manh.Applications.VietnameseTool.VocabularyNotebookControl();
            this.SuspendLayout();
            // 
            // vocabularyNotebookControl
            // 
            this.vocabularyNotebookControl.DbContext = null;
            this.vocabularyNotebookControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vocabularyNotebookControl.Example = null;
            this.vocabularyNotebookControl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.vocabularyNotebookControl.Location = new System.Drawing.Point(0, 0);
            this.vocabularyNotebookControl.Margin = new System.Windows.Forms.Padding(6);
            this.vocabularyNotebookControl.Name = "vocabularyNotebookControl";
            this.vocabularyNotebookControl.Size = new System.Drawing.Size(782, 553);
            this.vocabularyNotebookControl.TabIndex = 0;
            this.vocabularyNotebookControl.Word = null;
            // 
            // VocabularyNotebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.vocabularyNotebookControl);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VocabularyNotebookForm";
            this.Text = "Notebook - Vietnamese Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private VocabularyNotebookControl vocabularyNotebookControl;
    }
}