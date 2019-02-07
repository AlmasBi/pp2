using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_L_3_E
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int l = 0;
            a = Console.ReadLine();
            int c = int.Parse(a);
            string[] arr = Console.ReadLine().Split();
            for (int i = 0; i < c; i++)
            {
                
                    int q = int.Parse(arr[i]);
                Console.Write(q + " ");
                Console.Write(q + " ");

            } Console.ReadKey();
        }
    }
}
