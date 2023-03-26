using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMAVD_IMAGE_Proj
{
    public partial class Properties : Form
    {
        public Properties()
        {
            InitializeComponent();
        }

        private void Properties_Load(object sender, EventArgs e)
        {
            image_name.Text = Form1.imageName;
            image_dimension.Text = Form1.imageDimension;
            image_extension.Text = Form1.imageExtension;
            image_location.Text = Form1.imageLocation;
            image_size.Text = Form1.imageSize;
            image_created.Text = Form1.imageCreatedOn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
