using DogHouse.DB;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DogHouse.PageList
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        private Employee employee = new Employee();
        //public static List<TypeEmployee> typeEmployees { get; set; }
        public AddEmployeePage()
        {
            InitializeComponent();
            TypeCB.ItemsSource = App.db.TypeEmployee.ToList();
            TypeCB.DisplayMemberPath = "Name";

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeePage());
        }

        private void AddEmployeeBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            employee.IdType = TypeCB.SelectedIndex + 1;
            employee.FirstName = NameTB.Text;
            employee.Name = SurnameTB.Text;

            App.db.Employee.Add(employee);
            App.db.SaveChanges();
            MessageBox.Show("Данные успешно добавлены");
            NavigationService.Navigate(new EmployeePage());
            }
            
            catch
            {
                MessageBox.Show("Заполни все строки!");
            }
        }
    }
}
