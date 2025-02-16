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
        }
    }
}
