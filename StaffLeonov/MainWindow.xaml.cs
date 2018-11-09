

using System.Windows;

using System.Data.SqlClient;
using System.Data;

namespace StaffLeonov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable tblEmployee, tblAddress, tblDepartments, tblDepartmentsGrid, tblAddressType, tblPassports;
        
        public MainWindow()
        {
            InitializeComponent();
  
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Строка подключения 
            string staffConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = StaffLeonov; Integrated Security = True; Pooling = False";
            connection = new SqlConnection(staffConnectionString);
            ds = new DataSet();

            SqlCommand command = new SqlCommand(string.Empty,connection);
            adapter = new SqlDataAdapter(command);
            command.CommandText = "SELECT * FROM Employee";
            adapter.Fill(ds, "tblEmployee");
            command.CommandText = "SELECT(Employee.LastName) + (' ') + " +
                "(Employee.FirstName) + (' ') + (Employee.Patronymic)AS DepartmentHead," +
                "Departments.IdDepartment,DepartmentName, DepartmentPhoneNumber FROM Departments, " +
                "Employee WHERE Departments.DepartmentHead = Employee.IdEmployee";
            adapter.Fill(ds, "tblDepartmentsGrid");
            command.CommandText = "SELECT * FROM Address";
            adapter.Fill(ds, "tblAddress");
            command.CommandText = "SELECT * FROM AddressType";
            adapter.Fill(ds, "tblAddressType");
            command.CommandText = "SELECT * FROM Passports";
            adapter.Fill(ds, "tblPassports");
            command.CommandText = "SELECT * FROM Departments";
            adapter.Fill(ds, "tblDepartments");
                      
            adapter.SelectCommand = command;

            ////insert
            //command = new SqlCommand(@"INSERT INTO Employee (IdEmployee, LastName, FirstName, Patronymic) 
            //                          VALUES (@IdEmployee, @LastName, @FirstName, @Patronymic); SET @IdEmployee = @@IDENTITY;",
            //              connection);

            //command.Parameters.Add("@IdEmployee", SqlDbType.NVarChar, -1, "IdEmployee");
            //command.Parameters.Add("@LastName", SqlDbType.NVarChar, -1, "LastName");
            //command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 58, "FirstName");
            //command.Parameters.Add("@Patronymic", SqlDbType.NVarChar, -1, "Patronymic");

            //SqlParameter param = command.Parameters.Add("@IdEmployee", SqlDbType.Int, 0, "IdEmployee");

            //param.Direction = ParameterDirection.Output;

            //adapter.InsertCommand = command;

            //            // update
            //            command = new SqlCommand(@"UPDATE People SET FIO = @FIO,
            //Birthday = @Birthday, Email = @Email, Phone = @Phone WHERE ID = @ID", connection);

            //            command.Parameters.Add("@FIO", SqlDbType.NVarChar, -1, "FIO");
            //            command.Parameters.Add("@Birthday", SqlDbType.NVarChar, -1, "Birthday");
            //            command.Parameters.Add("@Email", SqlDbType.NVarChar, -1, "Email");
            //            command.Parameters.Add("@Phone", SqlDbType.NVarChar, -1, "Phone");
            //            param = command.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");

            //            param.SourceVersion = DataRowVersion.Original;

            //            adapter.UpdateCommand = command;
            //            //delete
            //            command = new SqlCommand("DELETE FROM People WHERE ID = @ID", connection);
            //            param = command.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
            //            param.SourceVersion = DataRowVersion.Original;
            //            adapter.DeleteCommand = command;

            // 

            tblEmployee = ds.Tables["tblEmployee"];
            tblDepartmentsGrid = ds.Tables["tblDepartmentsGrid"];
            tblDepartments = ds.Tables["tblDepartments"];
            tblAddress = ds.Tables["tblAddress"];
            tblAddressType = ds.Tables["tblAddressType"];
            tblPassports = ds.Tables["tblPassports"];
            


            employeeDataGrid.DataContext = tblEmployee.DefaultView;
            departmentsDataGrid.DataContext = tblDepartmentsGrid;
            cBox.ItemsSource = tblDepartments.DefaultView;


            //adapter.Fill(dt);
            //employeeDataGrid.DataContext = dt;



            //cBox.ItemsSource = dt.DefaultView;
            //
        }

        private void employeeDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            // добавим новую строку
            DataRow newRow = tblEmployee.NewRow();
            ChangeEmp changeEmp = new ChangeEmp(newRow);
            changeEmp.ShowDialog();

            if (changeEmp.DialogResult.Value)
            {
                tblEmployee.Rows.Add(changeEmp.resultRow);
                adapter.Update(tblEmployee);
            }
        }
    }
}
