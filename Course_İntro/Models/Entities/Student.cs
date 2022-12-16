using Course_İntro.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_İntro.Models.Entities
{
    internal class Student
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
            private set
            {
                _maidenName = value;
            }
        }
        public string Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; set; }

        public Gender Gender { get; set; }


        public Student(string firstName, string lastName, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;

            


            DateTime now = DateTime.Now;
            Id = now.ToString("fffff");


        }

        public Student(string firstName, string lastName, string maidenName) : this(firstName, lastName, Gender.Female)
        {
            MaidenName = maidenName;
        }




        /// <summary>
        /// 14.12.2022 cae çözümü
        /// </summary> 
        //public string GenderIsWomen(bool Women)
        //{

        //    if (Women)
        //    {
        //        string GetMaidenName = _maidenName;
        //        if (GetMaidenName != null)
        //        {
        //            return _maidenName;
        //        }
        //        else
        //        {
        //            return "not allowed!";
        //        }

        //    }

        //    else
        //    {
        //        return " men ";
        //    }
        //}












    }
}
