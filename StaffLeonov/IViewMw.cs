using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    interface IViewMw
    {
        int Number { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string Patronymic { get; set; }
        string DepartmentName { get; set; }

    }
}
