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

namespace Student_Registration_System.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();

            roleListBox.SelectedIndex = 0;
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var username = txtUser.Text;
            var password = txtPassword.Password;
            var role = ((ListBoxItem)roleListBox.SelectedItem)?.Content as string;

            using (UserDataContext context = new UserDataContext())
            {
                if (role == "Admin")
                {
                    bool adminFound = context.Admins.Any(admin => admin.userName == username && admin.password == password);

                    if (adminFound)
                    {
                        AdminView main = new AdminView();
                        main.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credintials");
                    }
                }
                else
                {
                    bool teacherFound = context.Teachers.Any(teacher => teacher.email == username && teacher.TeacherPass == password);

                    if (teacherFound) 
                    {
                        TeacherOption main = new TeacherOption();
                        main.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Credintials");
                    }

                }
            }
        }

       
    }
}
