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
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee>  colempl = new ObservableCollection<Employee>();
        
       
        public MainWindow()
        {

            InitializeComponent();
            LoadEmployee();
            Department.LoadDepartaments();

           this.comboBox.ItemsSource = Department.departments;
           
        }
        
        public  void LoadEmployee()
        {
            StreamReader sr = new StreamReader("../../Employee.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split('\t');

                    //colempl.Add(new Employee(int.Parse(s[0]), s[1], s[2], s[3], Convert.ToDateTime(s[4]), s[5], Convert.ToDateTime(s[6]), s[7], s[8], s[9], s[10], Convert.ToInt32(s[11]), Convert.ToBoolean(s[12])));
                    this.lv.Items.Add(new Employee { Number = int.Parse(s[0]), LastName = s[1], FirstName = s[2], Patronymic = s[3], Birthday = Convert.ToDateTime(s[4]), PassportSerNum = s[5], PassportDateOfIssue =Convert.ToDateTime(s[6]), PassporIssuedBy = s[7], PlaceOfResidence = s[8], PolicyNumber = s[9], Birthplace = s[10], Departamentnumber = Convert.ToInt32(s[11]), DepartamentHead =Convert.ToBoolean(s[12]) });
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
           

        }
        private void lv_Selected(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(e.Source.ToString());
        }

        private void lv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.AddedItems[0].ToString());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
