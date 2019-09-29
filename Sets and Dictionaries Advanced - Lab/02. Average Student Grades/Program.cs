using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                var studentArgs = Console.ReadLine().Split();
                var name = studentArgs[0];
                var grade = double.Parse(studentArgs[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }
            foreach (var student in grades)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(' ',student.Value.Select(x=>$"{x:F2}"))} (avg: {student.Value.Average():F2})");
            }
        }
    }
}
