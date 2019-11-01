using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private List<Vegetable> vegetables;

        public Salad(string name)
        {
            Name = name;
            vegetables = new List<Vegetable>();
        }

        public string Name { get; set; }

        public int GetTotalCalories()
        {
            return vegetables.Sum(x => x.Calories);
        }
        public int GetProductCount()
        {
            return vegetables.Count();
        }
        public void Add(Vegetable product)
        {
            vegetables.Add(product);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"* Salad {Name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            foreach (var vegetable in vegetables)
            {
                sb.AppendLine(vegetable.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
