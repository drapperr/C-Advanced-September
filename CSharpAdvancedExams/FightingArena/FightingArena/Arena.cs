using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            Name = name;
            gladiators = new List<Gladiator>();
        }

        public string Name { get; private set; }

        public int Count => gladiators.Count;

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            gladiators.RemoveAll(x => x.Name == name);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.OrderByDescending(x => x.GetStatPower()).FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.OrderByDescending(x => x.GetWeaponPower()).FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.OrderByDescending(x => x.GetTotalPower()).FirstOrDefault();
        }

        public override string ToString()
        {
            return $"{Name} - {Count} gladiators are participating.";
        }
    }
}
