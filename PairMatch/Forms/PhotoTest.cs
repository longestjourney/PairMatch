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
using Emgu.CV.Util;
using Emgu.CV.Features2D;
using System.Windows.Shapes;
using System.Windows.Media;

namespace NewPicEditApp
{
    public partial class PhotoTest : Form
    {
        Bitmap bitmap;
        Image<Rgb,byte> image;
        public PhotoTest(Bitmap bitmap)
        {
            InitializeComponent();
            this.bitmap = bitmap;
            pictureBox1.Image = bitmap;
            Image<Rgb, byte> image1 = bitmap.ToImage<Rgb, byte>();

            Mat fullMat = image1.Mat;
            CvInvoke.Resize(fullMat, fullMat, new System.Drawing.Size(0, 0), .7d, .7d);
            Mat templateOutput = new Mat();



            string[] templates = Directory.GetFiles(@"..\..\Templates", "*.png");
            string[] names = new string[templates.Length];
            int sub = 12;

            for(int t = 0; t < names.Length; ++t)
            {
                names[t] = templates[t];
                names[t]=names[t].Substring(0, names[t].Length - 4);
                names[t] = names[t].Substring(16);
            }

            Mat[] mats = new Mat[templates.Length];
            int m = 0;
            foreach (string picture in templates)
            {
                // create a new control
                Mat mat = CvInvoke.Imread(picture);
                CvInvoke.Resize(mat, mat, new System.Drawing.Size(0, 0), .7d, .7d);
                mats[m++] = mat;
            }

            bool pairNotFound = true;

            for(int c = 0; c < mats.Length; ++c)
            {
                Image<Rgb, byte> fullMatImage = fullMat.ToImage<Rgb, byte>();
                Image<Gray, byte> fullImage = fullMat.ToImage<Gray, byte>();
                Image<Gray, byte> secondTurn = fullMat.ToImage<Gray, byte>();
                Image<Gray, byte> template = mats[c].ToImage<Gray, byte>();
                var vp = ProcessImage(template, fullImage);




                if (vp != null)
                {
                    int[,] pointsINT = VectorOfPointTOint2DArray(vp);
                    if (isConvex(pointsINT))
                    {
                        CvInvoke.Polylines(fullMatImage, vp, true, new MCvScalar(0, 0, 255), 5);

                        //CvInvoke.FloodFill(secondTurn,template,vp, new MCvScalar(0,0,255), Bounds,)
                        //Polyline polyline = new Polyline();
                        //Point[] pointFromVector = vp.ToArray();
                        //foreach(Point point in pointFromVector)
                        //{
                        //    System.Windows.Point wp = new System.Windows.Point(point.X,point.Y);
                        //    //polyline.Points.Add(wp);
                        //}
                        CvInvoke.FillPoly(secondTurn, vp, new MCvScalar(0, 0, 255));

                        var secondturnVP = ProcessImage(template, secondTurn);


                        if (secondturnVP != null)
                        {
                            int[,] pointsINTST = VectorOfPointTOint2DArray(secondturnVP);

                            if (isConvex(pointsINTST))
                            {
                                CvInvoke.Polylines(fullMatImage, secondturnVP, true, new MCvScalar(0, 0, 255), 5);
                                pictureBox1.Image = fullMatImage.ToBitmap();
                                c = mats.Length;
                                pairNotFound = false;
                            }
                        }
                    }
                    //polyline.Stroke = System.Windows.Media.Brushes.SlateGray;
                    //polyline.StrokeThickness = 2;
                    //polyline.FillRule = FillRule.EvenOdd;
                    //secondTurn.
                }

            }

            if (pairNotFound)
            {
                Image<Rgb, byte> fMat = fullMat.ToImage<Rgb, byte>();

                pictureBox1.Image = fMat.ToBitmap();
                MessageBox.Show("Pair wasn't found");
            }

            //int index = 0;

            //foreach (Mat mat in mats) //każdy pojedynczy template
            //{

            //    double minValue = 0.0d;
            //    double maxValue = 0.0d;
            //    System.Drawing.Point minLocation = new System.Drawing.Point();
            //    System.Drawing.Point maxLocation = new System.Drawing.Point();
            //    CvInvoke.MatchTemplate(fullMat, mat, templateOutput, TemplateMatchingType.CcoeffNormed);

            //    //CvInvoke.Imshow("aaa",templateOutput);


            //    // hashmap - klucz (liczba wystąpien), value (obraz) if obraz key = 2 obraz2 key 1

            //    CvInvoke.MinMaxLoc(templateOutput, ref minValue, ref maxValue, ref minLocation, ref maxLocation);

            //    System.Drawing.Point checkPoint = new System.Drawing.Point();

            //    CvInvoke.Threshold(templateOutput, templateOutput, 0.05, 1, ThresholdType.ToZero);

            //    //scale for()
            //    //Console.WriteLine(minValue);
            //    //Console.WriteLine(maxValue);
            //    //Console.WriteLine(minLocation);
            //    //Console.WriteLine(maxLocation);
            //    //Console.WriteLine("dupa");

            //    var matches = templateOutput.ToImage<Gray, byte>();

            //    int counter = 0;
            //    //bool branch = true;
            //    //int Xloc1 = 0;
            //    //int XlocMax = 0;
            //    //int YlocMax = 0;
            //    //int Yloc1 = 0;

            //    //for (int i=0; i< matches.Rows; i++)
            //    //{
            //    //    for(int j=0; j<matches.Cols; j++)
            //    //    {
            //    //        if(matches[i,j].Intensity> .8) //wysortować te punkty
            //    //        {
            //    //            System.Drawing.Point loc = new System.Drawing.Point(j, i);
            //    //            //if (branch)
            //    //            //{
            //    //            //    Xloc1 = loc.X;
            //    //            //    XlocMax = loc.X + mat.Size.Width;
            //    //            //    Yloc1=loc.Y;
            //    //            //    YlocMax = loc.Y + mat.Size.Height;
            //    //            //    branch = false;
            //    //            //}
            //    //            //if((loc.X - Xloc1) * (XlocMax - loc.X) >= 0 && (loc.Y - Yloc1) * (YlocMax - loc.Y) >= 0)
            //    //            //{

            //    //            //}
            //    //            //else
            //    //            //{
            //    //            //    ++counter;

            //    //            //    System.Drawing.Rectangle box = new System.Drawing.Rectangle(loc, mat.Size);

            //    //            //    CvInvoke.Rectangle(fullMat, box, new Emgu.CV.Structure.MCvScalar(0, 255, 0), 2);
            //    //            //}


            //    //        }
            //    //        //if(matches[i,j].Equals(maxValue))
            //    //        //{
            //    //        //    counter++;
            //    //        //    System.Drawing.Point loc = new System.Drawing.Point(j, i);
            //    //        //    System.Drawing.Rectangle box = new System.Drawing.Rectangle(loc, mat.Size);

            //    //        //    CvInvoke.Rectangle(fullMat, box, new Emgu.CV.Structure.MCvScalar(0, 255, 0), 2);
            //    //        //}
            //    //        //if (matches[i, j].Equals(minValue))
            //    //        //{
            //    //        //    counter++;
            //    //        //    System.Drawing.Point loc = new System.Drawing.Point(j, i);
            //    //        //    System.Drawing.Rectangle box = new System.Drawing.Rectangle(loc, mat.Size);

            //    //        //    CvInvoke.Rectangle(fullMat, box, new Emgu.CV.Structure.MCvScalar(0, 255, 0), 2);
            //    //        //}
            //    //    }
            //    //}
            //    ////Console.WriteLine(counter);
            //    ////Console.WriteLine("dupa");

            //    //PhotoTest test = new PhotoTest(fullMat.ToImage<Rgb, byte>());
            //    //test.Show();
            //    //CvInvoke.WaitKey();
            //    //textBox1.Text = names[index] + " " + counter;
            //    //Console.WriteLine(names[index] + " " + counter);
            //    //++index;

            //}

        }

private static int[,] VectorOfPointTOint2DArray(VectorOfPoint vp)
{
            Point[] points = new Point[vp.Size];
            int[,] pointsINT = new int[points.Length, 2];
            for (int t = 0; t < vp.Size; ++t)
            {
                Point point = vp[t];
                points[t] = point;
            }
            for (int r = 0; r < pointsINT.GetLength(0); ++r)
            {
                pointsINT[r, 0] = (int)(points[r].X);
                pointsINT[r, 1] = (int)(points[r].Y);
            }
            return pointsINT;
}

private static VectorOfPoint ProcessImage(Image<Gray,byte> template, Image<Gray, byte> FullImage)
        {
            try
            {
                //initialization
                VectorOfPoint finalPoints = null;
                Mat homography = null;
                VectorOfKeyPoint vectorOfKeyPoint = new VectorOfKeyPoint();
                VectorOfKeyPoint sceneKeyPoint = new VectorOfKeyPoint();
                Mat templateDescriptor = new Mat();
                Mat sceneDescriptor = new Mat();

                Mat mask;
                int k = 2;
                double uniquenessthreshold = 0.80;
                VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch();

                Brisk featureDetector = new Brisk();
                featureDetector.DetectAndCompute(template, null, vectorOfKeyPoint, templateDescriptor, false);
                featureDetector.DetectAndCompute(FullImage, null, sceneKeyPoint, sceneDescriptor, false);

                //Matching
                BFMatcher matcher = new BFMatcher(DistanceType.Hamming);
                matcher.Add(templateDescriptor);
                matcher.KnnMatch(sceneDescriptor, matches, k);

                mask = new Mat(matches.Size, 1, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
                mask.SetTo(new MCvScalar(255));

                Features2DToolbox.VoteForUniqueness(matches, uniquenessthreshold, mask);
                int count = Features2DToolbox.VoteForSizeAndOrientation(vectorOfKeyPoint, sceneKeyPoint, matches, mask, 1.5, 20);


                if (count>=4)
                {
                    homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures
                        (
                        vectorOfKeyPoint, sceneKeyPoint, matches, mask, 5
                        );
                }
                if (homography != null)
                {
                    System.Drawing.Rectangle rect = new System.Drawing.Rectangle(Point.Empty, template.Size);
                    PointF[] pts = new PointF[] 
                    { 
                        new PointF(rect.Left,rect.Bottom),
                        new PointF(rect.Right,rect.Bottom),
                        new PointF(rect.Right,rect.Top),
                        new PointF(rect.Left,rect.Top) 
                    };
                    pts = CvInvoke.PerspectiveTransform(pts, homography);
                    Point[] points = Array.ConvertAll<PointF, Point>(pts, Point.Round);
                    finalPoints = new VectorOfPoint(points);

                }


                return finalPoints;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

 private static int CrossProduct(int[,] A)
        {
            // Stores coefficient of X
            // direction of vector A[1]A[0]
            int X1 = (A[1, 0] - A[0, 0]);

            // Stores coefficient of Y
            // direction of vector A[1]A[0]
            int Y1 = (A[1, 1] - A[0, 1]);

            // Stores coefficient of X
            // direction of vector A[2]A[0]
            int X2 = (A[2, 0] - A[0, 0]);

            // Stores coefficient of Y
            // direction of vector A[2]A[0]
            int Y2 = (A[2, 1] - A[0, 1]);

            // Return cross product
            return (X1 * Y2 - Y1 * X2);
        }

// Function to check if the polygon is
// convex polygon or not
private static bool isConvex(int[,] points)
        {
            // Stores count of
            // edges in polygon
            int N = points.GetLength(0);

            // Stores direction of cross product
            // of previous traversed edges
            int prev = 0;

            // Stores direction of cross product
            // of current traversed edges
            int curr = 0;

            // Traverse the array
            for (int i = 0; i < N; i++)
            {

                // Stores three adjacent edges
                // of the polygon
                int[] temp1 = GetRow(points, i);
                int[] temp2 = GetRow(points, (i + 1) % N);
                int[] temp3 = GetRow(points, (i + 2) % N);
                int[,] temp = new int[points.GetLength(0), points.GetLength(1)];
                temp = newTempIn(points, temp1, temp2, temp3);

                // Update curr
                curr = CrossProduct(temp);

                // If curr is not equal to 0
                if (curr != 0)
                {

                    // If direction of cross product of
                    // all adjacent edges are not same
                    if (curr * prev < 0)
                    {
                        return false;
                    }
                    else
                    {
                        // Update curr
                        prev = curr;
                    }
                }
            }
            return true;
        }
private static int[] GetRow(int[,] matrix, int row)
        {
            var rowLength = matrix.GetLength(1);
            var rowVector = new int[rowLength];

            for (var i = 0; i < rowLength; i++)
                rowVector[i] = matrix[row, i];

            return rowVector;
        }
private static int[,] newTempIn(int[,] points, int[] row1, int[] row2, int[] row3)
        {
            int[,] temp = new int[points.GetLength(0), points.GetLength(1)];

            for (var i = 0; i < row1.Length; i++)
            {
                temp[0, i] = row1[i];
                temp[1, i] = row2[i];
                temp[2, i] = row3[i];
            }
            return temp;
        }


        public PhotoTest(Image<Rgb,byte> image)
        {
            InitializeComponent();
            this.image = image;
            pictureBox1.Image = image.ToBitmap();
        }

        //void thing(Bitmap bitmap)
        //{
        //    int ksize = 5;
        //    Image<Rgb, byte> ImgResult = bitmap.ToImage<Rgb, byte>();
        //    Image<Rgb, byte> ImgOld = bitmap.ToImage<Rgb, byte>();
        //    CvInvoke.Laplacian(ImgOld, ImgResult, DepthType.Default, ksize, 1, 0, BorderType.Default);
        //    PhotoTest pTest = new PhotoTest(ImgResult);
        //    pTest.Show();
        //}
        //void thing2(Bitmap bitmap)
        //{
        //    int threshhold1 = 100;
        //    int threshhold2 = 100;
        //    Image<Rgb, byte> ImgResult = bitmap.ToImage<Rgb, byte>();
        //    Image<Rgb, byte> ImgOld = bitmap.ToImage<Rgb, byte>();
        //    CvInvoke.Canny(ImgOld, ImgResult, threshhold1, threshhold2, 3, false);
        //    PhotoTest pTest = new PhotoTest(ImgResult);
        //    pTest.Show();
        //}
        //void thing3(Bitmap bitmap)
        //{
        //    Image<Rgb, byte> ImgResult = bitmap.ToImage<Rgb, byte>();
        //    Image<Rgb, byte> ImgOld = bitmap.ToImage<Rgb, byte>();
        //    CvInvoke.Sobel(ImgOld, ImgResult, DepthType.Default, 1,0,3,1,0, BorderType.Default);
        //    PhotoTest pTest = new PhotoTest(ImgResult);
        //    pTest.Show();
        //}
        //void thing()
        //{

        //}
    }
}
