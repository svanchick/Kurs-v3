using Kurs_v3.DB.DTO;
using Kurs_v3.DB.Model;
using Kurs_v3.Objects.Classes;
using Kurs_v3.Objects.Pages.Show_Type;
using Kurs_v3.Objects.Windows;
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

namespace Kurs_v3.Objects.Pages.Add_Type
{
    /// <summary>
    /// Логика взаимодействия для Add_Users.xaml
    /// </summary>
    public partial class Add_Users : Page
    {
        public Add_Users(string Name, string Surname, string Patronymic, string Login, string Password,bool IsAdmin)
        {
            InitializeComponent();

            ToBlanks(new UserDTO() 
            {
                Name = Name,
                Surname = Surname,
                IsAdmin = IsAdmin,
                Login = Login,
                Password = Password,
                Patronymic = Patronymic
            });
        }
        private void ToBlanks(UserDTO user)
        {
            ClearUserForm();

            Name_Text.Text = user.Name;
            Surname_Text.Text = user.Surname;
            Patronymic_Text.Text = user.Patronymic;
            LogIn_Text.Text = user.Login;
            Password_Text.Text = user.Password;
            AdminCB.SelectedIndex = user.IsAdmin ? 0 : 1;
        }
       

        private void ClearUserForm()
        {
            Name_Text.Text = "";
            Surname_Text.Text = "";
            Patronymic_Text.Text = "";
            LogIn_Text.Text = "";
            Password_Text.Text = "";
            AdminCB.SelectedIndex = 0;
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {

            CheckAnalog();
           
        }
        private void CheckAnalog()
        {
            bool Isadmin;
            if (AdminCB.SelectedIndex == 0)
            {
                Isadmin = false;
            }
            else
            {
                Isadmin = true;
            }
            Users newuser = new Users { IsAdmin = Isadmin, Login = LogIn_Text.Text, Name = Name_Text.Text, Password = Password_Text.Text, Patronymic = Patronymic_Text.Text, Surname = Surname_Text.Text };
            
            var analog = GetContext.context.Users.Where(p => p.Login == LogIn_Text.Text).FirstOrDefault();

            try
            {
                if (analog == null)
                {
                    GetContext.context.Users.Add(newuser);
                    GetContext.context.SaveChangesAsync();
                    MessageBox.Show("Информация сохранена!");
                    Manager._MainFrame.Navigate(new Show_Users());
                }
                else
                {
                    MessageBoxResult res = MessageBox.Show("Данный пользователь уже существует, перезаписать его?", "Перезапись",MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (res == MessageBoxResult.Yes)
                    {
                        analog.Name = Name_Text.Text;
                        analog.Surname = Surname_Text.Text;
                        analog.Patronymic = Patronymic_Text.Text;
                        analog.Login = LogIn_Text.Text;
                        analog.Password = Password_Text.Text;
                        analog.IsAdmin = Isadmin;
                        try
                        {
                            GetContext.context.SaveChangesAsync();
                            MessageBox.Show("Информация сохранена!");
                            Manager._MainFrame.Navigate(new MainPage());
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"{ex}");
                        }
                        
                    }
                    else
                    {

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            
           
            
        }
    }
}
