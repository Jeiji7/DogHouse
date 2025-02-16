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
    /// Логика взаимодействия для AddDogInfoPage.xaml
    /// </summary>
    public partial class AddDogInfoPage : Page
    {
        public Dog newDog = new Dog();
        public AddDogInfoPage()
        {
            InitializeComponent();
            TypeVolyerCB.ItemsSource = App.db.TypeAviary.ToList();
            TypeVolyerCB.DisplayMemberPath = "Name";
            GenderDogTB.ItemsSource = App.db.Gender.ToList();
            GenderDogTB.DisplayMemberPath = "Name";
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
                    MessageBox.Show("Собака старая как рамиль!");
                    return;
                }
                newDog.AboutAge = int.Parse(AgeDogTB.Text);
                newDog.Number = NumberDogTB.Text;
                newDog.Height = int.Parse(HeightDogTB.Text);
                newDog.Weight = int.Parse(WeightDogTB.Text);
                newDog.Description = DiscriptionDogTB.Text;
                newDog.PhoneNumber = NumberDogTB.Text;
                newDog.IsDie = false;
                newDog.IsGive = false;
                newDog.Photo = null;
                newDog.IdAviary = TypeVolyerCB.SelectedIndex + 1;
                newDog.IdGender = GenderDogTB.SelectedIndex + 1;
                App.db.Dog.Add(newDog);
                App.db.SaveChanges();
                MessageBox.Show("Успешно добавлена запись о собаке!");
                NavigationService.Navigate(new PageList.ViewListDogPage());
            }
            catch (Exception)
            {
                MessageBox.Show("Вы ввели не корректные данные или не заполнили все поля");
            }
        }
    }
}
