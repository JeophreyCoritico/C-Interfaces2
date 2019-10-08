using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClass
{
    public class Weapon
    {
        public int baseDamage { get; set; }
        public int baseRange{ get; set; }
        public int baseCritDamage{ get; set; }

        public int chanceToHit { get; set; }

        public Weapon(int BD, int BR, int BCD, int CTH)
        {
            baseDamage = BD;
            baseRange = BR;
            baseCritDamage = BCD;
            chanceToHit = CTH;
        }

        public void Poke()
        {
            baseDamage = 1;
        }

    }
}
