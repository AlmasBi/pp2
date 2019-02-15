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
        public static void Ex1()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Lenovo\Desktop\C#\L 2 E 2\L 2 E 2\bin\Debug\output.txt");// "инструмент" для ввода текста
            StreamReader sr = new StreamReader(@"C:\Users\Lenovo\Desktop\C#\L 2 E 2\L 2 E 2\bin\Debug\input.txt");// "инструмент" для чтения текста
            string s = sr.ReadToEnd(); //  переменная  s принимает значение текста 
            string[] arr = s.Split(); // разделяем текст на элементы стрингового массива через пробел
            for(int i = 0; i < arr.Length; i++)
            {
                int n = 0;
                int q = int.Parse(arr[i]);// конвертируем каждый элемент массива со стринга в интеджер
                for(int j = 2; j <=q; j++)// пробегаемся по количеству элементов массива
                {
                    if (q % j == 0)
                        n++;
                }
                if (n == 1)// проверяем простое ли число
                    sw.Write(q + " ");// если простое, то вводим его в текст output
            } sw.Close();
            sr.Close();
        }
        static void Main(string[] args)
        {
            Ex1();//Вызываем функцию Ex1
            Console.ReadKey();
        }
    }
}
