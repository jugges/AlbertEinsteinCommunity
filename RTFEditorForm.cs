using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlbertEinsteinCommunity
{
    public partial class RTFEditorForm : Form
    {
        public string rtf;
        public string threadName;
        public bool isEdited;
        private bool replyCreation;

        public RTFEditorForm(bool replyCreation)
        {
            InitializeComponent();
            this.replyCreation = replyCreation;
            if (replyCreation)
            {
                Controls.Remove(tableLayoutPanel2);
                tableLayoutPanel2.Dispose();
            }
        }

        private void ChangeFontStyle(bool fontBold, bool fontItalic, bool fontUnderline, bool fontStrikeout)
        {
            var fontStyle = 0;

            if (fontBold) fontStyle += (int)FontStyle.Bold;
            if (fontItalic) fontStyle += (int)FontStyle.Italic;
            if (fontUnderline) fontStyle += (int)FontStyle.Underline;
            if (fontStrikeout) fontStyle += (int)FontStyle.Strikeout;

            rtb.SelectionFont = new Font(rtb.SelectionFont, (FontStyle)fontStyle);
            Rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void ChangeFontTypeAndSize(FontFamily fontFamily, int fontSize)
        {
            try
            {
                var myFont = new Font(fontFamily, fontSize, rtb.SelectionFont.Style);
                rtb.SelectionFont = myFont;
                Rtb_SelectionChanged(rtb, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rtb_SelectionChanged(object sender, EventArgs e)
        {
            if (rtb.SelectionFont == null) return;
            tsBold.Checked = rtb.SelectionFont.Bold;
            tsItalic.Checked = rtb.SelectionFont.Italic;
            tsUnderline.Checked = rtb.SelectionFont.Underline;
            tsStrikeout.Checked = rtb.SelectionFont.Strikeout;

            tsFontType.Text = rtb.SelectionFont.Name;
            tsFontType.ToolTipText = rtb.SelectionFont.Name;
            var fontSize = Math.Round(rtb.SelectionFont.Size);
            tsFontSize.Text = fontSize.ToString();
        }

        private void tsUndo_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void TsRedo_Click(object sender, EventArgs e)
        {
            rtb.Redo();
        }

        private void TsBold_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(!rtb.SelectionFont.Bold, rtb.SelectionFont.Italic, rtb.SelectionFont.Underline,
                rtb.SelectionFont.Strikeout);
        }

        private void TsItalic_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(rtb.SelectionFont.Bold, !rtb.SelectionFont.Italic, rtb.SelectionFont.Underline,
                rtb.SelectionFont.Strikeout);
        }

        private void TsUnderline_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(rtb.SelectionFont.Bold, rtb.SelectionFont.Italic, !rtb.SelectionFont.Underline,
                rtb.SelectionFont.Strikeout);
        }

        private void TsStrikeout_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(rtb.SelectionFont.Bold, rtb.SelectionFont.Italic, rtb.SelectionFont.Underline,
                !rtb.SelectionFont.Strikeout);
        }

        private void TsLeft_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Left;
            Rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void TsCenter_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Center;
            Rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void TsRight_Click(object sender, EventArgs e)
        {
            rtb.SelectionAlignment = HorizontalAlignment.Right;
            Rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void TsFontColor_Click(object sender, EventArgs e)
        {
            rtb.SelectionColor = tsFontColor.BackColor;
        }

        private void TsBackgroundColor_Click(object sender, EventArgs e)
        {
            rtb.SelectionBackColor = tsBackgroundColor.BackColor;
        }

        private void TsSelectBackgroundColor_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.Color = rtb.SelectionBackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionBackColor = colorDlg.Color;
                Rtb_SelectionChanged(rtb, new EventArgs());
            }
        }

        private void TsBullet_Click(object sender, EventArgs e)
        {
            rtb.SelectionBullet = !rtb.SelectionBullet;
            Rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void TsIdentPlus_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionAlignment == HorizontalAlignment.Left) rtb.SelectionIndent += 36;
        }

        private void TsIdentMinus_Click(object sender, EventArgs e)
        {
            if (rtb.SelectionAlignment == HorizontalAlignment.Left && rtb.SelectionIndent >= 36)
                rtb.SelectionIndent -= 36;
        }

        private void TsFontSize_SelectedIndexChanged(object sender, EventArgs e) => ChangeFontTypeAndSize(rtb.SelectionFont.FontFamily, int.Parse(tsFontSize.SelectedItem.ToString()));

        private void TsFontSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ChangeFontTypeAndSize(rtb.SelectionFont.FontFamily, int.Parse(tsFontSize.Text));
        }

        private void TsFontSize_Leave(object sender, EventArgs e)
        {
            try
            {
                ChangeFontTypeAndSize(rtb.SelectionFont.FontFamily, int.Parse(tsFontSize.Text));
            }
            catch
            {
                // ignored
            }
        }

        private void TsFontType_Click(object sender, EventArgs e)
        {
            var fontDlg = new FontDialog();
            fontDlg.Font = rtb.SelectionFont;
            fontDlg.ShowColor = true;
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionFont = fontDlg.Font;
                rtb.SelectionColor = fontDlg.Color;

                Rtb_SelectionChanged(rtb, new EventArgs());
            }
        }

        private void TsSelectFontColor_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            colorDlg.Color = rtb.SelectionColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                rtb.SelectionColor = colorDlg.Color;
                Rtb_SelectionChanged(rtb, new EventArgs());
            }
        }

        private void TsSave_Click(object sender, EventArgs e)
        {
            if (rtb.Text != "" && (replyCreation || txtboxThreadName.Text != ""))
            {
                isEdited = true;
                rtf = rtb.Rtf;
                if (!replyCreation)
                    threadName = txtboxThreadName.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show(null, "There was an error, you have to fill the textboxes to save.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}