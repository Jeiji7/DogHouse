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
    /// Логика взаимодействия для ViewListDogPage.xaml
    /// </summary>
    public partial class ViewListDogPage : Page
    {
        public ViewListDogPage()
        {
            InitializeComponent();
            DogsListLV.ItemsSource = App.db.Dog.ToList();
        }
        private void Button_AddDogs_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageList.AddDogInfoPage());
        }

        private void Button_EditDogs_Click(object sender, RoutedEventArgs e)
        {
            if(DogsListLV.SelectedItem != null)
            {
                var item = (Dog)DogsListLV.SelectedItem;
                NavigationService.Navigate(new PageList.EditDogInfoPage(item));
            }
            else
            {
                MessageBox.Show("Вы не выбрали собаку для редактирования!!!");
            }
        }
    }
}
