using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableHelperApp
{
    public partial class HTMLViewer : Form
    {
        public HTMLViewer(string HTML_file_path)
        {
            InitializeComponent();
            ShowPage("file:///" + HTML_file_path);
        }

        public void ShowPage(string URI_path)
        {
            try
            {
                Uri uri = new Uri(URI_path);
                webBrowser.Url = uri;
                //webBrowser.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t(!) {this}: Problem: {ex.Message} | {ex.Source} ");
            }
        }
    }
}
