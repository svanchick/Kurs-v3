using Kurs_v3.DB.Model;
using Kurs_v3.Objects.Classes;
using Kurs_v3.Objects.Pages.Add_Type;
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

namespace Kurs_v3.Objects.Pages.Show_Type
{
    /// <summary>
    /// Логика взаимодействия для Display_Show.xaml
    /// </summary>
    public partial class Display_Show : Page
    {
        public Display_Show()
        {
            InitializeComponent();
        }
        private void IdInputbtn_Click(object sender, RoutedEventArgs e)
        {
            if (ID_input_text.Text != "1")
            {
                try
                {
                    //Поиск нужной строки
                    var Name_to_TextBox = GetContext.context.Displays.Where(u => u.Id.ToString() == ID_input_text.Text).First();
                    Manager._MainFrame.Navigate(new New_Display(Name_to_TextBox.Name, Name_to_TextBox.SerialNumber));

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Данного дисплея не существует, или вы ввели не число, подробнеее:{ex}");
                }
            }
            else
            {
                MessageBox.Show("Нельзя взаимодействовать с системной строкой!");
            }

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager._MainFrame.Navigate(new New_Display(string.Empty, string.Empty));
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            var DisplaysForRemoving = DGrid.SelectedItems.Cast<Display>().ToList();
            var currentuser = GetContext.context.Users.Where(p => p.Login == Manager.LoginedUser).FirstOrDefault();
            if(currentuser.IsAdmin == true)
            {
                if (MessageBox.Show($"Вы точно хотите удалить следующие {DisplaysForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (DGrid.SelectedIndex != 0)
                    {
                        try
                        {
                            GetContext.context.Displays.RemoveRange(DisplaysForRemoving);
                            GetContext.context.SaveChanges();
                            DGrid.ItemsSource = GetContext.context.Displays.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Что-то пошло не так, подробности: {ex}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете удалить первй элемент");
                    }
                }
            }
            else
            {
                MessageBox.Show("У вас нет прав удалять записи");
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GetContext.context.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGrid.ItemsSource = GetContext.context.Displays.ToList();
            }
        }
    }
}
