using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Abstractions;

namespace Prototype.Implementations
{
    /// <summary>
    /// Класс реализующий интерфейсы и абстрактный класс Sportsman. Олицетворяет Футболиста
    /// </summary>
    internal class FootballPlayer : Sportsman<FootballPlayer>, ICloneable
    {
        public FootballPlayer(string sport, string sportsmanName, string clubName, int weight, int height)
           : base(sport, sportsmanName, clubName, weight, height)
        {
        }

        public override FootballPlayer MyClone()
        {
            return new FootballPlayer(Sport, SportsmanName, ClubName, Weight, Height);
        }

        public object Clone()
        {
            return MyClone();
        }

        public override FootballPlayer MyMemberwiseclone()
        {
            return (FootballPlayer)MemberwiseClone();
        }
    }
}
