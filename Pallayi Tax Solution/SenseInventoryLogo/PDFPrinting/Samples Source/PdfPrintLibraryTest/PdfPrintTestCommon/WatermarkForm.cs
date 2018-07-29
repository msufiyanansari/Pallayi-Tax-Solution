using PdfPrintingNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace PdfPrintLibraryTest
{
    public partial class WatermarkForm : Form
    {
        public PdfWatermark Watermark { get; set; }
        public string PaperWidth {  get { return tbPaperWidth.Text; } }
        private string PaperHeight { get { return tbPaperHeight.Text; } }
        private string ImagePath { get { return tbImagePath.Text; } }

        public WatermarkForm(PdfWatermark watermark, string paperWidth, string paperHeight, string imagePath)
        {
            InitializeComponent();
            Watermark = watermark;              
            _selectedColor = watermark.TextColor;
            _selectedFont = watermark.TextFont;
            tbPaperHeight.Text = paperHeight;
            tbPaperWidth.Text = paperWidth;
            tbImagePath.Text = imagePath;
            tbOpacity.Text = watermark.Opacity.ToString();
        }

        private Font _selectedFont;
        private Color _selectedColor;

        private string GetFontDetails(Font font)
        {
            if (font == null)
                return "Not set";
            var fontDesc = font.Name + ", " + font.Size + " pt";
            if (font.Bold)
                fontDesc += ", bold";
            if (font.Italic)
                fontDesc += ", italic";
            if (font.Underline)
                fontDesc += ", underline";
            return fontDesc;
        }

        private string GetColorDetails(Color color)
        {
            if (color == null)
                return "Not set";
            var colorDesc = color.Name;
            return colorDesc;
        }

        private bool IsValidFloat(string val)
        {
            float result = 0;
            return float.TryParse(val, out result);
        }

        private float ParseFloat(string val)
        {
            return float.Parse(val, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo);
        }

        private PdfWatermark GetWatermark()
        {
            PdfWatermark watermark = new PdfWatermark();
            try
            {
                if (!string.IsNullOrEmpty(tbImagePath.Text))
                    watermark.Image = Image.FromFile(tbImagePath.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("{0} isn't valid image file.", tbImagePath.Text));
                return null;
            }

            watermark.Text = tbText.Text;
            if (IsValidFloat(tbRotationAngle.Text))
                watermark.RotationAngle = ParseFloat(tbRotationAngle.Text);
            else { 
                MessageBox.Show(string.Format("{0} isn't valid value for rotation angle.", tbRotationAngle.Text));
                return null;
            }

            if (IsValidFloat(tbX.Text))
                watermark.X = ParseFloat(tbX.Text);
            else
            {
                MessageBox.Show(string.Format("{0} isn't valid value for X.", tbX.Text));
                return null;
            }

            if (IsValidFloat(tbY.Text))
                watermark.Y = ParseFloat(tbY.Text);
            else { 
                MessageBox.Show(string.Format("{0} isn't valid value for Y.", tbY.Text));
                return null;
            }

            if (IsValidFloat(tbOpacity.Text))
            {
                float opacityValue = ParseFloat(tbOpacity.Text);
                if (opacityValue > 100 || opacityValue < 0)
                {
                    MessageBox.Show(string.Format("{0} isn't valid value for Opacity.", tbOpacity.Text));
                    return null;
                }
                watermark.Opacity = opacityValue;
            }
            else
            {
                MessageBox.Show(string.Format("{0} isn't valid value for Opacity.", tbOpacity.Text));
                return null;
            }
            watermark.TextFont = _selectedFont;
            watermark.TextColor = _selectedColor;
            watermark.UseRelativeCoordinates = cbUseRelativePercPosition.Checked;

            return watermark;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PdfWatermark watermark = GetWatermark();

            if (watermark == null)
                return;

            if (!watermark.IsSet)
            {
                MessageBox.Show("Nothing to preview. Define watermark text or image.");
                return;
            }

            float paperWidth = 0;
            float paperHeight = 0;

            if (IsValidFloat(tbPaperWidth.Text))
                paperWidth = ParseFloat(tbPaperWidth.Text);
            else
            {
                MessageBox.Show(string.Format("{0} isn't valid value for Paper width.", tbPaperWidth.Text));
                return;
            }

            if (IsValidFloat(tbPaperHeight.Text))
                paperHeight = ParseFloat(tbPaperHeight.Text);
            else
            {
                MessageBox.Show(string.Format("{0} isn't valid value for Paper height.", tbPaperHeight.Text));
                return;
            }

            if (IsValidFloat(tbOpacity.Text))
            {
                float opacityValue = ParseFloat(tbOpacity.Text);
                if (opacityValue > 100 || opacityValue < 0)
                {
                    MessageBox.Show(string.Format("{0} isn't valid value for Opacity.", tbOpacity.Text));
                    return;
                }
                watermark.Opacity = opacityValue;
            }
            else
            {
                MessageBox.Show(string.Format("{0} isn't valid value for Opacity.", tbOpacity.Text));
                return;
            }

            var previewForm = new PreviewWatermark(watermark, new SizeF(paperWidth, paperHeight));
            previewForm.ShowDialog();            
        }

        private void btnSetFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = _selectedFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedFont = fontDialog1.Font;                
            }
            lSelectedFont.Text = GetFontDetails(_selectedFont);
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = _selectedColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedColor = colorDialog1.Color;
            }
            lSelectedColor.Text = GetColorDetails(_selectedColor);
        }

        private void btnOpenWatermarkImage_Click(object sender, EventArgs e)
        {         
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbImagePath.Text = openFileDialog1.FileName;
            }
        }

        private void WatermarkForm_Load(object sender, EventArgs e)
        {
            lSelectedColor.Text = GetColorDetails(_selectedColor);
            lSelectedFont.Text = GetFontDetails(_selectedFont);
            tbRotationAngle.Text = Watermark.RotationAngle.ToString();
            cbUseRelativePercPosition.Checked = Watermark.UseRelativeCoordinates;
            tbX.Text = Watermark.X.ToString();
            tbY.Text = Watermark.Y.ToString();
            tbText.Text = Watermark.Text;
            tbOpacity.Text = Watermark.Opacity.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PdfWatermark watermark = GetWatermark();
            if (watermark != null)
            {
                if (!IsValidFloat(tbPaperWidth.Text))
                {
                    MessageBox.Show(string.Format("{0} isn't valid value for Paper width.", tbPaperWidth.Text));
                    return;
                }

                if (!IsValidFloat(tbPaperHeight.Text))
                {
                    MessageBox.Show(string.Format("{0} isn't valid value for Paper height.", tbPaperHeight.Text));
                    return;
                }
                                
                Watermark = watermark;
                DialogResult = DialogResult.OK;
                Close();                
            }
        }
    }
}
