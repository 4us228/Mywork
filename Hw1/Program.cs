using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Выполнил Цубера Кристиан
/// </summary>

namespace Hw1
{
    internal class Anket
    {
        static void Main(string[] args)
        {
         #region  Задание 1
              Console.WriteLine("Здравствуй, мне нужно что-бы ты ответил на несколько вопросов:");
              Console.WriteLine("Первый вопрос. Как тебя зовут?");
              string name = Console.ReadLine();
              Console.WriteLine("Прексрасное имя, второй вопрос: Твоя фамилия");
              string surname = Console.ReadLine();
              Console.WriteLine("Отлично, сколько тебе лет?");
              short age = short.Parse(Console.ReadLine());
              Console.WriteLine("Ого ты уже не молодой но еще и не старый, а какого ты роста?");
              double hight = double.Parse(Console.ReadLine());
              Console.WriteLine("Неплохо и последний вопрос, сколько ты весишь?");
              double weight = double.Parse(Console.ReadLine());
              Console.Write("Итак подытожим ");
              Console.WriteLine( $"{name} {surname} {age}"  + " лет " + hight + " см " + weight + " кг " ) ;
              #endregion
         #region Задание 2
              Console.WriteLine("Сейчас мы определим твой индекс массы тела, нажми Enter что-бы узнать");
              Console.ReadLine();
              double index = weight / (hight * 2 / 100) ;
            Console.WriteLine("Твой индекс массы тела = ");
              Console.Write("{0:F2}", index);
              Console.ReadLine();
            #endregion
            Console.WriteLine("{0:F2}", distance(5, 10, 8, 6));//Вызов метода измерения дистанции
            Console.ReadLine();
            exchange(5, 20);//Вызов метода обмена значениями
            Console.ReadLine() ;
            centerScreen("kris", "tsubera", "kiev");//Вызов метода отцентровки текста
            Console.ReadLine();

        }
         #region Задание 3
        static double distance(double x1, double y1, double x2, double y2)
        {
            double r = 0;
            r = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);

            return r;
        }
        #endregion
         #region Задание 4
        static void exchange(int x1, int x2)
        {
            Console.WriteLine($"Первое число: {x1} второе число:{x2}");
            (x1, x2) = (x2, x1);
            Console.WriteLine("Обмен");
            Console.WriteLine($"Первое число: {x1} второе число {x2} ");
        }
        #endregion
         #region Задание 5
        static void centerScreen(string name, string surname, string city)
        {
            Console.Clear();
            string info = name + " " + surname + " " + city;
            int centerX = (Console.WindowWidth / 2) - (info.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(info);
        }
        #endregion

    }
}

