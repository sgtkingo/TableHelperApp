
namespace TableHelperApp
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Help = new System.Windows.Forms.Button();
            this.dataGridView_ProductAttributes = new System.Windows.Forms.DataGridView();
            this.l_productAttrib = new System.Windows.Forms.Label();
            this.l_producDesr = new System.Windows.Forms.Label();
            this.l_productName = new System.Windows.Forms.Label();
            this.rtxt_ProductDescr = new System.Windows.Forms.RichTextBox();
            this.rtxt_ProductName = new System.Windows.Forms.RichTextBox();
            this.btn_ClearCollection = new System.Windows.Forms.Button();
            this.chbox_ClearAutocomplete = new System.Windows.Forms.CheckBox();
            this.btn_ReloadAC = new System.Windows.Forms.Button();
            this.gbox_AutoComplete = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.btn_WebBrowser = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductAttributes)).BeginInit();
            this.gbox_AutoComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Help
            // 
            this.btn_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Help.Location = new System.Drawing.Point(764, 80);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(40, 40);
            this.btn_Help.TabIndex = 6;
            this.btn_Help.Text = "?";
            this.toolTip.SetToolTip(this.btn_Help, "Překvápko...");
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // dataGridView_ProductAttributes
            // 
            this.dataGridView_ProductAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ProductAttributes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ProductAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ProductAttributes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ProductAttributes.Location = new System.Drawing.Point(16, 326);
            this.dataGridView_ProductAttributes.MultiSelect = false;
            this.dataGridView_ProductAttributes.Name = "dataGridView_ProductAttributes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ProductAttributes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ProductAttributes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_ProductAttributes.RowTemplate.Height = 30;
            this.dataGridView_ProductAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ProductAttributes.Size = new System.Drawing.Size(787, 328);
            this.dataGridView_ProductAttributes.TabIndex = 2;
            this.dataGridView_ProductAttributes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_ProductAttributes_EditingControlShowing);
            // 
            // l_productAttrib
            // 
            this.l_productAttrib.AutoSize = true;
            this.l_productAttrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_productAttrib.Location = new System.Drawing.Point(13, 299);
            this.l_productAttrib.Name = "l_productAttrib";
            this.l_productAttrib.Size = new System.Drawing.Size(173, 24);
            this.l_productAttrib.TabIndex = 4;
            this.l_productAttrib.Text = "Vlastnosti produktu:";
            // 
            // l_producDesr
            // 
            this.l_producDesr.AutoSize = true;
            this.l_producDesr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_producDesr.Location = new System.Drawing.Point(12, 123);
            this.l_producDesr.Name = "l_producDesr";
            this.l_producDesr.Size = new System.Drawing.Size(141, 24);
            this.l_producDesr.TabIndex = 3;
            this.l_producDesr.Text = "Popis produktu:";
            // 
            // l_productName
            // 
            this.l_productName.AutoSize = true;
            this.l_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_productName.Location = new System.Drawing.Point(12, 52);
            this.l_productName.Name = "l_productName";
            this.l_productName.Size = new System.Drawing.Size(169, 25);
            this.l_productName.TabIndex = 2;
            this.l_productName.Text = "Název produktu:";
            // 
            // rtxt_ProductDescr
            // 
            this.rtxt_ProductDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxt_ProductDescr.Location = new System.Drawing.Point(17, 150);
            this.rtxt_ProductDescr.Name = "rtxt_ProductDescr";
            this.rtxt_ProductDescr.Size = new System.Drawing.Size(787, 118);
            this.rtxt_ProductDescr.TabIndex = 1;
            this.rtxt_ProductDescr.Text = "";
            // 
            // rtxt_ProductName
            // 
            this.rtxt_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtxt_ProductName.Location = new System.Drawing.Point(12, 80);
            this.rtxt_ProductName.Name = "rtxt_ProductName";
            this.rtxt_ProductName.Size = new System.Drawing.Size(746, 40);
            this.rtxt_ProductName.TabIndex = 0;
            this.rtxt_ProductName.Text = "";
            // 
            // btn_ClearCollection
            // 
            this.btn_ClearCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ClearCollection.Location = new System.Drawing.Point(71, 19);
            this.btn_ClearCollection.Name = "btn_ClearCollection";
            this.btn_ClearCollection.Size = new System.Drawing.Size(164, 22);
            this.btn_ClearCollection.TabIndex = 7;
            this.btn_ClearCollection.Text = "Vyčistit Autocomplete";
            this.toolTip.SetToolTip(this.btn_ClearCollection, "Smaže lokální paměť pro AutoComplete");
            this.btn_ClearCollection.UseVisualStyleBackColor = true;
            this.btn_ClearCollection.Click += new System.EventHandler(this.btn_ClearCollection_Click);
            // 
            // chbox_ClearAutocomplete
            // 
            this.chbox_ClearAutocomplete.AutoSize = true;
            this.chbox_ClearAutocomplete.Location = new System.Drawing.Point(71, 42);
            this.chbox_ClearAutocomplete.Name = "chbox_ClearAutocomplete";
            this.chbox_ClearAutocomplete.Size = new System.Drawing.Size(125, 17);
            this.chbox_ClearAutocomplete.TabIndex = 8;
            this.chbox_ClearAutocomplete.Text = "Vymazat permanetně";
            this.toolTip.SetToolTip(this.chbox_ClearAutocomplete, "Zcela vymaže data pro AutoComplete (!) ");
            this.chbox_ClearAutocomplete.UseVisualStyleBackColor = true;
            // 
            // btn_ReloadAC
            // 
            this.btn_ReloadAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ReloadAC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ReloadAC.Location = new System.Drawing.Point(7, 19);
            this.btn_ReloadAC.Name = "btn_ReloadAC";
            this.btn_ReloadAC.Size = new System.Drawing.Size(40, 40);
            this.btn_ReloadAC.TabIndex = 9;
            this.btn_ReloadAC.Text = "↺";
            this.toolTip.SetToolTip(this.btn_ReloadAC, "Znovu načíst AutoComplete...");
            this.btn_ReloadAC.UseVisualStyleBackColor = true;
            this.btn_ReloadAC.Click += new System.EventHandler(this.btn_ReloadAC_Click);
            // 
            // gbox_AutoComplete
            // 
            this.gbox_AutoComplete.Controls.Add(this.btn_ReloadAC);
            this.gbox_AutoComplete.Controls.Add(this.chbox_ClearAutocomplete);
            this.gbox_AutoComplete.Controls.Add(this.btn_ClearCollection);
            this.gbox_AutoComplete.Location = new System.Drawing.Point(564, 9);
            this.gbox_AutoComplete.Name = "gbox_AutoComplete";
            this.gbox_AutoComplete.Size = new System.Drawing.Size(240, 65);
            this.gbox_AutoComplete.TabIndex = 10;
            this.gbox_AutoComplete.TabStop = false;
            this.gbox_AutoComplete.Text = "Nastavení AutoComplete";
            // 
            // btn_Copy
            // 
            this.btn_Copy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Copy.Image = global::TableHelperApp.Properties.Resources.Editing_Copy_icon;
            this.btn_Copy.Location = new System.Drawing.Point(283, 671);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(281, 68);
            this.btn_Copy.TabIndex = 4;
            this.btn_Copy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btn_Copy, "Kopírovat");
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Image = global::TableHelperApp.Properties.Resources.Programming_Delete_Property_icon;
            this.btn_ClearAll.Location = new System.Drawing.Point(22, 661);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(90, 90);
            this.btn_ClearAll.TabIndex = 11;
            this.toolTip.SetToolTip(this.btn_ClearAll, "Vyčistit vše");
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_WebBrowser
            // 
            this.btn_WebBrowser.Image = global::TableHelperApp.Properties.Resources.Apps_internet_web_browser_icon;
            this.btn_WebBrowser.Location = new System.Drawing.Point(720, 660);
            this.btn_WebBrowser.Name = "btn_WebBrowser";
            this.btn_WebBrowser.Size = new System.Drawing.Size(90, 90);
            this.btn_WebBrowser.TabIndex = 5;
            this.toolTip.SetToolTip(this.btn_WebBrowser, "Webový náhled");
            this.btn_WebBrowser.UseVisualStyleBackColor = true;
            this.btn_WebBrowser.Click += new System.EventHandler(this.btn_WebBrowser_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Import.Location = new System.Drawing.Point(263, 274);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(301, 49);
            this.btn_Import.TabIndex = 12;
            this.btn_Import.Text = "IMPORTOVAT";
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btn_Copy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 761);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.gbox_AutoComplete);
            this.Controls.Add(this.btn_WebBrowser);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.dataGridView_ProductAttributes);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.l_productAttrib);
            this.Controls.Add(this.l_producDesr);
            this.Controls.Add(this.l_productName);
            this.Controls.Add(this.rtxt_ProductDescr);
            this.Controls.Add(this.rtxt_ProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Tabletka";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductAttributes)).EndInit();
            this.gbox_AutoComplete.ResumeLayout(false);
            this.gbox_AutoComplete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.DataGridView dataGridView_ProductAttributes;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_WebBrowser;
        private System.Windows.Forms.Label l_productAttrib;
        private System.Windows.Forms.Label l_producDesr;
        private System.Windows.Forms.Label l_productName;
        private System.Windows.Forms.RichTextBox rtxt_ProductDescr;
        private System.Windows.Forms.RichTextBox rtxt_ProductName;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Button btn_ClearCollection;
        private System.Windows.Forms.CheckBox chbox_ClearAutocomplete;
        private System.Windows.Forms.Button btn_ReloadAC;
        private System.Windows.Forms.GroupBox gbox_AutoComplete;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_ClearAll;
        private System.Windows.Forms.Button btn_Import;
    }
}

