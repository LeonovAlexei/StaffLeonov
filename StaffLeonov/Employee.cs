using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    public class Employee
    {
        public int Number { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthday { get; set; }
        public string PassportSerNum { get; set; }
        public DateTime PassportDateOfIssue { get; set; }
        public string PassporIssuedBy { get; set; }
        public string PlaceOfResidence { get; set; }
        public string PolicyNumber { get; set; }
        public string Birthplace { get; set; }
        public int Departamentnumber { get; set; }
        public bool DepartamentHead { get; set; }



        public Employee( int number, string lastName,string firstName,string patronymic,DateTime birthday,
            string passportSerNum, DateTime passportDateOfIssue, string passporIssuedBy, string placeOfResidence,
             string policyNumber, string birthplace, int departamentnumber, bool departamentHead)
        {
            this.Number = number;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Patronymic = patronymic;
            this.Birthday = birthday;
            this.PassportSerNum = passportSerNum;
            this.PassportDateOfIssue = passportDateOfIssue;
            this.PassporIssuedBy = passporIssuedBy;
            this.PlaceOfResidence = placeOfResidence;
            this.PolicyNumber = policyNumber;
            this.Birthplace = birthplace;
            this.Departamentnumber = departamentnumber;
            this.DepartamentHead = departamentHead;
        }
        public Employee() { }


        public override string ToString()
        {
            return $"{Number},{LastName},{FirstName},{Patronymic},{Birthday},{PassportSerNum},{PassportDateOfIssue},{PassporIssuedBy},{PlaceOfResidence},{PolicyNumber},{Birthplace},{Departamentnumber},{DepartamentHead}";
        }

    }

}
