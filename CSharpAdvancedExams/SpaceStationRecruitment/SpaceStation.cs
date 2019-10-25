using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;
        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Astronaut>();
        }

        public string Name { get;private set; }
        public int Capacity { get;private set; }

        public int Count => data.Count;

        public void Add(Astronaut astronaut)
        {
            if (this.Count < this.Capacity)
            {
                data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            int count =data.RemoveAll(x => x.Name == name);

            if (count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Astronaut GetOldestAstronaut()
        {
            return data.OrderByDescending(a => a.Age).FirstOrDefault();
        }

        public Astronaut GetAstronaut(string name)
        {
            return data.Where(a => a.Name == name).FirstOrDefault();
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");
            foreach (var astronaut in this.data)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
