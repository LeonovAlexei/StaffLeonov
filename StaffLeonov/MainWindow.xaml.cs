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
       
        
       
        public MainWindow()
        {

            InitializeComponent();
            
            Employee.LoadEmployee();
            Department.LoadDepartaments();

           this.comboBox.ItemsSource = Department.departments;
            lv.ItemsSource = Employee.colempl;
        }
        
        private void lv_Selected(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(e.Source.ToString());
            //MessageBox.Show(e.AddedItems[0].ToString());
        }

       
        private void lv_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            ChangeEmp ChangeEmp = new ChangeEmp();
            ChangeEmp.Show();
        }

        private void comboBox_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            ChangeDep ChangeDep = new ChangeDep();
            ChangeDep.Show();
        }




    }
}
