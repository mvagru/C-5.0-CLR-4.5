using System;
using System.Text;

namespace App4
{
    public class Panda
    {
        public string Name; // Поле экземпляра
        public static int Population; // Статическое поле
        public Panda(string n) // Конструктор
        {
            Name = n; // Присвоить значение полю экземпляра 
            Population = Population + 1; // Инкрементировать значение статического поля
        }
    }
    class Program
    {
        static void Main()
        {
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");
            Console.WriteLine(p1.Name); // Pan Dee
            Console.WriteLine(p2.Name); // Pan Dah
            Console.WriteLine(Panda.Population); // 2
        }
    }
}
