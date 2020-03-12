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
using System.Windows.Shapes;
using WSR_New_Sewing.Core.Classes;
using WSR_New_Sewing.Model;
using WSR_New_Sewing.ViewModel;

namespace WSR_New_Sewing.View.Stockman
{
    /// <summary>
    /// Логика взаимодействия для StockmanRolls.xaml
    /// </summary>
    public partial class StockmanRolls : Window
    {
        StockmanViewModel context;
        public StockmanRolls()
        {
            InitializeComponent();
            DataContext = context = new StockmanViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new StockManMiddleForm().Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(stock_grid.SelectedItem as StockmanModel == null)
            {
                DialogService.ShowError("Вы не выбрали запись!", "Ошибка!");
            }
            else
            {
                new UpdateForm(stock_grid.SelectedItem as StockmanModel).Show();
                Close();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new AddForm().Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (stock_grid.SelectedItem as StockmanModel == null)
            {
                DialogService.ShowError("Вы не выбрали запись!", "Ошибка!");
            }
            else
            {
                context.Delete(stock_grid.SelectedItem as StockmanModel);
            }
        }
    }
}
