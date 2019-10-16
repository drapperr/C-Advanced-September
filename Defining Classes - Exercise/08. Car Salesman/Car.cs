using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = 0;
            this.color = "n/a";
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine.Model}:");
            sb.AppendLine($"    Power: {Engine.Power}");

            if (Engine.Displacement == 0) sb.AppendLine($"    Displacement: n/a");
            else sb.AppendLine($"    Displacement: {Engine.Displacement}");

            sb.AppendLine($"    Efficiency: {Engine.Efficiency}");

            if (Weight == 0) sb.AppendLine($"  Weight: n/a");
            else sb.AppendLine($"  Weight: {Weight}");

            sb.Append($"  Color: {Color}");

            return sb.ToString();
        }
    }
}
