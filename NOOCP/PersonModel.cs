using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOOCP
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PersonModel(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
