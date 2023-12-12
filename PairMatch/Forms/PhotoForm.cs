using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;


namespace NewPicEditApp
{
    public partial class PhotoForm : Form
    {
        Bitmap bitmap;

        string[] templates = Directory.GetFiles(@"..\..\Templates", "*.png");

        public PhotoForm(Bitmap bitmap)
        {
            InitializeComponent();

            this.bitmap = bitmap;
            pbMyphoto.Image = bitmap;
            Image<Rgb, byte> image1 = bitmap.ToImage<Rgb, byte>();

            Mat fullMat = image1.Mat;
            CvInvoke.Resize(fullMat, fullMat, new System.Drawing.Size(0, 0), .7d, .7d);
            Mat templateOutput = new Mat();

            string[] names = new string[templates.Length];
            names = GetNames(names);


        }
        

        string[] GetNames(string[] names)
        {
            for (int t = 0; t < names.Length; ++t)
            {
                names[t] = templates[t];
                names[t] = names[t].Substring(0, names[t].Length - 4);
                names[t] = names[t].Substring(16);
            }
            return names;
        }
        //Mat GetMats()
        //{

        //}
    }
}
