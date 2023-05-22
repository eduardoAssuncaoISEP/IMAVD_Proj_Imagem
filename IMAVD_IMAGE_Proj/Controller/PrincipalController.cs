using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMAVD_IMAGE_Proj.Controller
{
    public class PrincipalController
    {
        private Principal view;
        public PrincipalController(Principal view)
        {
            this.view = view;
        }

        public void chooseImage()
        {
            view
        }

        private class ImageDetails
        {
            public static string imageName;
            public static string imageExtension;
            public static string imageDimension;
            public static string imageLocation;
            public static string imageSize;
            public static string imageCreatedOn;
            public static Image imagePath;
        }
    }
}
