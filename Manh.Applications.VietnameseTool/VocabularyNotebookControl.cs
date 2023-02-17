using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Globalization;

namespace Manh.Applications.VietnameseTool
{
    public partial class VocabularyNotebookControl : UserControl
    {
        private CultureInfo cultureInfo = CultureInfo.GetCultureInfo("vi-VN");
        private Word word;
        public Word Word
        {
            get
            {
                return word;
            }
            set
            {
                if (word == value) return;
                if (value == null)
                {
                    word = null;
                    Example = null;
                    return;
                }
                word = value;
                lblWord.Text = value.ToString();
                lbxExamples.Items.Clear();
                lbxExamples.Items.AddRange(value.GetAllExamplesText().ToArray());
                if (lbxExamples.Items.Count > 0)
                {
                    lbxExamples.SelectedIndex = 0;
                }
                else
                {
                    Example = new Example(DbContext, value);
                }
                wbTratu.Document.Clear();
                wbTratuViEn.Document.Clear();
                wbTratuViJa.Document.Clear();
                wbVndic.Document.Clear();
                wbWiktionary.Document.Clear();
                tabControlDictionary_TabIndexChanged(null, EventArgs.Empty);
            }
        }

        private Example example;
        public Example Example
        {
            get
            {
                return example;
            }
            set
            {
                tbxExample.TextChanged -= tbxExampleNote_TextChanged;
                tbxExampleNote.TextAlignChanged -= tbxExampleNote_TextChanged;
                example = value;
                if (value != null)
                {
                    tbxExample.Text = value.Text;
                    tbxExampleNote.Text = value.Note;
                }
                else
                {
                    tbxExample.Text = String.Empty;
                    tbxExampleNote.Text = String.Empty;
                }
                tbxExample.TextChanged += tbxExampleNote_TextChanged;
                tbxExampleNote.TextAlignChanged += tbxExampleNote_TextChanged;
            }
        }

        public AppDbContext DbContext { get; set; }
        public VocabularyNotebookControl()
        {
            InitializeComponent();
        }

        private async void tbxWord_TextChanged(object sender, EventArgs e)
        {
            var words = await DbContext.SelectWordsByPrefix(tbxWord.Text.Trim());
            lbxWords.Items.Clear();
            lbxWords.BeginUpdate();
            foreach (var word in words)
            {
                int i = lbxWords.Items.Add(word);
                if (word == tbxWord.Text) lbxWords.SelectedIndex = i;
            }
            lbxWords.EndUpdate();
        }

        private void tbxWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    tbxWord.Text = tbxWord.Text.Trim().Standardize();
                    Word = new Word(DbContext, tbxWord.Text);
                    tbxNote.Text = Word.Note;
                    e.Handled = true;
                    break;
                case '`':
                    tbxWord.Text = tbxWord.Text.SwitchCase(cultureInfo);
                    e.Handled = true;
                    break;
            }
        }

        

        public void SetWord(string w)
        {
            tbxWord.Text = w;
            tbxWord_KeyPress(null, new KeyPressEventArgs('\r'));
        }

        private async void tabControlDictionary_TabIndexChanged(object sender, EventArgs e)
        {
            if (Word is null) return;
            switch (tabControlDictionary.SelectedTab.Name)
            {
                case "tabPageTratuViVi":
                    if (!wbTratu.Document.IsEmpty()) break;
                    wbTratu.Document.SetContent(await HtmlUtils.ParseTratuAsync("vn_vn",Word));
                    break;

                case "tabPageWiktionary":
                    if (!wbWiktionary.Document.IsEmpty()) break;
                    wbWiktionary.Document.SetContent(await HtmlUtils.ParseWiktionaryAsync(Word));
                    break;

                case "tabPageVndic":
                    if (!wbVndic.Document.IsEmpty()) break;
                    wbVndic.Document.SetContent(await HtmlUtils.ParseVndicAsync(Word));
                    break;
                case "tabPageGlosbe":
                    string url = $"https://glosbe.com/vi/zh/{Word.ToString()}";
                    if (Uri.UnescapeDataString(wbGlosbe.Url.AbsoluteUri) == url) break;
                    wbGlosbe.Navigate(url);
                    break;
                case "tabPageTratuViJa":
                    if (!wbTratuViJa.Document.IsEmpty()) break;
                    wbTratuViJa.Document.SetContent(await HtmlUtils.ParseTratuAsync("vn_jp", Word));
                    break;
                case "tabPageTratuViEn":
                    if (!wbTratuViEn.Document.IsEmpty()) break;
                    wbTratuViEn.Document.SetContent(await HtmlUtils.ParseTratuAsync("vn_en", Word));
                    break;
                case "tabPageTranslate":
                    translateControl.InputText = word?.ToString();
                    break;
            }
        }



        private void tbxNote_TextChanged(object sender, EventArgs e)
        {
            if (Word != null)
                Word.Note = tbxNote.Text;
        }

        private void lbxWords_Click(object sender, EventArgs e)
        {
            var item = lbxWords.SelectedItem;
            if (item == null) return;
            tbxWord.Text = item.ToString();
            tbxWord_KeyPress(null, new KeyPressEventArgs('\r'));
        }

        private void tbxWord_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    var count = lbxWords.Items.Count;
                    if (count == 0) return;
                    int i = lbxWords.SelectedIndex;
                    if (i + 1 == count) return;
                    lbxWords.SelectedIndex = i + 1;
                    SetTbxWordText(lbxWords.SelectedItem.ToString());
                    e.Handled = true;
                    break;
                case Keys.Up:
                    count = lbxWords.Items.Count;
                    if (count == 0) return;
                    i = lbxWords.SelectedIndex;
                    if (i <= 0) return;
                    lbxWords.SelectedIndex = i - 1;
                    SetTbxWordText(lbxWords.SelectedItem.ToString());
                    e.Handled = true;
                    break;
            }
        }

        private void SetTbxWordText(string text)
        {
            tbxWord.TextChanged -= tbxWord_TextChanged;
            tbxWord.Text = text;
            tbxWord.TextChanged += tbxWord_TextChanged;
        }

        private void lbxExamples_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbxExamples.SelectedItem == null)
            {
                return;
            }
            var exampleText = lbxExamples.SelectedItem.ToString();
            Example = new Example(DbContext, Word, exampleText);
        }

        private void btnNewExample_Click(object sender, EventArgs e)
        {
            lbxExamples.SelectedIndex = -1;
            Example = new Example(DbContext, Word);
        }

        private void tbxExample_TextChanged(object sender, EventArgs e)
        {
            lbxExamples.SelectedValueChanged -= lbxExamples_SelectedValueChanged;
            var i = lbxExamples.SelectedIndex;
            Example.Text = tbxExample.Text;
            if (Example.Colliding)
            {
                tbxExample.ForeColor = Color.Red;
            }
            else
            {
                tbxExample.ForeColor = Color.Black;
            }
            if (i == -1)
            {
                if (Example.Text.Length > 0)
                    lbxExamples.SelectedIndex = lbxExamples.Items.Add(Example.Text);
            }
            else
            {
                if (Example.Text.Length == 0)
                {
                    lbxExamples.Items.RemoveAt(i);
                }
                else
                {
                    lbxExamples.Items[i] = Example.Text;
                }
            }
            lbxExamples.SelectedValueChanged += lbxExamples_SelectedValueChanged;
        }

        private void tbxExampleNote_TextChanged(object sender, EventArgs e)
        {
            if (Example != null && Example.Note != tbxExampleNote.Text)
                Example.Note = tbxExampleNote.Text;
        }

        private void tbxExample_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    if (Example.Colliding)
                    {
                        Example.Load();
                        tbxExampleNote.Text = Example.Note;
                        tbxExample.ForeColor = Color.Black;
                        var i = lbxExamples.SelectedIndex;
                        var enumerator = lbxExamples.Items.GetEnumerator();
                        var count = 0;
                        while (enumerator.MoveNext())
                        {
                            if (enumerator.Current.ToString() == Example.Text)
                            {
                                ++count;
                            }
                        }
                        if (count > 1)
                        {
                            lbxExamples.Items.RemoveAt(i);
                            lbxExamples.SelectedValueChanged -= lbxExamples_SelectedValueChanged;
                            lbxExamples.SelectedItem = Example.Text;
                            lbxExamples.SelectedValueChanged += lbxExamples_SelectedValueChanged;
                        }
                    }
                    break;
            }
        }
    }


}
