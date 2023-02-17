using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manh.Applications.VietnameseTool
{
    class Sequence
    {
        public RichTextBox RichTextBox { get; set; }

        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
       

        public Sequence(RichTextBox rbx, int index)
        {
            RichTextBox = rbx;
            StartIndex = index;
            EndIndex = index;
            while (StartIndex>0&&rbx.Text[StartIndex-1].IsVnLetter())
            {
                --StartIndex;
            }
            while (EndIndex < rbx.Text.Length && rbx.Text[EndIndex].IsVnLetter())
            {
                ++EndIndex;
            }
        }

        public void Select()
        {
            RichTextBox.Select(StartIndex, EndIndex - StartIndex);
        }

        public override string ToString()
        {
            return $"Sequence({StartIndex}, {EndIndex})";
        }
    }
}
