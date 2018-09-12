using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static void Main()
        {
            int x1=0, v1=0, x2=0, v2=0;
            string[] s = Console.ReadLine().Split(' ');
            x1 = Convert.ToInt32(s[0]);
            v1 = Convert.ToInt32(s[1]);
            x2 = Convert.ToInt32(s[2]);
            v2 = Convert.ToInt32(s[3]);
            string result = Cangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
            
            Console.ReadKey();
        }
        static string Cangaroo(int x1,int v1,int x2, int v2) 
        {
            if (v2 < v1)
            {
                for (int t = 0; true; t++)
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 == x2 || x1 > x2)
                    {
                        break;                  
                    }
                }
                if (x1 == x2) return "YES";
                else return "NO";
                
            }
            else return "NO";
        }
    }
}
