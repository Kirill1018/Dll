using System;
using System.Diagnostics;
using System.Threading;
using static System.Console;
namespace DLL
{
    public interface Weapon { void NewWeapon(); }
    public class IWeapon : Weapon
    {
        Weapon weapon = new IWeapon();
        public IWeapon() { }
        Pistol pistol = new Pistol();
        Shotgun shotgun = new Shotgun();
        Rifle rifle = new Rifle();
        public int Damage { get; set; } = 0;//исходное значение урона
        public int Fire_rate { get; set; } = 0;//исходное значение скорости
        public int Interval { get; set; } = 0;//исходное значение промежутка между выстрелами
        public void NewWeapon()
        {
            WriteLine("choose a weapon type: a gun, a shotgun or a rifle");
            string name = ReadLine();
            if (name == "gun") { pistol.Gun(name); }
            else if (name == "shotgun") shotgun._Shotgun(name);
            else if (name == "rifle") rifle._Rifle(name);
            else WriteLine("error");
        }
        internal class Pistol : IWeapon
        {
            public Pistol() { }
            public void Gun(string name)
            {
                IWeapon iweapon = new IWeapon();
                WriteLine(name);
                iweapon.Damage = 1;
                iweapon.Fire_rate = 120;
                iweapon.Interval = 60 / iweapon.Fire_rate * 1000;
                WriteLine("a damage=", iweapon.Damage);
                WriteLine("a fire rate=", iweapon.Fire_rate);
                int iterator = 0;//счётчик
                while (iterator < 10)
                {
                    WriteLine("a shot");
                    Thread.Sleep(iweapon.Interval);
                    iterator++;
                }
                WriteLine("shots ended");
            }
        }
        internal class Shotgun : IWeapon
        {
            public Shotgun() { }
            public void _Shotgun(string name)
            {
                IWeapon iweapon = new IWeapon();
                iweapon.Damage = 2;
                iweapon.Fire_rate = 60;
                iweapon.Interval = 60 / iweapon.Fire_rate * 1000;
                WriteLine("a damage=", iweapon.Damage);
                WriteLine("a fire rate=", iweapon.Fire_rate);
                int iterator = 0;//счётчик
                while (iterator < 5)
                {
                    WriteLine("a shot");
                    Thread.Sleep(iweapon.Interval);
                    iterator++;
                }
                WriteLine("shots ended");
            }
        }
        internal class Rifle : IWeapon
        {
            public Rifle() { }
            public void _Rifle(string name)
            {
                IWeapon iweapon = new IWeapon();
                iweapon.Damage = 3;
                iweapon.Fire_rate = 120;
                iweapon.Interval = 60 / iweapon.Fire_rate * 1000;
                WriteLine("a damage=", iweapon.Damage);
                WriteLine("a firing rate=", iweapon.Fire_rate);
                int iterator = 0;//счётчик
                while (iterator < 10)
                {
                    WriteLine("a shot");
                    Thread.Sleep(iweapon.Interval);
                    iterator++;
                }
                WriteLine("shots ended");
            }
        }
    }
}