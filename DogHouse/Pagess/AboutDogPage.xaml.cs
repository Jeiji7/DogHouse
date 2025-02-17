using DogHouse.DB;
using DogHouse.PageList;
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
    /// Логика взаимодействия для AboutDogPage.xaml
    /// </summary>
    public partial class AboutDogPage : Page
    {
        public AboutDogPage(Dog contextdog)
        {


            InitializeComponent();


            if (contextdog.Photo != null)
            {
                ClientImg.Source = new BitmapImage(new Uri(contextdog.Photo, UriKind.Absolute));
            }
            else
            {
                ClientImg.Source = new BitmapImage(new Uri("pack://application:,,,/Photoss/no-image.jpg", UriKind.Absolute));
            }
            NumberTb.Text = contextdog.Number;
            GenderTb.Text = contextdog.Gender.Name;
            HeightTb.Text = contextdog.Height.ToString();
            PhoneTb.Text = contextdog.PhoneNumber;
            WeightTb.Text = contextdog.Weight.ToString();
            DescriptionTb.Text = contextdog.Description;




        }

        public string ConvertImageToBase64String(byte[] imageBytes)
        {
            // Преобразуем байтовый массив в строку Base64
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

        public byte[] ConvertBase64StringToImage(string base64String)
        {
            // Преобразуем строку Base64 обратно в байтовый массив
            byte[] imageBytes = Convert.FromBase64String(base64String);
            return imageBytes;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                App.ContextDog = null;
                NavigationService.Navigate(new SearchDogsPage());
            }
            catch
            {
                //MessageClass.ExceptionMessage();
            }
        }

      
    }
}
