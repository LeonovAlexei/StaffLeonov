using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    
    public class Department : IEquatable <Department>
    {
        public bool Equals(Department other)
        {
            return this.departmentNumber == other.DepartmentNumber
                && this.departmentName == other.DepartmentName
                && this.departmentPhoneNumber == other.DepartmentPhoneNumber
                 && this.departmentHead == other.DepartmentHead
                ;
        }
        
       
        public Department (int DepartmentNumber, string DepartmentName, string DepartmentPhoneNumber, string DepartmentHead)
        {
            this.departmentNumber = DepartmentNumber;
            this.departmentName = DepartmentName;
            this.departmentPhoneNumber = DepartmentPhoneNumber;
            this.departmentHead = DepartmentHead;
        }
        private Department() { }
        
        #region Данные
        private int departmentNumber;
        private string departmentName;
        private string departmentPhoneNumber;
        private string departmentHead;

        public int DepartmentNumber { get { return this.departmentNumber; } set { this.departmentNumber = value; } }
        public string DepartmentName { get { return this.departmentName; } set { this.departmentName = value; } }
        public string DepartmentPhoneNumber { get { return this.departmentPhoneNumber; } set { this.departmentPhoneNumber = value; } }
        public string DepartmentHead { get { return this.departmentHead; } set { this.departmentHead = value; } }
        #endregion

        // public static ObservableCollection<Department> Departments { get; set; }
        //public override string ToString()
        //{
        //    return $"{DepartmentNumber},{DepartmentName},{DepartmentPhoneNumber},{DepartmentHead}";
        //}
        //public static void LoadDepartaments()
        //{
        //    Departments = new ObservableCollection<Department>();
        //    StreamReader sr = new StreamReader("../../Department.txt");
        //    while (!sr.EndOfStream)
        //    {

        //        try
        //        {
        //            string[] s = sr.ReadLine().Split('\t');
        //            Departments.Add(new Department(int.Parse(s[0]), s[1], s[2], s[3]));
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //    sr.Close();
        //}
    }
}
