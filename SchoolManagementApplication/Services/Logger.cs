using SchoolManagementApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplication.Services
{
    class Logger : Ilogger
    {
        public void log(string m)
        {
            Console.WriteLine(m);
        }
    }
}
