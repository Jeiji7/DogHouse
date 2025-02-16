using DogHouse.Pages;
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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void VolyerBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VoluerPage());
        }

        private void SickBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SickPage());
        }

        private void EmployeeBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeePage());

        }

        private void ListDogs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageList.ViewListDogPage());
        }
    }
}
