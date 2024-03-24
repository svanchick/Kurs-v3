using Kurs_v3.DB.Model;
using Kurs_v3.Objects.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для Edit_Page.xaml
    /// </summary>
    public partial class Edit_Page : Page
    {
        private int _CurrentAssembly;
        public Edit_Page(int CurrentAssembly)
        {
            InitializeComponent();
            ToBlanks(CurrentAssembly);
        }
        private void ToBlanks(int CurrentAssembly)
        {
            var currentTo = GetContext.context.Assemblies.FirstOrDefault(p => p.Id == CurrentAssembly);
           
            if (currentTo != null)
            {
                Assembly assembly = new Assembly { Name = currentTo.Name, DialId = currentTo.DialId, DisplayId = currentTo.DisplayId, PlateId = currentTo.PlateId };
                _CurrentAssembly = CurrentAssembly;
                
                Name_text.Text = currentTo.Name;

                Display_ComboBox.ItemsSource = GetContext.context.Displays.ToList();
                Display_ComboBox.DisplayMemberPath = "Name";
                Display_ComboBox.SelectedValuePath = "Id";
                Display_ComboBox.SelectedValue = assembly.DisplayId;

                Dial_ComboBox.ItemsSource = GetContext.context.Dials.ToList();
                Dial_ComboBox.DisplayMemberPath = "Name";
                Dial_ComboBox.SelectedValuePath = "Id";
                Dial_ComboBox.SelectedValue = assembly.DialId;

                Plate_ComboBox.ItemsSource = GetContext.context.Plates.ToList();
                Plate_ComboBox.DisplayMemberPath = "Name";
                Plate_ComboBox.SelectedValuePath = "Id";
                Plate_ComboBox.SelectedValue = assembly.PlateId;
            }
            else
            {
                MessageBox.Show("Произошла ошибка при переходе на информационную страницу");
            }
        }

        
        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {
            //var EntityToUpdate = GetContext.context.Assemblies.Find(_CurrentAssembly);
           
           
            var assemblyToupdate = GetContext.context.Assemblies.FirstOrDefault(u => u.Id == _CurrentAssembly);
            if (assemblyToupdate != null)
            {
                try
                {
                    assemblyToupdate.Name = Name_text.Text;

                    assemblyToupdate.PlateId = Convert.ToInt32(Plate_ComboBox.SelectedValue);

                    assemblyToupdate.DialId = Convert.ToInt32(Dial_ComboBox.SelectedValue);

                    assemblyToupdate.DisplayId = Convert.ToInt32(Display_ComboBox.SelectedValue);

                    GetContext.context.SaveChangesAsync();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка во время перезаписи: {ex}");
                }

                MessageBox.Show("Данные успешно сохранены!");
                Manager._MainFrame.Navigate(new MainPage());
                
            }
            else
            {
                MessageBox.Show("Данные не найдены");
            }
        }

        private void Display_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


                var Id_Display_To_Number = GetContext.context.Displays.Find(Display_ComboBox.SelectedValue);
                if(Id_Display_To_Number != null)
                {
                  Display_Number.Text = ($" С.Н.{Id_Display_To_Number.SerialNumber}");
                }
                else
                {
                    MessageBox.Show("Ошибка отображения серийного номера");
                }
                
            
        }

        private void Dial_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Id_Dial_To_Number = GetContext.context.Dials.Find(Dial_ComboBox.SelectedValue);
            if (Id_Dial_To_Number != null)
            {
                Dial_Number.Text = ($" С.Н.{Id_Dial_To_Number.SerialNumber}");
            }
            else
            {
                MessageBox.Show("Ошибка отображения серийного номера");
            }
        }

        private void Plate_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Id_Plate_To_Number = GetContext.context.Plates.Find(Plate_ComboBox.SelectedValue);
            if (Id_Plate_To_Number != null)
            {
                Plate_Number.Text = ($" С.Н.{Id_Plate_To_Number.SerialNumber}");
            }
            else
            {
                MessageBox.Show("Ошибка отображения серийного номера");
            }
        }
    }
}
