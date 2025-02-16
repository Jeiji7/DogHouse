using DogHouse.DB;
using DogHouse.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DogHouse.Pages
{
    /// <summary>
    /// Логика взаимодействия для SurveyPage.xaml
    /// </summary>
    public partial class SurveyPage : Page
    {
        public static ObservableCollection<Survey> surveys = new ObservableCollection<Survey>();
        private static Survey noneInfoSurvey;
        public SurveyPage()
        {
            InitializeComponent();
            surveys = new ObservableCollection<Survey>(DbConnections.homeEntities.Survey.ToList());
            SurveyLv.ItemsSource = surveys;

        }

        private void AddSurveyBtn_Click(object sender, RoutedEventArgs e)
        {
           App.editOrAdd = true;
           AddAnrEditSurveyWindow addAnrEditSurveyWindow = new AddAnrEditSurveyWindow(noneInfoSurvey);
            addAnrEditSurveyWindow.SurveyUpdated += LoadSurveyList;
            addAnrEditSurveyWindow.ShowDialog();
        }

       

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void SurveyLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
                App.editOrAdd = false;

                AddAnrEditSurveyWindow addAnrEditSurveyWindow = new AddAnrEditSurveyWindow(SurveyLv.SelectedItem as Survey);
            addAnrEditSurveyWindow.SurveyUpdated += LoadSurveyList;
            addAnrEditSurveyWindow.ShowDialog();
            
            
        }
        private void LoadSurveyList()
        {
            surveys = new ObservableCollection<Survey>(DbConnections.homeEntities.Survey.ToList());
            SurveyLv.ItemsSource = surveys;
        }
    }
}
