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
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);

                FileInfo fileInfo = new FileInfo(open.FileName);
                org = new PictureBox();
                org.Image = pictureBox1.Image;
                // set image information for global variable
                imagePath = pictureBox1.Image;
                imageName = Path.GetFileName(open.FileName);
                imageExtension = Path.GetExtension(open.FileName);

                string width = pictureBox1.Image.Width.ToString();
                string height = pictureBox1.Image.Height.ToString();
                imageDimension = width + " x " + height;

                long tamanhoEmBytes = fileInfo.Length;
                int tamanhoEmKilobytes = (int)tamanhoEmBytes / 1024;
                imageSize = tamanhoEmKilobytes.ToString() + " KB";
                imageLocation = Path.GetFullPath(open.FileName);
                imageCreatedOn = fileInfo.CreationTime.ToString();

            }
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
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
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
        //Necess�rio corrigir reset da imagem quando zoom � realizado
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0 && pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(org.Image, new Size(trackBar1.Value, trackBar1.Value));
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
                        //setar essas informa��es pelo form (pos em X da imagem, pos Y da imagem,tamanho do crop altura, tamanho do crop largura)
                        Rectangle rect = new Rectangle(xCrop, yCrop, wCrop, hCrop);
                        pictureBox1.Image = CropImage(pictureBox1.Image, rect);
                        saveCropButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Valores informados n�o s�o acess�veis a imagem usada. Verifique se a pasi��o de corte e o tamanho n�o ultrapassam o tamanho da imagem");
                    }
                }
                else
                {
                    MessageBox.Show("Valores para corte n�o informados");
                }
            }
            else
            {
                MessageBox.Show("Imagem n�o foi aberta");
            }
        }
        //Op��o alternativa. Pode ser removido
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
        //Necess�rio corrigir soma de brilho. 
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

        //Necess�rio corrigir soma de contraste.
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
        //Desenho de sele��o para crop
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.Black, 1);
                cropPen.DashStyle = DashStyle.DashDotDot;
            }
            pictureBox1.Refresh();
        }
        //Desenho de sele��o para crop
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            if (e.Button == MouseButtons.Left)
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
            //PictureBoxLocation();
            //makeCropButton.Enabled = false;
        }
    }
}