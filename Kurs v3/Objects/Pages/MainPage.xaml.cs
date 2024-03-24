using Kurs_v3.Objects.Classes;
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

namespace Kurs_v3.Objects.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            Manager.DGrid = DGrid;
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                GetContext.context.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGrid.ItemsSource = GetContext.context.Assemblies.ToList();
            }
        }

        private void Delete_Btn_Click(object sender, RoutedEventArgs e)
        {
            //var assemblyesForRemoving = DGrid.SelectedItems.Cast<Assembly>().ToList();
            //if (MessageBox.Show($"Вы точно хотите удалить следующие {assemblyesForRemoving.Count()} элементов?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            //{
            //    try
            //    {
            //        GetContext.context.Assemblies.RemoveRange(assemblyesForRemoving);
            //        GetContext.context.SaveChanges();
            //        DGrid.ItemsSource = GetContext.context.Assemblies.ToList();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Что-то пошло не так, подробности: {ex}");
            //    }
            //}
            var UserCanChacnge = GetContext.context.Users.Where(u => u.Login == Manager.LoginedUser).FirstOrDefault();

            if(UserCanChacnge?.IsAdmin == true)
            {
                if (MessageBox.Show($"Вы точно хотите удалить выбранный элемент?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {
                        foreach (var item in DGrid.SelectedItems)
                        {
                            var selectedAssembly = item as Kurs_v3.DB.Model.Assembly;

                            if (selectedAssembly != null)
                            {
                                GetContext.context.Assemblies.Remove(selectedAssembly);
                            }
                        }

                        GetContext.context.SaveChanges();

                        DGrid.ItemsSource = GetContext.context.Assemblies.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Что-то пошло не так, подробности: {ex}");
                    }
                }
            }
            else
            {
                MessageBox.Show("У вас нет прав удалять сборки");
            }
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager._MainFrame.Navigate(new Add_Edit_Page("", 0, 0, 0/* null*/));
        }

        private void IdInputbtn_Click(object sender, RoutedEventArgs e)
        {
            //if(ID_input_text.Text == "1" || String.IsNullOrEmpty(ID_input_text.Text))
            //{
            //    MessageBox.Show("Вы ввели не корректное число");
            //}
            
            
                //try
                //{
                //    //Поиск нужной строки
                //    var Name_to_TextBox = GetContext.context.Assemblies.Where(u => u.Id.ToString() == ID_input_text.Text).First();
                //    Manager._MainFrame.Navigate(new Add_Edit_Page(Name_to_TextBox.Name, Name_to_TextBox.DialId, Name_to_TextBox.DisplayId, Name_to_TextBox.PlateId /*null*/));


                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Данной сборки не существует, или вы ввели не число, подробнеее:{ex}");
                //}
                try
                {
                    Manager._MainFrame.Navigate(new Edit_Page(Convert.ToInt32(ID_input_text.Text)));
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Данной сборки не существует, или вы ввели не число, подробнеее:{ex}");
                }
            
           
               
            
                
        }
    }
}
