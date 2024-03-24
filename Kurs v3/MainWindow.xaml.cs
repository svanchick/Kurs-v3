using Kurs_v3.DB.Model;
using Kurs_v3.Objects.Classes;
using Kurs_v3.Objects.Windows;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows;
using System.Windows.Input;

namespace Kurs_v3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Add_Dial();
            Add_Display();
            Add_Plate();
            Add_Admin();
            

        }
       

        private async  void Add_Dial()
        {
            try
            {
                var Check_Dial = GetContext.context.Dials.Where(p => p.Name == "None" && p.SerialNumber == "-").FirstOrDefault();
                Dial dial = new Dial { Name = "None", SerialNumber = "-" };
                if (Check_Dial != null)
                {

                }
                else
                {
                    GetContext.context.Dials.Add(dial);
                    await GetContext.context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось создать системные строки для датчиков. Перезапустите программу, если это не поможет, обратитесь к системному администратору");
            }
        }

        private async void Add_Display()
        {
            try
            {
                var Check_Display = GetContext.context.Displays.Where(p => p.Name == "None" && p.SerialNumber == "-").FirstOrDefault();
                Display display = new Display { Name = "None", SerialNumber = "-" };
                if (Check_Display != null)
                {

                }
                else
                {
                    GetContext.context.Displays.Add(display);
                    await GetContext.context.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось создать системные строки для дисплеев. Перезапустите программу, если это не поможет, обратитесь к системному администратору");
            }
           
        }
        private async void Add_Plate()
        {
            try
            {
                var Check_Plate = GetContext.context.Plates.Where(p => p.Name == "None" && p.SerialNumber == "-").FirstOrDefault();
                Plate plate = new Plate { Name = "None", SerialNumber = "-" };
                if (Check_Plate != null)
                {

                }
                else
                {
                    GetContext.context.Plates.Add(plate);
                    await GetContext.context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось создать системные строки для плат. Перезапустите программу, если это не поможет, обратитесь к системному администратору");
            }
           
        }
        
        private async  void Add_Admin()
        {
            try
            {
                var Admin = GetContext.context.Users.Where(p => p.Name == "Max" && p.Surname == "D" && p.Patronymic == "D" && p.Login == "Admin" && p.Password == "Admin").FirstOrDefault();

                Users users = new Users { Name = "Max", Login = "Admin", Password = "Admin", Patronymic = "D", Surname = "D", IsAdmin = true };

                if (Admin != null)
                {
                    MessageBox.Show("Параметры администратора, успешно загружены");
                }
                else
                {
                    GetContext.context.Users.Add(users);
                    await GetContext.context.SaveChangesAsync();

                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show($"Не удалось создать Администратора! {ex}"); 
            }
            
        }
        private void CloseApp_btn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LogIn_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentUser = GetContext.context.Users.Where(u => u.Login == LogIn_text.Text && u.Password == Password_text.Text).FirstOrDefault();
                if (currentUser != null)
                {
                    Manager.LoginedUser = LogIn_text.Text;
                    Show show = new Show();
                    show.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Не правильно введён логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}