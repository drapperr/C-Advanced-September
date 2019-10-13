using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            FirstDate = firstDate;
            SecondDate = secondDate;

            int[] firstDateInfo = firstDate
                .Split()
                .Select(int.Parse)
                .ToArray();

            DateTime firstDateTime = new DateTime(firstDateInfo[0], firstDateInfo[1], firstDateInfo[2]);

            int[] secondDateInfo = secondDate
                .Split()
                .Select(int.Parse)
                .ToArray();

            DateTime secondDateTime = new DateTime(secondDateInfo[0], secondDateInfo[1], secondDateInfo[2]);

            var diff = secondDateTime - firstDateTime;
            Console.WriteLine(Math.Abs(diff.Days));
        }

        public string FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }

        public string SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }

    }
}
