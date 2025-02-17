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
    /// Логика взаимодействия для EditEmployeePage.xaml
    /// </summary>
    public partial class EditEmployeePage : Page
    {
        private Employee _employee;
        public EditEmployeePage(Employee employee)
        {
            InitializeComponent();
            TypeCB.ItemsSource = App.db.TypeEmployee.ToList();
            TypeCB.DisplayMemberPath = "Name";
            _employee = employee;
            NameTB.Text = employee.Name;
            SurnameTB.Text = employee.FirstName;
            TypeCB.SelectedIndex = (int)employee.IdType - 1;
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeePage());
        }

        private void EditEmployeeBTN_Click(object sender, RoutedEventArgs e)
        {
            if(NameTB.Text == "" || SurnameTB.Text == "")
            {
                MessageBox.Show("Вы оставили поля имя или фамилия пустыми!!!");
                return;
            }
            else
            {
                _employee.Name = (NameTB.Text).ToString();
                _employee.FirstName = (SurnameTB.Text).ToString();
                _employee.IdType = TypeCB.SelectedIndex + 1;
                App.db.SaveChanges();
                MessageBox.Show("Данные успешно отредактированны");
                NavigationService.Navigate(new EmployeePage());
            }
        }
    }
}
