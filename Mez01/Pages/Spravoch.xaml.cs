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
    /// Логика взаимодействия для Spravoch.xaml
    /// </summary>
    public partial class Spravoch : Page
    {
        public Spravoch()
        {
            InitializeComponent();
            InformationLV.ItemsSource = Connect.context.Sprav.ToList();
            sortCmb.ItemsSource = new[] { "По умолчанию", "По возврастанию", "По убыванию" };
            sortCmb.SelectedIndex = 0;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEditSprav(null));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEditSprav((sender as Button).DataContext as Sprav));
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var delObj = InformationLV.SelectedItems.Cast<Sprav>().ToList();
            foreach (var delOb in delObj)
            {
                if (Connect.context.Ychet.Any(x => x.KodAuto == delOb.KodAuto))
                {
                    MessageBox.Show("Данные используются в таблице продаж", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (MessageBox.Show($"Удалить {delObj.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Sprav.RemoveRange(delObj);
            try
            {
                Connect.context.SaveChanges();
                InformationLV.ItemsSource = Connect.context.Sprav.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RefrBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
        private void Update()
        {
            var sprav = Connect.context.Sprav.ToList();
            sprav = sprav.Where(x => x.Marka.ToString().ToLower().Trim().Contains(poiskTbx.Text.ToLower().Trim())).ToList();
            sprav = sprav.Where(x => x.Marka.ToString().ToLower().Trim().Contains(filtrTbx.Text.ToLower().Trim())
            || x.Model.ToString().ToLower().Trim().Contains(filtrTbx.Text.ToLower().Trim())).ToList();

            switch (sortCmb.SelectedIndex)
            {
                case 1:
                    sprav = sprav.OrderBy(x => x.KodAuto).ToList();
                    break;
                case 2:
                    sprav = sprav.OrderByDescending(x => x.KodAuto).ToList();
                    break;
            }
            InformationLV.ItemsSource = sprav;

        }

        private void poiskTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void filtrTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void sortCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
    }
}
