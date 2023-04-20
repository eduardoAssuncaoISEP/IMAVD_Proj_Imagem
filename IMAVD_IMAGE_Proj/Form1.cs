using System.Security.Cryptography.X509Certificates;
using System.Drawing.Imaging;
using System.Text;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IMAVD_IMAGE_Proj
{
    public partial class Form1 : Form
    {
        private Image Img;
        private Size OriginalImageSize;
        private Size ModifiedImageSize;

        //get the image niformation
        public static string imageName = "";
        public static string imageExtension = "";
        public static string imageDimension = "";
        public static string imageLocation = "";
        public static string imageSize = "";
        public static string imageCreatedOn = "";
        public static Image imagePath = null;

        //Crop information
        private int cropX, cropY, cropWidth, cropHeight, oCropX, oCropY;
        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;

        public Form1()
        {
            InitializeComponent();
        }

        PictureBox org;

        private void Form1_Load(object sender, EventArgs e)
        {

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            this.DoubleBuffered = true; //minimazes the strutter

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void print()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "";
            Dlg.Title = "Select image";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                makeSelectionButton.Enabled = true;
                Img = Image.FromFile(Dlg.FileName);
                LoadImage();

                FileInfo fileInfo = new FileInfo(Dlg.FileName);
                org = new PictureBox();
                org.Image = pictureBox1.Image;
                // set image information for global variable
                imagePath = pictureBox1.Image;
                imageName = Path.GetFileName(Dlg.FileName);
                imageExtension = Path.GetExtension(Dlg.FileName);

                string width = pictureBox1.Image.Width.ToString();
                string height = pictureBox1.Image.Height.ToString();
                imageDimension = width + " x " + height;

                long tamanhoEmBytes = fileInfo.Length;
                int tamanhoEmKilobytes = (int)tamanhoEmBytes / 1024;
                imageSize = tamanhoEmKilobytes.ToString() + " KB";
                imageLocation = Path.GetFullPath(Dlg.FileName);
                imageCreatedOn = fileInfo.CreationTime.ToString();
            }

            //----------------------------------------------------------//
        }

        private void LoadImage()
        {
            int imgWidth = Img.Width;
            int imgHeight = Img.Height;
            pictureBox1.Width = imgWidth;
            pictureBox1.Height = imgHeight;
            pictureBox1.Image = Img;
            PictureBoxLocation();
            OriginalImageSize = new Size(imgWidth, imgHeight);
            //SetResizeInfo();
        }

        private void PictureBoxLocation()
        {
            int _x = 0;
            int _y = 0;
            if (panelPictureBox1.Width > pictureBox1.Width)
            {
                _x = (panelPictureBox1.Width - pictureBox1.Width) / 2;
            }
            if (panelPictureBox1.Height > pictureBox1.Height)
            {
                _y = (panelPictureBox1.Height - pictureBox1.Height) / 2;
            }
            pictureBox1.Location = new Point(_x, _y);
        }

        private void inforToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Call the properties Form
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties properties = new Properties();
            properties.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Convert color to red
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                int width = pictureBox1.Image.Width;
                int height = pictureBox1.Image.Height;

                //Bitmap red = new Bitmap(img);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        img.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                    }
                }

                pictureBox2.Image = img;
            }
        }

        //Convert color to green
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                int width = pictureBox1.Image.Width;
                int height = pictureBox1.Image.Height;

                //Bitmap red = new Bitmap(img);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        img.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    }
                }

                pictureBox2.Image = img;
            }
        }

        //Convert color to blue
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                int width = pictureBox1.Image.Width;
                int height = pictureBox1.Image.Height;

                //Bitmap red = new Bitmap(img);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        img.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                    }
                }

                pictureBox2.Image = img;
            }
        }

        //invert color 
        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //verificando se a imagem foi aberta
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(pictureBox1.Image);
                int width = pictureBox1.Image.Width;
                int height = pictureBox1.Image.Height;

                //Bitmap red = new Bitmap(img);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img.GetPixel(x, y);

                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        r = 255 - r;
                        g = 255 - g;
                        b = 255 - b;

                        img.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }

                pictureBox2.Image = img;
            }
        }

        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, Convert.ToInt32(img.Width * size.Width),
                Convert.ToInt32(img.Height * size.Height));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void findColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorSearch colorSearch = new ColorSearch();
            colorSearch.Show();
        }

        private void getColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetColor getColor = new GetColor();
            getColor.Show();
        }
        //Necessário corrigir reset da imagem quando zoom é realizado
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0 && pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(Img, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (xPositionCrop.Text.Length > 0 && yPositionCrop.Text.Length > 0 && widthCrop.Text.Length > 0 && heightCrop.Text.Length > 0)
                {
                    int xCrop = Convert.ToInt32(xPositionCrop.Text);
                    int yCrop = Convert.ToInt32(yPositionCrop.Text);
                    int wCrop = Convert.ToInt32(widthCrop.Text);
                    int hCrop = Convert.ToInt32(heightCrop.Text);

                    if (pictureBox1.Image.Width > xCrop && pictureBox1.Image.Height > yCrop && pictureBox1.Image.Width > wCrop && pictureBox1.Image.Height > hCrop)
                    {
                        //setar essas informações pelo form (pos em X da imagem, pos Y da imagem,tamanho do crop altura, tamanho do crop largura)
                        Rectangle rect = new Rectangle(xCrop, yCrop, wCrop, hCrop);
                        pictureBox1.Image = CropImage(pictureBox1.Image, rect);
                        saveCropButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Valores informados não são acessíveis a imagem usada. Verifique se a pasição de corte e o tamanho não ultrapassam o tamanho da imagem");
                    }
                }
                else
                {
                    MessageBox.Show("Valores para corte não informados");
                }
            }
            else
            {
                MessageBox.Show("Imagem não foi aberta");
            }
        }
        //Opção alternativa. Pode ser removido
        private static Image CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        private void saveCropButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
                saveCropButton.Enabled = false;

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Arquivos PNG (*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(dialog.FileName, ImageFormat.Png);
            }
        }
        //Necessário corrigir soma de brilho. 
        public static Bitmap AdjustBrightness(Bitmap image, float brightnessAdjustment)
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int r = Clamp((int)(pixelColor.R + brightnessAdjustment), 0, 255);
                    int g = Clamp((int)(pixelColor.G + brightnessAdjustment), 0, 255);
                    int b = Clamp((int)(pixelColor.B + brightnessAdjustment), 0, 255);

                    adjustedImage.SetPixel(x, y, Color.FromArgb(pixelColor.A, r, g, b));
                }
            }

            return adjustedImage;
        }

        //Necessário corrigir soma de contraste.
        public static Bitmap AdjustContrast(Bitmap image, float contrastLevel)
        {
            Bitmap adjustedImage = new Bitmap(image.Width, image.Height);
            contrastLevel = (100.0f + contrastLevel) / 100.0f;
            contrastLevel *= contrastLevel;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    float r = pixelColor.R / 255.0f;
                    float g = pixelColor.G / 255.0f;
                    float b = pixelColor.B / 255.0f;
                    r = (((r - 0.5f) * contrastLevel) + 0.5f) * 255.0f;
                    g = (((g - 0.5f) * contrastLevel) + 0.5f) * 255.0f;
                    b = (((b - 0.5f) * contrastLevel) + 0.5f) * 255.0f;

                    adjustedImage.SetPixel(x, y, Color.FromArgb(pixelColor.A, Clamp((int)r, 0, 255), Clamp((int)g, 0, 255), Clamp((int)b, 0, 255)));
                }
            }

            return adjustedImage;
        }

        private static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private void changeGlowButton_Click(object sender, EventArgs e)
        {
            int brightnessAdjustment = Convert.ToInt32(changeGlowTextBox.Text);

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = AdjustBrightness(originalImage, brightnessAdjustment);

        }

        private void changeContrastButton_Click(object sender, EventArgs e)
        {
            int contrastAdjustment = Convert.ToInt32(changeContrastTextBox.Text);

            Bitmap originalImage = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = AdjustContrast(originalImage, contrastAdjustment);
        }

        private void makeSelectionButton_Click(object sender, EventArgs e)
        {
            makeSelectionButton.Enabled = false;
        }

        //Desenho de seleção para crop
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && makeSelectionButton.Enabled == false)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.Black, 1);
                cropPen.DashStyle = DashStyle.DashDotDot;
            }
            pictureBox1.Refresh();
        }
        //Desenho de seleção para crop
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            if (e.Button == MouseButtons.Left && makeSelectionButton.Enabled == false)
            {
                pictureBox1.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                pictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
            }
        }

        private void makeCropButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (cropWidth < 1)
                return;

            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);

            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);

            Bitmap _img = new Bitmap(cropWidth, cropHeight);

            Graphics g = Graphics.FromImage(_img);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            pictureBox1.Image = _img;
            pictureBox1.Width = _img.Width;
            pictureBox1.Height = _img.Height;
            PictureBoxLocation();
            //makeCropButton.Enabled = false;
        }

        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }

        private void rotateHorizontalButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }

        private void rotateVerticalButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }

        /// <summary>
        /// Resize Image
        /// </summary>
        private void BindDomainIUpDown()
        {
            for (int i = 1; i <= 999; i++)
            {
                resizeDomainUpDown.Items.Add(i);
            }
            resizeDomainUpDown.Text = "100";
        }
        private void resizeDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            int percentage = 0;
            try
            {
                percentage = Convert.ToInt32(resizeDomainUpDown.Text);
                ModifiedImageSize = new Size((OriginalImageSize.Width * percentage) / 100, (OriginalImageSize.Height * percentage) / 100);
                //SetResizeInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Percentage");
                return;
            }
        }
        private void okResizeButton_Click(object sender, EventArgs e)
        {
            Bitmap bm_source = new Bitmap(pictureBox1.Image);
            // Make a bitmap for the result.  
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(ModifiedImageSize.Width), Convert.ToInt32(ModifiedImageSize.Height));
            // Make a Graphics object for the result Bitmap.  
            Graphics gr_dest = Graphics.FromImage(bm_dest);
            // Copy the source image into the destination bitmap.  
            gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
            // Display the result.  
            pictureBox1.Image = bm_dest;
            pictureBox1.Width = bm_dest.Width;
            pictureBox1.Height = bm_dest.Height;
            PictureBoxLocation();
        }

        /// <summary>
        /// Brightness
        /// </summary>
        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            brightnessDomainUpDown.Text = brightnessTrackBar.Value.ToString();
            float value = brightnessTrackBar.Value * 0.01f;

            float[][] colorMatrixElements = {
                  new float[] {
                        1, 0, 0, 0, 0
                  },
                  new float[] {
                        0, 1, 0, 0, 0
                  },
                  new float[] {
                        0, 0, 1, 0, 0
                  },
                  new float[] {
                        0, 0, 0, 1, 0
                  },
                  new float[] {
                        value, value, value, 0, 1
                  }
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pictureBox1.Image = bm_dest;
        }

        /// <summary>
        /// Constrast
        /// </summary>
        private void constrastTrackBar_Scroll(object sender, EventArgs e)
        {
            /*brightnessDomainUpDown.Text = brightnessTrackBar.Value.ToString();
            float value = constrastTrackBar.Value * 0.01f;

            float[][] colorMatrixElements = {
                  new float[] {
                        0, 0, 0, 0, 0
                  },
                  new float[] {
                        0, 0, 0, 0, 0
                  },
                  new float[] {
                        0, 0, 0, 0, 0
                  },
                  new float[] {
                        0, 0, 0, 1, 0
                  },
                  new float[] {
                        value, value, value, 0, 1
                  }
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image _img = Img;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            pictureBox1.Image = bm_dest;*/
        }
    }
}