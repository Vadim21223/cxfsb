using Mez01.AppData;
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

namespace Mez01.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditYchet.xaml
    /// </summary>
    public partial class AddEditYchet : Page
    {
        Ychet acc;
        bool checkNew;
        public AddEditYchet(Ychet c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new Ychet() { Sprav = Connect.context.Sprav.FirstOrDefault(), Mesyacz = "Январь" };
                checkNew = true;
            }
            else
                checkNew = false;
            AccBCmb.ItemsSource = Connect.context.Sprav.ToList();
            AccMonthCmb.ItemsSource = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль",
                "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            DataContext = acc = c;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(quan.Text, out int x))
            {
                if (x >= 0)
                {
                    acc.Mesyacz = AccMonthCmb.SelectedValue.ToString();
                    if (checkNew)
                        Connect.context.Ychet.Add(acc);
                    try
                    {
                        Connect.context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    Nav.MainFrame.GoBack();
                }
            }
        }

        public static bool CheckYchet(Ychet ych)
        {
            if (string.IsNullOrEmpty(ych.FIO) || !ych.FIO.Replace(" ", "").All(char.IsLetter))
                return false;
            if (string.IsNullOrEmpty(ych.Mesyacz) || !ych.Mesyacz.Replace(" ", "").All(char.IsLetter))
                return false;
            if (ych.KolvoAuto < 0)
                return false;
            if (ych.KodAuto < 0)
                return false;
            return true;
        }
    }
}
