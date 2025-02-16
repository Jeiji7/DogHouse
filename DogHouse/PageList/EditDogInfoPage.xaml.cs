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
    /// Логика взаимодействия для EditDogInfoPage.xaml
    /// </summary>
    public partial class EditDogInfoPage : Page
    {
        private Dog _newDog;
        public EditDogInfoPage(Dog newDog)
        {
            InitializeComponent();
            _newDog = newDog;
            TypeVolyerCB.ItemsSource = App.db.TypeAviary.ToList();
            TypeVolyerCB.DisplayMemberPath = "Name";
            GenderDogTB.ItemsSource = App.db.Gender.ToList();
            GenderDogTB.DisplayMemberPath = "Name";

            AgeDogTB.Text = newDog.AboutAge.ToString();
            NumberDogTB.Text = newDog.Number.ToString();
            HeightDogTB.Text = newDog.Height.ToString();
            WeightDogTB.Text = newDog.Weight.ToString();
            DiscriptionDogTB.Text = newDog.Description.ToString();
            NumberDogTB.Text = newDog.PhoneNumber.ToString();
            TypeVolyerCB.SelectedIndex = (int)(newDog.IdAviary - 1);
            GenderDogTB.SelectedIndex = (int)(newDog.IdGender - 1);
            IsDieCK.IsChecked = (bool)newDog.IsDie;
            IsGiveCK.IsChecked = (bool)newDog.IsGive;

        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageList.ViewListDogPage());
        }

        private void Save_Dog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(AgeDogTB.Text) >= 15)
                {
                    MessageBox.Show("Собака старая как рамиль, возраст слишком большой!");
                    return;
                }
                _newDog.AboutAge = int.Parse(AgeDogTB.Text);
                _newDog.Number = NumberDogTB.Text;
                _newDog.Height = int.Parse(HeightDogTB.Text);
                _newDog.Weight = int.Parse(WeightDogTB.Text);
                _newDog.Description = DiscriptionDogTB.Text;
                _newDog.PhoneNumber = NumberDogTB.Text;
                _newDog.IsDie = IsDieCK.IsChecked;
                _newDog.IsGive = IsGiveCK.IsChecked;
                _newDog.Photo = null;
                _newDog.IdAviary = TypeVolyerCB.SelectedIndex + 1;
                _newDog.IdGender = GenderDogTB.SelectedIndex + 1;
                if (_newDog.IsDie == true)
                    MessageBox.Show("Оу наш милый питомец умер, жалко, что вместо него не рамиль(");
                App.db.SaveChanges();
                MessageBox.Show("Успешно обновили данные о собаке!");
                NavigationService.Navigate(new PageList.ViewListDogPage());
            }
            catch (Exception)
            {
                MessageBox.Show("При изменении вы ввели некорректные данные или оставили пустые поля!!");
            }
        }
    }
}
