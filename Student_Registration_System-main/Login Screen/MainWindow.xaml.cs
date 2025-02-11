using Student_Registration_System.View;
using Microsoft.Extensions.Logging.Abstractions;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Student_Registration_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Module[] modules = new Module[7];
        public List<Result> DatabaseInformations { get; private set; }
        private List<Result> filteredList;




        Student selectedStd = null;
        private string moduleCode = null;
        private string moduleName = null;
        private int moduleCredit = 0;
        private string grade = null;



        public MainWindow(Student selectedStd)
        {
            this.selectedStd = selectedStd;
            InitializeComponent();
            stdName.Text = selectedStd.FName + " " + selectedStd.LName;
            addModules();



            foreach (Module module in modules)
            {
                string moduleCode = module.getCode();
                roleListBox.Items.Add(moduleCode);
            }
            roleListBox.SelectedIndex = 0;
            gradeListBox.SelectedIndex = 0;

            GPAtxt.Text = selectedStd.gpa.ToString();

            Read();


        }

        public void Read()
        {
            using (UserDataContext context = new UserDataContext())
            {
                DatabaseInformations = context.Results.ToList();

                filteredList = DatabaseInformations.Where(result => result.StudentId == selectedStd.Id).ToList();

                InformationList.ItemsSource = filteredList;

            }
        }


        /// Add modules here
        private void addModules ()
        {
            modules[0] = new Module("EE3301", "Analog Electronics", 3);
            modules[1] = new Module("EE3302", "Data Structures and Algorithms", 3);
            modules[2] = new Module("EE3203", "Electrical and Electronic Measurements", 2);
            modules[3] = new Module("EE3305", "Signal and Systems", 3);
            modules[4] = new Module("EE3206", "GUI Programming", 2);
            modules[5] = new Module("EE3151", "Programming Project", 1);
            modules[6] = new Module("IS3302", "Complex Analysis", 3);
        }

      
        


        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            using (UserDataContext context = new UserDataContext())
            {
                var sID = selectedStd.Id;
                var mCode = moduleCode;
                var mName = moduleName;
                var mGrade = grade;

                if (validateFIelds())
                {
                    context.Results.Add(new Result() { StudentId = sID, ModuleCode = mCode, ModuleName = mName, grade = mGrade });
                    context.SaveChanges();

                }
            }

            Read();
            clear();

            double saveGPA = calculateGPA();
            updateGPA(saveGPA);
            GPAtxt.Text = saveGPA.ToString();

        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            Delete();
            Read();
            double delGPA = calculateGPA();
            GPAtxt.Text = delGPA.ToString();
            updateGPA(delGPA);
            clear();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            TeacherOption main = new TeacherOption();
            main.Show();
            Close();

        }

      

        private void roleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedModule = roleListBox.SelectedItem.ToString();

            if (roleListBox.SelectedIndex == 0)
            {
                moduleCode = null;
                moduleName = null;
                moduleCredit = 0;

                moduleNametxt.Text = "Module Name";
                moduleCredittxt.Text = "Credit";
            }
            else
            {
                foreach (Module module in modules)
                {
                    if (module.getCode() == selectedModule)
                    {
                        moduleNametxt.Text = module.getName();
                        moduleCredittxt.Text = module.getCredit().ToString();
                        moduleCode = module.getCode();
                        moduleName = module.getName();
                        moduleCredit = module.getCredit();
                    }
                }
            }
        }

        private void gradeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedGrade;
            // Get the ListBoxItem
            var selectedItem = (System.Windows.Controls.ListBoxItem)gradeListBox.SelectedItem;

            // Get the text from the Content property
            selectedGrade = selectedItem.Content.ToString();

            if (gradeListBox.SelectedIndex == 0)
            {
                grade = null;
            }
            else
            {
                grade = selectedGrade;
            }
        }

        private bool validateFIelds()
        {
            if (moduleCode == null)
            {
                MessageBox.Show("Please select Module");
                return false;
            }
            else if (grade == null)
            {
                MessageBox.Show("Please select Grade");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Delete()
        {
            Result selectedResult = InformationList.SelectedItem as Result;
            using (UserDataContext context = new UserDataContext())
            {
                if (selectedResult != null)
                {

                    //Teacher Teacher = context.Informations.Find(selectedInfo.Id);
                    Result result = context.Results.Single(x => x.Id == selectedResult.Id);

                    context.Remove(result);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please select student you want to delete");
                }
            }
        }

        private void clear()
        {
            roleListBox.SelectedIndex = 0;
            gradeListBox.SelectedIndex = 0;
        }

        private double calculateGPA()
        {
            double finalGPA;
            double calculatedGPA = 0;
            double totalGPA = 0;
            int totalCredits = 0;
            double gradePoint;
            int mCredit = 0;

            if (filteredList.Count > 0)
            {
                foreach (Result result in filteredList)
                {
                    switch (result.grade)
                    {
                        case "A+":
                            gradePoint = 4;
                            break;
                        case "A":
                            gradePoint = 4;
                            break;
                        case "A-":
                            gradePoint = 3.7;
                            break;
                        case "B+":
                            gradePoint = 3.3;
                            break;
                        case "B":
                            gradePoint = 3;
                            break;
                        case "B-":
                            gradePoint = 2.7;
                            break;
                        case "C+":
                            gradePoint = 2.3;
                            break;
                        case "C":
                            gradePoint = 2;
                            break;
                        case "C-":
                            gradePoint = 1.7;
                            break;
                        case "D+":
                            gradePoint = 1.3;
                            break;
                        case "D":
                            gradePoint = 1;
                            break;
                        default:
                            gradePoint = 0;
                            break;
                    }

                    foreach (Module module in modules)
                    {
                        if (module.getCode() == result.ModuleCode)
                        {
                            mCredit = module.getCredit();
                        }
                    }


                    totalGPA += gradePoint*mCredit;
                    totalCredits += mCredit;
                }
                
                calculatedGPA = totalGPA / totalCredits;
                
                finalGPA = Math.Round(calculatedGPA, 2);

            }
            else
            {
                finalGPA = 0;
            }

            return finalGPA;
        }

        private void updateGPA(double gpa)
        {
            using (UserDataContext context = new UserDataContext())
            {
                var fname = selectedStd.FName;
                var lname = selectedStd.LName;
                var gender = selectedStd.gender;
                var dob = selectedStd.dob;
                var age = selectedStd.age;
                var address = selectedStd.address;
                var email = selectedStd.email;
                var phone = selectedStd.mob;

                if (gpa != null)
                {
                    Student student = context.Students.Find(selectedStd.Id);
                    if (student != null)
                    {
                        student.FName = fname;
                        student.LName = lname;
                        student.gender = gender;
                        student.dob = dob;
                        student.age = age;
                        student.email = email;
                        student.address = address;
                        student.mob = phone;
                        student.gpa = gpa;
                    }
                    
                    context.SaveChanges();
                    selectedStd = student;
                }
            }
        }
    }

}
