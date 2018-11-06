using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    class Presenter
    {
        private Model model;
        private IViewMw view;
        public Presenter (IViewMw View)
        {
            this.view = View;
            model = new Model();
        }
        public void LoadEBDB()
        {
            model.LoadData();
            if (model.CurrenEmployeeBook.CountTast > 0)
            {
                model.CurrenEBIndex = 0;
                var tempEmployee = model.CurrentEmployee;
                view.Number = tempEmployee.Number;
                view.LastName = tempEmployee.LastName;
                view.FirstName = tempEmployee.FirstName;
                view.Patronymic = tempEmployee.Patronymic;
                //view.Birthday = tempEmployee.Birthday;
                //view.PassportSerNum = tempEmployee.PassportSerNum;
                //view.PassportDateOfIssue = tempEmployee.PassportDateOfIssue;
               // view.PassporIssuedBy = tempEmployee.PassporIssuedBy;
                //view.PlaceOfResidence = tempEmployee.PlaceOfResidence;
                //view.PolicyNumber = tempEmployee.PolicyNumber;
                //view.Birthplace = tempEmployee.Birthplace;
                //view.Departamentnumber = tempEmployee.Departamentnumber;
                //view.DepartamentHeadB = tempEmployee.DepartamentHeadB;
            }
            if (model.CurrenDepartmentBook.CountTast > 0)
            {
                model.CurrenDBIndex = 0;
                var tempDepartment = model.CurrentDepartment;
               // view.DepartmentNumber = tempDepartment.DepartmentNumber;
                view.DepartmentName = tempDepartment.DepartmentName;
                //view.DepartmentPhoneNumber = tempDepartment.DepartmentPhoneNumber;
                //view.DepartmentHead = tempDepartment.DepartmentHead;
            }
        }
    }
}
