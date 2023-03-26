using System.Security.Cryptography.X509Certificates;
using System.Drawing.Imaging;
using System.Text;
using System.Drawing.Drawing2D;

namespace IMAVD_IMAGE_Proj
{
    public partial class Form1 : Form
    {

        public static string imageName = "";
        public static string imageExtension = "";
        public static string imageDimension = "";
        public static string imageLocation = "";
        public static string imageSize = "";
        public static string imageCreatedOn = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

                // set image information for global variable
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

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties properties = new Properties();
            properties.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

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
    }
}