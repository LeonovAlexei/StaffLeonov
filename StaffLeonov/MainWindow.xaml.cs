

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
       // SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;
        DataTable ddt;


        public MainWindow()
        {

            InitializeComponent();



            //Строка подключения 
            string staffConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = StaffLeonov; Integrated Security = True; Pooling = False";
            
            string sql = "SELECT IdEmployee, LastName, FirstName, Patronymic FROM Employee";
            string sqld = "SELECT DepartmentName, DepartmentPhoneNumber FROM Departments";
            adapter = new SqlDataAdapter(sql, staffConnectionString);
           
            dt = new DataTable();
            
            adapter.Fill(dt);
            employeeDataGrid.DataContext = dt;
            adapter = new SqlDataAdapter(sqld, staffConnectionString);
            ddt = new DataTable();
            adapter.Fill(ddt);
            
            cBox.ItemsSource = ddt.DefaultView;



            //connection = new SqlConnection(staffConnectionString);
            //adapter.SelectCommand = new SqlCommand(sql, connection);
            //connection.Open();
            //    SqlCommand command =
            //    new SqlCommand("SELECT IdEmployee, LastName, FirstName, Patronymic, Birthday FROM Employee",
            //    connection);
            //    adapter.SelectCommand = command;
            //dt = new DataTable();
            // dt = command.ExecuteReader ();
            //adapter.Fill(dt);
            //employeeDataGrid.DataContext = dt;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
//            string staffConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = StaffLeonov; Integrated Security = True; Pooling = False";

//            connection = new SqlConnection(staffConnectionString);
//            adapter = new SqlDataAdapter();

//            SqlCommand command =
//                new SqlCommand("SELECT IdEmployee, LastName, FirstName, Patronymic, Birthday FROM Employee",
//                connection);
//            adapter.SelectCommand = command;

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

//            dt = new DataTable();

//            adapter.Fill(dt);
//            employeeDataGrid.DataContext = dt.DefaultView;
            //cBox.ItemsSource = dt.DefaultView;
        }








    }
}
