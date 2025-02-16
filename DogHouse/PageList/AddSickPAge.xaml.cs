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
    /// Логика взаимодействия для AddSickPAge.xaml
    /// </summary>
    public partial class AddSickPAge : Page
    {
        private Survey survey = new Survey();
        //public static List<Dog> dog { get; set; }

        public AddSickPAge()
        {
            InitializeComponent();
            DogNumberCB.ItemsSource = App.db.Dog.ToList();
            DogNumberCB.DisplayMemberPath = "Number";

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SickPage());
        }

        private void AddSickBTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                survey.IdDog = DogNumberCB.SelectedIndex + 1;
                survey.Illness = SickTB.Text;
                survey.Comment = CommentTB.Text;

                App.db.Survey.Add(survey);
                App.db.SaveChanges();
                MessageBox.Show("Данные успешно добавлены");
                NavigationService.Navigate(new SickPage());
            }
            catch
            {
                MessageBox.Show("Заполни все поля!");
            }
        }
    }
}
