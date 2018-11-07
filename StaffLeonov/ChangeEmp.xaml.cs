﻿using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace StaffLeonov
{
    /// <summary>
    /// Логика взаимодействия для ChangeEmp.xaml
    /// </summary>
    public partial class ChangeEmp : Window
    {
        public ChangeEmp()
        {
            InitializeComponent();
            gridChangeEmp.DataContext = Employee.colempl; 

            this.CBChangeEmp.ItemsSource = Department.departments;
        }

        
    }
}
