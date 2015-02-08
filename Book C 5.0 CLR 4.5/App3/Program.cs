using System;

namespace App3
{
    public class UnitConverter
    {
        int ratio;  // Поле
        public UnitConverter(int unitRatio) { ratio = unitRatio; } // Конструктор
        public int Convert(int unit) { return unit * ratio; } // Метод
    }
    class Program
    {
        static void Main()
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12); 
            UnitConverter milesToFeetConverter = new UnitConverter(5280);
            Console.WriteLine(feetToInchesConverter.Convert(30)); // 360
            Console.WriteLine(feetToInchesConverter.Convert(100)); // 1200
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1))); // 5280*1*12=63360
        }
    }
}
