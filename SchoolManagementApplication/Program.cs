using SchoolManagementApplication.Models;
using SchoolManagementApplication.MyFactory;
using SchoolManagementApplication.Repositories;
using SchoolManagementApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeachingStaff> teaching = new List<TeachingStaff>();

            List<NonTeachingStaff> nonteaching = new List<NonTeachingStaff>();

            List<Student> stulist = new List<Student>();

            Ilogger logger = Factory.GetLogger();

            logger.log(" WELCOME TO S.K.S PUBLIC SCHOOL ");

            while(1==1)
            {

                logger.log(" choose amonge the following ");

                logger.log(" Enter 1 to view our staff details  ");
                logger.log(" Enter 2 to view only permanent staffs  ");
                logger.log(" Enter 3 to view only temporary staffs  ");
                logger.log(" Enter 4 administrator controls for Staffs");
                logger.log(" Enter 5 To view Staffs by category and Sorted by Salary ");
                logger.log(" Enter 6 To view Student Details  ");
                logger.log(" Enter 7 administrator control for Students ");


                var choice = Convert.ToInt32(Console.ReadLine());

                var Viewdetails = Factory.getViewDetailsImpl();

                var admin = Factory.GetAdministartor();


                switch (choice)
                {

                    case 1:
                        Viewdetails.ViewStaffDetails(teaching,nonteaching);
                        break;

                    case 2:
                        Viewdetails.ViewPermanentStaffs(teaching,nonteaching);
                        break;

                    case 3:
                        Viewdetails.ViewTemporaryStaffDetails(teaching, nonteaching);
                        break;

                    case 4:
                        admin.InsertStaff(teaching,nonteaching);
                        break;

                    case 5:
                        Viewdetails.GroupAndSort(teaching,nonteaching);
                        break;

                        case 6:
                        Viewdetails.ViewStudentDetails(stulist);
                        break;

                    case 7:
                        admin.InsertStudentDetails(stulist);
                        break;


                }





            }




        }
    }
}
