using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_L_4_E
{
    class Program
    {
        static void Main(string[] args)
        {
            tring s = "[*]";  //  один экземпляр star triangle 
            int a = int.Parse(Console.ReadLine());  //  Вводим число
            for (int i = 1; i <= a; i++)  //      используем loop в loop-е
            {                               //  
                for (int j = 1; j <= i; j++)  //  
                {
                    Console.Write(s);  // выводим возрастающее каждой итерацией startriangle
                }
                Console.WriteLine();   //  переход в следующую строку
            }
            Console.ReadLine();

        }
    }
}
