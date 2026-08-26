using _6_WarriorWars_Udemy.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_WarriorWars_Udemy.Equipment
{
    class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;

        private int damage;

        public int Damage
        {
            get { return damage; }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}
