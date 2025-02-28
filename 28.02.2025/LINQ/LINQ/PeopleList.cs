using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> people = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Joonas",
                Age = 33,
                GenderId = Guid.Parse("04acd742-caf4-4325-82e0-6f357f869374")
            },
            new People()
            {
                Id = 2,
                Name = "Moona",
                Age = 21,
                GenderId = Guid.Parse("b5984042-4499-409e-adc5-b741e68d2ac7")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("04acd742-caf4-4325-82e0-6f357f869374")
            },
            new People()
            {
                Id = 4,
                Name = "Jane",
                Age = 20,
                GenderId = Guid.Parse("b5984042-4499-409e-adc5-b741e68d2ac7")
            },
            new People()
            {
                Id = 5,
                Name = "Mari",
                Age = 17,
                GenderId = Guid.Parse("b5984042-4499-409e-adc5-b741e68d2ac7")
            },
            new People()
            {
                Id = 6,
                Name = "Mari",
                Age = 33,
                GenderId = Guid.Parse("b5984042-4499-409e-adc5-b741e68d2ac7")
            }
        };
    }
}
