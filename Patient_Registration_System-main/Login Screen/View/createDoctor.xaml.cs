using Student_Registration_System.Migrations;
using Student_Registration_System.View;
using Student_Registration_System;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Media.Imaging;

namespace DoctorCreation.View
{
    public partial class CreateTeacher : Window
    {
        private String gender;
        private bool isUpdate = false;
        private int ID;

        public CreateTeacher()
        {
            InitializeComponent();

            Teacher std = new Teacher();

            DataContext = std;
        }

        public CreateTeacher(Teacher std)
        {
            InitializeComponent();

            DataContext = std;
            isUpdate = true;
            ID = std.Id;
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            AdminView main = new AdminView();
            main.Show();
            Close();
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

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
                        var password = teacherPassBox;
                        var imagepath = teacherImage;
                       

                        if (validateFields())
                        {
                            Teacher teacher = context.Teachers.Find(ID);
                            teacher.FName = fname;
                            teacher.LName = lname;
                            teacher.gender = gender;
                            teacher.dob = dob;
                            teacher.age = age;
                            teacher.email = email;
                            teacher.address = address;
                            teacher.mob = phone;
                            teacher.TeacherPass = teacherPassBox.Password; ;
                           // teacher.ImagePath = openFileDialog.FileName;

                            context.SaveChanges();

                            AdminView adminView = new AdminView(); // Create an instance of AdminView
                            adminView.Show(); // Show AdminView
                            Close(); // Close the current window (CreateTeacher window)
                        }
                    }
                }

                else
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
                        var password = teacherPassBox.Password;
                        var imagepath = teacherImage; ;

                        if (validateFields())
                        {
                            context.Teachers.Add(new Teacher() { FName = fname, LName = lname, gender = gender, dob = dob, age = age, address = address, email = email, mob = phone, TeacherPass = password });
                            context.SaveChanges();

                            AdminView main = new AdminView();
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nInner Exception: {ex.InnerException?.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            AdminView main = new AdminView();
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

        private bool validateFields()
        {
            if (gender != null)
            {
                if (string.IsNullOrEmpty(fnametxt.Text) && string.IsNullOrEmpty(lnametxt.Text) && string.IsNullOrEmpty(dobDatePicker.Text) && string.IsNullOrEmpty(agetxt.Text) && string.IsNullOrEmpty(addresstxt.Text) && string.IsNullOrEmpty(emaitxt.Text) && string.IsNullOrEmpty(mobtxt.Text))
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
                MessageBox.Show("Please select Gender");
                return false;
            }
        }

        private void AgeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Check if the entered text contains only letters
            if (!IsIntegerAllowed(e.Text))
            {
                e.Handled = true; // Mark the event as handled to prevent non-letter input
                MessageBox.Show("Please enter valid integer ", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

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
