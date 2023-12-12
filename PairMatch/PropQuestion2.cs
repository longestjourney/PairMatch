using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class PropQuestion2 : Form
    {
        private int progProperty = 127;
        private int progProperty2 = 127;
        public int ProgProperty { get { return progProperty; } set { progProperty = value; } }
        private Bitmap bmp;
        private Bitmap bmp2;
        PicForm form;
        int casenumber;
        public PropQuestion2(Bitmap map, Bitmap map2, PicForm form,int casenumber)
        {
            this.bmp = map;
            this.bmp2 = map2;
            this.form = form;
            this.casenumber = casenumber;
            InitializeComponent();
           
        }

        private void PropQuestion2_Load(object sender, EventArgs e)
        {
        
        }

        private void bgot_Click(object sender, EventArgs e)
        {
            Bitmap EditMap = new Bitmap(bmp);
            Image<Gray, byte> EditTable1 = EditMap.ToImage<Gray, byte>();
            Bitmap EditMap2 = new Bitmap(this.bmp2);
            Image<Gray, byte> EditTable2 = EditMap2.ToImage<Gray, byte>();
            Bitmap EditMap3 = new Bitmap(this.bmp);
            Image<Gray, byte> EditTableOut = EditMap.ToImage<Gray, byte>();
            progProperty = Convert.ToInt32(tbProp.Text);
            progProperty2 = Convert.ToInt32(textBox2.Text);
            int p = progProperty;
            for (int x = 0; x < bmp.Width; ++x)
            {
                for (int y = 0; y < bmp.Height; ++y)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    if (p >= pixelColor.R)
                    {
                        Color newColor = Color.FromArgb(0, 0, 0);
                        bmp.SetPixel(x, y, newColor);
                    }
                    else
                    {
                        Color newColor = Color.FromArgb(255, 255, 255);
                        bmp.SetPixel(x, y, newColor);
                    }

                }
            }

            form.picbox.Image = this.bmp;


            p = progProperty2;
            for (int x = 0; x < bmp2.Width; ++x)
            {
                for (int y = 0; y < bmp2.Height; ++y)
                {
                    Color pixelColor = bmp2.GetPixel(x, y);
                    if (p >= pixelColor.R)
                    {
                        Color newColor = Color.FromArgb(0, 0, 0);
                        bmp2.SetPixel(x, y, newColor);
                    }
                    else
                    {
                        Color newColor = Color.FromArgb(255, 255, 255);
                        bmp2.SetPixel(x, y, newColor);
                    }

                }
            }
            form.picturebox2.Image = this.bmp2;

            EditTable1 = bmp.ToImage<Gray, byte>();
            EditTable2 = bmp2.ToImage<Gray, byte>();
            EditTableOut = EditTable1;

            switch (casenumber)
            {
                case 3:
                    CvInvoke.BitwiseNot(EditTable1, EditTable2, EditTableOut);
                    Form2 form3 = new Form2(EditTableOut);
                    form3.Show();
                    break;
                case 4:
                    CvInvoke.BitwiseAnd(EditTable1, EditTable2, EditTableOut);
                    Form2 form4 = new Form2(EditTableOut);
                    form4.Show();
                    break;
                case 5:
                    CvInvoke.BitwiseOr(EditTable1, EditTable2, EditTableOut);
                    Form2 form5 = new Form2(EditTableOut);
                    form5.Show();
                    break;
                case 6:
                    CvInvoke.BitwiseXor(EditTable1, EditTable2, EditTableOut);
                    Form2 form6 = new Form2(EditTableOut);
                    form6.Show();
                    break;
            }

            

        }
    }
}
