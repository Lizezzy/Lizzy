using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHK_students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IsStudying { get; set; }

        public Student(string firstName, string lastName, string isStudying)
        {
            FirstName = firstName;
            LastName = lastName;
            IsStudying = isStudying;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Studying status: {IsStudying}";
        }
    }


}
