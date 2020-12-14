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

            Ilogger logger = Factory.GetLogger();

            logger.log(" WELCOME TO S.K.S PUBLIC SCHOOL ");

            while(1==1)
            {

                logger.log(" choose amonge the following ");

                logger.log(" Enter 1 to view our staff details  ");
                logger.log(" Enter 2 to view only permanent staffs  ");
                logger.log(" Enter 3 to view only temporary staffs  ");
                logger.log(" Enter 4 administrator controls ");


                var choice = Convert.ToInt32(Console.ReadLine());

                var staffdetails = Factory.getViewDetailsImpl();

                Administrator admin = new Administrator();


                switch (choice)
                {

                    case 1:
                        staffdetails.ViewStaffDetails(teaching,nonteaching);
                        break;

                    case 2:
                        staffdetails.ViewPermanentStaffs(teaching,nonteaching);
                        break;

                    case 4:
                        admin.InsertStaff(teaching,nonteaching);
                        break;



                }





            }




        }
    }
}
