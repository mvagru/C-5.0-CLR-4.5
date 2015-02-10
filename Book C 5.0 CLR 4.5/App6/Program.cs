using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    public class Point { int x, y; }
    public struct Point2 { int x2, y2;}
    class Program
    {
        static void Main()
        {
            int x = 1;
            Point p = null;
            Console.WriteLine(p == null); // Значение true
            /* Ссылке может быть присвоен литерал null, который отражает тот факт, что ссылка не указывает ни один объект. */
            Point2 p2 = null;
            /* Тип значения обычно не может иметь значение null. Кроме типов допустающих значение null */
        }
    }
}
