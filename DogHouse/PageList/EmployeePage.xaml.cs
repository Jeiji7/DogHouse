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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        public EmployeePage()
        {
            InitializeComponent();
            EmployeeLV.ItemsSource = App.db.Employee.ToList();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void AddEmployeeBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEmployeePage());
        }

        private void EmployeeLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditEmployeeBTN_Click(object sender, RoutedEventArgs e)
        {
            //if (EmployeeLV.SelectedIndex != -1)
            //{
            //    var SelectEmp = (Employee)EmployeeLV.SelectedItem;
            //    EditEmployeePage editPage = new EditEmployeePage(SelectEmp);
            //    NavigationService.Navigate(editPage);
            //}
            //else
            //{
            //    MessageBox.Show("Вы не выбрали заявку для изменения");
            
        }
    }
}
