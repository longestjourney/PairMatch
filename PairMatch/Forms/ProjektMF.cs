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
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace NewPicEditApp
{
    public partial class ProjektMF : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public ProjektMF()
        {
            InitializeComponent();
            bPhoto.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
                pictureBox1.Image = NewPicEditApp.Properties.Resources.offcamera;
                ButtonSetup();
            }
            else
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbVDevices.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                ButtonSetup();
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //Image<Gray, byte> imgOld = bitmap.ToImage<Gray, byte>();
            Image<Rgb, byte> imgOld = bitmap.ToImage<Rgb, byte>();
            //pictureBox1.Image = imgOld.ToBitmap();
            pictureBox1.Image = bitmap;
        }

        private void ProjektMF_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbVDevices.Items.Add(filterInfo.Name);
            }
            cbVDevices.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();


            //Load library
            //hash map TRIM on first occurance
            string[] images = Directory.GetFiles(@"..\..\Templates", "*.png");
                foreach (string image in images)
                {
                    // create a new control
                    PictureBox pb = new PictureBox();

                    // assign the image
                    pb.Image = new Bitmap(image);
                    // stretch the image
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;

                    // set the size of the picture box
                    pb.Height = pb.Image.Height / 10;
                    pb.Width = pb.Image.Width / 10;

                    // add the control to the container
                    panel2.Controls.Add(pb);
                    tableLayoutPanel1.Controls.Add(pb);
                    //tableLayoutPanel1.ColumnCount = 3;
                    //tableLayoutPanel1.RowCount = 1;

                }

        }
        private void ButtonSetup()
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                bPhoto.Enabled = true;
                button1.Text = "Wyłącz kamerkę";
            }
            else
            {
                bPhoto.Enabled = false;
                button1.Text = "Włącz kamerkę";
            }

        }

        private void ProjektMF_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void bPhoto_Click(object sender, EventArgs e)
        {
            Bitmap photo = (Bitmap)pictureBox1.Image;
            //PhotoForm photoForm = new PhotoForm(photo);
            //photoForm.Show();

            PhotoTest photoTest = new PhotoTest(photo);
            photoTest.Show();
        }

        private void bLoadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            try
            {//próba otwarcia pliku z obrazem
                dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Bitmap photo = new Bitmap(dialog.FileName);
                    PhotoTest photoTest = new PhotoTest(photo);
                    photoTest.Show();
                    //PhotoForm photoForm = new PhotoForm(photo);
                    //photoForm.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
