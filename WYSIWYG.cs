using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbertEinsteinCommunity
{
    public partial class WYSIWYG : UserControl
    {
        public WYSIWYG()
        {
            InitializeComponent();
        }

        private void ChangeFontStyle(bool fontBold, bool fontItalic, bool fontUnderline, bool fontStrikeout)
        {
            int fontStyle = 0;

            if (fontBold) { fontStyle += (int)FontStyle.Bold; }
            if (fontItalic) { fontStyle += (int)FontStyle.Italic; }
            if (fontUnderline) { fontStyle += (int)FontStyle.Underline; }
            if (fontStrikeout) { fontStyle += (int)FontStyle.Strikeout; }

            rtb.SelectionFont = new Font(rtb.SelectionFont, (FontStyle)fontStyle);
            rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void ChangeFontTypeAndSize(FontFamily fontFamily, int fontSize)
        {
            try
            {
                Font myFont = new Font(fontFamily, fontSize, this.rtb.SelectionFont.Style);
                this.rtb.SelectionFont = myFont;
                rtb_SelectionChanged(rtb, new EventArgs());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            if (rtb.SelectionFont == null) return;
            tsBold.Checked = rtb.SelectionFont.Bold;
            tsItalic.Checked = rtb.SelectionFont.Italic;
            tsUnderline.Checked = rtb.SelectionFont.Underline;
            tsStrikeout.Checked = rtb.SelectionFont.Strikeout;

            tsFontType.Text = rtb.SelectionFont.Name;
            tsFontType.ToolTipText = rtb.SelectionFont.Name;
            double fontSize = Math.Round(rtb.SelectionFont.Size);
            tsFontSize.Text = fontSize.ToString();
        }

        private void tsUndo_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void tsRedo_Click(object sender, EventArgs e)
        {
            rtb.Redo();
        }

        private void tsBold_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(!this.rtb.SelectionFont.Bold, this.rtb.SelectionFont.Italic, this.rtb.SelectionFont.Underline, this.rtb.SelectionFont.Strikeout);
        }

        private void tsItalic_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(this.rtb.SelectionFont.Bold, !this.rtb.SelectionFont.Italic, this.rtb.SelectionFont.Underline, this.rtb.SelectionFont.Strikeout);
        }

        private void tsUnderline_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(this.rtb.SelectionFont.Bold, this.rtb.SelectionFont.Italic, !this.rtb.SelectionFont.Underline, this.rtb.SelectionFont.Strikeout);
        }

        private void tsStrikeout_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(this.rtb.SelectionFont.Bold, this.rtb.SelectionFont.Italic, this.rtb.SelectionFont.Underline, !this.rtb.SelectionFont.Strikeout);
        }

        private void tsLeft_Click(object sender, EventArgs e)
        {
            this.rtb.SelectionAlignment = HorizontalAlignment.Left;
            rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void tsCenter_Click(object sender, EventArgs e)
        {
            this.rtb.SelectionAlignment = HorizontalAlignment.Center;
            rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void tsRight_Click(object sender, EventArgs e)
        {
            this.rtb.SelectionAlignment = HorizontalAlignment.Right;
            rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void tsFontColor_Click(object sender, EventArgs e)
        {
            this.rtb.SelectionColor = this.tsFontColor.BackColor;
        }

        private void tsSelectFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.rtb.SelectionColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtb.SelectionColor = colorDlg.Color;
                rtb_SelectionChanged(rtb, new EventArgs());
            }
        }

        private void tsBackgroundColor_Click(object sender, EventArgs e)
        {
            this.rtb.SelectionBackColor = this.tsBackgroundColor.BackColor;
        }

        private void tsSelectBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = this.rtb.SelectionBackColor;
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtb.SelectionBackColor = colorDlg.Color;
                rtb_SelectionChanged(rtb, new EventArgs());
            }
        }

        private void tsBullet_Click(object sender, EventArgs e)
        {
            this.rtb.SelectionBullet = !this.rtb.SelectionBullet;
            rtb_SelectionChanged(rtb, new EventArgs());
        }

        private void tsIdentPlus_Click(object sender, EventArgs e)
        {
            if (this.rtb.SelectionAlignment == HorizontalAlignment.Left)
            {
                this.rtb.SelectionIndent += 36;
            }
        }

        private void tsIdentMinus_Click(object sender, EventArgs e)
        {
            if (this.rtb.SelectionAlignment == HorizontalAlignment.Left && this.rtb.SelectionIndent >= 36)
            {
                this.rtb.SelectionIndent -= 36;
            }
        }

        private void tsFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontTypeAndSize(rtb.SelectionFont.FontFamily, Int32.Parse(this.tsFontSize.SelectedItem.ToString()));
        }

        private void tsFontSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChangeFontTypeAndSize(this.rtb.SelectionFont.FontFamily, Int32.Parse(this.tsFontSize.Text));
            }
        }

        private void tsFontSize_Leave(object sender, EventArgs e)
        {
            try
            {
                ChangeFontTypeAndSize(this.rtb.SelectionFont.FontFamily, Int32.Parse(this.tsFontSize.Text));
            }
            catch
            {
                // ignored
            }
        }

        private void tsFontType_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.Font = this.rtb.SelectionFont;
            fontDlg.ShowColor = true;
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtb.SelectionFont = fontDlg.Font;
                this.rtb.SelectionColor = fontDlg.Color;

                rtb_SelectionChanged(rtb, new EventArgs());
            }
        }
    }
}
