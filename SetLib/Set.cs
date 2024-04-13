using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetLib
{
    public class Set
    {
        public List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        public Set(IEnumerable<int> items)
        {
            elements = new List<int>(items);
        }

        public int this[int i]
        {
            get => elements[i];
            set => elements[i] = value;
        }

        public static Set operator +(Set set, int item)
        {
            if (!set.elements.Contains(item))
            {
                set.elements.Add(item);
            }
            return set;
        }

        public static Set operator +(Set a, Set b)
        {
            var result = new Set(a.elements);
            foreach (var item in b.elements)
            {
                if (!result.elements.Contains(item))
                {
                    result.elements.Add(item);
                }
            }
            return result;
        }

        public static Set operator *(Set a, Set b)
        {
            var result = new Set();
            foreach (var item in a.elements)
            {
                if (b.elements.Contains(item))
                {
                    result.elements.Add(item);
                }
            }
            return result;
        }

        public static explicit operator int(Set set)
        {
            return set.elements.Count;
        }

        public static bool operator false(Set set)
        {
            return set.elements.Count < 1 || set.elements.Count > 10;
        }

        public static bool operator true(Set set)
        {
            return set.elements.Count >= 1 && set.elements.Count <= 10;
        }

        public class Owner
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Organization { get; set; }

            public Owner(int id, string name, string organization)
            {
                Id = id;
                Name = name;
                Organization = organization;
            }
        }

        public class Date
        {
            public DateTime CreationDate { get; set; }

            public Date()
            {
                CreationDate = DateTime.Now;
            }
        }

        public Owner owner;
        public Date creationDate;

        public Set(int ownerId, string ownerName, string ownerOrganization) : this()
        {
            owner = new Owner(ownerId, ownerName, ownerOrganization);
            creationDate = new Date();
        }
    }
}
