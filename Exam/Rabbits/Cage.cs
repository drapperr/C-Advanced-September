using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Rabbit>();
        }
        public int Count => data.Count;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Rabbit rabbit)
        {
            if (data.Count < Capacity)
            {
                data.Add(rabbit);
            }
        }
        public bool RemoveRabbit(string name)
        {
            if (data.RemoveAll(x => x.Name == name) > 0)
            {
                return true;
            }
            return false;
        }
        public void RemoveSpecies(string species)
        {
            data.RemoveAll(x => x.Species == species);
        }

        public Rabbit SellRabbit(string name)//!!!!!!
        {
            foreach (var rabbit in data)
            {
                if (rabbit.Name == name && rabbit.Available == true)
                {
                    rabbit.Available = false;
                    return rabbit;
                }
            }
            return null;//!!!!!!!!
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            var rabbits = new List<Rabbit>();

            foreach (var rabbit in data)
            {
                if (rabbit.Species == species && rabbit.Available == true)//!!!!!!!!!
                {
                    rabbit.Available = false;
                    rabbits.Add(rabbit);
                }
            }
            return rabbits.ToArray();
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in data)
            {
                if (rabbit.Available)
                {
                    sb.AppendLine(rabbit.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
