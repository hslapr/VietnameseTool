using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace Manh.Applications.VietnameseTool
{
    public partial class TranslateControl : UserControl
    {
        public TranslateControl()
        {
            InitializeComponent();
        }
        private string inputText;
        public string InputText
        {
            get
            {
                return inputText;
            }
            set
            {
                if (value != inputText)
                {
                    inputText = value;
                    tbxInput.Text = value;
                }
                
            }
        }

        private async void tbxInput_TextChanged(object sender, EventArgs e)
        {
            IList<string> result = null;
            try
            {
               result= await TranslateWithGoogle("vi", "zh-CN", tbxInput.Text);
            }
            catch
            {
                result = new List<string>();
                result.Add("Translate Server Error!");
            }
            var sb = new StringBuilder();
            for (var i =0; i < result.Count; ++i)
            {
                sb.AppendLine(result[i]);
                if (i < result.Count - 1)
                {
                    sb.Append('=', (int)(tbxGoogle.ClientRectangle.Width / TextUtils.GetCharSize(tbxGoogle, '=').Width));
                    sb.AppendLine();
                }
            }
            tbxGoogle.Text = sb.ToString();
        }

        private async Task<List<string>> TranslateWithGoogle(string from, string to, string text)
        {
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={from}&tl={to}&dt=at&q={text}";
            string jsonString = null;
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                jsonString = await client.DownloadStringTaskAsync(url);
            }
            var data = (JArray)JsonConvert.DeserializeObject  (jsonString);
            var query = from arr in data[5][0][2] let t = arr[0] select t.ToString();
            var translation = query.ToList();
            
            return translation;
        }
    }
}
