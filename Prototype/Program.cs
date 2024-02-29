using System.Diagnostics;
using Prototype.Implementations;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            var Jordan = new BasketballPlayer("Лучшая игра с мячом", "Jordan", "Чикагские Быки", 198, 98);

            stopwatch.Start();
            var Shaq = Jordan.MyClone();
            Shaq.SportsmanName = "Shaquille O'Neal";
            Shaq.Sport = "Лучшая игра с мячом";
            Shaq.ClubName = "Лейкерс";
            Shaq.Height = 216;
            Shaq.Weight = 147;
            Console.WriteLine($"Оригинал: {Jordan.ShowSportsman()}");
            Console.WriteLine($"Клон: {Shaq.ShowSportsman()}");
            Console.WriteLine($"Клонирование занимает= {stopwatch.ElapsedMilliseconds} милисекунд");
            Console.WriteLine();

            stopwatch.Start();
            var AnotherShaq = new BasketballPlayer("Лучшая игра с мячом", "Shaquille O'Neal", "Лейкерс", 216, 147);
            Console.WriteLine($"Оригинал: {Jordan.ShowSportsman()}");
            Console.WriteLine($"Клон: {AnotherShaq.ShowSportsman()}");
            Console.WriteLine($"Создание через конструктор занимает= {stopwatch.ElapsedMilliseconds} милисекунд");
            Console.WriteLine();

            stopwatch.Start();
            var OneMoreShaq = Jordan.MyMemberwiseclone();
            OneMoreShaq.SportsmanName = "Shaquille O'Neal";
            OneMoreShaq.Sport = "Лучшая игра с мячом";
            OneMoreShaq.ClubName = "Орландо Мэджик";
            OneMoreShaq.Height = 216;
            OneMoreShaq.Weight = 147;

            Console.WriteLine($"Оригинал: {Jordan.ShowSportsman()}");
            Console.WriteLine($"Клон: {OneMoreShaq.ShowSportsman()}");
            Console.WriteLine($"Создание через memberwiseclone  занимает= {stopwatch.ElapsedMilliseconds} милисекунд");
            Console.WriteLine();


            stopwatch.Start();
            var MyFirstTeam = new List<BasketballPlayer>();
            for (int i = 0; i < 1000000; i++)
            {
                var MyFirstShaq = Jordan.MyClone();
                Shaq.SportsmanName = "Shaquille O'Neal";
                Shaq.Sport = "Лучшая игра с мячом";
                Shaq.ClubName = "Лейкерс";
                Shaq.Height = 216;
                Shaq.Weight = 147;
                MyFirstTeam.Add(MyFirstShaq);
            }
            Console.WriteLine($"Создание через клонирование(MyClone) на миллион Шакилов занимает= {stopwatch.ElapsedMilliseconds} милисекунд");
            Console.WriteLine();

            stopwatch.Start();
            var MyTeam = new List<BasketballPlayer>();
            for (int i = 0; i < 1000000; i++)
            {
                var ShaqNumberThree = Jordan.MyMemberwiseclone();
                OneMoreShaq.SportsmanName = "Shaquille O'Neal";
                OneMoreShaq.Sport = "Лучшая игра с мячом";
                OneMoreShaq.ClubName = "Орландо Мэджик";
                OneMoreShaq.Height = 216;
                OneMoreShaq.Weight = 147;
                MyTeam.Add(ShaqNumberThree);
            }
            Console.WriteLine($"Создание через memberwiseclone на миллион Шакилов занимает= {stopwatch.ElapsedMilliseconds} милисекунд");
            Console.WriteLine();

            stopwatch.Start();
            var MyAnotherTeam = new List<BasketballPlayer>();
            for (int i = 0; i < 1000000; i++)
            {
                var ShaqNumberFour = new BasketballPlayer("Лучшая игра с мячом", "Shaquille O'Neal", "Лейкерс", 216, 147);
                MyAnotherTeam.Add(ShaqNumberFour);
            }
            Console.WriteLine($"Создание через конструктор на миллион Шакилов занимает= {stopwatch.ElapsedMilliseconds} милисекунд");

            Console.ReadLine();

        }
    }
}
