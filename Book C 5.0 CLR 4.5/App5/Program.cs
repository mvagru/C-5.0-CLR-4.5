using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    public struct point { public int x, y;}
    public class point2 { public int x1, y1;}

    class Program
    {
        static void Main()
        {
            /* Типы значений все числовые типы, char и bool. Enum и Struct */
            point p1 = new point();
            p1.x = 7;
            point p2 = p1;  // Присваивание приводит к копированию
            Console.WriteLine(p1.x);    //7
            Console.WriteLine(p2.x);    //7
            p1.x = 9;   // Изменить p1.x
            Console.WriteLine(p1.x);    //9
            Console.WriteLine(p2.x);    //7
            /* Типы значений ссылочные все классы, массивы, делегаты и интерфейсы и String. Class */
            point2 p3 = new point2();
            p3.x1 = 7;
            point2 p4 = p3; // Копирует ссылку на p1 
            Console.WriteLine(p3.x1); //7
            p3.x1 = 9;
            Console.WriteLine(p3.x1); // 9
            Console.WriteLine(p4.x1);   //9
        }
    }
}
