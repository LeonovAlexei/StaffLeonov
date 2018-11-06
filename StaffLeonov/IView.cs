using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    interface IView
    {
         int Number { get; set; }
         string LastName { get; set; }
         string FirstName { get; set; }
         string Patronymic { get; set; }
         DateTime Birthday { get; set; }
         string PassportSerNum { get; set; }
         DateTime PassportDateOfIssue { get; set; }
         string PassporIssuedBy { get; set; }
         string PlaceOfResidence { get; set; }
         string PolicyNumber { get; set; }
         string Birthplace { get; set; }
         int Departamentnumber { get; set; }
         bool DepartamentHeadB { get; set; }
         int DepartmentNumber { get; set; }
         string DepartmentName { get; set; }
         string DepartmentPhoneNumber { get; set; }
         string DepartmentHead { get; set; }
    }
}
