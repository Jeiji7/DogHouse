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

namespace DogHouse.Pagess
{
    /// <summary>
    /// Логика взаимодействия для SearchDogsPage.xaml
    /// </summary>
    public partial class SearchDogsPage : Page
    {
        private List<Dog> DogList { get; set; }
        public SearchDogsPage()
        {
            try
            {
                InitializeComponent();
                DogList = new List<Dog>(Dbconnections.doghomeEntities.Dog.OrderBy(x => x.Number).ToList());
                DogLv.ItemsSource = DogList;
            }
            catch
            {
                //MessageClass.ExceptionMessage();
            }
        }



        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {  
            var alldogs = Dbconnections.doghomeEntities.Dog.ToList();
            DogList = new List<Dog>(alldogs.Where(i => i.Number.ToLower().Contains(SearchTb.Text.ToLower())
            || i.Description.ToLower().Contains(SearchTb.Text.ToLower())
            || i.PhoneNumber.ToLower().Contains(SearchTb.Text.ToLower())));
            DogLv.ItemsSource = DogList;

            //try
            //{
            //    List<Dog> filterList = DogList;
            //    string searchText = SearchTb.Text.ToLower().Trim();
            //    if (!string.IsNullOrWhiteSpace(searchText))
            //    {
            //        filterList = filterList.Where(x => x.Number.ToLower().Contains(searchText)).ToList();

            //    }
            //    DogLv.ItemsSource = filterList;
            //}
            //catch
            //{
            //    //MessageClass.ExceptionMessage();
            //}
        }

        private void DogLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (DogLv.SelectedItem != null)
            {
                NavigationService.Navigate(new AboutDogPage(DogLv.SelectedItem as Dog));
            }
            else
            {
                MessageBox.Show("gefff");

            }



        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenuPage());
        }
    }
}
