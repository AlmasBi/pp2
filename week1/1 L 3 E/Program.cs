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
            a = Console.ReadLine();//  количество элементов первого массива
            int c = int.Parse(a);// конвертируем  элемент со стринга в интеджер
            string[] arr = Console.ReadLine().Split();// разделяем каждое число массива в виде массива строк
            for (int i = 0; i < c; i++)
            {
                
                    int q = int.Parse(arr[i]);// все элементы массива строк конвертируем в элементы массива целых чисел 
                Console.Write(q + " ");//  Выводим элементы массива два раза
                Console.Write(q + " ");

            } Console.ReadKey();
        }
    }
}
