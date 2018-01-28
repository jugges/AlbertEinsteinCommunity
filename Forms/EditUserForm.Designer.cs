namespace AlbertEinsteinCommunity
{
    partial class EditUserForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLivingArea = new System.Windows.Forms.Label();
            this.comboboxSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtboxJob = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.datetimepickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblBiography = new System.Windows.Forms.Label();
            this.txtboxBiography = new System.Windows.Forms.TextBox();
            this.comboboxLivingArea = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::AlbertEinsteinCommunity.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSave.Location = new System.Drawing.Point(3, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(525, 62);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLivingArea
            // 
            this.lblLivingArea.AutoSize = true;
            this.lblLivingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLivingArea.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblLivingArea.Location = new System.Drawing.Point(3, 234);
            this.lblLivingArea.Name = "lblLivingArea";
            this.lblLivingArea.Size = new System.Drawing.Size(111, 46);
            this.lblLivingArea.TabIndex = 26;
            this.lblLivingArea.Text = "Living Area:";
            // 
            // comboboxSex
            // 
            this.comboboxSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboboxSex.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.comboboxSex.FormattingEnabled = true;
            this.comboboxSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboboxSex.Location = new System.Drawing.Point(120, 198);
            this.comboboxSex.Name = "comboboxSex";
            this.comboboxSex.Size = new System.Drawing.Size(402, 34);
            this.comboboxSex.TabIndex = 24;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSex.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblSex.Location = new System.Drawing.Point(3, 195);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(111, 39);
            this.lblSex.TabIndex = 23;
            this.lblSex.Text = "Sex:";
            // 
            // txtboxJob
            // 
            this.txtboxJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxJob.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtboxJob.Location = new System.Drawing.Point(120, 159);
            this.txtboxJob.Name = "txtboxJob";
            this.txtboxJob.Size = new System.Drawing.Size(402, 33);
            this.txtboxJob.TabIndex = 22;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJob.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblJob.Location = new System.Drawing.Point(3, 156);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(111, 39);
            this.lblJob.TabIndex = 21;
            this.lblJob.Text = "Job:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblLivingArea, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboboxSex, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSex, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtboxJob, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblJob, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtboxFirstName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.datetimepickerBirthDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtboxEmail, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBirthdate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBiography, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtboxBiography, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboboxLivingArea, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 280);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxFirstName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtboxFirstName.Location = new System.Drawing.Point(120, 81);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(402, 33);
            this.txtboxFirstName.TabIndex = 18;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblFirstName.Location = new System.Drawing.Point(3, 78);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(111, 39);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(3, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(111, 39);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email: ";
            // 
            // datetimepickerBirthDate
            // 
            this.datetimepickerBirthDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datetimepickerBirthDate.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.datetimepickerBirthDate.Location = new System.Drawing.Point(120, 42);
            this.datetimepickerBirthDate.Name = "datetimepickerBirthDate";
            this.datetimepickerBirthDate.Size = new System.Drawing.Size(402, 33);
            this.datetimepickerBirthDate.TabIndex = 14;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxEmail.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtboxEmail.Location = new System.Drawing.Point(120, 3);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(402, 33);
            this.txtboxEmail.TabIndex = 12;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBirthdate.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblBirthdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBirthdate.Location = new System.Drawing.Point(3, 39);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(111, 39);
            this.lblBirthdate.TabIndex = 11;
            this.lblBirthdate.Text = "Birth Date: ";
            // 
            // lblBiography
            // 
            this.lblBiography.AutoSize = true;
            this.lblBiography.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBiography.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lblBiography.Location = new System.Drawing.Point(3, 117);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(111, 39);
            this.lblBiography.TabIndex = 19;
            this.lblBiography.Text = "Biography:";
            // 
            // txtboxBiography
            // 
            this.txtboxBiography.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxBiography.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtboxBiography.Location = new System.Drawing.Point(120, 120);
            this.txtboxBiography.Name = "txtboxBiography";
            this.txtboxBiography.Size = new System.Drawing.Size(402, 33);
            this.txtboxBiography.TabIndex = 20;
            // 
            // comboboxLivingArea
            // 
            this.comboboxLivingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboboxLivingArea.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.comboboxLivingArea.FormattingEnabled = true;
            this.comboboxLivingArea.Items.AddRange(new object[] {
            "Hamerkaz",
            "Hasharon",
            "Hatzafon",
            "Hadarom",
            "Not Israel"});
            this.comboboxLivingArea.Location = new System.Drawing.Point(120, 237);
            this.comboboxLivingArea.Name = "comboboxLivingArea";
            this.comboboxLivingArea.Size = new System.Drawing.Size(402, 34);
            this.comboboxLivingArea.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(531, 354);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 354);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "EditUserForm";
            this.Text = "Edit Profile";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLivingArea;
        private System.Windows.Forms.ComboBox comboboxSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtboxJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker datetimepickerBirthDate;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblBiography;
        private System.Windows.Forms.TextBox txtboxBiography;
        private System.Windows.Forms.ComboBox comboboxLivingArea;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}