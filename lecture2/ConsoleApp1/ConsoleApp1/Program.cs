using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        // MSDN, Metanit.com - Множество туториалов, понятная документация!!
        static void Main(string[] args)
        {
            var weapons = new List<Weapon>
            {
                new Gun(),
                new Knife(),
                new Stick(),
                new NuclearWeapon(),
                new WaterGun()
            };

            foreach (var weapon in weapons.OrderByDescending(x => x.Damage))
            {
                weapon.Attack();

                if (weapon is IChangeDamagable)
                {
                    var weaponChangeDamagable = weapon as IChangeDamagable;
                    weaponChangeDamagable.ChangeDamage();
                }
            }

            Console.ReadKey();
        }
    }
}
