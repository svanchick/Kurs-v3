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
    /// Логика взаимодействия для New_Plate.xaml
    /// </summary>
    public partial class New_Plate : Page
    {
        private Plate _Plates = new();
        public New_Plate()
        {
            InitializeComponent();
           
        }
        private void Plate_Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Name_Plate_Text.Text) || string.IsNullOrEmpty(Serial_number_Plate_text.Text))
            {
                MessageBox.Show("Введите корректно название платы и её серийный номер");


            }
            else
            {
                if (_Plates.Id == 0)
                {
                    GetContext.context.Plates.Add(_Plates);
                }

                _Plates.Name = Name_Plate_Text.Text;
                try
                {
                    _Plates.SerialNumber = Serial_number_Plate_text.Text;
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
