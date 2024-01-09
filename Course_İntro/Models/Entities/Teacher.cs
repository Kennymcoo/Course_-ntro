﻿using Course_İntro.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_İntro.Models.Entities
{
    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName, Gender gender, byte[] picture) : base(firstName, lastName, gender, picture)
        {
        }

        public Teacher(string firstName, string lastName, string maidenName, byte[] picture) : base(firstName, lastName, maidenName, picture)
        {
        }
       
    }
}
