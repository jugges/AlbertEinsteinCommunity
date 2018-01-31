namespace AlbertEinsteinCommunity
{
    partial class ThreadTile
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
            this.lblThreadDate = new System.Windows.Forms.Label();
            this.lblThreadMaker = new System.Windows.Forms.Label();
            this.lblThreadName = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThreadDate
            // 
            this.lblThreadDate.AutoSize = true;
            this.lblThreadDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThreadDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreadDate.Location = new System.Drawing.Point(3, 45);
            this.lblThreadDate.Name = "lblThreadDate";
            this.lblThreadDate.Size = new System.Drawing.Size(141, 30);
            this.lblThreadDate.TabIndex = 2;
            this.lblThreadDate.Text = "THREAD DATE";
            // 
            // lblThreadMaker
            // 
            this.lblThreadMaker.AutoSize = true;
            this.lblThreadMaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThreadMaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThreadMaker.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblThreadMaker.Location = new System.Drawing.Point(150, 45);
            this.lblThreadMaker.Name = "lblThreadMaker";
            this.lblThreadMaker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblThreadMaker.Size = new System.Drawing.Size(633, 30);
            this.lblThreadMaker.TabIndex = 1;
            this.lblThreadMaker.Text = "THREAD MAKER";
            this.lblThreadMaker.Click += new System.EventHandler(this.lblThreadMaker_Click);
            // 
            // lblThreadName
            // 
            this.lblThreadName.AutoSize = true;
            this.lblThreadName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThreadName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThreadName.Font = new System.Drawing.Font("Calibri", 20.25F);
            this.lblThreadName.Location = new System.Drawing.Point(150, 0);
            this.lblThreadName.Name = "lblThreadName";
            this.lblThreadName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblThreadName.Size = new System.Drawing.Size(633, 45);
            this.lblThreadName.TabIndex = 0;
            this.lblThreadName.Text = "THREAD NAME";
            this.lblThreadName.Click += new System.EventHandler(this.lblThreadName_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.25F));
            this.tableLayoutPanel.Controls.Add(this.lblThreadName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblThreadMaker, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblThreadDate, 0, 1);
            this.tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(786, 75);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // ThreadTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ThreadTile";
            this.Size = new System.Drawing.Size(786, 75);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThreadDate;
        private System.Windows.Forms.Label lblThreadMaker;
        private System.Windows.Forms.Label lblThreadName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}
