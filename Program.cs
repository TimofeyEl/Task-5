using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветсвуем Вас в игре \"Угадай число\". Введите максимальное число диапазона.");

            int maxNumber = Convert.ToInt32(Console.ReadLine()); 
            Random rand = new Random();
            int iiNumber = rand.Next(0,maxNumber);
            int userNumber;
            int count = 0;
            string userText;
            while (true)
            {
                Console.Write("\nВведите число: ");

                userText = Console.ReadLine();
                

                if (String.IsNullOrEmpty(userText))
                {
                    Console.WriteLine($"До новых встреч! Загаданное число = {iiNumber}");
                    break;
                }
                userNumber = Convert.ToInt32(userText);
                count++;



                if (userNumber < iiNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Повторите попытку.");
                }
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("Введенное число больше загаданного. Повторите попытку.");
                }
                else
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число! Количество поппыток:{count}");
                    break;
                }
                
                





            }

            Console.ReadKey();

        }
    }
}



