using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    internal class PictureFactory

    {

        delegate Picture PictureMaker(Bitmap picture);
        private static readonly Dictionary<string, PictureMaker> map = new Dictionary<string, PictureMaker>
            {
                {"new", (picture)=> new Picture(picture)},
                {"invert", (picture)=> new PictureInvert(picture)},
                {"stretch",(picture)=> new HistogramStretch(picture)},
                {"equlize",(picture)=> new HistogramEqulize(picture)},
                //{"posterize" ,(picture,)=> new PicturePosterize(picture,)},
            };
        public static readonly string[] keys = map.Keys.OrderBy(s => s).ToArray();

        public static Picture make(string option, Bitmap picture)
        {
            return map[option](picture);
        }
    }
}
