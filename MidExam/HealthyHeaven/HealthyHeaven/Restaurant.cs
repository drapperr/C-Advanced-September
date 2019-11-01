using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Restaurant
    {
        private List<Salad> data;

        public Restaurant(string name)
        {
            Name = name;
            data = new List<Salad>();
        }

        public string Name { get; set; }

        public void Add(Salad salad)
        {
            data.Add(salad);
        }

        public bool Buy(string name)
        {
            if (data.RemoveAll(x=>x.Name==name)==0)
            {
                return false;
            }
            return true;
        }

        public Salad GetHealthiestSalad()
        {
            return data.OrderBy(x => x.GetTotalCalories()).FirstOrDefault();
        }

        public string GenerateMenu()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Name} have {data.Count} salads:");

            foreach (var salad in data)
            {
                sb.AppendLine(salad.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
