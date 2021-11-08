using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FileControl;

namespace TableHelperApp
{
    public class HTMLGenerator
    {
        static int tableWidth = Properties.Settings.Default.tableWidth;
        static int tableBorder = Properties.Settings.Default.tableBorder;

        public static string GenerateHTMLTable(string title, string description, string data)
        {
            Console.WriteLine($"(i)\t\t Generating HTML table...");
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($@"<h1>{title}</h1>");
            stringBuilder.AppendLine($@"<p>{description}</p>");
            stringBuilder.AppendLine($@"<p>{Properties.Settings.Default.tableTitle}</p>");
            stringBuilder.AppendLine($"<table dir=\"LTR\" border=\"{tableBorder}\" width=\"{tableWidth}\" cellspacing=\"0\" cellpadding=\"2\">");
            stringBuilder.AppendLine(@"<tbody>");
            stringBuilder.AppendLine($"{data}");
            stringBuilder.AppendLine(@"</tbody>");
            stringBuilder.AppendLine(@"</table>");

            return stringBuilder.ToString();
        }

        public static void GenerateHTMLTableAsFile(string title, string description, string data, string filePath)
        {
            Console.WriteLine($"(i)\t Generating HTML table as file({filePath})...");
            string HTMLdata = GenerateHTMLTable(title, description, data);
            FileManager.SaveFile(filePath, HTMLdata);
            Console.WriteLine($"(i)\t DONE!");
        }
    }
}
