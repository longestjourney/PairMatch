using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace NewPicEditApp
//{
//    internal class PictureToGreyscaleConverter : Picture
//    {
//        bool _isGreyscale;
//        delegate Picture PictureGreyscaleConverter(Bitmap picture);
//        public PictureToGreyscaleConverter(Bitmap mypicture) : base(mypicture)
//        {
//            if (!_isGreyscale)
//            {
//                private static readonly Dictionary<string, PictureGreyscaleConverter> map = new Dictionary<string, PictureGreyscaleConverter>
//                {
//                    {"R", (picture)=> },
//                    {"G", (picture)=>},
//                    {"B",(picture)=> },
//                };
//            } 
//         }
//             public static readonly string[] keys = map.Keys.OrderBy(s => s).ToArray();

//            public static Picture make(string option, Bitmap picture)
//            {
//                return map[option](picture);
//            } 
//        }

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

