using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class HistogramStretch : Picture
    {
        Bitmap mypicture;
        int min = 0;
        int max = 255;
        public HistogramStretch(Bitmap mypicture) : base(mypicture)
        {
            if (this.Grayscale)
            {
                min = this.histogram.Min();
                max = this.histogram.Max();
                this.mypicture = mypicture;

                for (int x = 0; x < this.width; ++x)
                {
                    for (int y = 0; y < this.height; ++y)
                    {
                        Color pixelcolor = this.mypicture.GetPixel(x, y);
                        if (pixelcolor.R < min)
                        {
                            Color newcolor = Color.FromArgb(0, 0, 0);
                            this.mypicture.SetPixel(x, y, newcolor);
                        }
                        else if (pixelcolor.R > max)
                        {

                            Color newColor = Color.FromArgb(255, 255, 255);
                            this.mypicture.SetPixel(x, y, newColor);
                        }
                        else
                        {
                            Color newColor = Color.FromArgb(
                                Math.Abs((pixelcolor.R) - min) * ((255) / (max - min)),
                                Math.Abs((pixelcolor.G) - min) * ((255) / (max - min)),
                                Math.Abs((pixelcolor.B) - min) * ((255) / (max - min)));

                            this.mypicture.SetPixel(x, y, newColor);
                        }
                    }
                    //this.picboxCopyMap = EditMap;
                    //picbox.Image = this.picboxCopyMap;
                }
            }
        }
    }
}



