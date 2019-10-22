using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            return GetWeaponPower() + GetStatPower();
        }

        public int GetWeaponPower()
        {
            return Weapon.Size + Weapon.Solidity + Weapon.Sharpness;
        }

        public int GetStatPower()
        {
            return Stat.Strangth + Stat.Flexibility + Stat.Agility + Stat.Skills + Stat.Inteligence;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Name} - {GetTotalPower()}");
            sb.AppendLine($"  Weapon Power: {GetWeaponPower()}");
            sb.Append($"  Stat Power: {GetStatPower()}");

            return sb.ToString();
        }
    }
}
