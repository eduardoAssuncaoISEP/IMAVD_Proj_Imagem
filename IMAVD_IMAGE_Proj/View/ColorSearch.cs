namespace IMAVD_IMAGE_Proj
{
    public partial class ColorSearch : Form
    {
        public ColorSearch()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ColorSearch_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Principal.imagePath;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Color actualColor = Color.White;
            try
            {
                // Clean previously selected color
                colorSelectName.Text = Color.White.ToString();
                selectColorPanel.BackColor = actualColor;

                //Showing color choice
                DialogResult IsColorChosen = colorDialog1.ShowDialog();

                if (IsColorChosen == DialogResult.OK)
                {
                    selectColorPanel.BackColor = colorDialog1.Color;
                    //colorSelectName.Text = colorDialog1.Color.;

                    //If it is know color, display the color name
                    if (colorSelectName.Text == Color.White.ToString())
                    {
                        colorSelectName.Text = ColorTranslator.ToHtml(colorDialog1.Color);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int countColor = 0;
            try
            {
                Boolean IsColorFound = false;
                if (pictureBox1.Image != null)
                {
                    //Converting loaded image into bitmap
                    Bitmap bmp = new Bitmap(pictureBox1.Image);

                    //Iterate whole bitmap to findout the picked color
                    for (int i = 0; i < pictureBox1.Image.Height; i++)
                    {
                        for (int j = 0; j < pictureBox1.Image.Width; j++)
                        {
                            countColor++;
                            //Get the color at each pixel
                            Color now_color = bmp.GetPixel(j, i);

                            //Compare Pixel's Color ARGB property with the picked color's ARGB property
                            if (now_color.ToArgb() == colorDialog1.Color.ToArgb())
                            {
                                countColor++;
                                IsColorFound = true;
                                MessageBox.Show("Color Found!");
                                getColorCountLabel.Text = Convert.ToString(countColor + " Pixels");
                                break;
                            }
                        }
                        if (IsColorFound == true)
                        {
                            break;
                        }
                    }
                    if (IsColorFound == false)
                    {
                        MessageBox.Show("Selected Color Not Found.");
                    }
                }
                else
                {
                    MessageBox.Show("Image is not loaded");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
