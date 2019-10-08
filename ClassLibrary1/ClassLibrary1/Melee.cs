using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponClass
{
    public class Melee : Weapon, IhitOrMiss
    {
        public Melee(int BD, int BR, int BCD, int CTH): base(BD, BR, BCD, CTH)
        {
            chanceToHit = 85;
        }

        public void hit()
        {
            Console.WriteLine("Success " + baseDamage);
        }

        public void miss()
        {
            Console.WriteLine("Fail ");
        }

        public void meleeAttack()
        {
            if (baseRange < chanceToHit)
            {
                miss();
            }
            else
            {
                Random rand = new Random();
                int randNum = rand.Next(0, 100);
                if (randNum < chanceToHit)
                {
                    miss();
                }
                else
                {
                    hit();
                }
            }
        }
    }
}
