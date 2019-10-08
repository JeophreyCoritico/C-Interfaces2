using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WeaponClass;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input weapon type");
            Console.WriteLine("1 - Melee");
            Console.WriteLine("2 - Ranged");
            Console.WriteLine("3 - Magic");
            Console.WriteLine();

            ConsoleKeyInfo MeleeMenu;

            MeleeMenu = Console.ReadKey();

            if (MeleeMenu.Key == ConsoleKey.D1)
            {
                Console.WriteLine("input base melee damage");
                Console.WriteLine();
                int userBD = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("input base melee range");
                Console.WriteLine();
                int userBR = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("input base melee crit damage");
                Console.WriteLine();
                int userBCD = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Melee newMelee = new Melee(userBD, userBR, userBCD, 85);
                Console.WriteLine();
                string meleeResult = newMelee.meleeAttack();
                Console.WriteLine(meleeResult);
            }
        }
    }
}
