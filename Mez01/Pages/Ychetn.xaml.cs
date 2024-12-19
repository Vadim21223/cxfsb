using iTextSharp.text.pdf;
using iTextSharp.text;
using Mez01.AppData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace Mez01.Pages
{
    /// <summary>
    /// Логика взаимодействия для Ychetn.xaml
    /// </summary>
    public partial class Ychetn : Page
    {
        public Ychetn()
        {
            InitializeComponent();
            AccountingLV.ItemsSource = Connect.context.Ychet.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new AddEditYchet(null));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Nav.MainFrame.Navigate(new AddEditYchet((sender as Button).DataContext as Ychet));
        }
        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var delObj = AccountingLV.SelectedItems.Cast<Ychet>().ToList();
            if (MessageBox.Show($"Удалить {delObj.Count} записей", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                Connect.context.Ychet.RemoveRange(delObj);
            try
            {
                Connect.context.SaveChanges();
                AccountingLV.ItemsSource = Connect.context.Ychet.ToList();
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
            var ych = Connect.context.Ychet.ToList();

            ych = ych.Where(x => x.Mesyacz.ToString().ToLower().Trim().Contains(poiskTbx.Text.ToLower().Trim())
            || x.FIO.ToString().ToLower().Trim().Contains(poiskTbx.Text.ToLower().Trim())).ToList();
            ych = ych.Where(x => x.Mesyacz.ToString().ToLower().Trim().Contains(filtrTbx.Text.ToLower().Trim())).ToList();

            AccountingLV.ItemsSource = ych;
        }

        private void poiskTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void filtrTbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void ExcelBtn_Click(object sender, RoutedEventArgs e)
        {
            var ych = Connect.context.Ychet.ToList();
            Excel.Application ap = new Excel.Application();
            ap.Visible = true;
            Excel.Workbook worbook = ap.Workbooks.Add(Type.Missing);
            Excel.Worksheet worsheet = (Excel.Worksheet)ap.Worksheets.get_Item(1);
            worsheet.Name = "Учётная  таблица";
            Excel.Range ran = worsheet.Range["A1", "E2"];
            ran.Merge();
            ran.Value = "Ведомость поставки автомобилей";
            ran.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ran.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            worsheet.Cells.Font.Name = "Times New Roman";
            worsheet.Cells[3, 1].Value = "Марка";
            worsheet.Cells[3, 2].Value = "Модель";
            worsheet.Cells[3, 3].Value = "Цена";
            worsheet.Cells[3, 4].Value = "Кол-во прихода";
            worsheet.Cells[3, 5].Value = "Стоимость";
            var curRowt = 4;
            decimal sums = 0;
            foreach (var item in ych)
            {
                worsheet.Cells[curRowt, 1].Value = item.Sprav.Marka;
                worsheet.Cells[curRowt, 2].Value = item.Sprav.Model;
                worsheet.Cells[curRowt, 3].Value = item.Sprav.Price;
                worsheet.Cells[curRowt, 4].Value = item.KolvoAuto;
                worsheet.Cells[curRowt, 5].Value = item.KolvoAuto * item.Sprav.Price;
                sums += item.KolvoAuto * item.Sprav.Price;
                curRowt++;
            }
            worsheet.Cells[curRowt, 1].Value = "Итого: ";
            worsheet.Cells[curRowt, 5].Value = sums;
            Excel.Range range = worsheet.Range[worsheet.Cells[curRowt, 1], worsheet.Cells[curRowt, 4]];
            range.Merge();
            Excel.Range rang = worsheet.Range[worsheet.Cells[3, 1], worsheet.Cells[curRowt, 5]];
            rang.Borders.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);
            worsheet.Columns.AutoFit();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "Ведомость поставки автомобилей");
            worbook.SaveAs(filePath);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ap);
        }

        private void PdfBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("Ведомость.pdf", FileMode.Create));
                doc.Open();
                BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                PdfPTable table = new PdfPTable(5);
                PdfPCell cell = new PdfPCell(new Phrase("Ведомость поставки товаров", font));
                cell.Colspan = 5;
                cell.HorizontalAlignment = 1;
                cell.Border = 0;
                table.AddCell(cell);
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Марка", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Модель", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Цена", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Кол-во прихода", font))));
                table.AddCell(new PdfPCell(new Phrase(new Phrase("Стоимость", font))));
                int sum = 0;
                foreach (var item in Connect.context.Ychet.ToList())
                {
                    table.AddCell(new Phrase(item.Sprav.Marka.ToString(), font));
                    table.AddCell(new Phrase(item.Sprav.Model.ToString(), font));
                    table.AddCell(new Phrase(item.Sprav.Price.ToString(), font));
                    table.AddCell(new Phrase(item.KolvoAuto.ToString(), font));
                    table.AddCell(new Phrase((item.KolvoAuto * item.Sprav.Price).ToString(), font));
                    sum += item.KolvoAuto * item.Sprav.Price;
                }
                table.AddCell(new PdfPCell(new Phrase("Итого: ", font)) { Colspan = 4 });
                table.AddCell(new Phrase(sum.ToString(), font));
                doc.Add(table);
                doc.Close();
                MessageBox.Show("PDF-документ сохранён");
            }
            catch
            {
                MessageBox.Show("PDF-документ не сохранён", "Ошибка");
            }
        }
    }
}
