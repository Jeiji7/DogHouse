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
    /// Логика взаимодействия для VoluerPage.xaml
    /// </summary>
    public partial class VoluerPage : Page
    {
        private TypeAviary typeAviary;
        public VoluerPage()
        {
            InitializeComponent();
            VolyerLV.ItemsSource = App.db.TypeAviary.ToList();

        }

        private void AddVolyerBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddVolyerPage());
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }
    }
}
