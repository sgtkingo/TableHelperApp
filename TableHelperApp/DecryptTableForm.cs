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
            Decryptor = new Decryptor();
            DecryptedProducts = null;

            richTextBox_Data.TextChanged += TextDecryptCheckEvent;
            rbtn_LineSplit.CheckedChanged += TextDecryptCheckEvent;
            rbtn_TabSplit.CheckedChanged += TextDecryptCheckEvent;

            //ENTER as default
            rbtn_LineSplit.Checked = true;
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

        private void DecryptText(string txt)
        {
            if (rbtn_TabSplit.Checked)
            {
                DecryptedProducts = Decryptor.DectyptText(txt, Decryptor.SplitType.TAB);
            }
            if (rbtn_LineSplit.Checked)
            {
                DecryptedProducts = Decryptor.DectyptText(txt, Decryptor.SplitType.ENTER);
            }
        }

        private void TryDetect(string txt)
        {
            l_detect.Text = $"Detekováno: {Decryptor.GetSplitType(txt)}";
            DecryptText(txt);
        }

        private void TextDecryptCheckEvent(object sender, EventArgs e)
        {
            //Console.WriteLine($"sender={sender}, e={e}");
            var rtxt = richTextBox_Data;
            int lastPosition = rtxt.SelectionStart;
            //Detection
            TryDetect(rtxt.Text);
            
            //Show errors
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
                for (int i = 0; i < rtxt.Lines.Length; i++)
                {
                    var start = rtxt.GetFirstCharIndexFromLine(i);
                    var end = rtxt.Text.IndexOf('\n', start);
                    if (end == -1)
                    {
                        end = rtxt.Text.Length;
                    }
                    rtxt.Select(start, end);

                    if (Decryptor.ErrorLines.Contains(i))
                    {
                        rtxt.SelectionBackColor = Color.Red;
                    }
                    else
                    {
                        //Clean highlight
                        rtxt.SelectionBackColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\t(!) {this}: Problem: {ex.Message} | {ex.Source} ");
            }
            //Reset selection
            rtxt.Select(lastPosition, 0);
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

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox_Data.SelectedText)) return;

            Clipboard.SetText(richTextBox_Data.SelectedText);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Data.Text += Clipboard.GetText();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Data.SelectAll();
        }

        private void rbtn_TabSplit_CheckedChanged(object sender, EventArgs e)
        {
            DecryptText(richTextBox_Data.Text);
        }

        private void rbtn_LineSplit_CheckedChanged(object sender, EventArgs e)
        {
            DecryptText(richTextBox_Data.Text);
        }

        private void DecryptTableForm_Resize(object sender, EventArgs e)
        {
            var newX = this.Width - (gbox_SplitType.Size.Width + 20);
            var newY = 10;
            gbox_SplitType.Location = new Point(newX, newY);
        }
    }
}
