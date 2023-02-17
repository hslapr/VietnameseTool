using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System;

namespace Manh.Applications.VietnameseTool
{
    public static class HtmlUtils
    {
        public static async Task<string> ParseVndicAsync(string word)
        {
            var url = $"http://4.vndic.net/index.php?word={word}&dict=vi_cn";
            var client = new WebClient();
            var doc = new HtmlAgilityPack.HtmlDocument();
            using (var stream = await client.OpenReadTaskAsync(url))
            {
                doc.Load(stream, Encoding.UTF8);
            }
            var table = doc.DocumentNode.SelectSingleNode("//di[@itemprop='description']//table");
            if (table == null)
            {
                return String.Empty;
            }
            return table.OuterHtml;
        }

        public static async Task<string> ParseTratuAsync(string dict, string word)
        {
            var url = $"http://tratu.soha.vn/dict/{dict}/{word}";
            var client = new WebClient();
            var doc = new HtmlAgilityPack.HtmlDocument();
            using (var stream = await client.OpenReadTaskAsync(url))
            {
                doc.Load(stream, Encoding.UTF8);
            }
            var contentDiv = doc.DocumentNode.SelectSingleNode("//div[@id='bodyContent']");
            if (contentDiv is null)
            {
                return String.Empty;
            }
            return contentDiv.OuterHtml;
        }

        public static async Task<string> ParseWiktionaryAsync(string word)
        {
            var url = $"https://en.wiktionary.org/w/api.php?action=parse&page={word}&prop=text&format=json";
            string jsonString = null;
            using (var client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                jsonString = await client.DownloadStringTaskAsync(url);
            }
            HtmlNode node;
            try
            {
                var data = (JObject)JsonConvert.DeserializeObject(jsonString);
                var html = data["parse"]["text"]["*"]?.ToString();
                if (html is null)
                {
                    return String.Empty;
                }
                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                node = doc.DocumentNode.SelectSingleNode("//span[@id='Vietnamese']/..");
            }
            catch
            {
                return String.Empty;
            }
            if (node == null)
            {
                return String.Empty;
            }
            var root = HtmlNode.CreateNode("<div></div>");
            var skip = false;
            do
            {
                if (node.Name == "h3")
                {
                    if (node.FirstChild.InnerText == "Pronunciation" || node.FirstChild.InnerText == "Further reading")
                    {
                        skip = true;
                    }
                    else
                    {
                        skip = false;
                    }
                }
                if (!skip)
                {
                    root.AppendChild(node.Clone());
                }
                node = node.NextSibling;
            } while (node != null && node.Name != "h2");
            return root.InnerHtml;
        }

        public static void SetContent(this System.Windows.Forms.HtmlDocument document, string contentHtml)
        {
            if (document.Body is null)
                document.Write("<html lang=\"vi\"><head></head><body></body></html>");
            document.Body.InnerHtml = contentHtml;
        }

        public static bool IsEmpty(this System.Windows.Forms.HtmlDocument document)
        {
            if (document.Body is null) return true;
            return document.Body.InnerHtml is null || document.Body.InnerHtml.Length == 0;
        }

        public static void Clear(this System.Windows.Forms.HtmlDocument document)
        {
            document.SetContent(String.Empty);
        }

    }
}
