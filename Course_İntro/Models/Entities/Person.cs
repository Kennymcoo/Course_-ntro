using Course_İntro.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_İntro.Models.Entities
{
    public class Person
    {
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(MaidenName))
                {
                    return $"{FirstName} {LastName}";
                }
                else
                {
                    return $"{FirstName} {LastName} ({MaidenName})";
                }
            }
        }
        private string _maidenName;
        public string MaidenName
        {
            get
            {
                return _maidenName;
            }
             set
            {
                _maidenName = value;
            }
        }
        public string Id { get; set; }
        public string FirstName { get;  set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public byte[] Picture { get; set; }

        public Person(string firstName, string lastName, Gender gender, byte[] picture)
        {
            Picture = picture;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateTime now = DateTime.Now;
            Id = now.ToString("fffff");
        }

        public Person(string firstName, string lastName, string maidenName, byte[] picture) : this(firstName, lastName, Gender.Female,picture)
        {
            MaidenName = maidenName;
        }
        //xml export için
        public Person() 
        { 
        }
    }
}
