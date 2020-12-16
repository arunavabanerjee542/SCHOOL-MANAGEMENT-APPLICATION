using SchoolManagementApplication.Repositories;
using SchoolManagementApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication.Models
{
    class Administrator
    {
        AdminControlIntf admin = new AdminControlImpl();

        public void InsertStaff(List<TeachingStaff> t, List<NonTeachingStaff> nt)
        {

           

            admin.InsertStaff(t, nt);

        }

        public void InsertStudentDetails(List<Student> sl)
        {
            admin.InsertStudent(sl);
        }




       

    }
}
