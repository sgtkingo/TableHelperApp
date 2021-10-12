using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableHelperApp
{
    public partial class DecryptTableForm : Form
    {
        public List<Product> DecryptedProducts;
        public Decryptor Decryptor { get; private set; }

        public DecryptTableForm()
        {
            InitializeComponent();
        }

        private void DecryptTableForm_Load(object sender, EventArgs e)
        {
            richTextBox_Data.TextChanged += RichBoxTextDecryptCheckEvent;

            Decryptor = new Decryptor();
            DecryptedProducts = null;
        }

        private void ExportAndClose()
        {
            if (DecryptedProducts == null)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void RichBoxTextDecryptCheckEvent(object sender, EventArgs e)
        {
            var rtxt = (RichTextBox)sender;
            //Clean highlight
            rtxt.SelectAll();
            rtxt.SelectionBackColor = Color.Empty;

            if (DecryptedProducts == null)
            {
                rtxt.BackColor = Color.Red;
                btn_OK.Enabled = false;
            }
            else
            {
                rtxt.BackColor = Color.LightGreen;
                btn_OK.Enabled = true;
            }
            //Try to highlight errors
            try
            {
                foreach (var errorLineNumber in Decryptor.ErrorLines)
                {
                    var start = rtxt.GetFirstCharIndexFromLine(errorLineNumber);
                    var end = rtxt.Text.IndexOf('\n');
                    rtxt.Select(start, end);
                    rtxt.SelectionBackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t(!) {this}: Problem: {ex.Message} | {ex.Source} ");
            }
            rtxt.SelectionStart = rtxt.Text.Length;
        }

        private void richTextBox_Data_TextChanged(object sender, EventArgs e)
        {
            string txt = richTextBox_Data.Text;
            DecryptedProducts = Decryptor.DectyptText(txt);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if( Decryptor.ErrorLines.Count != 0)
            {
                if (MessageBox.Show($"Bylo nalezeno {Decryptor.ErrorLines.Count} chybných řádků, které nebudou exportovány! Přesto pokračovat?", "Nalezeny chybné řádky", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ExportAndClose();
                }
                else return;
            }
            else ExportAndClose();
        }
    }
}
