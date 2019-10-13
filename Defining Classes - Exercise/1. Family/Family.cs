using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people = new List<Person>();

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            var oldestMember = this.People[0];

            foreach (var member in this.People)
            {
                if (member.Age > oldestMember.Age)
                {
                    oldestMember = member;
                }
            }
            return oldestMember;
        }

        public List<Person> GetMoreThen30()
        {
            var members = new List<Person>();

            foreach (var member in this.people)
            {
                if (member.Age>30)
                {
                    members.Add(member);
                }
            }
            return members.OrderBy(x=>x.Name).ToList();
        }
    }
}
