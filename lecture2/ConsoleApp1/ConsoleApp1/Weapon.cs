using System;

namespace ConsoleApp1
{
    public abstract class Weapon
    {
        public string BrandName { get; protected set; }
        public IChangeDamageStrategy Damage { get; protected set; }
        public float CriticalChance { get; set; }

        public abstract void Attack();
    }

    public interface IChangeDamageStrategy
    {
        int GetDamage();
    }

    public interface IChangeDamagable
    {
        void ChangeDamage();
    }

    public class TenPointsChangeDamageStrategy : IChangeDamageStrategy
    {
        public int GetDamage()
        {
            return 10;
        }
    }

    public class TwentyPointsChangeDamageStrategy : IChangeDamageStrategy
    {
        public int GetDamage()
        {
            return 20;
        }
    }

    public class ZeroPointsChangeDamageStrategy : IChangeDamageStrategy
    {
        public int GetDamage()
        {
            return 0;
        }
    }

    public class Gun : Weapon, IChangeDamagable
    {
        public Gun()
        {
            BrandName = "Валера";
            Damage = new TenPointsChangeDamageStrategy();
            CriticalChance = 0.25f;
        }

        public override void Attack()
        {
            Console.WriteLine("Пиф паф");
        }

        public void ChangeDamage()
        {
            Console.WriteLine($"{Damage} урона");
        }
    }

    public class Knife : Weapon, IChangeDamagable
    {
        public Knife()
        {
            BrandName = "Милана";
            Damage = new TenPointsChangeDamageStrategy();
            CriticalChance = 0.5f;
        }

        public override void Attack()
        {
            Console.WriteLine("Шинк шинк");
        }

        public void ChangeDamage()
        {
            Console.WriteLine($"{Damage} урона");
        }
    }

    public class NuclearWeapon : Weapon, IChangeDamagable
    {
        public NuclearWeapon()
        {
            BrandName = "Чебурашка";
            Damage = new TwentyPointsChangeDamageStrategy();
            CriticalChance = 1f;
        }

        public override void Attack()
        {
            Console.WriteLine("БООООМ БОМ");
        }

        public void ChangeDamage()
        {
            Console.WriteLine($"{Damage} урона");
        }
    }

    public class Stick : Weapon, IChangeDamagable
    {
        public Stick()
        {
            BrandName = "Люси";
            Damage = new TwentyPointsChangeDamageStrategy();
            CriticalChance = 1f;
        }

        public override void Attack()
        {
            Console.WriteLine("ШМЯК");
        }

        public void ChangeDamage()
        {
            Console.WriteLine($"{Damage} урона");
        }
    }

    
    public class WaterGun : Weapon
    {
        public WaterGun()
        {
        }

        public override void Attack()
        {
            Console.WriteLine("Льется вода");
        }
    }
}
