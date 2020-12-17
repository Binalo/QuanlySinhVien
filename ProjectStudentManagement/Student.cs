using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudentManagement
{
    class Student
    {
        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        public SEXUAL Gender { get; set; }

        public static Student CreateStudent()
        {
            Student student = new Student
            {
                ID = "17T1021034",
                FirstName = "Nguyen",
                LastName = "Dien",
                DateOfBirth = new DateTime(2002, 02, 22),
                PlaceOfBirth = "Hue",
                Gender = SEXUAL.Male
            };
            return student;
        }

    }
    public enum SEXUAL
    {
        Male, Female, Other
    }
}
