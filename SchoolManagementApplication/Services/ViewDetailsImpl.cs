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
      

        public void ViewStaffDetails(List<TeachingStaff> t, List<NonTeachingStaff> nt)
        {
     

            var teaching = getTeachingstaff(t);
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
            var nonteaching = getNonTeachingStaff(nt);


            Console.WriteLine(" OUR NON TEACHING STAFFS ");
            foreach (var x in nonteaching)
            {
                Console.WriteLine(x.name + " " + x.address.city+ " " +x.dept);

                Console.WriteLine();
               

            }









        }


        public List<TeachingStaff> getTeachingstaff(List<TeachingStaff> teaching)
        {
            TeachingStaff t = new TeachingStaff();

            List<TeachingStaff> p = t.GetAllTeachingStaffDetails(teaching);

            return p;

            
        }

        public List<NonTeachingStaff> getNonTeachingStaff( List<NonTeachingStaff> nt)
        {
            NonTeachingStaff t = new NonTeachingStaff();

            List<NonTeachingStaff> p = t.GetAllNonTeachingStaffDetails(nt);

            return p;


        }

        public void ViewPermanentStaffs(List<TeachingStaff> teach, List<NonTeachingStaff> nonteach)
        {
            var teaching = getTeachingstaff(teach);
            var nonteaching = getNonTeachingStaff(nonteach);

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




        public void ViewTemporaryStaffDetails(List<TeachingStaff> t , List<NonTeachingStaff> nt)
        {

         var result =   t.Where(x => x.type.Equals("Temporary")).Select(x =>
            new
            {
                n = x.name,
                sal = x.salary
            }

            );

            Console.WriteLine(" OUR TEACHING TEMPORARY STAFFS ");

           foreach(var x in result)
            {
                Console.WriteLine( x.n + "  " + x.sal);
            }



            var res = nt.Where(x => x.type.Equals("Temporary")).Select(x =>
          new
          {
              n = x.name,
              sal = x.salary
          }

            );

            Console.WriteLine(" OUR NON-TEACHING TEMPORARY STAFFS ");

            foreach (var x in res)
            {
                Console.WriteLine(x.n + "  " + x.sal);
            }




        }


        public void GroupAndSort(List<TeachingStaff> t , List<NonTeachingStaff> nt)
        {
            var res = t.GroupBy(x => x.type).Select(y =>
           new {
               k = y.Key,   // projecting key --> type in k 
               s = y.OrderBy(z => z.salary)  // projectionh TeachingStaff object value in s

            });



            //  var r =  res.OrderBy(k => k.OrderBy(x => x.salary));

            Console.WriteLine(" TEACHING STAFFS " );
            Console.WriteLine();

            foreach (var i in res)
            {
                Console.WriteLine( i.k +" -------> " + i.s.Count());
                foreach(var c in i.s)
                {
                    Console.WriteLine(c.name + " " +  c.type + " " + c.salary);
                }

            }


            Console.WriteLine("------------------------------------");

            Console.WriteLine("NON TEACHING ");

            Console.WriteLine();

            var result = nt.GroupBy(x => x.type).Select(y =>
            new
            {
                k = y.Key,
                staff = y.OrderBy(c => c.salary)

            }


            );

            foreach (var i in result)
            {
                Console.WriteLine(i.k + " -------> " + i.staff.Count());
                foreach (var c in i.staff)
                {
                    Console.WriteLine(c.name + " " + c.type + " " + c.salary);
                }

            }



        }



        public void ViewStudentDetails(List<Student> sl)
        {

            Student s = new Student();
            s.GetStudentDetailsStudents(sl);

           var studentdetails = sl.Select(x =>
            new
            {
                n = x.name, sec = x.section, r = x.roll
            }

            );

            foreach(var stu in studentdetails)
            {
                Console.WriteLine(stu.n + "  " + stu.sec + "  " + stu.r);
            }



        }






    }
}
