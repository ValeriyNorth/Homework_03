using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleKeyInfo cki;
            int gameNumber;
            int maxNumber = 120;
            string outtext = "Введите РАЗУМНОЕ максимальное число не меньше 12 и не больше 500 \n Нажмите 0 для выбора случайного значения от 12 до 120";
            string outtext1 = "";
            int lg = 0;     // Счетчик логинов
            List<string> LoginUser = new List<string>(); // Создаем хранилище логинов
            Random rand = new Random();

            int countuser;  // кол-во игроков, будем его хранить.
            
            // Цикл обработки максимального числа, при вводе 0 число генерируется автоматически от 12 до 120
            // ограничиваем пользователя в воде максимального значения
            do
            {
                Console.Clear();
                Console.WriteLine(outtext1 + outtext);
                maxNumber = Convert.ToInt32(Console.ReadLine());
                if (maxNumber == 0)
                {
                    maxNumber = 120;
                }
                else
                { 
                    outtext1 = "Число не соответствует условиям игры, повтроите ввод \n";
                }

            } while (maxNumber < 12  || maxNumber > 500);
            
            gameNumber = rand.Next(12, maxNumber);

            Console.WriteLine(" Начальное число " + gameNumber + " \n");
            Console.Write("Введите количество игроков >>> ");
            countuser = Convert.ToInt32(Console.ReadLine());
            Debug.WriteLine("Количество игроков ---> " + countuser);

            if (countuser != 0)
                if (countuser < 10)
                {
                    //LoginUser.Capacity(countuser);
                    for (int k = 1; k <= countuser; k++)
                    {
                        Console.Write($" Введите логин пользователя {k} >>> ");
                        //LoginUser.Insert(k, Console.ReadLine());
                        LoginUser.Add(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine(" Мощность Вашего компьютера недостаточна для такого количества игроков \n Обновите компьютер или играйте меньшим количеством");
                }
            else
            {
                // Здесь будет обработка игры компьютера самого с самим
            }
            
            foreach (string LU in LoginUser)
            {
                Console.WriteLine(LoginUser.ElementAt(lg));
                Console.WriteLine($" Логин пользователя {++lg} >>> {LU}");             
            }

            Console.ReadKey();


        }
    }
}
