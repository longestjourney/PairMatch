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
    public partial class PropQuestion : Form
    {
       
        private int progProperty=127;
        private int progProperty2 = 127;
        public int ProgProperty { get { return progProperty; } set { progProperty = value; } }
        private Bitmap bmp ;
        PicForm form;
        private int casenumber;
        int[] postHistogram = new int[256];
        public PropQuestion(Bitmap map, PicForm form, int casenumber)
        {
            
            this.bmp = map;
            this.form = form;
            this.casenumber = casenumber;
            InitializeComponent();
            if(casenumber == 2)
            {
                tbProp2.Visible = true;
            }
            if (casenumber == 3)
            {
                textBox1.Text = "Proszę wczytać ilość podziałów:";
                this.Text = "Posteryzacja";
            }
            if (casenumber == 4)
            {
                this.Text = "Rozciąganie selektywne";
                textBox1.Text = "Proszę wczytać odpowiednie zakresy:";
                tbProp2.Visible = true;
                p1.Visible = true;
                p2.Visible = true;
                q3.Visible = true;
                q4.Visible = true;
                tbQprop1.Visible = true;
                tbQprop2.Visible = true;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
       

        private void PropQuestion_Load(object sender, EventArgs e)
        {

        }
        private void bgot_Click(object sender, EventArgs e)
        {
            switch (casenumber)
            {
                case 1:
                    progProperty = Convert.ToInt32(tbProp.Text);
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
                    break;
                case 2:
                    
                    progProperty = Convert.ToInt32(tbProp.Text);
                    progProperty2 = Convert.ToInt32(tbProp2.Text);

                    p = progProperty;
                    int p2 = progProperty2;
                    int z = Math.Min(p, p2);
                    p2 = Math.Max(p, p2);
                    p = z;
                    for (int x = 0; x < bmp.Width; ++x)
                    {
                        for (int y = 0; y < bmp.Height; ++y)
                        {
                            Color pixelColor = bmp.GetPixel(x, y);
                            if (p > pixelColor.R)
                            {
                                Color newColor = Color.FromArgb(0, 0, 0);
                                bmp.SetPixel(x, y, newColor);
                            }
                            else if(p2 < pixelColor.R)
                            {
                                Color newColor = Color.FromArgb(255, 255, 255);
                                bmp.SetPixel(x, y, newColor);
                            }
                            else
                            {
                                Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);
                                bmp.SetPixel(x, y, newColor);
                            }

                        }
                    }

                    form.picbox.Image = this.bmp;
                    break;
                case 3:
                    progProperty = Convert.ToInt32(tbProp.Text);
                    if (progProperty < 256)
                    {
                        progProperty = 255/progProperty;
                        int j = 0;
                       for (int i = 0; i <= 255;i+= progProperty)
                        {
                            for(; j <= i; j++)
                            {
                                postHistogram[j] = i;
                            }
                            
                        }
                        for (int x = 0; x < bmp.Width; ++x)
                        {
                            for (int y = 0; y < bmp.Height; ++y)
                            {
                                Color pixelColor = bmp.GetPixel(x, y);

                                Color newColor = Color.FromArgb(postHistogram[pixelColor.R], postHistogram[pixelColor.G], postHistogram[pixelColor.B]);
                                bmp.SetPixel(x, y, newColor);


                            }
                        }
                    }
                    form.picbox.Image = this.bmp;
                    form.picboxCopyMap = bmp;
                    break;
                case 4:
                   int progp1 = Convert.ToInt32(tbProp.Text);
                   int progp2 = Convert.ToInt32(tbProp2.Text);
                    int progq3 = Convert.ToInt32(tbQprop1.Text);
                    int progq4 = Convert.ToInt32(tbQprop2.Text);
                    
                    for (int x = 0; x < bmp.Width; ++x)
                    {
                        for (int y = 0; y < bmp.Height; ++y)
                        {
                            Color pixelColor = bmp.GetPixel(x, y);
                            if (pixelColor.R <= progp2 && pixelColor.R >= progp1)
                            {
                                //to nie działa
                                Color newColor = Color.FromArgb(
                                       Math.Abs((pixelColor.R) - progp1) * ((progq4-progq3) / (progp2 - progp1)),
                                       Math.Abs((pixelColor.G) - progp1) * ((progq4 - progq3) / (progp2 - progp1)),
                                       Math.Abs((pixelColor.B) - progp1) * ((progq4 - progq3) / (progp2 - progp1)));

                                bmp.SetPixel(x, y, newColor);
                            }
                            else
                            {

                                Color newColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);
                                bmp.SetPixel(x, y, newColor);
                            }

                        }
                    }
                    form.picbox.Image = this.bmp;
                    break;
            }
            

            
        }
    }
}
