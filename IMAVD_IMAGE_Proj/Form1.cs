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
                imageDimension = pictureBox1.Image.Size.ToString();
                
                long tamanhoEmBytes = fileInfo.Length;
                double tamanhoEmKilobytes = (double)tamanhoEmBytes / 1024;
                imageSize = tamanhoEmBytes.ToString();
                
                imageLocation = Path.GetFullPath(open.FileName);

                imageCreatedOn = fileInfo.CreationTime.ToString();
                //double size = Math.Round(((double)open.Conted))

                
                //imageCreatedOn = pictureBox1.Image.GetPropertyItem(36867);



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
    }
}