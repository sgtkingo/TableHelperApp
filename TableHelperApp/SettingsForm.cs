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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {
            num_tabWidth.Value = Properties.Settings.Default.tableWidth;
            num_tabBorder.Value = Properties.Settings.Default.tableBorder;
            rtxt_tabTitle.Text = Properties.Settings.Default.tableTitle;
        }
        private void CollectData()
        {
             Properties.Settings.Default.tableWidth = (int)num_tabWidth.Value;
             Properties.Settings.Default.tableBorder = (int)num_tabBorder.Value;
             Properties.Settings.Default.tableTitle = rtxt_tabTitle.Text;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Console.WriteLine("(i) Saving properities...");
            CollectData();
            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
