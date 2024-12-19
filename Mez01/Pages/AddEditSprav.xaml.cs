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
    /// Логика взаимодействия для AddEditSprav.xaml
    /// </summary>
    public partial class AddEditSprav : Page
    {
        Sprav inf;
        bool checkNew;
        public AddEditSprav(Sprav c)
        {
            InitializeComponent();
            if (c == null)
            {
                c = new Sprav();
                checkNew = true;
            }
            else
                checkNew = false;
            DataContext = inf = c;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(prise.Text.Trim(' '), out decimal i))
            {
                if (i >= 0)
                {
                    if (checkNew)
                    {
                        Connect.context.Sprav.Add(inf);
                    }
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

        public static bool CheckInformation(Sprav spr)
        {
            if (string.IsNullOrEmpty(spr.Model) || !spr.Model.Replace(" ", "").All(char.IsLetter))
                return false;
            if (string.IsNullOrEmpty(spr.Marka) || !spr.Marka.Replace(" ", "").All(char.IsLetter))
                return false;
            if (spr.Price < 0)
                return false;
            return true;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
