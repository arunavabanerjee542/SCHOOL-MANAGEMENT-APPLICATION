using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication.Models
{
    class Administrator
    {  

        public void InsertStaff(List<TeachingStaff> t, List<NonTeachingStaff> nt)
        {


            string category = GetCategory();
            if (category.Equals("Teaching"))
            {
                TeachingStaff staff = new TeachingStaff();

              //  staff.TeachingOrNonTeaching = category;

                List<Subjects> subb = GetSubjects();
               // staff.sub = subb;

                string n = getName();
               // staff.name = n;

                Address ad = getAddress();
               // staff.address = ad;

                string tpe = GetStaffType();
              //  staff.type = tpe;

                int sal = GetSalary();
              //  staff.salary = sal;

            staff.AddTeachingStaffs(new TeachingStaff()
                {
                  address = ad, TeachingOrNonTeaching = category, name=n, salary= sal, sub= subb, type = tpe
                }, t);





            }
            /*
            else
            {
                staff = new NonTeachingStaff();
            }

    */
            
            

           






        }


        public string getName()
        {
            Console.WriteLine("Enter staff Name");
            return Console.ReadLine();
        }

        public Address getAddress()
        {
            Console.WriteLine("Enter staff Adderess");

            Address ad = new Address();

            Console.WriteLine("city :");
            try
            {
                ad.city = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("INVALID INPUT");
                getAddress();
            }


            Console.WriteLine("state :");
            try
            {
                ad.state = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("INVALID INPUT");
                getAddress();
            }

            Console.WriteLine("country :");
            try
            {
                ad.country = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("INVALID INPUT");
                getAddress();
            }

            return ad;

        }


        public string GetStaffType()
        {
            Console.WriteLine("Enter staff type");
            Console.WriteLine("1 -->  Permanent");
            Console.WriteLine("2 --> Temporary");

            int choice = 0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("INVALID INPUT ");
                GetStaffType();
            }

            if(choice==1)
            {
                return "Permanent";  
            }

            return "Temporary";

        }


        public string GetCategory()
        {
            Console.WriteLine(" Select Saff Category ");
            Console.WriteLine(" 1 -->  Teaching");
            Console.WriteLine(" 2 --> NonTeaching");

            int choice = 0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("INVALID INPUT ");
                GetCategory();
            }

            if (choice == 1)
            {
                return "Teaching";
            }

            return "NonTeaching";



        }


        public List<Subjects> GetSubjects()
        {
            List<Subjects> l = new List<Subjects>();

            Console.WriteLine(" Enter the number of subjects");
            int choice = 0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("INVALID INPUT ");
                GetSubjects();
            }

            for (int i = 0; i < choice; i++)
            {
                Subjects s = new Subjects();
                Console.WriteLine(" ENTER SUBJECT NAME : ");
                s.subname = Console.ReadLine();
                Console.WriteLine(" ENTER CLASS IN WHICH THIS SUBJECT IS TAUGHT : ");

                int std = 0;
                try
                {
                    std = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(" Invalid input");
                    GetSubjects();

                }

                s.standard = std;

                l.Add(s);



            }

            return l;


        }



        public int GetSalary()
        {
            Console.WriteLine(" ENTER  THE SALARY : ");

            int s = 0;
            try
            {
                s = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(" Invalid Input ");
                GetSalary();
            }

            return s;

        }










        public void UpdateStaff()
        {

        }


    }
}
