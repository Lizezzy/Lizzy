using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTHK_students
{
    public class Group
    {
        public List<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
        }

        public void AddToGroup (Student student, string isStudying)
        {
            Students.Add(student);
        }
    }
}
