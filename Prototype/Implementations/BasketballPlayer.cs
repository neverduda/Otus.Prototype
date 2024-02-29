using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Abstractions;

namespace Prototype.Implementations
{
    /// <summary>
    /// Класс реализующий интерфейсы и абстрактный класс Sportsman. Олицетворяет Баскетболиста
    /// </summary>
    internal class BasketballPlayer : Sportsman<BasketballPlayer>, ICloneable
    {
        public BasketballPlayer(string sport, string sportsmanName, string clubName, int weight, int height)
            : base(sport, sportsmanName, clubName, weight, height)
        {
        }

        public override BasketballPlayer MyClone()
        {
            return new BasketballPlayer(Sport, SportsmanName, ClubName, Weight, Height);
        }

        public object Clone()
        {
            return MyClone();
        }

        public override BasketballPlayer MyMemberwiseclone()
        {
            return (BasketballPlayer)MemberwiseClone();
        }
    }
}
