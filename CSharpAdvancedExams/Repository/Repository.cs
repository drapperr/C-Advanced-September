using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> data;
        public int Count { get; private set; }
        public Repository()
        {
            data = new Dictionary<int, Person>();
        }
        public void Add(Person person)
        {
            data.Add(Count, person);
            Count++;
        }
        public Person Get(int id)
        {
            return data[id];
        }
        public bool Update(int id, Person newPerson)
        {
            if (!data.ContainsKey(id))
            {
                return false;
            }

            data[id] = newPerson;
            return true;
        }
        public bool Delete(int id)
        {
            if (!data.ContainsKey(id))
            {
                return false;
            }

            data.Remove(id);
            Count--;
            return true;
        }
    }
}
