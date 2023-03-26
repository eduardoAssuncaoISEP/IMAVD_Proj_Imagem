using System.Security.Cryptography.X509Certificates;
using System.Drawing.Imaging;
using System.Text;

namespace IMAVD_IMAGE_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
                textBox1.Text = pictureBox1.Image.Height.ToString();
                textBox2.Text = pictureBox1.Image.Width.ToString();
                string size = pictureBox1.Image.Size.ToString();

                Test test = new Test();

                test.test();

                /*OpenFileDialog openFile = new OpenFileDialog();

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFile.FileName);

                }*/

            }
            
        }

        public void print()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("teste");
        }

    }
}