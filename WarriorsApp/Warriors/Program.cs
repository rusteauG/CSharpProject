using System;
using WarriorWars;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    internal class Program
    {
        static Random rng = new Random();   
        static void Main(string[] args)
        {
            
            Warriors goodGuy = new Warriors("bob", Faction.GoodGuy);
            Warriors badGuy = new Warriors("nev", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if(rng.Next(0,10) < 5 )
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }

        }
    }
}
