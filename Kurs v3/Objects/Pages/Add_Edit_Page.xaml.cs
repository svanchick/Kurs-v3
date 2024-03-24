
using System.Windows;
using System.Windows.Controls;
using Kurs_v3.DB;
using Kurs_v3.DB.Model;
using Kurs_v3.Objects.Classes;
using Microsoft.EntityFrameworkCore;


namespace Kurs_v3.Objects.Pages
{
    /// <summary>
    /// Логика взаимодействия для Add_Edit_Page.xaml
    /// </summary>
    public partial class Add_Edit_Page : Page
    {
        //private Assembly _assembly = new();
        
        public Add_Edit_Page(string Name, int Dial, int Display, int Plate /*Assembly selectedassembly*/)
        {
            InitializeComponent();

            //if (selectedassembly != null)
            //{
            //   _assembly = selectedassembly;
            //}
            //DataContext = _assembly;
            

            #region(Displays_ComboBox)
            Display_ComboBox.ItemsSource = GetContext.context.Displays.ToList();
            Display_ComboBox.DisplayMemberPath = "Name";
            Display_ComboBox.SelectedValuePath = "Id";
            #endregion

            #region(Dial_ComboBox)
            Dial_ComboBox.ItemsSource = GetContext.context.Dials.ToList();
            Dial_ComboBox.DisplayMemberPath = "Name";
            Dial_ComboBox.SelectedValuePath = "Id";
            #endregion

            #region(Plates_ComboBox)
            Plate_ComboBox.ItemsSource = GetContext.context.Plates.ToList();
            Plate_ComboBox.DisplayMemberPath = "Name";
            Plate_ComboBox.SelectedValuePath = "Id";
            #endregion



            Name_text.Text = Name;
            Display_ComboBox.SelectedItem = Display;
            Dial_ComboBox.SelectedIndex = Dial;
            Plate_ComboBox.SelectedIndex = Plate;
        }
        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if ((Dial_ComboBox.SelectedIndex == 0 && Plate_ComboBox.SelectedIndex == 0 && Display_ComboBox.SelectedIndex == 0) || string.IsNullOrEmpty(Name_text.Text))
                {
                    MessageBox.Show("Введите название сборки или Выбирете хотя-бы один компонент");


                }
                else
                {
                    Assembly assembly = new Assembly { Name = Name_text.Text, DialId = Convert.ToInt32(Dial_ComboBox.SelectedValue), DisplayId = Convert.ToInt32(Display_ComboBox.SelectedValue), PlateId = Convert.ToInt32(Plate_ComboBox.SelectedValue) };

                    //_assembly.Name = Name_text.Text;
                    //_assembly.DialId = Dial_ComboBox.SelectedIndex;
                    //_assembly.PlateId = Plate_ComboBox.SelectedIndex;
                    //_assembly.DisplayId = Display_ComboBox.SelectedIndex;
                    if(assembly.Id == 0 ) 
                    {
                        GetContext.context.Assemblies.Add(assembly);
                    }
                   
                    
                    GetContext.context.SaveChanges();

                    MessageBox.Show("Информация сохранена!");

                    Manager._MainFrame.GoBack();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }
           
            
        }

        private void Display_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Id_Display_To_Number = GetContext.context.Displays.Find(Display_ComboBox.SelectedValue);
            if (Id_Display_To_Number != null)
            {
                Display_number.Text = ($" С.Н.{Id_Display_To_Number.SerialNumber}");
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
                Dial_number.Text = ($" С.Н.{Id_Dial_To_Number.SerialNumber}");
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
                Plate_number.Text = ($" С.Н.{Id_Plate_To_Number.SerialNumber}");
            }
            else
            {
                MessageBox.Show("Ошибка отображения серийного номера");
            }
        }
    }
}
