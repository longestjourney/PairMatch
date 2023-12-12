using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class Histogram
    {
        Bitmap picture = null;
        int min = 0;
        int max = 255;
        int[] RHistogram = new int[256];
        int[] GHistogram = new int[256];
        int[] BHistogram = new int[256];
        int[] AHistogram = new int[256];
        public bool Greyscale { get { return is_greyscale(); } }

        /*-------------------------------------------------------------------------------------
        publiczne elementy do wyciągnięcia:
        -------------------------------------------------------------------------------------*/
        public int[] R { get { return RHistogram; }}
        public int[] G { get { return GHistogram; }}
        public int[] B { get { return BHistogram; }}

        //public int[,] FHistogram { get { return FullHistogram; } private set { } }

        public Histogram(Bitmap picture)
        {
            //to ma być jakby tworzenie histogramu - co zgadza się z ideą konstruktora
            this.picture = picture;
            for (int x = 0; x < this.picture.Width; ++x)
            {
                for (int y = 0; y < this.picture.Height; ++y)
                {
                    Color pixelColor = this.picture.GetPixel(x, y);
                    RHistogram[Convert.ToInt32(pixelColor.R.ToString())] += 1;
                    GHistogram[Convert.ToInt32(pixelColor.G.ToString())] += 1;
                    BHistogram[Convert.ToInt32(pixelColor.B.ToString())] += 1;
                    AHistogram[Convert.ToInt32(pixelColor.A.ToString())] += 1;
                }
            }
            //if (picture != null) throw new PictureNotLoadedException("Nie ma obrazu");
        }

        //zapytanie czy ten obraz jest szaroodcieniowy
        private bool is_greyscale()
        {
            for (int i = 0; i < RHistogram.Length; ++i)
            {
                if ((RHistogram[i] != GHistogram[i]) || (GHistogram[i] != BHistogram[i])) return false;
            }
            return true;
        }
        
        public int Min()
        {
            if (is_greyscale())
            {
                for (int i = 0; i < RHistogram.Length; ++i)
                {
                    if (RHistogram[i] != 0) 
                    {
                        return min = i;
                    }
                }
            }
            return min;
        }
        public int Max() 
        {
            if (is_greyscale())
            {
                for (int i = RHistogram.Length-1; i >0 ; --i)
                {
                    if (RHistogram[i] != 0)
                    {
                        return max = i;
                    }
                }
            }
            return max;
        }
        public int Sum()
        {
            int sum = 0;
            if (is_greyscale())
            {
                for (int i = 0; i < RHistogram.Length; ++i)
                {
                    sum += RHistogram[i];
                }
            }
            return sum;
        }
        public int SumToI(int i)
        {
            int sum = 0;
            if (is_greyscale())
            {
                for (int j = 0; j < i; ++j)
                {
                    sum += RHistogram[j];
                }
            }
            return sum;
        }
    }
}
