using Kurs_v3.DB.Model;
using Kurs_v3.Objects.Classes;
using System.Data.Entity.Validation;
using System.Windows;
using System.Windows.Controls;


namespace Kurs_v3.Objects.Pages.Add_Type
{
    /// <summary>
    /// Логика взаимодействия для New_Dial.xaml
    /// </summary>
    public partial class New_Dial : Page
    {
        private Dial _dials = new();
        public New_Dial(string Name, string SerialNumber)
        {
            InitializeComponent();
            DataContext = _dials;
            Name_Dial_Text.Text = Name;
            Serial_number_Dial_text.Text = SerialNumber;
        }

        private void Dial_Add_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Name_Dial_Text.Text) || string.IsNullOrEmpty(Serial_number_Dial_text.Text))
            {
                MessageBox.Show("Введите корректно название датчика и его серийный номер");


            }
            else
            {
                if (_dials.Id == 0)
                {
                    GetContext.context.Dials.Add(_dials);
                }

                _dials.Name = Name_Dial_Text.Text;
                try
                {

                    _dials.SerialNumber = Serial_number_Dial_text.Text;
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
