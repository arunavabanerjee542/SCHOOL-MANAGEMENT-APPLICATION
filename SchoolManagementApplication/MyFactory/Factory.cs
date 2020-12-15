using SchoolManagementApplication.Models;
using SchoolManagementApplication.Repositories;
using SchoolManagementApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication.MyFactory
{
   static class Factory  
    {
        static public Ilogger GetLogger()
        {
            return new Logger();
        }

        static public ViewDetailsIntf getViewDetailsImpl()
        {
            return new ViewDetailsImpl();
        }

        static public Administrator GetAdministartor()
        {
            return new Administrator();
        }

    }
}
