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
    /// Логика взаимодействия для SickPage.xaml
    /// </summary>
    public partial class SickPage : Page
    {
        public SickPage()
        {
            InitializeComponent();
            SickLV.ItemsSource = App.db.Survey.ToList();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void AddSickBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddSickPAge());
        }
    }
}
