
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Warriors;
using WarriorWars;
using WarriorWars.Enum;
using WarriorWars.Equipment;

namespace WarriorWars
{
    class Warriors
    {

        private int _health;
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        private string _name;

        private bool _isAlive;
        public bool IsAlive
        { get { return _isAlive; } }



        private Weapon weapon;
        private Armour armour;
        private readonly Faction FACTION;

        public Warriors(string name, Faction faction)
        {
            _name = name;
            FACTION = faction;

            _isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armour = new Armour(faction);
                    _health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armour = new Armour(faction);
                    _health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warriors enemy)
        {
            int damage = weapon.Damage / enemy.armour.ArmourPoints;
            enemy._health -= damage;

            AttackResult(enemy, damage);
            Thread.Sleep(500);
        }

        private void AttackResult(Warriors enemy, int damage)
        {
            if (enemy._health <= 0)
            {
                enemy._isAlive = false;
                Tools.ColorWriteLine($"{enemy._name} is Dead!(¬_¬\")  and {_name} is Victorious💘", ConsoleColor.Red);
            }
            else
            {
                Tools.ColorWriteLine($"{_name} Attacked {enemy._name}.\n" +
                    $"{damage} Damage was inflicted to {enemy._name}\n" +
                    $"Remaning Health of {enemy._name} is {enemy._health} ", ConsoleColor.Green);
                Console.WriteLine();
            }
        }
    }
}
