
namespace TableHelperApp
{
    partial class DecryptTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox_Data = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip_RichText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kopírovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vybratVšeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_OK = new System.Windows.Forms.Button();
            this.rbtn_TabSplit = new System.Windows.Forms.RadioButton();
            this.gbox_SplitType = new System.Windows.Forms.GroupBox();
            this.l_detect = new System.Windows.Forms.Label();
            this.rbtn_LineSplit = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip_RichText.SuspendLayout();
            this.gbox_SplitType.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Data
            // 
            this.richTextBox_Data.ContextMenuStrip = this.contextMenuStrip_RichText;
            this.richTextBox_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_Data.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Data.Name = "richTextBox_Data";
            this.richTextBox_Data.Size = new System.Drawing.Size(800, 450);
            this.richTextBox_Data.TabIndex = 0;
            this.richTextBox_Data.Text = "";
            // 
            // contextMenuStrip_RichText
            // 
            this.contextMenuStrip_RichText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopírovatToolStripMenuItem,
            this.vložitToolStripMenuItem,
            this.vybratVšeToolStripMenuItem});
            this.contextMenuStrip_RichText.Name = "contextMenuStrip_RichText";
            this.contextMenuStrip_RichText.Size = new System.Drawing.Size(129, 70);
            // 
            // kopírovatToolStripMenuItem
            // 
            this.kopírovatToolStripMenuItem.Name = "kopírovatToolStripMenuItem";
            this.kopírovatToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.kopírovatToolStripMenuItem.Text = "Kopírovat";
            this.kopírovatToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // vložitToolStripMenuItem
            // 
            this.vložitToolStripMenuItem.Name = "vložitToolStripMenuItem";
            this.vložitToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.vložitToolStripMenuItem.Text = "Vložit";
            this.vložitToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // vybratVšeToolStripMenuItem
            // 
            this.vybratVšeToolStripMenuItem.Name = "vybratVšeToolStripMenuItem";
            this.vybratVšeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.vybratVšeToolStripMenuItem.Text = "Vybrat vše";
            this.vybratVšeToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OK.Location = new System.Drawing.Point(0, 401);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(800, 49);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "Exportovat";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // rbtn_TabSplit
            // 
            this.rbtn_TabSplit.AutoSize = true;
            this.rbtn_TabSplit.Location = new System.Drawing.Point(6, 19);
            this.rbtn_TabSplit.Name = "rbtn_TabSplit";
            this.rbtn_TabSplit.Size = new System.Drawing.Size(46, 17);
            this.rbtn_TabSplit.TabIndex = 1;
            this.rbtn_TabSplit.TabStop = true;
            this.rbtn_TabSplit.Text = "TAB";
            this.rbtn_TabSplit.UseVisualStyleBackColor = true;
            this.rbtn_TabSplit.CheckedChanged += new System.EventHandler(this.rbtn_TabSplit_CheckedChanged);
            // 
            // gbox_SplitType
            // 
            this.gbox_SplitType.Controls.Add(this.l_detect);
            this.gbox_SplitType.Controls.Add(this.rbtn_LineSplit);
            this.gbox_SplitType.Controls.Add(this.rbtn_TabSplit);
            this.gbox_SplitType.Location = new System.Drawing.Point(615, 12);
            this.gbox_SplitType.Name = "gbox_SplitType";
            this.gbox_SplitType.Size = new System.Drawing.Size(173, 60);
            this.gbox_SplitType.TabIndex = 3;
            this.gbox_SplitType.TabStop = false;
            this.gbox_SplitType.Text = "Typ dešifrace";
            // 
            // l_detect
            // 
            this.l_detect.AutoSize = true;
            this.l_detect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_detect.Location = new System.Drawing.Point(6, 39);
            this.l_detect.Name = "l_detect";
            this.l_detect.Size = new System.Drawing.Size(90, 13);
            this.l_detect.TabIndex = 4;
            this.l_detect.Text = "Nedetekováno";
            // 
            // rbtn_LineSplit
            // 
            this.rbtn_LineSplit.AutoSize = true;
            this.rbtn_LineSplit.Location = new System.Drawing.Point(105, 19);
            this.rbtn_LineSplit.Name = "rbtn_LineSplit";
            this.rbtn_LineSplit.Size = new System.Drawing.Size(62, 17);
            this.rbtn_LineSplit.TabIndex = 2;
            this.rbtn_LineSplit.TabStop = true;
            this.rbtn_LineSplit.Text = "ENTER";
            this.rbtn_LineSplit.UseVisualStyleBackColor = true;
            this.rbtn_LineSplit.CheckedChanged += new System.EventHandler(this.rbtn_LineSplit_CheckedChanged);
            // 
            // DecryptTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_SplitType);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.richTextBox_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DecryptTableForm";
            this.Text = "Přímé vložení";
            this.Load += new System.EventHandler(this.DecryptTableForm_Load);
            this.Resize += new System.EventHandler(this.DecryptTableForm_Resize);
            this.contextMenuStrip_RichText.ResumeLayout(false);
            this.gbox_SplitType.ResumeLayout(false);
            this.gbox_SplitType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Data;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_RichText;
        private System.Windows.Forms.ToolStripMenuItem kopírovatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vybratVšeToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbtn_TabSplit;
        private System.Windows.Forms.GroupBox gbox_SplitType;
        private System.Windows.Forms.Label l_detect;
        private System.Windows.Forms.RadioButton rbtn_LineSplit;
    }
}