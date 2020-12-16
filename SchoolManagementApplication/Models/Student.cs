using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication
{
    class Student : Person
    {
        public int standard;
        public  char section;
        public int roll;

        public Student(string n, Address ad, int std, char sec, int r )
        {
            name = n;
            address = ad;
            standard = std;
            section = sec;
            roll = r;
        }
               

        public Student()
        {

        }

        public List<Student> GetStudentDetailsStudents(List<Student> sl)
        {

            sl.Add(
                new Student("Hari", new Address() { city = " Noida ", state = "Delhi", country = "India" },
                12, 'A', 41)

                );

            sl.Add(
                new Student("Krish", new Address() { city = " Noida ", state = "Delhi", country = "India" },
                12, 'A', 11)

                );

            sl.Add(
                new Student("Rao", new Address() { city = " Noida ", state = "Delhi", country = "India" },
                11, 'B', 12)

                );

            sl.Add(
                new Student("Ram", new Address() { city = " Noida ", state = "Delhi", country = "India" },
                12, 'C', 49)

                );

            return sl;


        }









    }
}
