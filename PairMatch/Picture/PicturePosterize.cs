using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class PicturePosterize : Picture
    {
        int[] histogramE = new int[256];
        int progi, level;
        public PicturePosterize(Bitmap bitmap, int progi) : base(bitmap)
        {
            this.progi = progi;

            if (progi < 256)
            {
                level = (int)Math.Round(255.0 / progi);

                
                for (int i = 0; i <= 255; i += level)
                {
                    int pp2 = i + level;
                    for (int j = 0; j < pp2 && j < 256; j++)
                    {
                        histogramE[j] = i;
                    }

                }
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);

                        Color newColor = Color.FromArgb(histogramE[pixelColor.R], histogramE[pixelColor.G], histogramE[pixelColor.B]);
                        bitmap.SetPixel(x, y, newColor);
                    }
                }
            }



            //for (int x = 0; x < mypicture.Width; ++x)
            //{
            //    for (int y = 0; y < mypicture.Height; ++y)
            //    {
            //        Color pixelColor = mypicture.GetPixel(x, y);
            //        Color newColor = Color.FromArgb(0xff - pixelColor.R
            //       , 0xff - pixelColor.G, 0xff - pixelColor.B);
            //        mypicture.SetPixel(x, y, newColor);

            //    }
            //}
            //progProperty = Convert.ToInt32(tbProp.Text);
            //if (progProperty < 256)
            //{
            //    progProperty = 255 / progProperty;
            //    int j = 0;
            //    for (int i = 0; i <= 255; i += progProperty)
            //    {
            //        int pp2 = i + progProperty;
            //        for (; j < pp2 && j < 256; j++)
            //        {
            //            postHistogram[j] = i;
            //        }

            //    }
            //}
        }
    }
}

//progProperty = Convert.ToInt32(tbProp.Text);
//if (progProperty < 256)
//{
//    progProperty = 255 / progProperty;
//    int j = 0;
//    for (int i = 0; i <= 255; i += progProperty)
//    {
//        for (; j <= i; j++)
//        {
//            postHistogram[j] = i;
//        }

//    }
//    for (int x = 0; x < bmp.Width; ++x)
//    {
//        for (int y = 0; y < bmp.Height; ++y)
//        {
//            Color pixelColor = bmp.GetPixel(x, y);

//            Color newColor = Color.FromArgb(postHistogram[pixelColor.R], postHistogram[pixelColor.G], postHistogram[pixelColor.B]);
//            bmp.SetPixel(x, y, newColor);


//        }
//    }
//}
//form.picbox.Image = this.bmp;
