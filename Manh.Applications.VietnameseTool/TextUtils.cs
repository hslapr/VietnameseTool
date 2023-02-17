using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace Manh.Applications.VietnameseTool
{
    static class TextUtils
    {
        public static bool IsWord(string s)
        {
            return true;
        }


        public static string SwitchCase(this string s, CultureInfo cultureInfo)
        {
            if (s == cultureInfo.TextInfo.ToUpper(s))
            {
                return cultureInfo.TextInfo.ToLower(s);
            }
            if (s == cultureInfo.TextInfo.ToLower(s))
            {
                return cultureInfo.TextInfo.ToTitleCase(s);
            }
            if (s == cultureInfo.TextInfo.ToTitleCase(s))
            {
                return cultureInfo.TextInfo.ToUpper(s);
            }
            return cultureInfo.TextInfo.ToLower(s);
        }

        public static bool IsVnLetter(this char c) => Regex.IsMatch(
            c.ToString(), @"[ÀÁÂÃÒÓÔÕÙÚÈÉÊÌÍÝĂĐĨŨƠƯẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼẾỀỂỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪỬỮỰỲỴỶỸàáâãòóôõùúèéêìíýăđĩũơưạảấầẩẫậắằẳẵặẹẻẽếềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹa-zA-Z\-]");

        public static bool IsWhiteSpace(this string s)
        {
            foreach (var c in s)
            {
                if (c == '\r' || c == '\n' || (!Char.IsWhiteSpace(c))) return false;
            }
            return true;
        }

        public static Size GetCharSize(TextBoxBase tb, char c)
        {
            var size = new Size();
            using (Graphics g = tb.CreateGraphics())
            {
                var csize = g.MeasureString("A", tb.Font);
                size.Height = Convert.ToInt32(csize.Height);
                size.Width = Convert.ToInt32(csize.Width);
            }
            return size;
        }

        public static string Standardize(this string word)
        {
            string[] oldPatterns = { "óa", "Óa", "òa", "Òa", "ọa", "Ọa", "ỏa", "Ỏa", "õa", "Õa", "óe", "Óe", "òe", "Òe", "ọe", "Ọe", "ỏe", "Ỏe", "õe", "Õe", "úy", "Úy", "ùy", "Ùy", "ũy", "Ũy", "ủy", "Ủy", "ụy", "Ụy" };
            string[] newPatterns = { "oá", "Oá", "oà", "Oà", "oạ", "Oạ", "oả", "Oả", "oã", "Oã", "oé", "Oé", "oè", "Oè", "oẹ", "Oẹ", "oẻ", "Oẻ", "oẽ", "Oẽ", "uý", "Uý", "uỳ", "Uỳ", "uỹ", "Uỹ", "uỷ", "Uỷ", "uỵ", "Uỵ" };
            for (var i = 0; i < oldPatterns.Length; ++i)
            {
                word = word.Replace(oldPatterns[i], newPatterns[i]);
            }
            return word;
        }
    }
}
