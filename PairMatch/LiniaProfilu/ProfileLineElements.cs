using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class ProfileLineElements
    {
        int ax, ay, bx, by;
        int[] elementsX;
        int[] elementsY;
        List<int> XElements = new List<int>();
        List<int> YElements = new List<int>();
        int length, width, height;
        Bitmap bitmap;
        double a, b, c;
        public double A { get { return a; } }
        public double B { get { return b; } }
        public double C { get { return c; } }


        public ProfileLineElements(int ax, int ay, int bx, int by, Bitmap bitmap)
        {
            this.bitmap = bitmap;
            this.ax = ax;
            this.ay = ay;
            this.bx = bx;
            this.by = by;
            width = Math.Abs(bx - ax);
            height = Math.Abs(by - ay);

            a = (double)(by-ay);
            b = (double)(ax - bx);
            c = (a * ax) + (b * ay);
            //a /= (-b);
            //c /= (b);

        }
        //public int[] Elements
        //{

        //}
        public int LengthPrzekatnej()
        {
            length = (int)(Math.Sqrt(Math.Pow(width, 2) + Math.Pow(width, 2)));
            return length;
        }

        public int[] theElementsX()
        {

            //elementsX = new int[Math.Abs(bx-ax)];
            XElements.Clear();
            int i=0;
                for (double x = 0; x < bitmap.Width; ++x)
                {
                    for (double y = 0; y < bitmap.Height; ++y)
                    {
                    if (Math.Floor(a * x + b * y) == Math.Floor(c))
                        if (x <= (Math.Max(ax, bx)))
                        {
                            XElements.Add((int)x);
                            i++;
                        }
                    }

                }
            elementsX = new int[XElements.Count];
            for (int k = 0; k < elementsX.Length; k++)
            {
                elementsX[k] = XElements[k];
            }
            return elementsX;
        }

        public int[] theElementsY()
        {
            //elementsY = new int[Math.Abs(by-ay)];
            YElements.Clear();
            int i = 0;
            for (double x = 0; x < bitmap.Width; ++x)
            {
                for (double y = 0; y < bitmap.Height; ++y)
                {
                    if (Math.Floor(a * x + b * y) == Math.Floor(c))
                    {
                        if (y <= (Math.Max(ay, by)))
                        {
                            YElements.Add((int)y);
                            i++;
                        }
                    }
                }

            }
            elementsY = new int[YElements.Count];
            for(int k=0;k< elementsY.Length; k++)
            {
                elementsY[k]=YElements[k];
            }
            return elementsY;
        }

        //public String equation()
        //{
        //    //return String.Format("{a}*x+{b}*y={c}", a, b, c);
        //}
    }
}
