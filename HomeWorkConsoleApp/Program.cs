using System;
using static System.Formats.Asn1.AsnWriter;

namespace HomeWorkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание1
            Console.WriteLine("Данные о пользователе");
            //Исходные данные о пользователе
            string fullName = "Мельников Антон Алексеевич";
            byte age = 20;
            string email = "sky@mail.ru";
            double programmingScores = 5;
            double mathScores = 4.3;
            double physicsScores = 4.501;
            //Заготовленные названия строк в таблице
            string wordPatternInfo = $"Ф.И.О:{fullName}:" +
                $"Возраст:{age}:" +
                $"Email:{email}:" +
                $"Баллы по программированию:{programmingScores:0.0}:" +
                $"Баллы по математике:{mathScores:0.0}:" +
                $"Баллы по физике:{physicsScores:0.0}";
            //Заготовленный шаблон для таблицы
            string patternInfo = 
                "{0,30}: {1}\n" +   //Ф.И.О
                "{2,30}: {3}\n" +   //Возвраст
                "{4,30}: {5}\n" +   //Email
                "{6,30}: {7}\n" +   //Баллы по программированию
                "{8,30}: {9}\n" +   //Быллы по математике
                "{10,30}: {11}\n";  //Баллы по физике

            Console.WriteLine(patternInfo, wordPatternInfo.Split(':')); //Вывод в консоль таблицы с информаццией о пользователе
            Console.ReadKey(); //Ожидания нажатия клавиши для gt
            #endregion
            #region Задание2
            double scoresTotal = programmingScores + mathScores + physicsScores; //Сумма всех баллов за предметы
            double averageScore = scoresTotal / 3; //Среднее арифмитическое баллов по предметам
            Console.WriteLine("Данные о подсчёте количества баллов по всем предметам");
            //Заготовленные названия строк в таблице
            string wordPatternCounting = 
                $"Сумма всех баллов:{scoresTotal:0.0}:" +
                $"Среднее арифмитическое баллов:{averageScore:0.0}";
            //Заготовленный шаблон для таблицы 
            string patternCounting =
                "{0,35}: {1}\n" +   //Сумма баллов за все предметы
                "{2,35}: {3}\n";    //Среднее арифмитическое баллов за все предметы
            Console.WriteLine(patternCounting, wordPatternCounting.Split(':')); //Вывод в консоль таблицы с информаццией о пользователе
            Console.ReadKey(); //Ожидания нажатия клавиши для завершения программы
            #endregion
        }
    }
}
