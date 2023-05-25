using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace IMAVD_IMAGE_Proj
{
    public partial class GetColor : Form
    {

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        public GetColor()
        {
            InitializeComponent();
        }

        private void GetColor_Load(object sender, EventArgs e)
        {
            getColorPictureBox.Image = Principal.imagePath;
        }

        //Function to get color from image
        public Color GetColorAt(Point location)
        {
            using (Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb))
            {
                using (Graphics gdest = Graphics.FromImage(screenPixel))
                {
                    using (Graphics gsrc = Graphics.FromHwnd(getColorPictureBox.Handle))
                    {
                        IntPtr hSrcDC = gsrc.GetHdc();
                        IntPtr hDC = gdest.GetHdc();
                        int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                        gdest.ReleaseHdc();
                        gsrc.ReleaseHdc();
                    }
                }

                return screenPixel.GetPixel(0, 0);
            }
        }

        //Get color with the moving mouse in the image
        //Fazer ativaçao após ter clicado na opção Get color na toolbar
        private void getColorImage_MouseMove(object sender, MouseEventArgs e)
        {

            getColorPanel.BackColor = GetColorAt(e.Location);

        }

        //Get color with a mouse click
        //Fazer ativaçao após ter clicado na opção Get color na toolbar
        private void getColorImage_MouseClick(object sender, MouseEventArgs e)
        {

            Color pixel = GetColorAt(e.Location);
            MessageBox.Show("Cor do pixel: " + pixel.ToString());
            getColorTextBox.Text = pixel.ToString();

        }

        private void getColorButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
