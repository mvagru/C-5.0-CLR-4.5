using System;

namespace App1_
{
    class Program
    {
        static void Main() /* Вызов метода FeetToInches с передачей аргументов для обработки */
        {
            Console.WriteLine(FeetToInches (30)); //360
            Console.WriteLine(FeetToInches (100)); //1200
        }
        static int FeetToInches(int feet) /* Метод принимающий аргументы в футах*/
        {
            int inches = feet * 12; // Конвертация футы в дюймы
            return inches; // Выходной аргумент возвращающий параметр в дюймах
        }
    }
}
