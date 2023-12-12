using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace NewPicEditApp
{
    public partial class PicForm : Form
    {
        OpenFileDialog dialog = new OpenFileDialog();
        int[] RHistogram = new int[256];
        int[] GHistogram = new int[256];
        int[] BHistogram = new int[256];
        int[] AHistogram = new int[256];
        bool is_grayscale;
        int min;
        int max;
        double cumulativesum = 0;
        internal Bitmap picboxCopyMap;

        //to jest konstruktor okienka PicForm
        public PicForm() { InitializeComponent(); }

        private void PicForm_Load(object sender, EventArgs e) { }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            try
            {//próba otwarcia pliku z obrazem
                dialog.Filter = "bmp files(*.bmp)|*.bmp| jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.**";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.picboxCopyMap = new Bitmap(dialog.FileName);
                    this.picbox.Image = picboxCopyMap;
                    Picture mypicture = new Picture(picboxCopyMap);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pokażToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rozciąToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void equalizacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void co_histogram_operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.picboxCopyMap != null)
            {

                switch (co_histogram_operations.SelectedIndex)
                {
                    case 0: //pokaz histogram
                        //czyszczenie tablic histogramów żeby przy załadowaniu nowego obrazka były puste

                        TablesMethods.ZeroTables(RHistogram);
                        TablesMethods.ZeroTables(GHistogram);
                        TablesMethods.ZeroTables(BHistogram);
                        TablesMethods.ZeroTables(AHistogram);

                        //histogram musi tu zaczac istniec


                        for (int x = 0; x < picboxCopyMap.Width; ++x)
                        {
                            for (int y = 0; y < picboxCopyMap.Height; ++y)
                            {
                                Color pixelColor = picboxCopyMap.GetPixel(x, y);
                                RHistogram[Convert.ToInt32(pixelColor.R.ToString())] += 1;
                                GHistogram[Convert.ToInt32(pixelColor.G.ToString())] += 1;
                                BHistogram[Convert.ToInt32(pixelColor.B.ToString())] += 1;
                                AHistogram[Convert.ToInt32(pixelColor.A.ToString())] += 1;
                            }
                        }
                        HistogramForm histogram = new HistogramForm(RHistogram, GHistogram, BHistogram, AHistogram, is_grayscale);
                        histogram.Show();
                        break;
                    case 1: //rozciagnij histogram
                        Bitmap EditMap = new Bitmap(this.picboxCopyMap);
                        is_grayscale = TablesMethods.IsGrayScale(RHistogram, GHistogram, BHistogram);
                        if (is_grayscale)
                        {
                            for (int x = 0; x < EditMap.Width; ++x)
                            {
                                for (int y = 0; y < EditMap.Height; ++y)
                                {
                                    Color pixelColor = EditMap.GetPixel(x, y);
                                    if (pixelColor.R < min)
                                    {
                                        Color newColor = Color.FromArgb(0, 0, 0);
                                        EditMap.SetPixel(x, y, newColor);
                                    }
                                    else if (pixelColor.R > max)
                                    {

                                        Color newColor = Color.FromArgb(255, 255, 255);
                                        EditMap.SetPixel(x, y, newColor);
                                    }
                                    else
                                    {
                                        Color newColor = Color.FromArgb(
                                            Math.Abs((pixelColor.R) - min) * ((255) / (max - min)),
                                            Math.Abs((pixelColor.G) - min) * ((255) / (max - min)),
                                            Math.Abs((pixelColor.B) - min) * ((255) / (max - min)));

                                        EditMap.SetPixel(x, y, newColor);
                                    }

                                }
                                this.picboxCopyMap = EditMap;
                                picbox.Image = this.picboxCopyMap;
                            }
                        }
                        else MessageBox.Show("Obraz musi być szaroodcieniowy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 2: //equalizacja

                        EditMap = new Bitmap(this.picboxCopyMap);
                        double[] normalhist = new double[256];

                        for (int i = 0; i < normalhist.Length; i++)
                        {
                            int numberofk = RHistogram[i];
                            normalhist[i] = (double)numberofk / (cumulativesum);
                        }
                        for (int x = 0; x < EditMap.Width; ++x)
                        {
                            for (int y = 0; y < EditMap.Height; ++y)
                            {
                                double suma = 0;
                                Color pixelColor = EditMap.GetPixel(x, y);
                                int k = pixelColor.R;
                                for (int n = 0; n <= k; ++n)
                                {
                                    suma += normalhist[n];
                                }
                                suma = suma * (max - min);
                                if (Math.Floor(suma) > 255) {
                                    Color newColor = Color.FromArgb(255, 255, 255);
                                    EditMap.SetPixel(x, y, newColor);
                                }

                                else
                                {
                                    Color newColor = Color.FromArgb((int)Math.Floor(suma), (int)Math.Floor(suma), (int)Math.Floor(suma));
                                    EditMap.SetPixel(x, y, newColor);
                                }
                            }
                        }
                        this.picboxCopyMap = EditMap;
                        picbox.Image = this.picboxCopyMap;
                        break;

                    default: break;
                }
            }
            else { MessageBox.Show("Nie wybrano obrazu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

       

        public class jakiesoperacje{}


        // string onePixelOpList = new List<string> {"invert", "progowanie", "costam" };
        // this.picboxCopyMap = PictureCreator.CreatePicture(EditMap, onePixelOpList[co_onepoint_operations.SelectedIndex]).toBitmap();

    //Negatyw click
    private void miInvert_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            picbox.Image = PictureFactory.make("invert", EditMap).toBitmap();
        }

        //
        private void zwykłeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            EditMap = new Bitmap(this.picboxCopyMap);
            PropQuestion propQuestion = new PropQuestion(EditMap, this, 1);
            propQuestion.Show();
        }

        private void zPoziomamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            EditMap = new Bitmap(this.picboxCopyMap);
            PropQuestion propQuestion2 = new PropQuestion(EditMap, this, 2);
            propQuestion2.Show();
        }

        private void posteryzacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            EditMap = new Bitmap(this.picboxCopyMap);
            PropQuestion propQuestion3 = new PropQuestion(EditMap, this, 3);
            propQuestion3.Show();
        }

        private void rozciąganieSelektywneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(this.picboxCopyMap);
            EditMap = new Bitmap(this.picboxCopyMap);
            PropQuestion propQuestion4 = new PropQuestion(EditMap, this, 4);
            propQuestion4.Show();
        }
    }

}

