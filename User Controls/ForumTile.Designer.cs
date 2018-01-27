namespace AlbertEinsteinCommunity
{
    partial class ForumTile
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
            this.forumBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forumBtn
            // 
            this.forumBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.forumBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forumBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forumBtn.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.forumBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.forumBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forumBtn.Location = new System.Drawing.Point(0, 0);
            this.forumBtn.Name = "forumBtn";
            this.forumBtn.Size = new System.Drawing.Size(149, 78);
            this.forumBtn.TabIndex = 0;
            this.forumBtn.UseVisualStyleBackColor = false;
            this.forumBtn.Click += new System.EventHandler(this.forumBtn_Click);
            // 
            // ForumTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.forumBtn);
            this.Name = "ForumTile";
            this.Size = new System.Drawing.Size(149, 78);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button forumBtn;
    }
}
