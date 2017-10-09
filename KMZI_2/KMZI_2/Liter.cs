using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMZI_2
{
    class Liter
    {
        private const int n = 4;
        public char lit { get; set; }
        public int[] shifr_id = new int[n];
        public int count { get; set; }
     public   Liter()
        {
            lit = '0';
            for (int i = 0; i < n; i++)
            
           shifr_id[i] = 0;
            count = 0;
        }
      public  Liter( char a, int[] mas,int c=0)
        {
            lit = a;
            shifr_id = mas;
            count = c;
        }
      public  Liter(string a, int[] mas, int c=0)
        {
            lit = a[0];
            shifr_id = mas;
            count = c;
        }
        public int Pop(int i)
        {
            return shifr_id[i];
        }
        public void Control()
        {
            if (count >= (n-1)) count = 0;
        }

       public Liter (int j)
        {
            // 32 - ' ' 33 - '!'    44 - ','    46 - '.'    63 -'?'    

            if (j < 1000)
            {
                if (j == 13)
                {
                    
                    int[] a = new int[n];
                    a[0] = 9999;
                    a[1] = 9898;
                    a[2] = 9779;
                    a[3] = 9000;
                    lit = (char)j;
                    shifr_id = a;
                    count = 0;
                }
                else
                {
                    if (j < 40)
                    {
                        int j_new = j * 100;
                        int[] a = new int[n];
                        a[0] = j_new;
                        a[1] = (j_new + 3) * 2;
                        a[2] = j_new * 3;
                        a[3] = (j_new + 101);
                        lit = (char)j;
                        shifr_id = a;
                        count = 0;
                    }
                    else
                    {
                        int j_new = (j + 100) * 10;
                        int[] a = new int[n];
                        a[0] = j_new;
                        a[1] = (j_new + 3) * 2;
                        a[2] = j_new * 3;
                        a[3] = (j_new + 101);
                        lit = (char)j;
                        shifr_id = a;
                        count = 0;
                    }
                }
            }
            else
            {
                int[] a = new int[n];
                a[0] = j;
                a[1] = (j + 3) * 2;
                a[2] = j * 3;
                a[3] = (j + 101);
                lit = (char)j;
                shifr_id = a;
                count = 0;
            }

            
           }
    }
}
