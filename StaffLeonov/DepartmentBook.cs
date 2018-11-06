using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    class DepartmentBook : IEnumerable
    {
        public DepartmentBook()
        {
            departments = new ObservableCollection<Department>();
        }
        #region Логика
        public bool AddDepartment(Department NewDepartment)
        {
            bool flag = false;
            if (!departments.Contains(NewDepartment))
            {
                departments.Add(NewDepartment);
                flag = true;
            }

            return flag;
        }
        public bool RemoveDepartment(Department RemoveDepartment)
        {

            bool flag = false;
            if (departments.IndexOf(RemoveDepartment) != -1)
            {
                departments.Remove(RemoveDepartment);
                flag = true;
            }
            return flag;
        }
        public int CountTast => departments.Count;
        private bool IsNullOrEmpty()
        {
            bool flag = true;

            if (departments != null)
            {
                if (departments.Count > 0)
                {
                    flag = false;
                }
            }
            return flag;
        }
        public Department this[int index]
        {
            get => !IsNullOrEmpty() ? departments[index] : null;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (Department e in departments)
            {
                yield return (Department)e;
            }
        }
        #endregion


        #region Данные
        public ObservableCollection <Department> Departments
        {
            get => this.departments;
            set => this.departments = value;
        }
        private ObservableCollection<Department> departments;
        #endregion
    }
}
