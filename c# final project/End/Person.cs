using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End
{
   abstract class Person
    {
        private string firstName;
        private string lastName;
        private readonly  string id;
        public  string Id
        {
            get { return id; }
        }
        private DateTime birthDate;
        public string FirstName { get { return firstName;
            }
            set { if (value.Length > 2) firstName = value; }
        }
        public string LastName { get { return lastName; }
            set
            {
                if (value.Length > 2)
                {
                    lastName = value;
                }
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                if (value < birthDate)
                {
                    birthDate = value;
                }
            }
        }
        public Person(string id, DateTime birthDate, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            this.id = id;
            BirthDate = birthDate;

        }
        public Person(string id):this(id,default(DateTime),"","")
        {
            
        }


    }
}
