using DogHouse.DB;
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
using System.Windows.Shapes;

namespace DogHouse.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddAnrEditSurveyWindow.xaml
    /// </summary>
    public partial class AddAnrEditSurveyWindow : Window
    {
        public event Action SurveyUpdated;
        public static ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public static ObservableCollection<Dog> dog = new ObservableCollection<Dog>();
        public static ObservableCollection<StatusSurvey> statusSurveys = new ObservableCollection<StatusSurvey>();
        public static DB.Survey addSurvey = new DB.Survey();
        public static DB.Survey editSurvey = new DB.Survey();

        public AddAnrEditSurveyWindow(Survey infoSurvey)
        {
            InitializeComponent();
            employees = new ObservableCollection<Employee>(App.db.Employee.ToList());  
            EmployeeCb.ItemsSource = employees;
            dog = new ObservableCollection<Dog>(App.db.Dog.ToList());
            DogeCb.ItemsSource = dog;
            DogeCb.DisplayMemberPath = "Number";
            statusSurveys = new ObservableCollection<StatusSurvey>(App.db.StatusSurvey.ToList());
            StatusCb.ItemsSource = statusSurveys;
            StatusCb.DisplayMemberPath = "Name";
            if (App.editOrAdd == false)
            {
                editSurvey = infoSurvey;
                AddBtn.Visibility = Visibility.Collapsed; 
                EditBtn.Visibility = Visibility.Visible;
                NameDogeTb.Visibility = Visibility.Visible;
                DogeCb.Visibility = Visibility.Collapsed;
                DogeSt.Visibility = Visibility.Collapsed;
                NameDogeTb.Text += " " + infoSurvey.Dog.Number;
                IllessTb.Text = infoSurvey.Illness;
                EmployeeCb.Text = infoSurvey.Employee.LastName + " " + infoSurvey.Employee.FirstName + " " + infoSurvey.Employee.Name;
                StatusCb.Text = infoSurvey.StatusSurvey.Name;
                CommentTb.Text = infoSurvey.Comment;
                DateCb.SelectedDate = infoSurvey.Date;
            }

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var textBox = new TextBox[] {IllessTb, CommentTb };
            var comboBox = new ComboBox[] { DogeCb, EmployeeCb, StatusCb }; 
            if(textBox.Any(x => string.IsNullOrEmpty(x.Text)) || comboBox.Any(x => x.SelectedItem == null))
            {
                MessageBox.Show("Write all string!");
            }
            else
            {
                addSurvey.Illness = IllessTb.Text;
                addSurvey.Comment = CommentTb.Text;
                addSurvey.IdDog = (DogeCb.SelectedItem as Dog).ID;
                addSurvey.IdDoctor = (EmployeeCb.SelectedItem as Employee).ID;
                addSurvey.IdStatus = (StatusCb.SelectedItem as StatusSurvey).ID;
                App.db.Survey.Add(addSurvey);
                App.db.SaveChanges();
                MessageBox.Show("Success!");
                SurveyUpdated?.Invoke();

            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var textBox = new TextBox[] { IllessTb, CommentTb };
            var comboBox = new ComboBox[] { EmployeeCb, StatusCb };
            if (textBox.Any(x => string.IsNullOrEmpty(x.Text)) || comboBox.Any(x => x.SelectedItem == null))
            {
                MessageBox.Show("Write all string!");
            }
            else
            {
                editSurvey.Illness = IllessTb.Text;
                editSurvey.Comment = CommentTb.Text;
                editSurvey.IdDoctor = (EmployeeCb.SelectedItem as Employee).ID;
                editSurvey.IdStatus = (StatusCb.SelectedItem as StatusSurvey).ID;
                App.db.SaveChanges();
                MessageBox.Show("Success!");
                SurveyUpdated?.Invoke();

            }
        }
    }
}
