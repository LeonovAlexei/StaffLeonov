using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    
    public class Department
    {
        public static ObservableCollection<Department> departments = new ObservableCollection<Department>();
        public int DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentPhoneNumber { get; set; }
        public string DepartmentHead { get; set; }
        public Department (int departmentNumber, string departmentName, string departmentPhoneNumber, string departmentHead)
        {
            this.DepartmentNumber = departmentNumber;
            this.DepartmentName = departmentName;
            this.DepartmentPhoneNumber = departmentPhoneNumber;
            this.DepartmentHead = departmentHead;
        }
        public Department() { }
        public override string ToString()
        {
            return $"{DepartmentNumber},{DepartmentName},{DepartmentPhoneNumber},{DepartmentHead}";
        }
        public static void LoadDepartaments()
        {
            StreamReader sr = new StreamReader("../../Department.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split('\t');
                    departments.Add(new Department(int.Parse(s[0]), s[1], s[2], s[3]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
        }
    }
}
