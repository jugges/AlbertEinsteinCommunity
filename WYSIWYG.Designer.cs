namespace AlbertEinsteinCommunity
{
    partial class WYSIWYG
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsUndo = new System.Windows.Forms.ToolStripButton();
            this.tsRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBold = new System.Windows.Forms.ToolStripButton();
            this.tsItalic = new System.Windows.Forms.ToolStripButton();
            this.tsUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLeft = new System.Windows.Forms.ToolStripButton();
            this.tsCenter = new System.Windows.Forms.ToolStripButton();
            this.tsRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFontColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSelectFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBackgroundColor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsSelectBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBullet = new System.Windows.Forms.ToolStripButton();
            this.tsIdentPlus = new System.Windows.Forms.ToolStripButton();
            this.tsIdentMinus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.tsFontType = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.rtb);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(548, 311);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(548, 338);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // rtb
            // 
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.HideSelection = false;
            this.rtb.Location = new System.Drawing.Point(0, 0);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(548, 311);
            this.rtb.TabIndex = 1;
            this.rtb.TabStop = false;
            this.rtb.Text = "";
            this.rtb.SelectionChanged += new System.EventHandler(this.rtb_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUndo,
            this.tsRedo,
            this.toolStripSeparator1,
            this.tsBold,
            this.tsItalic,
            this.tsUnderline,
            this.tsStrikeout,
            this.toolStripSeparator2,
            this.tsLeft,
            this.tsCenter,
            this.tsRight,
            this.toolStripSeparator3,
            this.tsFontColor,
            this.tsBackgroundColor,
            this.toolStripSeparator5,
            this.tsBullet,
            this.tsIdentPlus,
            this.tsIdentMinus,
            this.toolStripSeparator6,
            this.tsFontSize,
            this.tsFontType});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(540, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsUndo
            // 
            this.tsUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUndo.Image = global::AlbertEinsteinCommunity.Properties.Resources.undo;
            this.tsUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUndo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsUndo.Name = "tsUndo";
            this.tsUndo.Size = new System.Drawing.Size(24, 24);
            this.tsUndo.Text = "Undo";
            this.tsUndo.Click += new System.EventHandler(this.tsUndo_Click);
            // 
            // tsRedo
            // 
            this.tsRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRedo.Image = global::AlbertEinsteinCommunity.Properties.Resources.redo;
            this.tsRedo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRedo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsRedo.Name = "tsRedo";
            this.tsRedo.Size = new System.Drawing.Size(24, 24);
            this.tsRedo.Text = "Redo";
            this.tsRedo.Click += new System.EventHandler(this.tsRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsBold
            // 
            this.tsBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBold.Image = global::AlbertEinsteinCommunity.Properties.Resources.bold;
            this.tsBold.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBold.Name = "tsBold";
            this.tsBold.Size = new System.Drawing.Size(24, 24);
            this.tsBold.Text = "Bold";
            this.tsBold.Click += new System.EventHandler(this.tsBold_Click);
            // 
            // tsItalic
            // 
            this.tsItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsItalic.Image = global::AlbertEinsteinCommunity.Properties.Resources.italic;
            this.tsItalic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsItalic.Name = "tsItalic";
            this.tsItalic.Size = new System.Drawing.Size(24, 24);
            this.tsItalic.Text = "Italic";
            this.tsItalic.Click += new System.EventHandler(this.tsItalic_Click);
            // 
            // tsUnderline
            // 
            this.tsUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUnderline.Image = global::AlbertEinsteinCommunity.Properties.Resources.underline;
            this.tsUnderline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUnderline.Name = "tsUnderline";
            this.tsUnderline.Size = new System.Drawing.Size(24, 24);
            this.tsUnderline.Text = "Underline";
            this.tsUnderline.Click += new System.EventHandler(this.tsUnderline_Click);
            // 
            // tsStrikeout
            // 
            this.tsStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsStrikeout.Image = global::AlbertEinsteinCommunity.Properties.Resources.strikethrough;
            this.tsStrikeout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsStrikeout.Name = "tsStrikeout";
            this.tsStrikeout.Size = new System.Drawing.Size(24, 24);
            this.tsStrikeout.Text = "Strikeout";
            this.tsStrikeout.Click += new System.EventHandler(this.tsStrikeout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsLeft
            // 
            this.tsLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLeft.Image = global::AlbertEinsteinCommunity.Properties.Resources.justifyleft;
            this.tsLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsLeft.Name = "tsLeft";
            this.tsLeft.Size = new System.Drawing.Size(24, 24);
            this.tsLeft.Text = "Left";
            this.tsLeft.Click += new System.EventHandler(this.tsLeft_Click);
            // 
            // tsCenter
            // 
            this.tsCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCenter.Image = global::AlbertEinsteinCommunity.Properties.Resources.justifycenter;
            this.tsCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCenter.Name = "tsCenter";
            this.tsCenter.Size = new System.Drawing.Size(24, 24);
            this.tsCenter.Text = "Center";
            this.tsCenter.Click += new System.EventHandler(this.tsCenter_Click);
            // 
            // tsRight
            // 
            this.tsRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRight.Image = global::AlbertEinsteinCommunity.Properties.Resources.justifyright;
            this.tsRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRight.Name = "tsRight";
            this.tsRight.Size = new System.Drawing.Size(24, 24);
            this.tsRight.Text = "Right";
            this.tsRight.Click += new System.EventHandler(this.tsRight_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsFontColor
            // 
            this.tsFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFontColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSelectFontColor});
            this.tsFontColor.Image = global::AlbertEinsteinCommunity.Properties.Resources.forecolor;
            this.tsFontColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFontColor.Name = "tsFontColor";
            this.tsFontColor.Size = new System.Drawing.Size(33, 24);
            this.tsFontColor.Text = "    ";
            this.tsFontColor.ToolTipText = "Font color  ";
            this.tsFontColor.Click += new System.EventHandler(this.tsFontColor_Click);
            // 
            // tsSelectFontColor
            // 
            this.tsSelectFontColor.Name = "tsSelectFontColor";
            this.tsSelectFontColor.Size = new System.Drawing.Size(144, 22);
            this.tsSelectFontColor.Text = "Select color...";
            this.tsSelectFontColor.Click += new System.EventHandler(this.tsSelectFontColor_Click);
            // 
            // tsBackgroundColor
            // 
            this.tsBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBackgroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSelectBackgroundColor});
            this.tsBackgroundColor.Image = global::AlbertEinsteinCommunity.Properties.Resources.backcolor;
            this.tsBackgroundColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBackgroundColor.Name = "tsBackgroundColor";
            this.tsBackgroundColor.Size = new System.Drawing.Size(33, 24);
            this.tsBackgroundColor.Text = "    ";
            this.tsBackgroundColor.ToolTipText = "Background color";
            this.tsBackgroundColor.Click += new System.EventHandler(this.tsBackgroundColor_Click);
            // 
            // tsSelectBackgroundColor
            // 
            this.tsSelectBackgroundColor.Name = "tsSelectBackgroundColor";
            this.tsSelectBackgroundColor.Size = new System.Drawing.Size(144, 22);
            this.tsSelectBackgroundColor.Text = "Select color...";
            this.tsSelectBackgroundColor.Click += new System.EventHandler(this.tsSelectBackgroundColor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsBullet
            // 
            this.tsBullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBullet.Image = global::AlbertEinsteinCommunity.Properties.Resources.bullist;
            this.tsBullet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBullet.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsBullet.Name = "tsBullet";
            this.tsBullet.Size = new System.Drawing.Size(24, 24);
            this.tsBullet.Text = "Bullet";
            this.tsBullet.Click += new System.EventHandler(this.tsBullet_Click);
            // 
            // tsIdentPlus
            // 
            this.tsIdentPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsIdentPlus.Image = global::AlbertEinsteinCommunity.Properties.Resources.indent;
            this.tsIdentPlus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsIdentPlus.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsIdentPlus.Name = "tsIdentPlus";
            this.tsIdentPlus.Size = new System.Drawing.Size(24, 24);
            this.tsIdentPlus.Text = "Ident plus";
            this.tsIdentPlus.Click += new System.EventHandler(this.tsIdentPlus_Click);
            // 
            // tsIdentMinus
            // 
            this.tsIdentMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsIdentMinus.Image = global::AlbertEinsteinCommunity.Properties.Resources.outdent;
            this.tsIdentMinus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsIdentMinus.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsIdentMinus.Name = "tsIdentMinus";
            this.tsIdentMinus.Size = new System.Drawing.Size(24, 24);
            this.tsIdentMinus.Text = "Ident minus";
            this.tsIdentMinus.Click += new System.EventHandler(this.tsIdentMinus_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsFontSize
            // 
            this.tsFontSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tsFontSize.AutoSize = false;
            this.tsFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.tsFontSize.Name = "tsFontSize";
            this.tsFontSize.Size = new System.Drawing.Size(50, 23);
            this.tsFontSize.ToolTipText = "Font size";
            this.tsFontSize.SelectedIndexChanged += new System.EventHandler(this.tsFontSize_SelectedIndexChanged);
            this.tsFontSize.Leave += new System.EventHandler(this.tsFontSize_Leave);
            this.tsFontSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tsFontSize_KeyUp);
            // 
            // tsFontType
            // 
            this.tsFontType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFontType.Name = "tsFontType";
            this.tsFontType.Size = new System.Drawing.Size(61, 24);
            this.tsFontType.Text = "Font type";
            this.tsFontType.Click += new System.EventHandler(this.tsFontType_Click);
            // 
            // WYSIWYG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer);
            this.Name = "WYSIWYG";
            this.Size = new System.Drawing.Size(548, 338);
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsItalic;
        private System.Windows.Forms.ToolStripButton tsUnderline;
        private System.Windows.Forms.ToolStripButton tsStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsLeft;
        private System.Windows.Forms.ToolStripButton tsCenter;
        private System.Windows.Forms.ToolStripButton tsRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsFontColor;
        private System.Windows.Forms.ToolStripMenuItem tsSelectFontColor;
        private System.Windows.Forms.ToolStripDropDownButton tsBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem tsSelectBackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsBullet;
        private System.Windows.Forms.ToolStripButton tsIdentPlus;
        private System.Windows.Forms.ToolStripButton tsIdentMinus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripComboBox tsFontSize;
        private System.Windows.Forms.ToolStripButton tsFontType;
        private System.Windows.Forms.ToolStripButton tsUndo;
        private System.Windows.Forms.ToolStripButton tsRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBold;
        private System.Windows.Forms.RichTextBox rtb;
    }
}
