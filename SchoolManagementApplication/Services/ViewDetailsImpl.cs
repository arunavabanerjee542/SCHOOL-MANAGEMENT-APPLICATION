using SchoolManagementApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication.Services
{
    class ViewDetailsImpl : ViewDetailsIntf
    {
      

        public void ViewStaffDetails()
        {
            var teaching = getTeachingstaff();
            Console.WriteLine(" OUR TEACHING STAFFS " );
            foreach(var x in teaching)
            {
                Console.WriteLine(x.name + " " + x.address.city);

                foreach(var y in x.sub)
                {
                    Console.WriteLine(y.subname +" "+ y.standard);
                }

                Console.WriteLine();
                    
            }

            Console.WriteLine();
            var nonteaching = getNonTeachingStaff();


            Console.WriteLine(" OUR NON TEACHING STAFFS ");
            foreach (var x in nonteaching)
            {
                Console.WriteLine(x.name + " " + x.address.city+ " " +x.dept);

                Console.WriteLine();
               

            }









        }


        public List<TeachingStaff> getTeachingstaff()
        {
            TeachingStaff t = new TeachingStaff();

            List<TeachingStaff> p = t.GetAllTeachingStaffDetails();

            return p;

            
        }

        public List<NonTeachingStaff> getNonTeachingStaff()
        {
            NonTeachingStaff t = new NonTeachingStaff();

            List<NonTeachingStaff> p = t.GetAllNonTeachingStaffDetails();

            return p;


        }

        public void ViewPermanentStaffs()
        {
            var teaching = getTeachingstaff();
            var nonteaching = getNonTeachingStaff();

          IEnumerable<TeachingStaff> t =  teaching.Where(x => x.type.Equals("Permanent"));
            IEnumerable<NonTeachingStaff> nt = nonteaching.Where(x => x.type == "Permanent");

            Console.WriteLine(" OUR PERMANANT STAFFS ");

            Console.WriteLine();

            Console.WriteLine(" TEACHING ");

            foreach (var x in t)
            {
                Console.WriteLine(x.name + " " +  x.salary);

                Console.WriteLine();


            }

            Console.WriteLine(" NON TEACHING " );

            foreach (var x in nt)
            {
                Console.WriteLine(x.name + " "  + x.salary);

                Console.WriteLine();


            }


        }
    }
}
