using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class Picture
    {
        private Bitmap bitmap;
        public int width { get; private set; }
        public int height { get; private set; }
        public Histogram histogram { get; private set; }
        public bool Grayscale { get { return histogram.Greyscale; } private set { } }

        public Picture(Bitmap bitmap)
        {
            this.bitmap = bitmap;
            width = bitmap.Width; //jest to chyba dość wtórne ale skraca zapis wewnątrz tej klasy
            height = bitmap.Height;
            makeHistogram();
        }

        //moze to byc void i po prostu przypisanie do powyższej zmiennej, bo wtedy ten histogram bylby przypisany do obiektu
        public void makeHistogram()
        {
            histogram = new Histogram(bitmap);
        }

        public Bitmap toBitmap()
        {
            return bitmap;
        }

        public Bitmap toGrayScaleR()
        {
            if (!Grayscale)
            {
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);
                        Color newColor = Color.FromArgb(
                            pixelColor.R,
                            pixelColor.R,
                            pixelColor.R);
                        bitmap.SetPixel(x, y, newColor);

                    }
                }
            }
            return bitmap;
        }
        public Bitmap toGrayScaleG()
        {
            if (!Grayscale)
            {
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);
                        Color newColor = Color.FromArgb(
                            pixelColor.G,
                            pixelColor.G,
                            pixelColor.G);
                        bitmap.SetPixel(x, y, newColor);

                    }
                }
            }
            return bitmap;
        }
        public Bitmap toGrayScaleB()
        {
            if (!Grayscale)
            {
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);
                        Color newColor = Color.FromArgb(
                            pixelColor.B,
                            pixelColor.B,
                            pixelColor.B);
                        bitmap.SetPixel(x, y, newColor);

                    }
                }
            }
            return bitmap;
        }
        public Bitmap toGrayScaleMid()
        {
            if (!Grayscale)
            {
                for (int x = 0; x < bitmap.Width; ++x)
                {
                    for (int y = 0; y < bitmap.Height; ++y)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);
                        Color newColor = Color.FromArgb(
                            (pixelColor.R+ pixelColor.G+pixelColor.B)/3,
                            (pixelColor.R + pixelColor.G + pixelColor.B) / 3,
                            (pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                        bitmap.SetPixel(x, y, newColor);

                    }
                }
            }
            return bitmap;
        }
    }
}
