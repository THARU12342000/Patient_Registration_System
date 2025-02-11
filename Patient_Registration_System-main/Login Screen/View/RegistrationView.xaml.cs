using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : Window
    {

        private String gender;
        private bool isUpdate = false;
        private int ID;
        private object emailtxt;

        //public string TitleText { get; set; }

        public RegistrationView()
        {
            InitializeComponent();

            Student std = new Student();

            DataContext = std;
            //TitleText = "Add Student";
        }

        public RegistrationView(Student std)
        {
            InitializeComponent();

            DataContext = std;
            isUpdate = true;
            ID = std.Id;
           // TitleText = "Edit Student";

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            TeacherOption main = new TeacherOption();
            main.Show();
            Close();
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {

            if (isUpdate)
            {
                using (UserDataContext context = new UserDataContext())
                {
                    var fname = fnametxt.Text;
                    var lname = lnametxt.Text;
                    var dob = dobDatePicker.Text;
                    var age = agetxt.Text;
                    var address = addresstxt.Text;
                    var email = emaitxt.Text;
                    var phone = mobtxt.Text;

                    if (validateFIelds())
                    {
                        Student student = context.Students.Find(ID);
                        student.FName = fname;
                        student.LName = lname;
                        student.gender = gender;
                        student.dob = dob;
                        student.age = age;
                        student.email = email;
                        student.address = address;
                        student.mob = phone;
                        context.SaveChanges();

                        TeacherOption main = new TeacherOption();
                        main.Show();
                        Close();
                    }
                }
            }
            else { 
                using (UserDataContext context = new UserDataContext())
                {
                    var fname = fnametxt.Text;
                    var lname = lnametxt.Text;
                    var dob = dobDatePicker.Text;
                    var age = agetxt.Text;
                    var address = addresstxt.Text;
                    var email = emaitxt.Text;
                    var phone = mobtxt.Text;
                    if (validateFIelds())
                    {
                        context.Students.Add(new Student() { FName = fname, LName = lname, gender = gender, dob = dob, age = age, address = address, email = email, mob = phone });
                        context.SaveChanges();

                        TeacherOption main = new TeacherOption();
                        main.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("All fields must have value");
                    }
                }
            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            TeacherOption main = new TeacherOption();
            main.Show();
            Close();
        }
       
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (female.IsChecked == true)
            {
                gender = "Female";
            }
            else if (male.IsChecked == true)
            {
                gender = "Male";
            }

        }

        private bool validateFIelds()
        {
            if (gender != null) { 
                if (fnametxt.Text == "" && lnametxt.Text == "" && dobDatePicker.Text == "" && agetxt.Text == "" && addresstxt.Text == "" && emaitxt.Text == "" && mobtxt.Text == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Please select Gendeer");
                return false;
            }
        }

        private void FNameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Check if the entered text contains only letters
            if (!IsStringAllowed(e.Text))
            {
                e.Handled = true; // Mark the event as handled to prevent non-string input
                MessageBox.Show("Please enter valid characters (letters only).", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Helper method to check if the text contains only letters
        private bool IsStringAllowed(string text)
        {
            return text.All(char.IsLetter);
        }


        private void LNameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Check if the entered text contains only letters
            if (!IsStringAllowed(e.Text))
            {
                e.Handled = true; // Mark the event as handled to prevent non-string input
                MessageBox.Show("Please enter valid characters (letters only).", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Helper method to check if the text contains only letters

        private void AgeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Check if the entered text is a valid integer
            if (!IsIntegerAllowed(e.Text))
            {
                e.Handled = true; // Mark the event as handled to prevent non-integer input
                MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Helper method to check if the text is a valid integer
        private bool IsIntegerAllowed(string text)
        {
            return int.TryParse(text, out _);
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

        // Helper method to check if the text is a valid integer
        private void ChooseImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                teacherImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }



    }
}