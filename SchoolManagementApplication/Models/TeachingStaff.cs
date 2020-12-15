using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication
{
    class TeachingStaff : Staff
    {
       public  List<Subjects> sub;
        public string type;
     //  public List<TeachingStaff> ListOfTeachingStaffs = new List<TeachingStaff>();

        public TeachingStaff()
        {
            
                
            
        }

        public  TeachingStaff(string n, Address a, int sal, string t,List<Subjects> s,string category)
        {
            name = n;
            address = a;
            salary = sal;
            type = t;
            sub = s;
            category = TeachingOrNonTeaching;

        }



        public  List<TeachingStaff> GetAllTeachingStaffDetails(List<TeachingStaff> t)
        {



         TeachingStaff t1 =  new TeachingStaff("Arut Selvan", new Address() { city = "Noida", state = "Delhi", country = "India" }, 90000, "Permanent",
                     new List<Subjects>()
                     {
                           new Subjects("Java" , 12),
                           new Subjects("C" , 11),
                           new Subjects("DBMS" , 12),

                     }, "Teaching");



            TeachingStaff t2=new TeachingStaff("Victo Sudha", new Address() { city = "Noida", state = "Delhi", country = "India" }, 90000, "Permanent",
                       new List<Subjects>()
                       {
                           new Subjects("Java" , 12),
                           new Subjects("C++" , 11),
                           new Subjects("OS" , 12),

                       }, "Teaching");


            TeachingStaff t3 = new TeachingStaff("Rabish", new Address() { city = "Noida", state = "Delhi", country = "India" }, 20000, "Temporary",
                       new List<Subjects>()
                       {
                           new Subjects("Snskrit" , 12),
                           new Subjects("C" , 11),
                           new Subjects("DBMS" , 12),

                       }, "Teaching");



            TeachingStaff t4 = new TeachingStaff("Amudha", new Address() { city = "Noida", state = "Delhi", country = "India" }, 70000, "Permanent",
                      new List<Subjects>()
                      {
                           new Subjects("Analytics" , 12),
                           new Subjects("Ruby" , 11),
                           new Subjects("Microprocessor" , 12),

                      }, "Teaching");



            TeachingStaff t5 = new TeachingStaff("Arun", new Address() { city = "Noida", state = "Delhi", country = "India" }, 40000, "Temporary",
                       new List<Subjects>()
                       {
                           new Subjects("OS" , 12),
                           new Subjects("C" , 11),
                           new Subjects("Aptitude" , 7),

                       }, "Teaching");



            t.Add(t1);
           t.Add(t2);
            t.Add(t3);
           t.Add(t4);
            t.Add(t5);



            return t;

    



        }








    }
}
