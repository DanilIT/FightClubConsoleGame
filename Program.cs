using System;
using System.Threading;
using FightClubConsoleGame.Fighters;

namespace FightClubConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            Game game = new Game();
            game.StartGame();
        }
        /// <summary>
        /// Вызов меню
        /// </summary>
        static void PrintMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Игра <<<Бойцовский Клуб>>>\n");
            Console.ResetColor();
            Console.WriteLine("1 - начать игру");
            Console.WriteLine("2 - правила");
            Console.WriteLine("3 - выход");
            string option = Console.ReadLine();

            if(option == "1")
            {
                Game game = new Game();
                game.StartGame();
            }

            if (option == "2")
                PrintRules();

            if(option == "3")
            {
                Console.WriteLine("***Игра завершена***");
                Thread.Sleep(2000);
                return; // прерываем бесконецный цикл
            }
            //рекурсия
            PrintMenu();
        }
        /// <summary>
        /// Выводим правила игры на консоль
        /// </summary>
        static void PrintRules()
        {
            Console.Clear();
            Console.WriteLine(new Warrior());
            Console.WriteLine(new Mage());
            Console.WriteLine(new Dodge());

            Console.ReadLine();
        }
    }
}
