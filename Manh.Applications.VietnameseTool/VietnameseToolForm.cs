using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Manh.Applications.VietnameseTool
{
    public partial class VietnameseToolForm : Form
    {
        private VocabularyNotebookForm vocabularyNotebookForm;
        private AppDbContext dbContext;
        public VietnameseToolForm()
        {
            InitializeComponent();
            dbContext = new AppDbContext("Data Source=vietnamese.db");
            dbContext.CreateWordsTable();
            dbContext.CreateExamplesTable();
            dbContext.CreateWordWithExamplesTable();

            switchReadingTextBoxModeMenuItem.Tag = ReadingTextBoxMode.Edit;
            readingTextBox.SelectionChangedEvent += (Object sender, SelectionChangedEventArgs args) =>
            {
                vocabularyNotebookForm.SetWord(args.Text);
            };
        }

        private void VocabularyNotebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vocabularyNotebookForm = new VocabularyNotebookForm
            {
                DbContext = dbContext
            };
            vocabularyNotebookForm.Show();
        }

        private void switchReadingTextBoxModeMenuItem_Click(object sender, EventArgs e)
        {
            if ((ReadingTextBoxMode)switchReadingTextBoxModeMenuItem.Tag == ReadingTextBoxMode.Edit)
            {
                readingTextBox.Mode = ReadingTextBoxMode.Read;
                switchReadingTextBoxModeMenuItem.Text = "Read Mode";
                switchReadingTextBoxModeMenuItem.Tag = ReadingTextBoxMode.Read;
            }
            else
            {
                readingTextBox.Mode = ReadingTextBoxMode.Edit;
                switchReadingTextBoxModeMenuItem.Text = "Edit Mode";
                switchReadingTextBoxModeMenuItem.Tag = ReadingTextBoxMode.Edit;
            }
        }

        private void loadFromJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string filePath = openFileDialog.FileName;
                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    string jsonString = null;                     
                    using (var reader = new StreamReader(fileStream,Encoding.UTF8))
                    {
                        jsonString = reader.ReadToEnd();
                    }
                    var data = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
                    foreach(var pair in data)
                    {
                        dbContext.InsertWordNote(pair.Key, pair.Value);
                    }
                }
            }

        }

        private void VietnameseToolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbContext.Dispose();
            readingTextBox.SaveText();
        }
    }
}
