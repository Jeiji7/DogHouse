using DogHouse.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
    /// Логика взаимодействия для AddVolyerPage.xaml
    /// </summary>
    public partial class AddVolyerPage : Page
    {
        private TypeAviary typeAviary;
        public AddVolyerPage()
        {
            InitializeComponent();


        }

        private void AddVolyerBTN_Click(object sender, RoutedEventArgs e)
        {
            typeAviary.Name = NameVolyerTB.Text;

            DBConnection.DogHome1Entities.TypeAviary.Add(typeAviary);
            DBConnection.DogHome1Entities.SaveChanges();
            MessageBox.Show("Данные успешно добавлены");
            NavigationService.Navigate(new VoluerPage());
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VoluerPage());
        }
    }
}
