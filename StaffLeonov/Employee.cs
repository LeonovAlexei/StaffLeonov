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
  
    class Employee : IEquatable <Employee>
    {
        public bool Equals(Employee other)
        {
        return this.number == other.Number
            && this.lastName == other.LastName
            && this.firstName == other.FirstName
             && this.patronymic == other.Patronymic
             && this.birthday == other.Birthday
            && this.passportSerNum == other.PassportSerNum
             && this.passportDateOfIssue == other.PassportDateOfIssue
             && this.passporIssuedBy == other.PassporIssuedBy
            && this.placeOfResidence == other.PlaceOfResidence
             && this.policyNumber == other.PolicyNumber
             && this.birthplace == other.Birthplace
            && this.departamentnumber == other.Departamentnumber
             && this.departamentHeadB == other.DepartamentHeadB
            ;
        }
        public Employee(int Number, string LastName, string FirstName, string Patronymic, DateTime Birthday,
            string PassportSerNum, DateTime PassportDateOfIssue, string PassporIssuedBy, string PlaceOfResidence,
             string PolicyNumber, string Birthplace, int Departamentnumber, bool DepartamentHeadB)
        {
            this.number = Number;this.lastName = LastName;this.firstName = FirstName;this.patronymic = Patronymic;
            this.birthday =  Birthday;this.passportSerNum = PassportSerNum;
            this.passportDateOfIssue = PassportDateOfIssue;this.passporIssuedBy = PassporIssuedBy;
            this.placeOfResidence = PlaceOfResidence;this.policyNumber = PolicyNumber;
            this.birthplace = Birthplace;this.departamentnumber = Departamentnumber;
            this.departamentHeadB = DepartamentHeadB;
        }
        private Employee() { }
        #region Данные
        private int number;
        private string lastName;
        private string firstName;
        private string patronymic;
        private DateTime birthday;
        private string passportSerNum;
        private DateTime passportDateOfIssue;
        private string passporIssuedBy;
        private string placeOfResidence;
        private string policyNumber;
        private string birthplace;
        private int departamentnumber;
        private bool departamentHeadB;

        public int Number { get { return this.number; } set { this.number = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string Patronymic { get { return this.patronymic; } set { this.patronymic = value; } }
        public DateTime Birthday { get { return this.birthday; } set { this.birthday = value; } }
        public string PassportSerNum { get { return this.passportSerNum; } set { this.passportSerNum = value; } }
        public DateTime PassportDateOfIssue { get { return this.passportDateOfIssue; } set { this.passportDateOfIssue = value; } }
        public string PassporIssuedBy { get { return this.passporIssuedBy; } set { this.passporIssuedBy = value; } }
        public string PlaceOfResidence { get { return this.placeOfResidence; } set { this.placeOfResidence = value; } }
        public string PolicyNumber { get { return this.policyNumber; } set { this.policyNumber = value; } }
        public string Birthplace { get { return this.birthplace; } set { this.birthplace = value; } }
        public int Departamentnumber { get { return this.departamentnumber; } set { this.departamentnumber = value; } }
        public bool DepartamentHeadB { get { return this.departamentHeadB; } set { this.departamentHeadB = value; } }

        #endregion

        


        //public override string ToString()
        //{
        //    return $"{Number},{LastName},{FirstName},{Patronymic},{Birthday},{PassportSerNum},{PassportDateOfIssue},{PassporIssuedBy},{PlaceOfResidence},{PolicyNumber},{Birthplace},{Departamentnumber},{DepartamentHead}";
        //}
        //public static ObservableCollection<Employee> colempl = new ObservableCollection<Employee>();
        /// <summary>
        /// Метод загрузки списка сотрудников из файла и добавления данных в коллекцию
        /// </summary>
        //public static void LoadEmployee()
        //{
        //    StreamReader sr = new StreamReader("../../Employee.txt");
        //    while (!sr.EndOfStream)
        //    {
        //        try
        //        {
        //            string[] s = sr.ReadLine().Split('\t');
        //            colempl.Add(new Employee(int.Parse(s[0]), s[1], s[2], s[3], Convert.ToDateTime(s[4]), s[5], Convert.ToDateTime(s[6]), s[7], s[8], s[9], s[10], Convert.ToInt32(s[11]), Convert.ToBoolean(s[12])));
        //            // this.lv.Items.Add(new Employee { Number = int.Parse(s[0]), LastName = s[1], FirstName = s[2], Patronymic = s[3], Birthday = Convert.ToDateTime(s[4]), PassportSerNum = s[5], PassportDateOfIssue =Convert.ToDateTime(s[6]), PassporIssuedBy = s[7], PlaceOfResidence = s[8], PolicyNumber = s[9], Birthplace = s[10], Departamentnumber = Convert.ToInt32(s[11]), DepartamentHead =Convert.ToBoolean(s[12]) });
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
