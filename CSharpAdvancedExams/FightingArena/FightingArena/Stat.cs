using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Stat
    {
        public Stat(int strangth, int flexibility, int agility, int skills, int inteligence)
        {
            Strangth = strangth;
            Flexibility = flexibility;
            Agility = agility;
            Skills = skills;
            Inteligence = inteligence;
        }

        public int Strangth { get; set; }
        public int Flexibility { get; set; }
        public int Agility { get; set; }
        public int Skills { get; set; }
        public int Inteligence { get; set; }

    }
}
