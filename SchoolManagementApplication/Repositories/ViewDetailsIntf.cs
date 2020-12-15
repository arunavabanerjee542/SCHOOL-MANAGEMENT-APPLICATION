using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication.Repositories
{
    interface ViewDetailsIntf
    {
        void ViewStaffDetails(List<TeachingStaff> t, List<NonTeachingStaff> nt);

        void ViewPermanentStaffs(List<TeachingStaff> t, List<NonTeachingStaff> nt);

        void ViewTemporaryStaffDetails(List<TeachingStaff> t, List<NonTeachingStaff> nt);

        void GroupAndSort(List<TeachingStaff> t, List<NonTeachingStaff> nt);
    }
}
