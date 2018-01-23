namespace AlbertEinsteinCommunity
{
    partial class RTFEditorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.wysiwyg = new AlbertEinsteinCommunity.WYSIWYG();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.wysiwyg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.16666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.83333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // wysiwyg
            // 
            this.wysiwyg.AutoSize = true;
            this.wysiwyg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wysiwyg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wysiwyg.Location = new System.Drawing.Point(3, 3);
            this.wysiwyg.Name = "wysiwyg";
            this.wysiwyg.Size = new System.Drawing.Size(747, 421);
            this.wysiwyg.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(747, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RTFEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RTFEditorForm";
            this.Text = "RTFEditorForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private WYSIWYG wysiwyg;
        private System.Windows.Forms.Button button1;
    }
}