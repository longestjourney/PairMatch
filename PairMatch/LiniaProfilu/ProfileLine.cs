using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPicEditApp
{
    public partial class ProfileLine : Form
    {
        Bitmap bitmap;
        int ax, ay, bx, by;
        int[] ElementsX;
        int[] ElementsY;
        int[] ElementsZ;

        public void AdjustPicbox()
        {
            //To jest ustawienie rozmiaru pictureboxa
            numAX.Maximum = bitmap.Width;
            numAY.Maximum = bitmap.Height;
            numBX.Maximum = bitmap.Width;
            numBY.Maximum = bitmap.Height;
        }
        
        public ProfileLine(Bitmap bitmap)
        {
            InitializeComponent();
            this.bitmap = bitmap;
            ProfilePicbox.Image=bitmap;
            AdjustPicbox();
        }

        private void numValueChanged(object sender, EventArgs e)
        {
            //wyciągnięcie wartości z pól (potem można zmienić że on change)
            ax = ((int)numAX.Value);
            ay = ((int)numAY.Value);
            bx = ((int)numBX.Value);
            by = ((int)numBY.Value);

            Bitmap preview = new Bitmap(bitmap);
            Graphics g = Graphics.FromImage(preview);
            Pen pen = new Pen(Brushes.Red);
            pen.Width = 5.0F;
            g.DrawLine(pen, ax, ay, bx, by);
            ProfilePicbox.Image = preview;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            dGElements.Rows.Clear();

            ax = ((int)numAX.Value);
            ay = ((int)numAY.Value);
            bx = ((int)numBX.Value);
            by = ((int)numBY.Value);

            ProfileLineElements elements = new ProfileLineElements(ax, ay, bx, by, bitmap);
            ElementsX = elements.theElementsX();
            ElementsY = elements.theElementsY();
            int len = Math.Min(ElementsX.Length, ElementsY.Length);
            ElementsZ = new int[len];

            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = len;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 255;

            //chart.Series.Clear();

            chart.Series[0].Points.Clear();

            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.Series[0].Color = Color.Red;
            for(int i = 0; i < len; i++)
            {
                ElementsZ[i] = (int)(bitmap.GetPixel(ElementsX[i], ElementsY[i]).R);
                dGElements.Rows.Add(ElementsX[i], ElementsY[i],ElementsZ[i]);

                chart.Series[0].Points.AddXY(i, ElementsZ[i]);
            }


            //NoElementsL.Text = elements.equation();
            //dGElements
        }

    }
}


//for (int i = 0; i < R.Length; i++)
//{
//    GridViewRED.Rows.Add(i, R[i]);
//    GridViewGREEN.Rows.Add(i, G[i]);
//    GridViewBLUE.Rows.Add(i, B[i]);
//}

//chRED.Series[0].Points.DataBindY(R);
//chGREEN.Series[0].Points.DataBindY(G);
//chBLUE.Series[0].Points.DataBindY(B);
