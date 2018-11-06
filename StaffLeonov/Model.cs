using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffLeonov
{
    class Model
    {
        public Model(string Wayeb = "../../Employee.txt", string Waydb = "../../Department.txt")
        {
            currenEmployeeBook = new EmployeeBook();
            currenDepartmentBook = new DepartmentBook();
            currentEBIndex = 0;
            currentDBIndex = 0;
            this.WAYEB = Wayeb;
            this.WAYDB = Waydb;
        }
        public Employee CurrentEmployee
        {
            get
            {
                if (CurrenEBIndex>=0)
                {
                    return currenEmployeeBook[currentEBIndex];
                } else { return null; }
            }
        }
        public Department CurrentDepartment
        {
            get
            {
                if (CurrenDBIndex >= 0)
                {
                    return currenDepartmentBook[currentDBIndex];
                }
                else { return null; }
            }
        }
        public void LoadData()
        {
            StreamReader srE = new StreamReader(WAYEB);
            while (!srE.EndOfStream)
            {
                try
                {
                    string[] sE = srE.ReadLine().Split('\t');
                    this.currenEmployeeBook.AddEmployee(new Employee(int.Parse(sE[0]), sE[1], sE[2], 
                        sE[3], Convert.ToDateTime(sE[4]), sE[5], Convert.ToDateTime(sE[6]), sE[7],
                        sE[8], sE[9], sE[10], Convert.ToInt32(sE[11]), Convert.ToBoolean(sE[12])));
                   // colempl.Add(new Employee(int.Parse(s[0]), s[1], s[2], s[3], Convert.ToDateTime(s[4]), s[5], Convert.ToDateTime(s[6]), s[7], s[8], s[9], s[10], Convert.ToInt32(s[11]), Convert.ToBoolean(s[12])));
                    // this.lv.Items.Add(new Employee { Number = int.Parse(s[0]), LastName = s[1], FirstName = s[2], Patronymic = s[3], Birthday = Convert.ToDateTime(s[4]), PassportSerNum = s[5], PassportDateOfIssue =Convert.ToDateTime(s[6]), PassporIssuedBy = s[7], PlaceOfResidence = s[8], PolicyNumber = s[9], Birthplace = s[10], Departamentnumber = Convert.ToInt32(s[11]), DepartamentHead =Convert.ToBoolean(s[12]) });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //sr.Close();
            StreamReader srD = new StreamReader(WAYDB);
            while (!srD.EndOfStream)
            {
                try
                {
                    string[] sD = srD.ReadLine().Split('\t');
                    this.currenDepartmentBook.AddDepartment(new Department(int.Parse(sD[0]), sD[1], sD[2], sD[3]));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        #region Данные
        public EmployeeBook CurrenEmployeeBook => currenEmployeeBook;
        public DepartmentBook CurrenDepartmentBook => currenDepartmentBook;
        public int CurrenEBIndex
        {
            get => this.currentEBIndex;
            set => this.currentEBIndex = value;
        }
        public int CurrenDBIndex
        {
            get => this.currentDBIndex;
            set => this.currentDBIndex = value;
        }

        EmployeeBook currenEmployeeBook;
        DepartmentBook currenDepartmentBook;
        private int currentEBIndex;
        private int currentDBIndex;
        private readonly string WAYEB;
        private readonly string WAYDB;
        #endregion
    }
}
