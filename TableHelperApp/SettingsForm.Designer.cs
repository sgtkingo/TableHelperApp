
namespace TableHelperApp
{
    partial class SettingsForm
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.num_tabWidth = new System.Windows.Forms.NumericUpDown();
            this.num_tabBorder = new System.Windows.Forms.NumericUpDown();
            this.rtxt_tabTitle = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_tabWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tabBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(0, 197);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(302, 45);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Uložit";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // num_tabWidth
            // 
            this.num_tabWidth.Location = new System.Drawing.Point(142, 24);
            this.num_tabWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_tabWidth.Name = "num_tabWidth";
            this.num_tabWidth.Size = new System.Drawing.Size(148, 20);
            this.num_tabWidth.TabIndex = 1;
            // 
            // num_tabBorder
            // 
            this.num_tabBorder.Location = new System.Drawing.Point(142, 50);
            this.num_tabBorder.Name = "num_tabBorder";
            this.num_tabBorder.Size = new System.Drawing.Size(55, 20);
            this.num_tabBorder.TabIndex = 2;
            // 
            // rtxt_tabTitle
            // 
            this.rtxt_tabTitle.Location = new System.Drawing.Point(12, 131);
            this.rtxt_tabTitle.Name = "rtxt_tabTitle";
            this.rtxt_tabTitle.Size = new System.Drawing.Size(278, 55);
            this.rtxt_tabTitle.TabIndex = 3;
            this.rtxt_tabTitle.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Table Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table Border:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Table title:";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(302, 242);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxt_tabTitle);
            this.Controls.Add(this.num_tabBorder);
            this.Controls.Add(this.num_tabWidth);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tabulka";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_tabWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tabBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.NumericUpDown num_tabWidth;
        private System.Windows.Forms.NumericUpDown num_tabBorder;
        private System.Windows.Forms.RichTextBox rtxt_tabTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}