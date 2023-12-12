//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Emgu.CV;
//using Emgu.CV.Structure;
//using Emgu.CV.CvEnum;
//using System.IO;
//using Emgu.CV.Util;
//using Emgu.CV.Features2D;
//using System.Windows.Shapes;
//using System.Windows.Media;
//using System.Threading;

//namespace NewPicEditApp
//{
//    public partial class PhotoTest : Form
//    {
//        Bitmap bitmap;
//        Image<Rgb, byte> image;
//        public PhotoTest(Bitmap bitmap)
//        {
//            InitializeComponent();
//            this.bitmap = bitmap;
//            pictureBox1.Image = bitmap;
//            Image<Rgb, byte> image1 = bitmap.ToImage<Rgb, byte>();

//            Mat fullMat = image1.Mat;
//            CvInvoke.Resize(fullMat, fullMat, new System.Drawing.Size(0, 0), .7d, .7d);
//            Mat templateOutput = new Mat();



//            string[] templates = Directory.GetFiles(@"..\..\Templates", "*.png");
//            string[] names = new string[templates.Length];
//            int sub = 12;

//            for (int t = 0; t < names.Length; ++t)
//            {
//                names[t] = templates[t];
//                names[t] = names[t].Substring(0, names[t].Length - 4);
//                names[t] = names[t].Substring(16);
//            }

//            Mat[] mats = new Mat[templates.Length];
//            int m = 0;
//            foreach (string picture in templates)
//            {
//                // create a new control
//                Mat mat = CvInvoke.Imread(picture);
//                CvInvoke.Resize(mat, mat, new System.Drawing.Size(0, 0), .7d, .7d);
//                mats[m++] = mat;
//            }

//            Image<Rgb, byte> fullMatImage = fullMat.ToImage<Rgb, byte>();
//            Image<Gray, byte> fullImage = fullMat.ToImage<Gray, byte>();
//            Image<Gray, byte> secondTurn = fullMat.ToImage<Gray, byte>();
//            //Image<Gray,byte> template = mats[2].ToImage<Gray, byte>();

//            //var vp = ProcessImage(template, fullImage);

//            foreach (Mat mat in mats)
//            {
//                Image<Gray, byte> fullImageCopy = fullImage.Clone();
//                Image<Gray, byte> secondTurnCopy = secondTurn.Clone();
//                Image<Gray, byte> template = mat.ToImage<Gray, byte>();

//                VectorOfPoint vp = ProcessImage(template, fullImageCopy);
//                if (vp != null)
//                {
//                    Image<Rgb, byte> fullImageResult = FullImageResult(vp, template, secondTurnCopy, fullMatImage);
//                    if (fullImageResult != null)
//                    {
//                        pictureBox1.Image = fullImageResult.ToBitmap();
//                        break;
//                    }
//                }

//            }

//            //if (vp != null)
//            //{
//            //    CvInvoke.Polylines(fullMatImage, vp, true, new MCvScalar(0, 0, 255), 5);
//            //    CvInvoke.FloodFill(secondTurn, template, vp, new MCvScalar(0, 0, 255), Bounds,)
//            //    Polyline polyline = new Polyline();
//            //    Point[] pointFromVector = vp.ToArray();
//            //    foreach (Point point in pointFromVector)
//            //    {
//            //        System.Windows.Point wp = new System.Windows.Point(point.X, point.Y);
//            //        //polyline.Points.Add(wp);
//            //    }
//            //    CvInvoke.FillPoly(secondTurn, vp, new MCvScalar(0, 0, 255));

//            //    var secondturnVP = ProcessImage(template, secondTurn);
//            //    if (secondturnVP != null)
//            //    {
//            //        CvInvoke.Polylines(fullMatImage, secondturnVP, true, new MCvScalar(0, 0, 255), 5);
//            //    }
//            //    polyline.Stroke = System.Windows.Media.Brushes.SlateGray;
//            //    polyline.StrokeThickness = 2;
//            //    polyline.FillRule = FillRule.EvenOdd;
//            //    secondTurn.
//            //}

//            //pictureBox1.Image = fullMatImage.ToBitmap();

//            //int index = 0;

//            //foreach (Mat mat in mats) //każdy pojedynczy template
//            //{

//            //    double minValue = 0.0d;
//            //    double maxValue = 0.0d;
//            //    System.Drawing.Point minLocation = new System.Drawing.Point();
//            //    System.Drawing.Point maxLocation = new System.Drawing.Point();
//            //    CvInvoke.MatchTemplate(fullMat, mat, templateOutput, TemplateMatchingType.CcoeffNormed);

//            //    //CvInvoke.Imshow("aaa",templateOutput);


//            //    // hashmap - klucz (liczba wystąpien), value (obraz) if obraz key = 2 obraz2 key 1

//            //    CvInvoke.MinMaxLoc(templateOutput, ref minValue, ref maxValue, ref minLocation, ref maxLocation);

//            //    System.Drawing.Point checkPoint = new System.Drawing.Point();

//            //    CvInvoke.Threshold(templateOutput, templateOutput, 0.05, 1, ThresholdType.ToZero);

//            //    //scale for()
//            //    //Console.WriteLine(minValue);
//            //    //Console.WriteLine(maxValue);
//            //    //Console.WriteLine(minLocation);
//            //    //Console.WriteLine(maxLocation);
//            //    //Console.WriteLine("dupa");

//            //    var matches = templateOutput.ToImage<Gray, byte>();

//            //    int counter = 0;
//            //    //bool branch = true;
//            //    //int Xloc1 = 0;
//            //    //int XlocMax = 0;
//            //    //int YlocMax = 0;
//            //    //int Yloc1 = 0;

//            //    //for (int i=0; i< matches.Rows; i++)
//            //    //{
//            //    //    for(int j=0; j<matches.Cols; j++)
//            //    //    {
//            //    //        if(matches[i,j].Intensity> .8) //wysortować te punkty
//            //    //        {
//            //    //            System.Drawing.Point loc = new System.Drawing.Point(j, i);
//            //    //            //if (branch)
//            //    //            //{
//            //    //            //    Xloc1 = loc.X;
//            //    //            //    XlocMax = loc.X + mat.Size.Width;
//            //    //            //    Yloc1=loc.Y;
//            //    //            //    YlocMax = loc.Y + mat.Size.Height;
//            //    //            //    branch = false;
//            //    //            //}
//            //    //            //if((loc.X - Xloc1) * (XlocMax - loc.X) >= 0 && (loc.Y - Yloc1) * (YlocMax - loc.Y) >= 0)
//            //    //            //{

//            //    //            //}
//            //    //            //else
//            //    //            //{
//            //    //            //    ++counter;

//            //    //            //    System.Drawing.Rectangle box = new System.Drawing.Rectangle(loc, mat.Size);

//            //    //            //    CvInvoke.Rectangle(fullMat, box, new Emgu.CV.Structure.MCvScalar(0, 255, 0), 2);
//            //    //            //}


//            //    //        }
//            //    //        //if(matches[i,j].Equals(maxValue))
//            //    //        //{
//            //    //        //    counter++;
//            //    //        //    System.Drawing.Point loc = new System.Drawing.Point(j, i);
//            //    //        //    System.Drawing.Rectangle box = new System.Drawing.Rectangle(loc, mat.Size);

//            //    //        //    CvInvoke.Rectangle(fullMat, box, new Emgu.CV.Structure.MCvScalar(0, 255, 0), 2);
//            //    //        //}
//            //    //        //if (matches[i, j].Equals(minValue))
//            //    //        //{
//            //    //        //    counter++;
//            //    //        //    System.Drawing.Point loc = new System.Drawing.Point(j, i);
//            //    //        //    System.Drawing.Rectangle box = new System.Drawing.Rectangle(loc, mat.Size);

//            //    //        //    CvInvoke.Rectangle(fullMat, box, new Emgu.CV.Structure.MCvScalar(0, 255, 0), 2);
//            //    //        //}
//            //    //    }
//            //    //}
//            //    ////Console.WriteLine(counter);
//            //    ////Console.WriteLine("dupa");

//            //    //PhotoTest test = new PhotoTest(fullMat.ToImage<Rgb, byte>());
//            //    //test.Show();
//            //    //CvInvoke.WaitKey();
//            //    //textBox1.Text = names[index] + " " + counter;
//            //    //Console.WriteLine(names[index] + " " + counter);
//            //    //++index;

//            //}

//        }
//        Image<Rgb, byte> FullImageResult(VectorOfPoint vp, Image<Gray, byte> template, Image<Gray, byte> secondTurn, Image<Rgb, byte> fullMatImage)
//        {
//            if (vp != null)
//            {
//                CvInvoke.Polylines(fullMatImage, vp, true, new MCvScalar(0, 0, 255), 5);

//                CvInvoke.FillPoly(secondTurn, vp, new MCvScalar(0, 0, 255));

//                VectorOfPoint secondturnVP = ProcessImage(template, secondTurn);
//                if (secondturnVP != null)
//                {
//                    CvInvoke.Polylines(fullMatImage, secondturnVP, true, new MCvScalar(0, 0, 255), 5);
//                    return fullMatImage;
//                }

//            }

//            return null;
//        }
//        private static VectorOfPoint ProcessImage(Image<Gray, byte> template, Image<Gray, byte> FullImage)
//        {
//            try
//            {
//                //initialization
//                VectorOfPoint finalPoints = null;
//                Mat homography = null;
//                VectorOfKeyPoint vectorOfKeyPoint = new VectorOfKeyPoint();
//                VectorOfKeyPoint sceneKeyPoint = new VectorOfKeyPoint();
//                Mat templateDescriptor = new Mat();
//                Mat sceneDescriptor = new Mat();

//                Mat mask;
//                int k = 2;
//                double uniquenessthreshold = 0.80;
//                VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch();

//                Brisk featureDetector = new Brisk();
//                featureDetector.DetectAndCompute(template, null, vectorOfKeyPoint, templateDescriptor, false);
//                featureDetector.DetectAndCompute(FullImage, null, sceneKeyPoint, sceneDescriptor, false);

//                //Matching
//                BFMatcher matcher = new BFMatcher(DistanceType.Hamming);
//                matcher.Add(templateDescriptor);
//                matcher.KnnMatch(sceneDescriptor, matches, k);

//                mask = new Mat(matches.Size, 1, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
//                mask.SetTo(new MCvScalar(255));

//                Features2DToolbox.VoteForUniqueness(matches, uniquenessthreshold, mask);
//                int count = Features2DToolbox.VoteForSizeAndOrientation(vectorOfKeyPoint, sceneKeyPoint, matches, mask, 1.5, 20);


//                if (count >= 4)
//                {
//                    homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures
//                        (
//                        vectorOfKeyPoint, sceneKeyPoint, matches, mask, 5
//                        );
//                }
//                if (homography != null)
//                {
//                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Point.Empty, template.Size);
//                    PointF[] pts = new PointF[]
//                    {
//                        new PointF(rect.Left,rect.Bottom),
//                        new PointF(rect.Right,rect.Bottom),
//                        new PointF(rect.Right,rect.Top),
//                        new PointF(rect.Left,rect.Top)
//                    };
//                    pts = CvInvoke.PerspectiveTransform(pts, homography);
//                    Point[] points = Array.ConvertAll<PointF, Point>(pts, Point.Round);
//                    finalPoints = new VectorOfPoint(points);

//                }


//                return finalPoints;
//            }
//            catch (Exception e)
//            {
//                throw new Exception(e.Message);
//            }
//        }

//        public PhotoTest(Image<Rgb, byte> image)
//        {
//            InitializeComponent();
//            this.image = image;
//            pictureBox1.Image = image.ToBitmap();
//        }

//        //void thing(Bitmap bitmap)
//        //{
//        //    int ksize = 5;
//        //    Image<Rgb, byte> ImgResult = bitmap.ToImage<Rgb, byte>();
//        //    Image<Rgb, byte> ImgOld = bitmap.ToImage<Rgb, byte>();
//        //    CvInvoke.Laplacian(ImgOld, ImgResult, DepthType.Default, ksize, 1, 0, BorderType.Default);
//        //    PhotoTest pTest = new PhotoTest(ImgResult);
//        //    pTest.Show();
//        //}
//        //void thing2(Bitmap bitmap)
//        //{
//        //    int threshhold1 = 100;
//        //    int threshhold2 = 100;
//        //    Image<Rgb, byte> ImgResult = bitmap.ToImage<Rgb, byte>();
//        //    Image<Rgb, byte> ImgOld = bitmap.ToImage<Rgb, byte>();
//        //    CvInvoke.Canny(ImgOld, ImgResult, threshhold1, threshhold2, 3, false);
//        //    PhotoTest pTest = new PhotoTest(ImgResult);
//        //    pTest.Show();
//        //}
//        //void thing3(Bitmap bitmap)
//        //{
//        //    Image<Rgb, byte> ImgResult = bitmap.ToImage<Rgb, byte>();
//        //    Image<Rgb, byte> ImgOld = bitmap.ToImage<Rgb, byte>();
//        //    CvInvoke.Sobel(ImgOld, ImgResult, DepthType.Default, 1,0,3,1,0, BorderType.Default);
//        //    PhotoTest pTest = new PhotoTest(ImgResult);
//        //    pTest.Show();
//        //}
//        //void thing()
//        //{

//        //}
//    }
//}
