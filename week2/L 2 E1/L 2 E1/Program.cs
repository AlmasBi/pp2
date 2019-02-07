using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace L_2_E1
{
   

    class Program
    {
        public static bool Ex7()
        {
            StreamReader sr = new StreamReader("input.txt");
            String s = sr.ReadToEnd();
            String[] arr = s.Split();
            bool qw = false;
            for (int i = 0; i <= arr.Length; i++)
            {
                if (arr[0] == arr[arr.Length - 1 - i])
                {
                    qw = true;
                    return qw;
                }

            }return qw;
        }

        static void Main(string[] args)
        {
         
               if(Ex7())
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
