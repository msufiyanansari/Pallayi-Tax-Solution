using PdfPrintingNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace PdfPrintLibraryTest
{
    public partial class PreviewWatermark : Form
    {
        private PdfWatermark _pdfWatermark;
        private SizeF _paperSize;

        public PreviewWatermark(PdfWatermark pdfWatermark, SizeF paperSize)
        {
            InitializeComponent();
            _pdfWatermark = pdfWatermark;
            _paperSize = paperSize;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
        private float _previewRatio = 1;

        private static Image SetImageOpacity(Image image, float opacity)
        {
            try
            {
                //TODO Sto ako je jpgeg? Ako je BW? Ako je 16 bit?
                //create a Bitmap the size of the image provided  
                Bitmap bmp = new Bitmap(image.Width, image.Height);
                bmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
                //create a graphics object from the image  
                using (Graphics gfx = Graphics.FromImage(bmp))
                {

                    //create a color matrix object  
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity  
                    matrix.Matrix33 = opacity / 100;

                    //create image attributes  
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image  
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image  
                    gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
                }
                return bmp;
            }
            catch (Exception ex)
            {                
                return null;
            }
        }

        private void pbPreview_Paint(object sender, PaintEventArgs e)
        {            
            float x = _pdfWatermark.X * _previewRatio;
            float y = _pdfWatermark.Y * _previewRatio;
            int paperWidth = pbPreview.Width;
            int paperHeight = pbPreview.Height;

            if (_pdfWatermark.UseRelativeCoordinates)
            {
                x = paperWidth * (_pdfWatermark.X / 100);
                y = paperHeight * (_pdfWatermark.Y / 100);
            }         

            PointF watermarkPosition = _pdfWatermark.RotationAngle != 0 ? new PointF(0, 0) : new PointF(x, y);

            if (_pdfWatermark.RotationAngle != 0)
            {
                e.Graphics.TranslateTransform(x, y);
                e.Graphics.RotateTransform(_pdfWatermark.RotationAngle);
            }

            if (_pdfWatermark.Image != null)
            {
                Image img = _pdfWatermark.Opacity < 100 ? SetImageOpacity(_pdfWatermark.Image, _pdfWatermark.Opacity) : _pdfWatermark.Image;
                if (_previewRatio != 1)
                {
                    int newWidth = (int)(img.Width * _previewRatio);
                    int newHeight = (int)(img.Height * _previewRatio);
                    Bitmap resizedImage = new Bitmap(img, new Size(newWidth, newHeight));
                    e.Graphics.DrawImage(resizedImage, watermarkPosition);
                    resizedImage.Dispose();
                } else
                    e.Graphics.DrawImage(img, watermarkPosition);
                if (_pdfWatermark.Opacity < 100)
                    img.Dispose();
            }
            
            if (!string.IsNullOrEmpty(_pdfWatermark.Text))
            {
                SolidBrush brush = null;                
                if (_pdfWatermark.Opacity < 100)
                    brush = new SolidBrush(Color.FromArgb((int)(_pdfWatermark.Opacity / 100 * 255), _pdfWatermark.TextColor));
                else
                    brush = new SolidBrush(_pdfWatermark.TextColor);

                Font f = _pdfWatermark.TextFont;
                Font f1 = new Font(f.FontFamily, f.Size * _previewRatio, f.Style, GraphicsUnit.Point, f.GdiCharSet, f.GdiVerticalFont);
                e.Graphics.DrawString(
                _pdfWatermark.Text,
                f1,
                brush,
                watermarkPosition);

                brush.Dispose();
            }
            e.Graphics.ResetTransform();
        }

        private void PreviewWatermark_Load(object sender, EventArgs e)
        {
            int maxHeight = Screen.PrimaryScreen.Bounds.Height - 60;
            int maxWidth = Screen.PrimaryScreen.Bounds.Width - 60;
            float paperHeight = _paperSize.Height * 72;
            float paperWidth = _paperSize.Width * 72;
            int pbWidth = (int) paperWidth;
            int pbHeight = (int) paperHeight;

            if ((paperWidth > maxWidth) || (paperHeight > maxHeight))
            {
                pbWidth = maxWidth;
                pbHeight = (int)((maxWidth / paperWidth) * paperHeight);
                _previewRatio = maxWidth / paperWidth;
            }            

            pbPreview.Size = new Size(pbWidth, pbHeight);
            Size = new Size(pbWidth + 60, pbHeight + 80);

            Text = string.Format("Watermark preview for paper size {0}\" X {1}\" at {2}%", _paperSize.Width, _paperSize.Height, _previewRatio * 100);
            Location = new Point((maxWidth - Width) / 2, 5);
        }
    }
}
