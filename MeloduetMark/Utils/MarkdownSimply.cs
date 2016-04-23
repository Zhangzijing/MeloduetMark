using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeloduetMark.Utils
{
    /// <summary>
    /// Markdown简单操作类
    /// </summary>
    public class MarkdownSimply
    {
        public static MarkdownDeep.Markdown Markdown = new MarkdownDeep.Markdown() { ExtraMode = true    };
        public static string Header = string.Format("<!DOCTYPE HTML>\n"+
            "<html>\n<head>\n<meta http-equiv = \"Content-Type\" content = \"text/html; charset=utf-8\" >\n<title></title>\n</head>\n<body>");
        public static string Footer = string.Format("</body></html>");

        /// <summary>
        /// 把markdown格式文本转换为html标记文本
        /// </summary>
        /// <param name="str">源文本</param>
        /// <returns></returns>
        public static string GetHtmlText(string str)
        {
            return Header + Markdown.Transform(str)  + Footer;
        }
        
    }
}
