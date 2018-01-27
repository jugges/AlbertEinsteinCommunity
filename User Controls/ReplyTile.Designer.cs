namespace AlbertEinsteinCommunity
{
    partial class ReplyTile
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReplyDate = new System.Windows.Forms.Label();
            this.lblReplyMaker = new System.Windows.Forms.Label();
            this.picEdit = new System.Windows.Forms.PictureBox();
            this.richtextboxReplyContent = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.richtextboxReplyContent, 0, 1);
            this.tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(784, 220);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblReplyDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblReplyMaker, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picEdit, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 34);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblReplyDate
            // 
            this.lblReplyDate.AutoSize = true;
            this.lblReplyDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReplyDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplyDate.Location = new System.Drawing.Point(3, 0);
            this.lblReplyDate.Name = "lblReplyDate";
            this.lblReplyDate.Size = new System.Drawing.Size(98, 37);
            this.lblReplyDate.TabIndex = 2;
            this.lblReplyDate.Text = "REPLY DATE";
            this.lblReplyDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReplyMaker
            // 
            this.lblReplyMaker.AutoSize = true;
            this.lblReplyMaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReplyMaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReplyMaker.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblReplyMaker.Location = new System.Drawing.Point(145, 0);
            this.lblReplyMaker.Name = "lblReplyMaker";
            this.lblReplyMaker.Size = new System.Drawing.Size(630, 37);
            this.lblReplyMaker.TabIndex = 4;
            this.lblReplyMaker.Text = "REPLY MAKER";
            this.lblReplyMaker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblReplyMaker.Click += new System.EventHandler(this.lblReplyMaker_Click);
            // 
            // picEdit
            // 
            this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picEdit.Image = global::AlbertEinsteinCommunity.Properties.Resources.edit;
            this.picEdit.Location = new System.Drawing.Point(107, 3);
            this.picEdit.Name = "picEdit";
            this.picEdit.Size = new System.Drawing.Size(32, 31);
            this.picEdit.TabIndex = 5;
            this.picEdit.TabStop = false;
            this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
            // 
            // richtextboxReplyContent
            // 
            this.richtextboxReplyContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richtextboxReplyContent.Location = new System.Drawing.Point(3, 43);
            this.richtextboxReplyContent.Name = "richtextboxReplyContent";
            this.richtextboxReplyContent.ReadOnly = true;
            this.richtextboxReplyContent.Size = new System.Drawing.Size(778, 174);
            this.richtextboxReplyContent.TabIndex = 4;
            this.richtextboxReplyContent.Text = "";
            this.richtextboxReplyContent.WordWrap = false;
            this.richtextboxReplyContent.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richtextboxReplyContent_ContentsResized);
            this.richtextboxReplyContent.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richtextboxReplyContent_LinkClicked);
            // 
            // ReplyTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ReplyTile";
            this.Size = new System.Drawing.Size(784, 220);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblReplyDate;
        private System.Windows.Forms.RichTextBox richtextboxReplyContent;
        private System.Windows.Forms.Label lblReplyMaker;
        private System.Windows.Forms.PictureBox picEdit;
    }
}
