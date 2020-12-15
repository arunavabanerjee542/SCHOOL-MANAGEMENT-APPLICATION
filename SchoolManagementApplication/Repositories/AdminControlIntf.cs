using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication.Repositories
{
    interface AdminControlIntf
    {

        void InsertStaff(List<TeachingStaff> t , List<NonTeachingStaff> nt);

    }
}
