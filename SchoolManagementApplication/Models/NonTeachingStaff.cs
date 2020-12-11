using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication
{
    class NonTeachingStaff : Staff
    {
        public string dept;
        public string type;

        public NonTeachingStaff()
        {

        }


        public NonTeachingStaff(string n, Address a,int sal,string d,string t)
        {
            name = n;
            address = a;
           salary = sal;
            dept = d;
            type = t;

        }

        public List<NonTeachingStaff> GetAllNonTeachingStaffDetails()
        {
            List<NonTeachingStaff> l = new List<NonTeachingStaff>()
            {
            
                new NonTeachingStaff("Dubey", new Address(){ city = "Noida", state="Delhi", country = "India"},
                           20000,"Accounts","Permanent"),

                 new NonTeachingStaff("Pramod", new Address(){ city = "Nasik", state="Delhi", country = "India"},
                           21000,"Accounts","Permanent"),

                  new NonTeachingStaff("Amit", new Address(){ city = "Noida", state="Delhi", country = "India"},
                           10000,"Security","Temporary"),

                   new NonTeachingStaff("Raju", new Address(){ city = "Noida", state="Delhi", country = "India"},
                           5000,"Maintainence","Temporary")


            };

            return l;


        }


    }
}
