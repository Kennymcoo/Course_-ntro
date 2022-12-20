using Course_İntro.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_İntro.Models.Entities
{
    internal class Student : Person
    {     
        public Student(string firstName, string lastName, Gender gender) : base(firstName, lastName, gender)
        {
        }

        public Student(string firstName, string lastName, string maidenName) : base(firstName, lastName, maidenName)
        {
        }
    }
}
