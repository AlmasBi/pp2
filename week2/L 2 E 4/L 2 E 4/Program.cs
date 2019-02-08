using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace L_2_E_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = @"C:\Users\Lenovo\Desktop\C#\L 2 E 4\L 2 E 4\text1.txt";    //  Пути для создания 
            string w = @"C:\Users\Lenovo\Desktop\C#\L 2 E 4\L 2 E 4\text2.txt";    //     файлов
            string asd = "KBTU is the best!!!";
            StreamWriter dd = new StreamWriter(q);
            dd.Write(asd);
            dd.Close();
            File.Copy(q, w);   //  Копируем  в новый файл
            File.Delete(q);   //  Удаляем первый файл
        }
    }
}
