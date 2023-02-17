using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows;
using System.IO;

namespace Manh.Applications.VietnameseTool
{
    public partial class ReadingTextBox : UserControl
    {
        public ReadingTextBox()
        {
            InitializeComponent();
            richTextBox.AutoWordSelection = false;
            Mode = ReadingTextBoxMode.Edit;
            LoadText();
        }

        private int selectionStart;
        private int selectionLength;
        private ReadingTextBoxMode mode;

        public ReadingTextBoxMode Mode
        {
            get { return mode; }
            set
            {
                mode = value;
                if (value == ReadingTextBoxMode.Edit)
                {
                    richTextBox.ReadOnly = false;
                }
                else
                {
                    richTextBox.ReadOnly = true;
                }
            }
        }


        private void richTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (Mode == ReadingTextBoxMode.Edit) return;
            var index = richTextBox.GetCharIndexFromPosition(e.Location);
            var seq = new Sequence(richTextBox, index);
            var leftTop = richTextBox.GetPositionFromCharIndex(seq.StartIndex);
            var rightButtom = richTextBox.GetPositionFromCharIndex(seq.EndIndex - 1) + TextUtils.GetCharSize(richTextBox, richTextBox.Text[seq.EndIndex - 1]);
            var seqSize = new Size(rightButtom.X - leftTop.X, rightButtom.Y - leftTop.Y);
            var rect = new Rectangle(leftTop, seqSize);
            if (rect.Contains(e.Location))
            {
                if (e.Clicks > 1 || selectionLength == 0)
                {
                    seq.Select();
                    selectionStart = seq.StartIndex;
                    selectionLength = seq.EndIndex - seq.StartIndex;
                }
                else if (selectionLength>0)
                {
                    var end = selectionStart + selectionLength;
                    if (end <= seq.StartIndex)
                    {
                        if (richTextBox.Text.Substring(end, seq.StartIndex - end).IsWhiteSpace())
                        {
                            selectionLength += seq.EndIndex - end;
                            richTextBox.Select(selectionStart, selectionLength);
                        }
                        else
                        {
                            seq.Select();
                            selectionStart = seq.StartIndex;
                            selectionLength = seq.EndIndex - seq.StartIndex;
                        }
                    }
                    else if (selectionStart >= seq.EndIndex)
                    {
                        if (richTextBox.Text.Substring(seq.EndIndex, selectionStart - seq.EndIndex).IsWhiteSpace())
                        {
                            selectionLength += selectionStart - seq.StartIndex;
                            selectionStart = seq.StartIndex;
                            richTextBox.Select(selectionStart, selectionLength);
                        }
                        else
                        {
                            seq.Select();
                            selectionStart = seq.StartIndex;
                            selectionLength = seq.EndIndex - seq.StartIndex;
                        }
                    }
                    else
                    {
                        seq.Select();
                        selectionStart = seq.StartIndex;
                        selectionLength = seq.EndIndex - seq.StartIndex;
                    }
                }
                else
                {
                    seq.Select();
                    selectionStart = seq.StartIndex;
                    selectionLength = seq.EndIndex - seq.StartIndex;
                }
                SelectionChangedEvent.Invoke(this, new SelectionChangedEventArgs(richTextBox.SelectedText));
            }
            else
            {
                selectionLength = 0;
                selectionStart = richTextBox.SelectionStart;
                richTextBox.DeselectAll();
            }
            richTextBox.ResumeLayout();
        }

        private void richTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Mode == ReadingTextBoxMode.Edit) return;
            richTextBox.Select(selectionStart, selectionLength);
            //if (Mode == ReadingTextBoxMode.Edit) return;
            //richTextBox_MouseClick(sender, e);
            return;
        }


        public void SaveText()
        {
            //using (var writer = new StreamWriter(File.Open("text.txt", FileMode.Create), Encoding.UTF8))
            //{
            //    writer.Write(richTextBox.Text);
            //}
            richTextBox.SaveFile("text.txt", RichTextBoxStreamType.UnicodePlainText);
        }

        public void LoadText()
        {
            //if (File.Exists("text.txt"))
            //    using (var reader = new StreamReader(File.OpenRead("text.txt"), Encoding.UTF8))
            //    {
            //        richTextBox.Text = reader.ReadToEnd();
            //    }
            richTextBox.LoadFile("text.txt", RichTextBoxStreamType.UnicodePlainText);

        }


        public event SelectionChangedEventHandler SelectionChangedEvent;

        public delegate void SelectionChangedEventHandler(Object sender, SelectionChangedEventArgs e);

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (Mode == ReadingTextBoxMode.Edit) return;
            richTextBox.Select(selectionStart, selectionLength);
        }
    }

    public class SelectionChangedEventArgs : EventArgs
    {
        public string Text { get; }
        public SelectionChangedEventArgs(string text)
        {
            Text = text;
        }
    }

    public enum ReadingTextBoxMode { Read, Edit }
}
