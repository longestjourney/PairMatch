using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPicEditApp
{
    static internal class TablesMethods
    {

        static public int[] ZeroTables(int[] mytable)
        {
            for (int i = 0; i < mytable.Length; ++i)
            {
                mytable[i] = 0;
            }
            return mytable;
        }
        //metoda pozawalajaca na przenoszenie tych samych wartosci z mytable do mytable2
        static public int[] CopyTables(int[] mytable, int[] mytable2)
        {
            for (int i = 0; i < mytable.Length; ++i)
            {
                mytable2[i] = mytable[i];
            }

            return mytable2;
        }
        //stretching

        static public bool IsGrayScale(int[] R, int[] G, int[] B)
        {
            bool is_gray_scale = true;
            for (int i = 0; i < R.Length; ++i)
            {
                if ((R[i] == G[i]) && (R[i] == B[i]))
                {
                    is_gray_scale &= true;
                }
                else
                {
                    is_gray_scale &= false;
                }
            }
            return is_gray_scale;
        }
        static public int MinTable(int[] mytable)
        {
            int min = 0;
            for(int i=0; i < mytable.Length&&mytable[i]==0; ++i)
            {
                min = i;
            }
            return min;
        }
        static public int MaxTable(int[] mytable)
        {
            int max = 255;
            for (int i = mytable.Length-1; i > 0 && mytable[i] == 0; --i)
            {
                max = i;
            }
            return max;
        }

    }
}
