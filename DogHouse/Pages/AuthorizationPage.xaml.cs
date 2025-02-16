using DogHouse.DB;
using DogHouse.PageList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

namespace DogHouse.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public static List<Employee> employees { get; set; }

        public AuthorizationPage()
        {
            InitializeComponent();
        }

       

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();
            string pass = PassTb.Text.Trim();

            employees = new List<Employee>(App.db.Employee.ToList());
            Employee currentEmpl = employees.FirstOrDefault(x => x.Login == login && x.Password == pass);
            if (currentEmpl != null)
            {
                
                NavigationService.Navigate(new SurveyPage());
            }
            else if (LoginTb.Text == "0000" && PassTb.Text == "0000")
                NavigationService.Navigate(new AdminPage());
            else
            {
                MessageBox.Show("Мы не нашли ваши данные в системе, попробуйте зайти снова");
                LoginTb.Text = "";
                PassTb.Text = "";
            }
        }

        private void Guest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
