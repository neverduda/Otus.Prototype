using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Abstractions
{
    /// <summary>
    /// Базовый абстрактный класс олицетворяющий Спортсмена, на базе данного класса можно создать спортсмена для разных видов спорта.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Sportsman<T> : IMyCloneable<T>
    {
        public Sportsman(string sport, string sportsmanName, string clubName, int weight, int height)
        {
            Sport = sport;
            SportsmanName = sportsmanName;
            ClubName = clubName;
            Weight = weight;
            Height = height;

        }

        public string Sport { get; set; }

        public string SportsmanName { get; set; }

        public string ClubName { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public string ShowSportsman()
        {
            return $"Вид спорта: {Sport}, Имя: {SportsmanName}, Клуб: {ClubName}, Вес: {Weight}, Рост: {Height} ";
        }

        public abstract T MyClone();

        public abstract T MyMemberwiseclone();
    }
}
