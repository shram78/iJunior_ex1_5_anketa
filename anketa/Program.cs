using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Вы задаете вопросы пользователю, по типу "как вас зовут", "какой ваш знак зодиака" и тд,
после чего, по данным, которые он ввел, формируете небольшой текст о пользователе.
"Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе."*/

namespace anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Анкета\n");
            Console.Write("Введи своё имя: ");
            string myName = Console.ReadLine();
            Console.Write("Сколько тебе лет? ");
            int myYarsOld = Convert.ToInt32(Console.ReadLine());
            Console.Write("В каком городе ты родился? ");
            string myTownWasBorn = Console.ReadLine();
            Console.Write("Какой язык программирования ты изучаешь? ");
            string cSharpOfCorse = Console.ReadLine();

            Console.WriteLine($"\nТебя зовут {myName}, тебе {myYarsOld} лет, ты родился в городе {myTownWasBorn}," +
                              $" ты освоил основы языка {cSharpOfCorse}");

                Console.ReadKey();
        }
    }
}
