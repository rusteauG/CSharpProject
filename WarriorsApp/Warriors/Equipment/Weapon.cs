using WarriorWars;
using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        private const  int GOOD_GUY_DAMAGE =5;
        private const int BAD_GUY_DAMAGE=5;
        private int _damage;

    
    public int Damage { get { return _damage; } }


        public Weapon (Faction faction)
        {
            switch(faction)
            {
                case Faction.GoodGuy:
                   _damage = GOOD_GUY_DAMAGE; break;
                case Faction.BadGuy:
                    _damage = BAD_GUY_DAMAGE; break;
            default:break;
            }
        }

    }

   
}