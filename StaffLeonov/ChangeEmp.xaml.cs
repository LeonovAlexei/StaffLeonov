using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StaffLeonov
{
    /// <summary>
    /// Логика взаимодействия для ChangeEmp.xaml
    /// </summary>
    public partial class ChangeEmp : Window
    {
        public DataRow resultRow { get; set; }
        public ChangeEmp(DataRow dataRow)
        {
            InitializeComponent();
            resultRow = dataRow;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            idEmployee.Text = resultRow["IdEmployee"].ToString();
            lastName.Text = resultRow["LastName"].ToString();
            firstName.Text = resultRow["FirstName"].ToString();
            patronymic.Text = resultRow["Patronymic"].ToString();
        }

    }
}
