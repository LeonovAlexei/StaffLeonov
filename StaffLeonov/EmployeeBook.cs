using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    class EmployeeBook : IEnumerable
    {
        public EmployeeBook()
        {
            employees = new ObservableCollection<Employee>();
        }
        #region Логика
        public bool AddEmployee(Employee NewEmployee)
        {
            bool flag = false;
            if (!employees.Contains(NewEmployee))
            {
                employees.Add(NewEmployee);
                flag = true;
            }

            return flag;
        }
        public bool RemoveEmployee(Employee RemoveEmployee)
        {

            bool flag = false;
            if (employees.IndexOf(RemoveEmployee) != -1)
            {
                employees.Remove(RemoveEmployee);
                flag = true;
            }
            return flag;
        }
        public int CountTast => employees.Count;
        private bool IsNullOrEmpty()
        {
            bool flag = true;

            if (employees != null)
            {
                if (employees.Count > 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
        public Employee this[int index]
        {
            get => !IsNullOrEmpty() ? employees[index] : null;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Employee e in employees)
            {
                yield return (Employee)e;
            }
        }
        #endregion
        #region Данные
        public ObservableCollection<Employee> Employees
        {
            get => this.employees;
            set => this.employees = value;
        }
        private ObservableCollection<Employee> employees;
        #endregion
    }
}
