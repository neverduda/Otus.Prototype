using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Abstractions;

namespace Prototype.Implementations
{
    /// <summary>
    /// Класс реализующий интерфейсы и абстрактный класс Sportsman. Олицетворяет Волейболиста
    /// </summary>
    internal class VolleyballPlayer : Sportsman<VolleyballPlayer>, ICloneable
    {
        public VolleyballPlayer(string sport, string sportsmanName, string clubName, int weight, int height)
           : base(sport, sportsmanName, clubName, weight, height)
        {
        }

        public override VolleyballPlayer MyClone()
        {
            return new VolleyballPlayer(Sport, SportsmanName, ClubName, Weight, Height);
        }

        public object Clone()
        {
            return MyClone();
        }

        public override VolleyballPlayer MyMemberwiseclone()
        {
            return (VolleyballPlayer)MemberwiseClone();
        }
    }
}
