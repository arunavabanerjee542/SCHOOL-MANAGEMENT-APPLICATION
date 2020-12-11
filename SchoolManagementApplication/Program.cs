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
            Ilogger logger = Factory.GetLogger();

            logger.log(" WELCOME TO S.K.S PUBLIC SCHOOL ");

            while(1==1)
            {

                logger.log(" choose amonge the following ");

                logger.log(" Enter 1 to view our staff details  ");
                logger.log(" Enter 2 to view only permanent staffs  ");
                logger.log(" Enter 3 to view only temporary staffs  ");

                var choice = Convert.ToInt32(Console.ReadLine());

                var staffdetails = Factory.getViewDetailsImpl();


                switch (choice)
                {

                    case 1:
                        staffdetails.ViewStaffDetails();
                        break;

                    case 2:
                        staffdetails.ViewPermanentStaffs();
                        break;


                }





            }




        }
    }
}
