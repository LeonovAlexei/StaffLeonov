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
        public static ObservableCollection<Employee> colempl = new ObservableCollection<Employee>();
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
        /// <summary>
        /// Метод загрузки списка сотрудников из файла и добавления данных в коллекцию
        /// </summary>
        public static void LoadEmployee()
        {
            StreamReader sr = new StreamReader("../../Employee.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split('\t');

                    colempl.Add(new Employee(int.Parse(s[0]), s[1], s[2], s[3], Convert.ToDateTime(s[4]), s[5], Convert.ToDateTime(s[6]), s[7], s[8], s[9], s[10], Convert.ToInt32(s[11]), Convert.ToBoolean(s[12])));
                    // this.lv.Items.Add(new Employee { Number = int.Parse(s[0]), LastName = s[1], FirstName = s[2], Patronymic = s[3], Birthday = Convert.ToDateTime(s[4]), PassportSerNum = s[5], PassportDateOfIssue =Convert.ToDateTime(s[6]), PassporIssuedBy = s[7], PlaceOfResidence = s[8], PolicyNumber = s[9], Birthplace = s[10], Departamentnumber = Convert.ToInt32(s[11]), DepartamentHead =Convert.ToBoolean(s[12]) });

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
