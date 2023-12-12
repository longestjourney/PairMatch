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
    public partial class HistogramForm : Form
    {

        int[] RhistogramArray = new int[256];
        int[] GhistogramArray = new int[256];
        int[] BhistogramArray = new int[256];
        int[] AhistogramArray = new int[256];
        bool is_greyscale;
        public HistogramForm(int[] Rhistarray, int[] Ghistarray, int[] Bhistarray, int[] Ahistarray, bool greyscale)
        {
            InitializeComponent();
            for (int i = 0; i < AhistogramArray.Length; i++)
            {
                this.RhistogramArray[i] = Rhistarray[i];
                this.GhistogramArray[i] = Ghistarray[i];
                this.BhistogramArray[i] = Bhistarray[i];
                this.AhistogramArray[i] = Ahistarray[i];
            }
            this.is_greyscale = greyscale;
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            if (is_greyscale)//jest czarno-bialy
            {
                chRED.Visible = false;
                chGREEN.Visible = false;
                chBLUE.Visible = false;
                GridViewBLUE.Visible = false;
                GridViewGREEN.Visible = false;
                GridViewRED.Visible = false;

                cValue.Series[0].Points.DataBindY(RhistogramArray);

                for (int i = 0; i < AhistogramArray.Length; i++)
                {
                    GridViewValues.Rows.Add(i, RhistogramArray[i]);
                }

            }
            else //jest kolorowy
            {
                //chRED.Visible = true;
                //chGREEN.Visible = true;
                //chBLUE.Visible = true;
                for (int i = 0; i < AhistogramArray.Length; i++)
                {
                    GridViewRED.Rows.Add(i, RhistogramArray[i]);
                    GridViewGREEN.Rows.Add(i, GhistogramArray[i]);
                    GridViewBLUE.Rows.Add(i, BhistogramArray[i]);
                }

                chRED.Series[0].Points.DataBindY(RhistogramArray);
                chGREEN.Series[0].Points.DataBindY(GhistogramArray);
                chBLUE.Series[0].Points.DataBindY(BhistogramArray);
                chA.Series[0].Points.DataBindY(AhistogramArray);
            }

        }
    }
}
