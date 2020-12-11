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

        public TeachingStaff()
        {

        }

        public TeachingStaff(string n, Address a, int sal, string t,List<Subjects> s)
        {
            name = n;
            address = a;
            salary = sal;
            type = t;
            sub = s;

        }



        public List<TeachingStaff> GetAllTeachingStaffDetails()
        {

            List<TeachingStaff> l = new List<TeachingStaff>()
            {
                new TeachingStaff("Arut Selvan" , new Address(){city= "Noida" , state = "Delhi",country= "India"},90000,"Permanent",
                       new List<Subjects>()
                       {
                           new Subjects("Java" , 12),
                           new Subjects("C" , 11),
                           new Subjects("DBMS" , 12),

                       } ),



                new TeachingStaff("Victo Sudha" , new Address(){city= "Noida" , state = "Delhi",country= "India"},90000,"Permanent",
                       new List<Subjects>()
                       {
                           new Subjects("Java" , 12),
                           new Subjects("C++" , 11),
                           new Subjects("OS" , 12),

                       } ),


                new TeachingStaff("Rabish" , new Address(){city= "Noida" , state = "Delhi",country= "India"},20000,"Temporary",
                       new List<Subjects>()
                       {
                           new Subjects("Snskrit" , 12),
                           new Subjects("C" , 11),
                           new Subjects("DBMS" , 12),

                       } ),



                new TeachingStaff("Amudha" , new Address(){city= "Noida" , state = "Delhi",country= "India"},70000,"Permanent",
                       new List<Subjects>()
                       {
                           new Subjects("Analytics" , 12),
                           new Subjects("Ruby" , 11),
                           new Subjects("Microprocessor" , 12),

                       } ),



                new TeachingStaff("Arun" , new Address(){city= "Noida" , state = "Delhi",country= "India"},40000,"Temporary",
                       new List<Subjects>()
                       {
                           new Subjects("OS" , 12),
                           new Subjects("C" , 11),
                           new Subjects("Aptitude" , 7),

                       } )


            };

            return l;



        }






    }
}
