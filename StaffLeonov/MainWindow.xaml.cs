

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
        DataTable tblEmployee;
        DataTable tblDiparments;

        public MainWindow()
        {
            InitializeComponent();
      
            string sql = "SELECT IdEmployee, LastName, FirstName, Patronymic FROM Employee;SELECT (Employee.LastName) +(' ')+(Employee.FirstName)+(' ') + (Employee.Patronymic)AS DepartmentHead,Departments.IdDepartment,DepartmentName, DepartmentPhoneNumber FROM Departments, Employee WHERE Departments.DepartmentHead=Employee.IdEmployee";
            //string sql = "SELECT IdEmployee, LastName, FirstName, Patronymic FROM Employee";
            //string sqld = 
            
           
        
            
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
            adapter.Fill(ds, "tblDiparments");
            //"SELECT IdEmployee, LastName, FirstName, Patronymic, Birthday FROM Employee"
            adapter.SelectCommand = command;

            //            //insert
            //            command = new SqlCommand(@"INSERT INTO Employee (IdEmployee, LastName, FirstName, Patronymic) 
            //                          VALUES (@IdEmployee, @LastName, @FirstName, @Patronymic); SET @IdEmployee = @@IDENTITY;",
            //                          connection);

            //            command.Parameters.Add("@IdEmployee", SqlDbType.NVarChar, -1, "IdEmployee");
            //            command.Parameters.Add("@LastName", SqlDbType.NVarChar, -1, "LastName");
            //            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 58, "FirstName");
            //            command.Parameters.Add("@Patronymic", SqlDbType.NVarChar, -1, "Patronymic");

            //            SqlParameter param = command.Parameters.Add("@IdEmployee", SqlDbType.Int, 0, "IdEmployee");

            //            param.Direction = ParameterDirection.Output;

            //            adapter.InsertCommand = command;

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

            DataTable tblEmployee = ds.Tables["tblEmployee"];
            DataTable tblDiparments = ds.Tables["tblDiparments"];

            employeeDataGrid.DataContext = tblEmployee.DefaultView;
            departmmentsDataGrid.DataContext = tblDiparments;
            cBox.ItemsSource = tblDiparments.DefaultView;


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
            editWindow.ShowDialog();

            if (editWindow.DialogResult.Value)
            {
                dt.Rows.Add(editWindow.resultRow);
                adapter.Update(dt);
            }
        }
    }
}
