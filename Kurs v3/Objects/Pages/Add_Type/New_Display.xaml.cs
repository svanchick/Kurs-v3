using Kurs_v3.DB.Model;
using Kurs_v3.Objects.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для New_Display.xaml
    /// </summary>
    public partial class New_Display : Page
    {
        private Display _Displays = new Display();
        public New_Display(string Name, string SerialNumber)
        {
            InitializeComponent();
            DataContext = _Displays;
            Name_Display_Text.Text = Name;
            Serial_number_Display_text.Text = SerialNumber;
        }

        private void Display_Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Name_Display_Text.Text) || string.IsNullOrEmpty(Serial_number_Display_text.Text))
            {
                MessageBox.Show("Введите корректно название дисплея и его серийный номер");
            }
            else
            {
                if (_Displays.Id == 0)
                {
                    GetContext.context.Displays.Add(_Displays);
                }

                _Displays.Name = Name_Display_Text.Text;
                try
                {

                    _Displays.SerialNumber = Serial_number_Display_text.Text;
                }
                catch (DbEntityValidationException ex)
                {
                    MessageBox.Show($"Серийный номер может иметь только числовое значение! {ex}");
                }


                GetContext.context.SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Manager._MainFrame.GoBack();
            }
        }
    }
}
