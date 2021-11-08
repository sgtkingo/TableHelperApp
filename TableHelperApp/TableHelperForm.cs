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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitProgram();
        }

        private void InitProgram()
        {
            btn_Copy.Click += ButtonCopyEfectEvent;

            ProperitiesManager.Init();
            BindSources();
        }

        private void BindSources()
        {
            productsBindingSource.DataSource = ProductManager.Products;
            dataGridView_ProductAttributes.DataSource = productsBindingSource;

            productsBindingSource.ResetBindings(true);
            SetDataGrid();
        }

        private void SetDataGrid()
        {
            dataGridView_ProductAttributes.RowTemplate.Height = 30;
        }

        private void CreateHTMLFile()
        {
            string title = rtxt_ProductName.Text;
            string description = rtxt_ProductDescr.Text;
            string data = ProductManager.GetProductsAsString();
            string filePath = ProperitiesManager.RelativeHTMLFilePath;

            HTMLGenerator.GenerateHTMLTableAsFile(title, description, data, filePath);
        }

        private void CopyHTML()
        {
            string title = rtxt_ProductName.Text;
            string description = rtxt_ProductDescr.Text;
            string data = ProductManager.GetProductsAsString();

            Clipboard.SetText(HTMLGenerator.GenerateHTMLTable(title, description, data));

            Collector.UpdateCollectionAsync(ProductManager.GetPruductAttributeNamesAsList().ToArray());
        }

        private async void ButtonCopyEfectEvent(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var originColor = button.BackColor;

            button.Text = "Zkopírováno do schránky!";
            button.BackColor = Color.GreenYellow;
            await Task.Run(() => {   
                Thread.Sleep(1000);   
            });
            button.Text = string.Empty;
            button.BackColor = originColor;
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            CopyHTML();
        }

        private void btn_WebBrowser_Click(object sender, EventArgs e)
        {
            CreateHTMLFile();

            var form = new HTMLViewer(ProperitiesManager.AbsoluteHTMLFilePath);
            form.ShowDialog();
        }

        private void dataGridView_ProductAttributes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            //0 = AttributeName
            if (dataGridView.CurrentCell.ColumnIndex == 0)
            {
                try
                {
                    var txtBox = e.Control as TextBox;
                    txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtBox.AutoCompleteCustomSource = Collector.Collection;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\t(!) {this}: Problem: {ex.Message} | {ex.Source} ");
                }
            }
            //1 = AttributeValue
            if (dataGridView.CurrentCell.ColumnIndex == 1)
            {
                try
                {
                    var txtBox = e.Control as TextBox;
                    txtBox.Multiline = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\t(!) {this}: Problem: {ex.Message} | {ex.Source} ");
                }
            }

        }

        private void ClearAutocomplete(bool permanentClear)
        {
            if(permanentClear)
            {
                if (MessageBox.Show("Opravdu permanetně smazat paměť AutoComplete funkce?\nTato akce je nevratná!","Smazat paměť AutoComplete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Collector.ClearCollection(false);
                }
            }
            else
            {
                Collector.ClearCollection(true);
            }
        }

        private void btn_ClearCollection_Click(object sender, EventArgs e)
        {
            ClearAutocomplete(chbox_ClearAutocomplete.Checked);
            chbox_ClearAutocomplete.Checked = false;
        }

        private void btn_ReloadAC_Click(object sender, EventArgs e)
        {
            Collector.Init(ProperitiesManager.RelativeStringCollectionFileName);
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Opravdu to chceš smazat ženo?", "Bacha", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes) {
                rtxt_ProductDescr.Text = string.Empty;
                rtxt_ProductName.Text = string.Empty;

                ProductManager.Products.Clear();
                productsBindingSource.ResetBindings(true);
            }
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            var form = new DecryptTableForm();
            form.FormClosed += (_sender, _e) =>
            {
                if( form.DialogResult == DialogResult.OK)
                {
                    ProductManager.Products.AddRange(form.DecryptedProducts);
                    productsBindingSource.ResetBindings(true);
                }
            };
            form.ShowDialog();
        }

        //Menu
        private void topSecretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Snad ti to trošku ulehčí práci...<3", "Děsně tajný");
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutBox();
            form.ShowDialog(this);
        }

        private void tableStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SettingsForm();
            form.ShowDialog(this);
        }
    }
}
