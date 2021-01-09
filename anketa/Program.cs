using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName, myTownWasBorn, learningLanguage;
            int myAge;
            Console.WriteLine("Анкета\n");
            Console.Write("Введи своё имя: ");
            myName = Console.ReadLine();
            Console.Write("Сколько тебе лет? ");
            myAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("В каком городе ты родился? ");
            myTownWasBorn = Console.ReadLine();
            Console.Write("Какой язык программирования ты изучаешь? ");
            learningLanguage = Console.ReadLine();
            Console.WriteLine($"\nТебя зовут {myName}, тебе {myAge} лет, ты родился в городе {myTownWasBorn}," +
                  $" ты освоил основы языка {learningLanguage}");
            Console.ReadKey();
        }
    }
}