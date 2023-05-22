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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Properties_Load(object sender, EventArgs e)
        {
            image_name.Text = Principal.imageName;
            image_dimension.Text = Principal.imageDimension;
            image_extension.Text = Principal.imageExtension;
            image_location.Text = Principal.imageLocation;
            image_size.Text = Principal.imageSize;
            image_created.Text = Principal.imageCreatedOn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
