using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace L_2_E_2
{
    class Program
    {
        public static void Ex2(int t)
        {
            
            
           

        }
        public static void Ex1()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\Desktop\C#\L 2 E 2\L 2 E 2\bin\Debug\output.txt");
            StreamReader sr = new StreamReader(@"C:\Users\Lenovo\Desktop\C#\L 2 E 2\L 2 E 2\bin\Debug\input.txt");
            string s = sr.ReadToEnd();
            string[] arr = s.Split();
            for(int i = 0; i < arr.Length; i++)
            {
                int n = 0;
                int q = int.Parse(arr[i]);
                for(int j = 2; j <=q; j++)
                {
                    if (q % j == 0)
                        n++;
                }
                if (n == 1)
                    sw.Write(q + " ");
            } sw.Close();
            sr.Close();
        }
        static void Main(string[] args)
        {
            Ex1();
            Console.ReadKey();
        }
    }
}
