using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCatCafe.CMN.ImageHelpers
{
    public static class ImageHelper
    {
        public static string UploadImage(string imageName)
        {

           


            string newImageName = "";

            string guidName = Guid.NewGuid().ToString();


            var fileArray = imageName.Split('.');

            var extension = fileArray[fileArray.Length - 1]; 

            if (extension == "png" || extension == "jpg" || extension == "bmp" || extension == "gif" || extension == "jpeg")
            {
                newImageName = guidName + "." + extension;
                return newImageName;
            }
            else
            {
                return "0";
            }


        }
    }
}
