using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class HistogramEqulize : Picture
    {
        Bitmap mypicture;
        double D0 = 0;
        int M = 256;
        bool first=true;
        int[] normalLUT = new int[256];
        double[] normalD = new double[256];
        public HistogramEqulize(Bitmap mypicture) : base(mypicture)
        {
            this.mypicture = mypicture;
            for (int i = 0; i < normalD.Length; i++)
            {
                normalD[i] = (double)this.histogram.SumToI(i) / this.histogram.Sum();
                if (first && (normalD[i] != 0))
                {
                    D0 = normalD[i];
                    first = false;
                }
            }
            for (int i = 0; i < normalLUT.Length; i++)
            {
                normalLUT[i] = (int)(((normalD[i] - D0) / (1 - D0)) * (M - 1));
            }
            for (int x = 0; x < this.width; ++x)
            {
                for (int y = 0; y < this.height; ++y)
                {
                    Color pixelColor = this.mypicture.GetPixel(x, y);
                    for (int i = 0; i < normalLUT.Length; i++)
                    {
                        Color oldColor = Color.FromArgb(i,i,i);
                        Color newColor = Color.FromArgb(normalLUT[i], normalLUT[i], normalLUT[i]);
                        if (pixelColor == oldColor)
                        {
                            this.mypicture.SetPixel(x, y, newColor);
                        }
                    }
                        
                }
            }
        }
    }
}
