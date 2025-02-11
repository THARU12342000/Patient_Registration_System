using DoctorCreation.View;
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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Student_Registration_System.View
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        public List<Teacher> DatabaseInformations { get; private set; }

        String gender;
        

        public AdminView()
        {
            InitializeComponent();

            Read();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        public void Create()
        {
            CreateTeacher main = new CreateTeacher();
            main.Show();
            Close();
        }
        public void Read()
        {
            using (UserDataContext context = new UserDataContext())
            {
                DatabaseInformations = context.Teachers.ToList();
                InformationList.ItemsSource = DatabaseInformations;

            }

        }
        public void Update()
        {
            Teacher selectedStd = InformationList.SelectedItem as Teacher;
            using (UserDataContext context = new UserDataContext())
            {
                if (selectedStd != null)
                {

                    CreateTeacher regView = new CreateTeacher(selectedStd);
                    regView.Show();
                    //regView.TitleText = "EDIT STUDENT";
                    
                    Close();
                  
                }
                else
                {
                    MessageBox.Show("Please select the doctor");
                }
            }
        }
        public void Delete()
        {
            Teacher selectedInfo = InformationList.SelectedItem as Teacher;
            using (UserDataContext context = new UserDataContext())
            {
                if (selectedInfo != null)
                {

                    //Teacher Teacher = context.Informations.Find(selectedInfo.Id);
                    Teacher Teacher = context.Teachers.Single(x => x.Id == selectedInfo.Id);

                    context.Remove(Teacher);
                    context.SaveChanges();
                    
                }
                else
                {
                    MessageBox.Show("Please select Doctor");
                }

            }
        }

        private void createbtn_Click(object sender, RoutedEventArgs e)
        {
            Create();
            Read();

        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            Update();
            Read();

        }

        private void dltebtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();
            Read();
            MessageBox.Show("Successfully deleted", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

        }

      

        private void logoutbtn_Click(object sender, RoutedEventArgs e)
        {
            LoginView main = new LoginView();
            main.Show();
            Close();
        }

        private void AgeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Allow only numeric input
            if (!int.TryParse(e.Text, out _))
            {
                e.Handled = true; // Mark the event as handled to prevent non-numeric input
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void FNameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Check if the entered text contains only letters
            if (!IsTextAllowed(e.Text))
            {
                e.Handled = true; // Mark the event as handled to prevent non-letter input
                MessageBox.Show("Please enter valid characters (letters only).", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
      

        private void LNameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Check if the entered text contains only letters
            if (!IsTextAllowed(e.Text))
            {
                e.Handled = true; // Mark the event as handled to prevent non-letter input
                MessageBox.Show("Please enter valid characters (letters only).", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private bool IsTextAllowed(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void MobTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Check if the entered text is a valid integer
            if (!IsIntegerAllowed(e.Text))
            {
                e.Handled = true; // Mark the event as handled to prevent non-integer input
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Helper method to check if the text represents a valid integer
        private bool IsIntegerAllowed(string text)
        {
            return int.TryParse(text, out _);
        }



    }
}