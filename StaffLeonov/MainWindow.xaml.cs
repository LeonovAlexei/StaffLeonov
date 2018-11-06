using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StaffLeonov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IViewMw
    {

        Presenter p;

       
        public MainWindow()
        {

            InitializeComponent();
            p = new Presenter(this);
            this.Loaded += delegate { p.LoadEBDB(); };
            
            //Employee.LoadEmployee();
            //Department.LoadDepartaments();

            //comboBox.ItemsSource =  Department.Departments;
            //lv.ItemsSource = Employee.colempl;
            
        }
        
        private void lv_Selected(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(e.Source.ToString());
            //MessageBox.Show(e.AddedItems[0].ToString());
        }

       
        private void lv_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
          // new ChangeEmp(lv.SelectedItem as Employee).ShowDialog();
            
        }

        private void comboBox_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            //new ChangeDep(comboBox.SelectionBoxItem as Department).ShowDialog();

        }
        public int Number { get => txtNumber.DisplayMemberBinding; set => txtNumber.DisplayMemberBinding = value; }
        public string LastName { get => txtLastName.Text; set => txtLastName.Text = value; }
        public string FirstName { get => txtFirstName.Text; set => txtFirstName.Text = value; }
        public string Patronymic { get => txtPatronymic.Text; set => txtPatronymic.Text = value; }
        //public DateTime Birthday { get => txtBirthday.Text; set => txtBirthday.Text = value; }
        //public string PassportSerNum { get => txtPassportSerNum.Text; set => txtPassportSerNum.Text = value; }
        //public DateTime PassportDateOfIssue { get => txtPassportDateOfIssue.Text; set => txtPassportDateOfIssue.Text = value; }
        //public string PassporIssuedBy { get => txtPassporIssuedBy.Text; set => txtPassporIssuedBy.Text = value; }
        //public string PlaceOfResidence { get => txtPlaceOfResidence.Text; set => txtPlaceOfResidence.Text = value; }
        //public string PolicyNumber { get => txtPolicyNumber.Text; set => txtPolicyNumber.Text = value; }
        //public string Birthplace { get => txtBirthplace.Text; set => txtBirthplace.Text = value; }
        //public int Departamentnumber { get => txtDepartamentnumber.Text; set => txtDepartamentnumber.Text = value; }
        //public bool DepartamentHeadB { get => txtDepartamentHeadB.Text; set => txtDepartamentHeadB.Text = value; }
        //public int DepartmentNumber { get => txtDepartmentNumber.Text; set => txtDepartmentNumber.Text = value; }
        public string DepartmentName { get => txtDepartmentName.Text; set => txtDepartmentName.Text = value; }
        //public string DepartmentPhoneNumber { get => txtDepartmentPhoneNumber.Text; set => txtDepartmentPhoneNumber.Text = value; }
        ////public string DepartmentHead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string DepartmentHead { get => txtDepartmentHead.Text; set => txtDepartmentHead.Text = value; }

       // public int Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       // public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       // public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string Patronymic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Birthday { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PassportSerNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime PassportDateOfIssue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PassporIssuedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PlaceOfResidence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PolicyNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Birthplace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Departamentnumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool DepartamentHeadB { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DepartmentNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       // public string DepartmentName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DepartmentPhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DepartmentHead { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



    }
}
