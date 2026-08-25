using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_WarriorWars_Udemy.Enum;
using _6_WarriorWars_Udemy.Equipment;

namespace _6_WarriorWars_Udemy
{
    class Warrior
    {
        private int goodGuyStartingHealth;
        private int badGuyStartingHealth;

        private Faction faction;

        private int health;
        private string name;
        private bool isAlive;

        
        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;
    }
}
